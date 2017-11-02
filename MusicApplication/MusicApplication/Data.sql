use [MusicAppDataBase]
go
insert into [User](Username, Name, [password], [E-mail]) values('thanhtung', N'Thanh Tung', 'password', 'a@gmail.com')
insert into [User](Username, Name, [password], [E-mail]) values('gialuat', N'Gia Luật', 'password', 'b@gmail.com')
insert into [User](Username, Name, [password], [E-mail]) values('sontuong', N'Sơn Tường', 'password', 'c@gmail.com')
insert into [User](Username, Name, [password], [E-mail]) values('ahihi', N'Ahihi', 'password', 'd@gmail.com')
insert into [User](Username, Name, [password], [E-mail]) values('hahaha', N'Hahaha', 'password', 'e@gmail.com')
insert into [User](Username, Name, [password], [E-mail]) values('hohoho', N'Hô hô hô', 'password', 'f@gmail.com')
go
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Em dạo này', 'abc', 1, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Tôi muốn quên em', 'abc', 2, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Em gái mưa', 'abc', 1, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Túy âm', 'abc', 4, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Chiều hôm ấy', 'abc', 5, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Sao chẳng thể vì em', 'abc', 6, '02-10-2017')
go
insert into [Singer](FullName) values(N'Ngọt')
insert into [Singer](FullName) values(N'Phan Mạnh Quỳnh')
insert into [Singer](FullName) values(N'Hương Tràm')
insert into [Singer](FullName) values(N'Xesi')
insert into [Singer](FullName) values(N'Kaykii')
insert into [Singer](FullName) values(N'Đông Nhi')
go
select * from [Category]
insert into [Category](Name) values ('EDM')
insert into [Category](Name) values ('Acoustic')
insert into [Category](Name) values ('Rap/Hip Hop')
insert into [Category](Name) values ('Country')
insert into [Category](Name) values ('Pop')
insert into [Category](Name) values ('Rock')
