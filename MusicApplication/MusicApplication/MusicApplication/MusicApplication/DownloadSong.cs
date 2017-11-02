using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication
{
    class DownloadSong
    {
        private string songID, saveURL;

        public string SongID { get => songID; set => songID = value; }
        public string SaveURL { get => saveURL; set => saveURL = value; }

        public void Download()
        {
            const int bufferLength = 65000;
            ServiceReference.ITransfer client = new ServiceReference.TransferClient();
            ServiceReference.DownloadRequest request = new ServiceReference.DownloadRequest();
            ServiceReference.FileInfo fileInfo = new ServiceReference.FileInfo();
            request.ID = SongID;
            fileInfo = client.DownloadSong(request);
            FileStream outputStream = null;
            Stream inputStream = fileInfo.FileByteStream;
            //MessageBox.Show(filePath);
            using (outputStream = new FileStream(saveURL, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[bufferLength];
                int count = 0;
                while ((count = inputStream.Read(buffer, 0, bufferLength)) > 0)
                {
                    outputStream.Write(buffer, 0, count);
                }
                outputStream.Close();
                inputStream.Close();
            }
        }
    }
}
