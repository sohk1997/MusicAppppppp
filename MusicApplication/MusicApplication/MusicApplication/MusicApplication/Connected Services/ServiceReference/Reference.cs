﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicApplication.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SongInfo", Namespace="http://schemas.datacontract.org/2004/07/MusicAppService")]
    [System.SerializableAttribute()]
    public partial class SongInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CountingLikeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CountingPlayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SingerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string URLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UploaderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WritterField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CountingLike {
            get {
                return this.CountingLikeField;
            }
            set {
                if ((this.CountingLikeField.Equals(value) != true)) {
                    this.CountingLikeField = value;
                    this.RaisePropertyChanged("CountingLike");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CountingPlay {
            get {
                return this.CountingPlayField;
            }
            set {
                if ((this.CountingPlayField.Equals(value) != true)) {
                    this.CountingPlayField = value;
                    this.RaisePropertyChanged("CountingPlay");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Singer {
            get {
                return this.SingerField;
            }
            set {
                if ((object.ReferenceEquals(this.SingerField, value) != true)) {
                    this.SingerField = value;
                    this.RaisePropertyChanged("Singer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string URL {
            get {
                return this.URLField;
            }
            set {
                if ((object.ReferenceEquals(this.URLField, value) != true)) {
                    this.URLField = value;
                    this.RaisePropertyChanged("URL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Uploader {
            get {
                return this.UploaderField;
            }
            set {
                if ((object.ReferenceEquals(this.UploaderField, value) != true)) {
                    this.UploaderField = value;
                    this.RaisePropertyChanged("Uploader");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Writter {
            get {
                return this.WritterField;
            }
            set {
                if ((object.ReferenceEquals(this.WritterField, value) != true)) {
                    this.WritterField = value;
                    this.RaisePropertyChanged("Writter");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfo", Namespace="http://schemas.datacontract.org/2004/07/MusicAppService")]
    [System.SerializableAttribute()]
    public partial class UserInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.ITransfer")]
    public interface ITransfer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransfer/Login", ReplyAction="http://tempuri.org/ITransfer/LoginResponse")]
        string Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransfer/Login", ReplyAction="http://tempuri.org/ITransfer/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string username, string password);
        
        // CODEGEN: Generating message contract since the wrapper name (DownloadRequest) of message DownloadRequest does not match the default value (DownloadSong)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransfer/DownloadSong", ReplyAction="http://tempuri.org/ITransfer/DownloadSongResponse")]
        MusicApplication.ServiceReference.FileInfo DownloadSong(MusicApplication.ServiceReference.DownloadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransfer/DownloadSong", ReplyAction="http://tempuri.org/ITransfer/DownloadSongResponse")]
        System.Threading.Tasks.Task<MusicApplication.ServiceReference.FileInfo> DownloadSongAsync(MusicApplication.ServiceReference.DownloadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransfer/GetAllSong", ReplyAction="http://tempuri.org/ITransfer/GetAllSongResponse")]
        MusicApplication.ServiceReference.SongInfo[] GetAllSong();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransfer/GetAllSong", ReplyAction="http://tempuri.org/ITransfer/GetAllSongResponse")]
        System.Threading.Tasks.Task<MusicApplication.ServiceReference.SongInfo[]> GetAllSongAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransfer/Register", ReplyAction="http://tempuri.org/ITransfer/RegisterResponse")]
        bool Register(MusicApplication.ServiceReference.UserInfo user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransfer/Register", ReplyAction="http://tempuri.org/ITransfer/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(MusicApplication.ServiceReference.UserInfo user);
        
        // CODEGEN: Generating message contract since the operation UploadSong is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransfer/UploadSong", ReplyAction="http://tempuri.org/ITransfer/UploadSongResponse")]
        MusicApplication.ServiceReference.UploadSongResponse UploadSong(MusicApplication.ServiceReference.FileInfo request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransfer/UploadSong", ReplyAction="http://tempuri.org/ITransfer/UploadSongResponse")]
        System.Threading.Tasks.Task<MusicApplication.ServiceReference.UploadSongResponse> UploadSongAsync(MusicApplication.ServiceReference.FileInfo request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransfer/InsertSongInfo", ReplyAction="http://tempuri.org/ITransfer/InsertSongInfoResponse")]
        int InsertSongInfo(MusicApplication.ServiceReference.SongInfo song);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransfer/InsertSongInfo", ReplyAction="http://tempuri.org/ITransfer/InsertSongInfoResponse")]
        System.Threading.Tasks.Task<int> InsertSongInfoAsync(MusicApplication.ServiceReference.SongInfo song);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DownloadRequest", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DownloadRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string ID;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string SongName;
        
        public DownloadRequest() {
        }
        
        public DownloadRequest(string ID, string SongName) {
            this.ID = ID;
            this.SongName = SongName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FileInfo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FileInfo {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Album;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Singer;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string SongName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream FileByteStream;
        
        public FileInfo() {
        }
        
        public FileInfo(string Album, string Id, string Singer, string SongName, System.IO.Stream FileByteStream) {
            this.Album = Album;
            this.Id = Id;
            this.Singer = Singer;
            this.SongName = SongName;
            this.FileByteStream = FileByteStream;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadSongResponse {
        
        public UploadSongResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITransferChannel : MusicApplication.ServiceReference.ITransfer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TransferClient : System.ServiceModel.ClientBase<MusicApplication.ServiceReference.ITransfer>, MusicApplication.ServiceReference.ITransfer {
        
        public TransferClient() {
        }
        
        public TransferClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TransferClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransferClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransferClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MusicApplication.ServiceReference.FileInfo MusicApplication.ServiceReference.ITransfer.DownloadSong(MusicApplication.ServiceReference.DownloadRequest request) {
            return base.Channel.DownloadSong(request);
        }
        
        public string DownloadSong(string ID, ref string SongName, out string Id1, out string Singer, out System.IO.Stream FileByteStream) {
            MusicApplication.ServiceReference.DownloadRequest inValue = new MusicApplication.ServiceReference.DownloadRequest();
            inValue.ID = ID;
            inValue.SongName = SongName;
            MusicApplication.ServiceReference.FileInfo retVal = ((MusicApplication.ServiceReference.ITransfer)(this)).DownloadSong(inValue);
            Id1 = retVal.Id;
            Singer = retVal.Singer;
            SongName = retVal.SongName;
            FileByteStream = retVal.FileByteStream;
            return retVal.Album;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MusicApplication.ServiceReference.FileInfo> MusicApplication.ServiceReference.ITransfer.DownloadSongAsync(MusicApplication.ServiceReference.DownloadRequest request) {
            return base.Channel.DownloadSongAsync(request);
        }
        
        public System.Threading.Tasks.Task<MusicApplication.ServiceReference.FileInfo> DownloadSongAsync(string ID, string SongName) {
            MusicApplication.ServiceReference.DownloadRequest inValue = new MusicApplication.ServiceReference.DownloadRequest();
            inValue.ID = ID;
            inValue.SongName = SongName;
            return ((MusicApplication.ServiceReference.ITransfer)(this)).DownloadSongAsync(inValue);
        }
        
        public MusicApplication.ServiceReference.SongInfo[] GetAllSong() {
            return base.Channel.GetAllSong();
        }
        
        public System.Threading.Tasks.Task<MusicApplication.ServiceReference.SongInfo[]> GetAllSongAsync() {
            return base.Channel.GetAllSongAsync();
        }
        
        public bool Register(MusicApplication.ServiceReference.UserInfo user) {
            return base.Channel.Register(user);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(MusicApplication.ServiceReference.UserInfo user) {
            return base.Channel.RegisterAsync(user);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MusicApplication.ServiceReference.UploadSongResponse MusicApplication.ServiceReference.ITransfer.UploadSong(MusicApplication.ServiceReference.FileInfo request) {
            return base.Channel.UploadSong(request);
        }
        
        public void UploadSong(string Album, string Id, string Singer, string SongName, System.IO.Stream FileByteStream) {
            MusicApplication.ServiceReference.FileInfo inValue = new MusicApplication.ServiceReference.FileInfo();
            inValue.Album = Album;
            inValue.Id = Id;
            inValue.Singer = Singer;
            inValue.SongName = SongName;
            inValue.FileByteStream = FileByteStream;
            MusicApplication.ServiceReference.UploadSongResponse retVal = ((MusicApplication.ServiceReference.ITransfer)(this)).UploadSong(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MusicApplication.ServiceReference.UploadSongResponse> MusicApplication.ServiceReference.ITransfer.UploadSongAsync(MusicApplication.ServiceReference.FileInfo request) {
            return base.Channel.UploadSongAsync(request);
        }
        
        public System.Threading.Tasks.Task<MusicApplication.ServiceReference.UploadSongResponse> UploadSongAsync(string Album, string Id, string Singer, string SongName, System.IO.Stream FileByteStream) {
            MusicApplication.ServiceReference.FileInfo inValue = new MusicApplication.ServiceReference.FileInfo();
            inValue.Album = Album;
            inValue.Id = Id;
            inValue.Singer = Singer;
            inValue.SongName = SongName;
            inValue.FileByteStream = FileByteStream;
            return ((MusicApplication.ServiceReference.ITransfer)(this)).UploadSongAsync(inValue);
        }
        
        public int InsertSongInfo(MusicApplication.ServiceReference.SongInfo song) {
            return base.Channel.InsertSongInfo(song);
        }
        
        public System.Threading.Tasks.Task<int> InsertSongInfoAsync(MusicApplication.ServiceReference.SongInfo song) {
            return base.Channel.InsertSongInfoAsync(song);
        }
    }
}
