using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuSync.Monitoring
{
    internal class FolderWatcher
    {
        //monitor local TLD for changes if something is added then make it into a symlink
        //if an excluded folder/file is updated then copy the updated version to the remote
        //if an excluded folder/file is updated on the remote then we copy the new version to local
    }
}
