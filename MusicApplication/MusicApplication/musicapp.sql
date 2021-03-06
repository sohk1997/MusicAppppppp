DROP DATABASE [MusicAppDataBase] 
CREATE DATABASE [MusicAppDataBase] 
GO
USE [MusicAppDataBase]
GO

CREATE TABLE [User]
(
	ID int primary key identity NOT NULL,
	Username varchar(20) NOT NULL unique,
	Name nvarchar(30) NOT NULL,
	[Password] varchar(20) NOT NULL,
	[E-mail] varchar(50) NOT NULL,
	PhoneNumber varchar(11)	
)
 GO
 CREATE TABLE Song
(
	ID int primary key identity,
	Name nvarchar(50) NOT NULL,
	URL nvarchar(150) NOT NULL,
	UploaderID int NOT NULL,
	Writter nvarchar(100),
	LastModified datetime NOT NULL,
	CountingPlay int,
	CountingLike int,
	Copyright nvarchar(40),
	Lyric nvarchar(max),
	constraint FK_SONG_USER foreign key (UploaderID) references [User](ID)
)
GO
CREATE TABLE Album
(
	ID int primary key identity NOT NULL,
	Name nvarchar(100) NOT NULL,
	Copyright nvarchar(40),
	[Description] nvarchar(max)
)
GO
CREATE TABLE PlayList
(
	ID int primary key identity NOT NULL,
	Name nvarchar(50) NOT NULL,
	LastModified datetime NOT NULL,
	UserID int NOT NULL,
	[Description] nvarchar(max),
	constraint FK_PLAYLIST_USER foreign key (UserID) references [User](ID)
 ) 
 GO
CREATE TABLE Singer
(
	ID int primary key identity NOT NULL,
	FullName nvarchar(100) NOT NULL,
	URLImage varchar(300),
	Information nvarchar(max)
) 
GO
CREATE TABLE Category
(
	ID int primary key identity NOT NULL,
	Name nvarchar(50) NOT NULL,
) 
GO
CREATE TABLE CategoryOfAlbum
(
	ID int primary key identity NOT NULL,
	AlbumID int NOT NULL,
	CategoryID int NOT NULL,
	constraint FK_CATEGORYOFALBUM_CATEGORY foreign key (CategoryID) references [Category](ID),
	constraint FK_CATEGORYOFALBUM_ALBUM foreign key (AlbumID) references [Album](ID)
)
GO
CREATE TABLE CategoryOfSongs
(
	ID int primary key identity NOT NULL,
	SongID int NOT NULL,
	CategoryID int NOT NULL,
	constraint FK_CATEGORYOFSONG_CATEGORY foreign key (CategoryID) references [Category](ID),
	constraint FK_CATEGORYOFALBUM_SONG foreign key (SongID) references [Song](ID),
)
GO

CREATE TABLE SingersOfAlbum
(
	ID int primary key identity NOT NULL,
	SingerID int NULL,
	AlbumID int NULL,
	constraint FK_SINGERSOFALBUM_SINGER foreign key (SingerID) references [Singer](ID),
	constraint FK_SINGERSOFALBUM_ALBUM foreign key (AlbumID) references [Album](ID)
)
GO
CREATE TABLE SingersOfSong
(
	ID int primary key identity NOT NULL,
	SingerID int NOT NULL,
	SongID int NOT NULL,
	constraint FK_SINGERSOFSONG_SONG foreign key (SongID) references [Song](ID),
	constraint FK_SINGERSOFSONG_SINGER foreign key (SingerID) references [Singer](ID)
 )
GO

CREATE TABLE SongsInAlbum
(
	ID int primary key identity NOT NULL,
	SongID int NULL,
	AlbumID int NULL,
	constraint FK_SONGSINALBUM_SONG foreign key (SongID) references [Song](ID),
	constraint FK_SONGSINALBUM_ALBUM foreign key (AlbumID) references [Album](ID)
)
GO
CREATE TABLE SongsInPlayList
(
	ID int primary key identity NOT NULL,
	SongID int NOT NULL,
	PlaylistID int NOT NULL,
	constraint FK_SONGINPLAYLIST_PLAYLIST foreign key (PlaylistID) references [Playlist](ID),
	constraint FK_SONGINPLAYLIST_SONG foreign key (SongID) references [Song](ID)
 )


