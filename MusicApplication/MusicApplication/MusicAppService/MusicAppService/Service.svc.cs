using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Configuration;
namespace MusicAppService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class TransferService : ITransfer
    {
        string saveFolder = ConfigurationManager.AppSettings["saveURL"];
        const int bufferLength = 65000;
        public FileInfo DownloadSong(DownloadRequest request)
        {
            FileInfo fileTransfer = new FileInfo();
            string URL = Path.Combine(saveFolder, request.ID+".mp3");
            fileTransfer.SongName = request.SongName;
            FileStream stream = new FileStream(URL, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            fileTransfer.FileByteStream = stream;
            return fileTransfer;
        }

        public List<SongInfo> GetAllSong()
        {
            return new SongInfoData().GetAllSong();
        }
        public List<ArtistInfo> LoadAllArtist()
        {
            return new Tung_ArtistData().LoadAllArtist();
        }

        public List<SingerInformation> GetSingerInformation(string ID)
        {
            throw new NotImplementedException();
        }

        public string Login(string username, string password)
        {
            UserInfoData userInfoData = new UserInfoData();
            return userInfoData.checkLogin(username, password);
        }
        public bool Register(UserInfo user)
        {
            UserInfoData userInfoData = new UserInfoData();
            return userInfoData.registerAccount(user);
        }

        public void UploadSong(FileInfo request)
        {
            FileStream outputStream = null;
            Stream inputStream = request.FileByteStream;
            string filePath = Path.Combine(saveFolder, request.Id+".mp3");
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

        public int InsertSongInfo(SongInfo song)
        {
            song.URL = "aaaa";
            SongInfoData data = new SongInfoData();
            int songID = data.InsertSong(song);
            AddSingerAndSong(song.Singer, songID);
            return songID;
        }
        private void AddSingerAndSong(string singer,int songID)
        {
            Tung_ArtistData tool = new Tung_ArtistData();
            string []singers = singer.Split(';');
            foreach(string name in singers)
            {
                int id = tool.FindSingerByName(name);
                if(id == 0)
                {
                    id = tool.AddSinger(name);
                }
                tool.AddSongWithSinger(id, songID);
            }
        }
        public List<SongInfo> FindSongLikeName(string name)
        {
            return new SongInfoData().FindSongLikeName(name);
        }
    }
}
