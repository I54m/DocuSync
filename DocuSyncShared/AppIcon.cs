using System.Reflection;
using System.Drawing;

namespace DocuSyncShared
{
    public static class AppIcons
    {
        public static Icon TrayIcon
        {
            get
            {
                var asm = Assembly.GetExecutingAssembly();
                using var stream = asm.GetManifestResourceStream("DocuSyncShared.Resources.DocuSyncLogo.ico");
                if (stream == null)
                    throw new InvalidOperationException("Failed to load embedded icon resource. Check resource name and build action.");
                return new Icon(stream);
            }
        }
    }
}
