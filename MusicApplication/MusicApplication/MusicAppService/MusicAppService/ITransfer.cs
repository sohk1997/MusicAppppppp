using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MusicAppService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITransfer
    {
        [OperationContract]
        string Login(string username, string password);

        [OperationContract]
        FileInfo DownloadSong(DownloadRequest request);

        [OperationContract]
        List<SongInfo> GetAllSong();
        //load nghệ sĩ
        [OperationContract]
        List<ArtistInfo> LoadAllArtist();

        [OperationContract]
        bool Register(UserInfo user);

        [OperationContract]
        void UploadSong(FileInfo request);

        [OperationContract]
        int InsertSongInfo(SongInfo song);

        [OperationContract]
        List<SongInfo> FindSongLikeName(string name);
    }

    [MessageContract]
    public class SingerInformation
    {
        [MessageHeader(MustUnderstand = true)]
        string Name;

        [MessageHeader(MustUnderstand = true)]
        string FullName;

        [MessageBodyMember]
        DateTime BirthDay;

        [MessageBodyMember]
        Image Avartar;

        [MessageBodyMember]
        string Information;
    }

    [MessageContract]
    public class FileInfo : IDisposable
    {
        [MessageHeader(MustUnderstand = true)]
        public string Id;

        [MessageHeader(MustUnderstand = true)]
        public string SongName;

        [MessageHeader(MustUnderstand = true)]
        public string Singer;

        [MessageHeader(MustUnderstand = true)]
        public string Album;

        [MessageBodyMember(Order = 1)]
        public System.IO.Stream FileByteStream;

        public void Dispose()
        {
            if (FileByteStream != null)
            {
                FileByteStream.Close();
                FileByteStream = null;
            }
        }
    }

    [MessageContract]
    public class DownloadRequest
    {
        [MessageHeader(MustUnderstand = true)]
        public string ID;

        [MessageHeader(MustUnderstand = true)]
        public string SongName;
    }

 
    public class SongInfo
    {
        [DataMember]
        public string ID;
        [DataMember]
        public string Name;
        [DataMember]
        public string URL;
        [DataMember]
        public string Writter;
        [DataMember]
        public string Singer;
        [DataMember]
        public string Uploader;
        [DataMember]
        public int CountingPlay;
        [DataMember]
        public int CountingLike;
    }
    [DataContract]
    public class ArtistInfo
    {
        [DataMember]
        public int ID;
        [DataMember]
        public string FullName;
        [DataMember]
        public string URLImage;
        [DataMember]
        public string Information;
    }
  
    [DataContract]
    public class UserInfo
    {
        [DataMember]
        public string Name;
        [DataMember]
        public string Email;
        [DataMember]
        public string PhoneNumber;
        [DataMember]
        public int Age;
        [DataMember]
        public string Username;
        [DataMember]
        public string Password;
    }
}
