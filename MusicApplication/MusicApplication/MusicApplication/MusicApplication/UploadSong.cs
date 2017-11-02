using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication
{
    public class UploadSong
    {
        public void UploadFile(string id, string URL)
        {
            ServiceReference.ITransfer client = new ServiceReference.TransferClient();
            ServiceReference.FileInfo remoteFileInfo = new ServiceReference.FileInfo();
            using (FileStream stream = new FileStream(URL, FileMode.Open, FileAccess.Read))
            {
                remoteFileInfo.Id = "S" + id;
                remoteFileInfo.FileByteStream = stream;
                client.UploadSong(remoteFileInfo);
            }
        }
    }
}
