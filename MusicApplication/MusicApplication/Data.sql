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
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Xin gọi nhau là cố nhân', 'abc', 6, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Chuyến tàu hoàng hôn', 'abc', 6, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Trả lại thời gian', 'abc', 6, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Nghẹn ngào', 'abc', 6, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Người ta nói', 'abc', 2, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Trộm nhìn nhau', 'abc', 6, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Thành phố buồn', 'abc', 6, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Sao chưa thấy hồi âm', 'abc', 2, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Huyền thoại chiều mưa', 'abc', 2, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Thương Tình Nhân', 'abc', 6, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Con Đường Xưa Em Đi', 'abc', 6, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Khi Đã Yêu', 'abc', 2, '02-10-2017')
insert into [Song](Name, URL, UploaderID, LastModified)	values(N'Xóa Sạch Hết', 'abc', 2, '02-10-2017')
go
insert into [Singer](FullName, URLImage, Information) 
values(N'Khánh Vũ', 'khanhvu.jpg', N'Phan Mạnh Quỳnh là tác giả của nhiều bản hit mà ca sĩ Ưng Hoàng Phúc,
 Khởi My, Hồ Quang Hiếu, Miu Lê... từng thể hiện. Không chỉ sáng tác, anh còn được cộng đồng mạng yêu mến
  khi tự thể hiện các ca khúc của mình với chất giọng lạ, trầm ấm và gần gũi với cuộc sống như "Người yêu cũ",
   "Nước ngoài", "Bước qua thế giới", "Mất hy vọng", "Khi phải quên đi"...')
insert into [Singer](FullName, URLImage, Information) 
values(N'Thủy Tiên', 'thuytien.jpg', N'Phan Mạnh Quỳnh là tác giả của nhiều bản hit mà ca sĩ Ưng Hoàng Phúc,
 Khởi My, Hồ Quang Hiếu, Miu Lê... từng thể hiện. Không chỉ sáng tác, anh còn được cộng đồng mạng yêu mến
  khi tự thể hiện các ca khúc của mình với chất giọng lạ, trầm ấm và gần gũi với cuộc sống như "Người yêu cũ",
   "Nước ngoài", "Bước qua thế giới", "Mất hy vọng", "Khi phải quên đi"...')
insert into [Singer](FullName, URLImage, Information) 
values(N'Ưng Hoàng Phúc', 'uhp.jpg', N'Nam Anh, Thắng và Tuấn cùng nhau thành lập ban nhạc đầu tiên khi cả
3 đang theo học THCS tại Hà Nội. Tháng 12/2012, khi chuẩn bị bước vào kì thi tốt nghiệp
THPT, Thắng gặp Hoàng, khi đó là sinh viên năm cuối. Cả 2 khi đó cùng tham gia một buổi
biểu diễn cover ban nhạc The Beatles tại Hà Nội. Tháng 7/2013, Nam Anh, Thắng, Tuấn tốt
nghiệp THPT và bắt đầu theo học các trường Đại học khác nhau tại Hà Nội. Thắng quyết định 
sẽ thành lập một nhóm chỉ chơi sáng tác, thay vì chơi lại các ban nhạc khác như trước đây. 
Nam Anh và Tuấn ngay lập tức hưởng ứng ý tưởng này và ban nhạc quyết định tìm kiếm mảnh ghép 
cuối cùng là thành viên chơi bass. Hoàng là người đầu tiên Thắng tìm đến, song cuối cùng thành 
viên này chưa thể tham gia ban nhạc do sẽ lên đường du học vào tháng 9/2013. Tháng 11/2013, Ngọt 
chính thức được thành lập với 3 thành viên là Nam Anh, Thắng và Tuấn. Cái tên "Ngọt" được đặt một 
cách ngẫu hứng do ở thời điểm đó, các thành viên "chỉ cần 1 cái tên để ngắn gọn, dễ gọi để phân biệt 
với các ban nhạc khác".')
insert into [Singer](FullName, URLImage, Information) 
values(N'Giang Hồng Ngọc', 'ghn.jpg', N'Nam Anh, Thắng và Tuấn cùng nhau thành lập ban nhạc đầu tiên khi cả
3 đang theo học THCS tại Hà Nội. Tháng 12/2012, khi chuẩn bị bước vào kì thi tốt nghiệp
THPT, Thắng gặp Hoàng, khi đó là sinh viên năm cuối. Cả 2 khi đó cùng tham gia một buổi
biểu diễn cover ban nhạc The Beatles tại Hà Nội. Tháng 7/2013, Nam Anh, Thắng, Tuấn tốt
nghiệp THPT và bắt đầu theo học các trường Đại học khác nhau tại Hà Nội. Thắng quyết định 
sẽ thành lập một nhóm chỉ chơi sáng tác, thay vì chơi lại các ban nhạc khác như trước đây. 
Nam Anh và Tuấn ngay lập tức hưởng ứng ý tưởng này và ban nhạc quyết định tìm kiếm mảnh ghép 
cuối cùng là thành viên chơi bass. Hoàng là người đầu tiên Thắng tìm đến, song cuối cùng thành 
viên này chưa thể tham gia ban nhạc do sẽ lên đường du học vào tháng 9/2013. Tháng 11/2013, Ngọt 
chính thức được thành lập với 3 thành viên là Nam Anh, Thắng và Tuấn. Cái tên "Ngọt" được đặt một 
cách ngẫu hứng do ở thời điểm đó, các thành viên "chỉ cần 1 cái tên để ngắn gọn, dễ gọi để phân biệt 
với các ban nhạc khác".')
insert into [Singer](FullName, URLImage, Information) 
values(N'Ngọt', 'ngot.jpg', N'Nam Anh, Thắng và Tuấn cùng nhau thành lập ban nhạc đầu tiên khi cả
3 đang theo học THCS tại Hà Nội. Tháng 12/2012, khi chuẩn bị bước vào kì thi tốt nghiệp
THPT, Thắng gặp Hoàng, khi đó là sinh viên năm cuối. Cả 2 khi đó cùng tham gia một buổi
biểu diễn cover ban nhạc The Beatles tại Hà Nội. Tháng 7/2013, Nam Anh, Thắng, Tuấn tốt
nghiệp THPT và bắt đầu theo học các trường Đại học khác nhau tại Hà Nội. Thắng quyết định 
sẽ thành lập một nhóm chỉ chơi sáng tác, thay vì chơi lại các ban nhạc khác như trước đây. 
Nam Anh và Tuấn ngay lập tức hưởng ứng ý tưởng này và ban nhạc quyết định tìm kiếm mảnh ghép 
cuối cùng là thành viên chơi bass. Hoàng là người đầu tiên Thắng tìm đến, song cuối cùng thành 
viên này chưa thể tham gia ban nhạc do sẽ lên đường du học vào tháng 9/2013. Tháng 11/2013, Ngọt 
chính thức được thành lập với 3 thành viên là Nam Anh, Thắng và Tuấn. Cái tên "Ngọt" được đặt một 
cách ngẫu hứng do ở thời điểm đó, các thành viên "chỉ cần 1 cái tên để ngắn gọn, dễ gọi để phân biệt 
với các ban nhạc khác".')
insert into [Singer](FullName, URLImage, Information) 
values(N'Đàm Vĩnh Hưng', 'dvh.jpg', N'Phan Mạnh Quỳnh là tác giả của nhiều bản hit mà ca sĩ Ưng Hoàng Phúc,
 Khởi My, Hồ Quang Hiếu, Miu Lê... từng thể hiện. Không chỉ sáng tác, anh còn được cộng đồng mạng yêu mến
  khi tự thể hiện các ca khúc của mình với chất giọng lạ, trầm ấm và gần gũi với cuộc sống như "Người yêu cũ",
   "Nước ngoài", "Bước qua thế giới", "Mất hy vọng", "Khi phải quên đi"...')
insert into [Singer](FullName, URLImage, Information) 
values(N'Phan Mạnh Quỳnh', 'pmq.jpg', N'Phan Mạnh Quỳnh là tác giả của nhiều bản hit mà ca sĩ Ưng Hoàng Phúc,
 Khởi My, Hồ Quang Hiếu, Miu Lê... từng thể hiện. Không chỉ sáng tác, anh còn được cộng đồng mạng yêu mến
  khi tự thể hiện các ca khúc của mình với chất giọng lạ, trầm ấm và gần gũi với cuộc sống như "Người yêu cũ",
   "Nước ngoài", "Bước qua thế giới", "Mất hy vọng", "Khi phải quên đi"...')
insert into [Singer](FullName, URLImage, Information) 
values(N'Hương Tràm', N'huongtram.jpg', N'Hương Tràm là con nhà nòi. 
Cô có ba là NSƯT Tiến Dũng và anh trai là thí sinh Sao Mai điểm hẹn 2010 Phạm Tiến Mạnh. 
Năm phát hành 2013: Ngại Ngùng Với Em Là Mãi Mãi Xa Sẽ Có Người Cần Anh – song ca với Cao Thái Sơn Trăng dưới chân 
mình Vẫn yêu từng phút giây – song ca với Cao Thái Sơn. Năm phát hành 2015: I’m still loving you. 
Năm phát hành 2016: Ngốc Cho Em Gần Anh Thêm Chút Nữa (Nhạc phim cùng tên). Năm phát hành 2017: 
Ta Còn Thuộc Về Nhau. Em Gái Mưa')
insert into [Singer](FullName, URLImage, Information) 
values(N'Xesi', 'xesi.jpg', N'Xesi là nữ ca sĩ hát bài Túy Âm nổi tiếng thời gian gần đây.
Gia đình không có ai theo nghệ thuật, nhưng được cái bố mẹ rất ủng hộ Xesi theo đuổi ước mơ. 
Ca khúc Túy Âm được sáng tác sau khi nghe câu chuyện tình yêu thời cấp 3 của một người bạn cùng đam mê. 
Vì thế, Xesi đã kể lại câu chuyện đó bằng âm nhạc, nghĩa của từ Túy Âm là người đàn ông không chỉ say 
trong men rượu mà còn say trong âm nhạc.Hiện tại, ngoài chăm chỉ đến trường để hoàn thành việc học cuối cấp, 
Xesi cũng đang thử thách bản thân ở những ý tưởng lạ hơn, hứa hẹn mang lại cho người yêu âm nhạc những tác phẩm "gây nghiện" hơn nữa.')
insert into [Singer](FullName, URLImage, Information)
values(N'Jaykii', 'jaykii.jpg', N'JayKii là một gương mặt ca sĩ đã không còn xa lạ với những người yêu nhạc Việt,
đặc biệt là giới trẻ. Anh được công chúng biết tới từ khi tham gia cuộc thi "VietNam Idol 2013". 
Sau khi rời khỏi chương trình VietNam Idol 2013, JayKii đã chính thức hoạt động âm nhạc chuyên nghiệp.
Anh khá thành công với dòng nhạc Ballad. Các ca khúc của anh được nhiều người yêu thích như: Anh Yêu Em,
Anh Sẽ Cố Quên Em, Con Khóc, Khi Em Rời Xa, Điều Lặng Thầm Trong Anh, Anh Đã Mất Em... Mới đây, nam ca sĩ 
này đã tung ra single "Chiều hôm ấy", một ca khúc do chính anh sáng tác và thể hiện. MV ca khúc này đã thu 
hút gần 1 triệu lượt xem trên Youtube chi sau một thời gian ngắn phát hành.')
insert into [Singer](FullName, URLImage, Information) 
values(N'Đông Nhi', 'dongnhi.jpg', 'Thuở nhỏ sống ở Hà Nội, được khoảng lớp 4 thì chuyển vào TP.HCM 
sống Tên thân mật thường gọi: Nu Nu Nick trong FC: POTATO Chúa Cao: 1m66, nặng 49 kg 
Sở thích: ca hát (tất nhiên rùi ^^), nhảy múa, đánh đàn piano, sáng tác, xem phim, shopping,
ăn uống cực pro nhưng không hề "bé bự" nhá Tật xấu: hạy quên, hay trễ giờ (vì điệu), ngủ nướng.
Các blog, forum FC trên mạng: Là ca sĩ kiêm nhạc sĩ, diễn viên người Việt Nam. Cô được biết đến 
với một số ca khúc hit dành cho lứa tuổi teen như: "Khóc", "Bối Rối", "Bí Mật Của Hạnh Phúc", 
"Lời Thú Tội Ngọt Ngào",.. Cùng với: Bảo Thy, Noo Phước Thịnh,... Đông Nhi được coi là người đi
tiên phong cho phong trào ca sĩ bước ra từ thế giới mạng.')
insert into SingersOfSong values(1, 1)
insert into SingersOfSong values(2, 2)
insert into SingersOfSong values(3, 3)
insert into SingersOfSong values(4, 4)
insert into SingersOfSong values(5, 5)
insert into SingersOfSong values(6, 6)
go
select * from [Category]
insert into [Category](Name) values ('EDM')
insert into [Category](Name) values ('Acoustic')
insert into [Category](Name) values ('Rap/Hip Hop')
insert into [Category](Name) values ('Country')
insert into [Category](Name) values ('Pop')
insert into [Category](Name) values ('Rock')
go
insert into Album(Name,URLImage) values (N'Bay về thời gian', 'bayvethoigian.jpg')
insert into Album(Name,URLImage) values (N'Người ta nói (Single)', 'nguoitanoi.jpg')
insert into Album(Name,URLImage) values (N'Đôi mắt người xưa', 'doimatnguoixua.jpg')
insert into Album(Name,URLImage) values (N'Tôi muốn quên em (Single)', 'toimuonquenem.jpg')
insert into Album(Name,URLImage) values (N'Tình bơ vơ', 'tinhbovo.jpg')
insert into Album(Name,URLImage) values (N'Xóa sạch hết (Single)', 'xoasachhet.jpg')
go
insert into SingersOfAlbum(SingerID, AlbumID) values(7,1)
insert into SingersOfAlbum(SingerID, AlbumID) values(8,2)
insert into SingersOfAlbum(SingerID, AlbumID) values(9,3)
insert into SingersOfAlbum(SingerID, AlbumID) values(2,4)
insert into SingersOfAlbum(SingerID, AlbumID) values(10,5)
insert into SingersOfAlbum(SingerID, AlbumID) values(11,6)	
go
insert into SongsInAlbum(SongID, AlbumID) values(7,1)
insert into SongsInAlbum(SongID, AlbumID) values(8,1)
insert into SongsInAlbum(SongID, AlbumID) values(9,1)
insert into SongsInAlbum(SongID, AlbumID) values(10,1)
insert into SongsInAlbum(SongID, AlbumID) values(11,2)
insert into SongsInAlbum(SongID, AlbumID) values(12,3)
insert into SongsInAlbum(SongID, AlbumID) values(13,3)
insert into SongsInAlbum(SongID, AlbumID) values(14,3)
insert into SongsInAlbum(SongID, AlbumID) values(2,4)
insert into SongsInAlbum(SongID, AlbumID) values(15,5)
insert into SongsInAlbum(SongID, AlbumID) values(16,5)
insert into SongsInAlbum(SongID, AlbumID) values(17,5)
insert into SongsInAlbum(SongID, AlbumID) values(18,5)
insert into SongsInAlbum(SongID, AlbumID) values(19,6)					