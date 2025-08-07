using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuSync.Monitoring
{
    public class HeartBeatWriter
    {
        private MemoryMappedFile _mmf;
        private MemoryMappedViewAccessor _accessor;

        public HeartBeatWriter()
        {
            _mmf = MemoryMappedFile.CreateOrOpen("DocuSyncHeartBeat", 1024);
            _accessor = _mmf.CreateViewAccessor(0, 1024);
        }

        public void Beat()
        {
            Logger.Info($"HeartBeat updated at : {DateTime.Now}");
            _accessor.Write(0, DateTime.UtcNow.Ticks);
        }


        public void Dispose()
        {
            _accessor.Dispose();
            _mmf.Dispose();
        }
    }
}
