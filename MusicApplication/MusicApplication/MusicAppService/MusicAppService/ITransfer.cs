using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Windows.Media.Imaging;

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
        ListArtist LoadAllArtist(DownloadRequest request);

        [OperationContract]
        bool Register(UserInfo user);

        [OperationContract]
        void UploadSong(FileInfo request);

        [OperationContract]
        int InsertSongInfo(SongInfo song);

        [OperationContract]
        List<SongInfo> FindSongLikeName(string name);

        [OperationContract]
        List<SongInfo> FindSongOfSinger(string name);
    }

    [DataContract]
    public class SingerInformation
    {
        [DataMember]
        string Name;

        [DataMember]
        string FullName;

        [DataMember]
        DateTime BirthDay;

        [DataMember]
        Image Avartar;

        [DataMember]
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

    [DataContract]
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

    [MessageContract]
    public class ArtistInfo
    {
        [MessageHeader(MustUnderstand = true)]
        public int ID;
        [MessageHeader(MustUnderstand = true)]
        public string FullName;
        [MessageHeader(MustUnderstand = true)]
        public string URLImage;
        [MessageHeader(MustUnderstand = true)]
        public string Information;
        [MessageBodyMember(Order = 1)]
        public BitmapImage Image;
        [MessageBodyMember(Order = 1)]
        public byte []RawData;
    }

    [MessageContract]
    public class ListArtist
    {
        [MessageBodyMember(Order = 1)]
        public List<ArtistInfo> ListOfArtist;
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
