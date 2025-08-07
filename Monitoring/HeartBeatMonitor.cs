using DocuSync.Core;
using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuSync.Monitoring
{
    public class HeartBeatMonitor
    {
        private MemoryMappedFile? _mmf;
        private MemoryMappedViewAccessor? _accessor;
        private double _lastHB;
        private int _hangCount = 0;
        private bool _running = false;

        private const int _maxHangCount = 4;
        private const int _defaultTimeout = 5;
        private const int _gracePeriod = 10;

        public void Start()
        {
            if (DocuSync == null) throw new InvalidOperationException("DocuSync is not running, Please run Docusync and then start heartbeat monitor!");
            _mmf = MemoryMappedFile.CreateOrOpen("DocuSyncHeartBeat", 1024);
            _accessor = _mmf.CreateViewAccessor(0, 1024);
            _running = true;
            Logger.Info("DocuSync HeartBeat Monitor is starting...");
            Logger.Info($"Waiting {_gracePeriod}s for DocuSync to start...");
            Thread.Sleep(_gracePeriod*1000);
            Logger.Info("DocuSync HeartBeat Monitor is now running!");
            while (_running)
            {
                Thread.Sleep(_defaultTimeout * 1000);

                if (DocuSync.HasExited && DocuSync.ExitCode == 0)
                {
                    _running = false;
                    RestartNeeded = false;
                    break;
                }
                if (RestartNeeded)
                {
                    _running = false;
                    break;
                }

                if (!IsAlive())
                {
                    Logger.Warning($"Last HeartBeat from DocuSync was {_lastHB}s ago!");
                    _hangCount++;
                }
                else _hangCount = 0;

                if (_hangCount >= _maxHangCount)
                {
                    Logger.Error($"DocuSync Failed HeartBeat for {_maxHangCount * _defaultTimeout}s! Considering application unresponsive, Killing and restarting..");
                    _hangCount = 0;
                    DocuSync.Kill();
                    _running = false;
                    RestartNeeded = true;
                }
            }
            Stop();
        }

        public bool IsAlive(int timeout = _defaultTimeout)
        {
            if (!_running || _accessor == null) throw new InvalidOperationException("HeartBeat Monitor is not running, Use HeartBeatMonitor.Start() first!!");
            _accessor.Read(0, out long ticks);
            var last = new DateTime(ticks, DateTimeKind.Utc);
            _lastHB = (DateTime.UtcNow - last).TotalSeconds;
            return _lastHB <= timeout;
        }

        public void Stop()
        {
            if (_accessor == null || _mmf == null) return;
            Logger.Info("DocuSync HeartBeat Monitor is now stopping!");
            _accessor.Dispose();
            _mmf.Dispose();
            _accessor = null;
            _mmf = null;
            Logger.Info("DocuSync HeartBeat Monitor has Stopped!");
        }

    }
}
