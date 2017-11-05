using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Windows;
using System.IO;
using System.Threading;
using System.Windows.Controls;

namespace MusicApplication
{
    class MusicPlayer
    {
        WMPLib.WindowsMediaPlayerClass playerClass;
        private string savePath = @"Buffer";
        string songID;
        public MusicPlayer(string songID)
        {
            this.playerClass = new WindowsMediaPlayerClass();
            SongID = songID;
        }

        public WindowsMediaPlayerClass PlayerClass { get => playerClass; set => playerClass = value; }
        public string SongID { get => songID; set => songID = value; }

        public void CreateNew()
        {
            playerClass = new WindowsMediaPlayerClass();
        }
        public void Play()
        {
            DownloadTEMP(SongID);
            playerClass.URL = Path.Combine(savePath, "buffer");
            playerClass.play();
            //IWMPMedia media = playerClass.newMedia(playerClass.URL);
            //MessageBox.Show(media.durationString);
        }
        private void DownloadTEMP(string id)
        {
            playerClass.stop();
            playerClass.URL = "";
            const int bufferLength = 65000;
            ServiceReference.ITransfer client = new ServiceReference.TransferClient();
            ServiceReference.DownloadRequest request = new ServiceReference.DownloadRequest();
            ServiceReference.FileInfo fileInfo = new ServiceReference.FileInfo();
            request.ID = id;
            fileInfo = client.DownloadSong(request);
            FileStream outputStream = null;
            Stream inputStream = fileInfo.FileByteStream;
            string filePath = System.IO.Path.Combine(savePath, "buffer");
            if (!System.IO.Directory.Exists(savePath))
            {
                System.IO.Directory.CreateDirectory(savePath);
            }
            using (outputStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
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
        public void Stop()
        {
            playerClass.stop();
            playerClass.URL = "";
            string filePath = System.IO.Path.Combine(savePath, "buffer.mp3");
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
