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
        string songID;
        System.Windows.Controls.Slider slider;
        public MusicPlayer(string songID, System.Windows.Controls.Slider slider)
        {
            this.playerClass = new WindowsMediaPlayerClass();
            SongID = songID;
            this.Slider = slider;
            //Thread thread = new Thread(new ThreadStart(UpdateSlider));
        }

        public WindowsMediaPlayerClass PlayerClass { get => playerClass; set => playerClass = value; }
        public string SongID { get => songID; set => songID = value; }
        public Slider Slider { get => slider; set => slider = value; }

        public void Play()
        {

            playerClass = new WindowsMediaPlayerClass();
            DownloadTEMP(SongID);
            playerClass.URL = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "buffer.mp3");
            playerClass.play();
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
            string filePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "buffer.mp3");
            //MessageBox.Show(filePath);
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
        private void UpdateSlider()
        {
            while (true)
            {
                if (playerClass != null)
                {
                    Slider.Value = Slider.Value + 1;
                }
                else
                {
                    Slider.Value = 0;
                }
            }
        }
    }
}
