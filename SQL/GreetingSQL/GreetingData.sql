CREATE DATABASE GreetingHitachi
GO
--DROP DATABASE GreetingHitachi
--GO
USE GreetingHitachi
GO
--DEPARTMENTLIST
CREATE TABLE TableDepartments
(
	departmentID		INT PRIMARY KEY,
	departname			NVARCHAR(100) NOT NULL,
)
GO
--Input initial data for TableDepartmentList
--SET IDENTITY_INSERT TableDepartmentList ON
INSERT INTO TableDepartments VALUES (1, N'DS')
INSERT INTO TableDepartments VALUES (2, N'JDS')
INSERT INTO TableDepartments VALUES (3, N'IS')
INSERT INTO TableDepartments VALUES (4, N'TS')
INSERT INTO TableDepartments VALUES (5, N'EMB')
--TAIKHOAN
CREATE TABLE TableAccounts
(
	userName		NVARCHAR(100) PRIMARY KEY,
    displayName		NVARCHAR(100) NOT NULL DEFAULT N'Admin',
	passWord		NVARCHAR(1000) NOT NULL DEFAULT N'admin',
	adminType		INT NOT NULL
);
GO
--Input initial data for TableAccounts
INSERT INTO TableAccounts(userName, displayName, adminType) VALUES(N'admin'					,N'Admin'					, 1)
INSERT INTO TableAccounts(userName, displayName, adminType) VALUES(N'sonhongpham'			,N'Son Hong Pham'			, 0)
INSERT INTO TableAccounts(userName, displayName, adminType) VALUES(N'vanthingocdo'			,N'Van Thi Ngoc Do'			, 0)
INSERT INTO TableAccounts(userName, displayName, adminType) VALUES(N'huyvandoan'			,N'Huy Van Doan'			, 0)
INSERT INTO TableAccounts(userName, displayName, adminType) VALUES(N'tuanbuunguyen'			,N'Tuan Buu Nguyen'			, 0)
INSERT INTO TableAccounts(userName, displayName, adminType) VALUES(N'hahoang'				,N'Ha Hoang'				, 0)
INSERT INTO TableAccounts(userName, displayName, adminType) VALUES(N'tienthithuynguyen'		,N'Tien Thi Thuy Nguyen'	, 0)
INSERT INTO TableAccounts(userName, displayName, adminType) VALUES(N'trinhthituyetnguyen'	,N'Trinh Thi Tuyet Nguyen'	, 0)
INSERT INTO TableAccounts(userName, displayName, adminType) VALUES(N'thuythidang'			,N'Dang Thi Thuy'			, 0)
INSERT INTO TableAccounts(userName, displayName, adminType) VALUES(N'quocvanhoang'			,N'Quoc Van Hoang'			, 0)
INSERT INTO TableAccounts(userName, displayName, adminType) VALUES(N'thanhvannguyen'		,N'Thanh Van Nguyen'		, 0)
--So thich
create table TableHobbies 
(
	hobbyID				INT PRIMARY KEY,
	hobbyName			NVARCHAR(100) NOT NULL,
)
go
--Intput initial data for TableHobbies
--1:Soccer, 2: Singing, 3: Tennis, 4: Photography, 5: Painting, 6:Cooking, 7: Game
INSERT INTO TableHobbies VALUES (1, N'Soccer')
INSERT INTO TableHobbies VALUES (2, N'Singing')
INSERT INTO TableHobbies VALUES (3, N'Tennis')
INSERT INTO TableHobbies VALUES (4, N'Photography')
INSERT INTO TableHobbies VALUES (5, N'Painting')
INSERT INTO TableHobbies VALUES (6, N'Cooking')
INSERT INTO TableHobbies VALUES (7, N'Game')

--NHANVIEN
CREATE TABLE TableStaff
(
	staffID			int primary key,
	hccid			INT not null,
	fullname		NVARCHAR(100) NOT NULL,
	departmentID	INT NOT NULL FOREIGN KEY REFERENCES TableDepartments(departmentID),
	roles			NVARCHAR(200) NOT NULL,
	birthday		NVARCHAR(100) NOT NULL,
	hobbysID		INT NOT NULL FOREIGN KEY REFERENCES TableHobbies(hobbyID),
	aboardDate		NVARCHAR(100) NOT NULL,
	email			NVARCHAR(100),
	imageName		NVARCHAR(100),
	userName		NVARCHAR(100) FOREIGN KEY REFERENCES TableAccounts(userName)
)
GO
--Input initial data for TableStaff
--1:DS 2:JDS 3:IS 4:TS 5:EMB
--1:Soccer, 2: Singing, 3: Tennis, 4: Photography, 5: Painting, 6:Cooking, 7: Game
INSERT INTO TableStaff VALUES (1, 111222, N'Son Hong Pham'			, 1, N'Da Nang Branch Manager, Mgr Consulting Services, DS - Practice & Delivery - IoT - Product, Engg & Em', '1988-12-11', 1		, '2014-01-01', N'sonph@gmai.com'		, N'1.SonHongPham.png'			, N'sonhongpham')
INSERT INTO TableStaff VALUES (2, 134756, N'Van Thi Ngoc Do'		, 2, N'Sr Consultant, Quality Assurance'																	, '1986-06-08', 2		, '2012-01-01', N'vandtn@gmai.com'		, N'2.VanThiNgocDo.png'			, N'vanthingocdo')
INSERT INTO TableStaff VALUES (3, 112224, N'Huy Van Doan'			, 1, N'Sr Mgr Consulting Services, DS - Practice & Delivery - IoT - Product Engg & Em'						, '1988-09-10', 3		, '2012-01-01', N'huydv@gmai.com'		, N'3.HuyVanDoan.png'			, N'huyvandoan')
INSERT INTO TableStaff VALUES (4, 178678, N'Tuan Buu Nguyen'		, 3, N'Systems Analyst'																						, '1990-01-01', 1		, '2012-01-01', N'tuannb@gmai.com'		, N'4.TuanBuuNguyen.png'		, N'tuanbuunguyen')
INSERT INTO TableStaff VALUES (5, 115116, N'Ha Hoang'				, 2, N'Bilingual Specialist II'																				, '1986-08-25', 4		, '2021-01-01', N'hah@gmai.com'			, N'5.HaHoang.png'				, N'hahoang')
INSERT INTO TableStaff VALUES (6, 135145, N'Tien Thi Thuy Nguyen'	, 2, N'Bilingual Specialist II'																				, '1991-01-09', 5		, '2017-01-01', N'tienntt@gmai.com'		, N'6.TienThiThuyNguyen.png'	, N'tienthithuynguyen')
INSERT INTO TableStaff VALUES (7, 123453, N'Trinh Thi Tuyet Nguyen', 2, N'Facilities Specialist II'																			, '1991-02-07', 6			, '2017-01-01', N'trinhntt@gmai.com'	, N'7.TrinhThiTuyetNguyen.png'	, N'trinhthituyetnguyen')
INSERT INTO TableStaff VALUES (8, 176877, N'Thuy Thi Dang'			, 4, N'Consultant - Tester'																					, '1987-11-09', 6		, '2012-01-01', N'thuydt@gmai.com'		, N'8.ThuyDang.png'				, N'thuythidang')
INSERT INTO TableStaff VALUES (9, 198345, N'Quoc Van Hoang'		, 5, N'Consultant - Developer'																				, '1994-05-02', 1			, '2019-01-01', N'quochv@gmai.com'		, N'9.QuocHoang.png'			, N'quocvanhoang')
INSERT INTO TableStaff VALUES (10, 123876, N'Thanh Van Nguyen'		, 5, N'Sr Consultant - Brse'																				, '1991-02-06', 7		, '2019-01-01', N'thanhnv@gmai.com'		, N'10.ThanhNguyen.png'			, N'thanhvannguyen')
go

--questionType: 1:DisplayName, 2: Hobby, 3: Department 4: Manual
CREATE TABLE TableQuestions
(
	questionID						int PRIMARY KEY,
    questionContent					NVARCHAR(200) NOT NULL DEFAULT N'_',
	questionTypeID					int NOT NULL DEFAULT 1,
	correctAnswer					nvarchar(100) default N'_',
	wrongAnswer1					nvarchar(100) default N'_',
	wrongAnswer2					nvarchar(100) default N'_'
);
GO
insert  into TableQuestions values(1, N'Who is this person?', 1, N'_', N'_', N'_')
insert  into TableQuestions values(2, N'When having network problems, who will you need to contact for support?', 4, N'Tuan Buu Nguyen', N'Thanh Tat Nguyen', N'Son Hong Pham')
insert  into TableQuestions values(3, N'Who is the winner of 2020 Innovation test?', 4, N'Quoc Hoang', N'Dang Thi Thuy', N'Thanh Nguyen')
insert  into TableQuestions values(4, N'Who is the winner  in Women In Digital Transformation Contest held on March 8?', 4, N'Van Thi Do', N'Tien Thi Thuy Nguyen', N'Ha Hoang')
insert  into TableQuestions values(5, N'What is his/her hobby?', 2, N'_', N'_', N'_')
insert  into TableQuestions values(6, N'What is his/her role in the project?', 4, N'Tester', N'Developer', N'Quality Assurance')
insert  into TableQuestions values(7, N'Who is the manager of Danang branch in the period of 2018 ~ 2020?', 4, N'Huy Van Doan', N'Son Hong Pham', N'Long Dang')
insert  into TableQuestions values(8, N'Who is the manager of Danang branch in 2021?', 4, N'Huy Van Doan', N'Son Hong Pham', N'Long Dang')
insert  into TableQuestions values(9, N'What is his/her department/division?', 3, N'_', N'_', N'_')
insert  into TableQuestions values(10, N'Who is the longest working person at Da Nang branch?', 4, N'Van Thi Do', N'Ha Hoang', N'Quoc Hoang')

go

--questionType: 1:CorrectAnswer, 2: News
CREATE TABLE TableCompanyQuestions
(
	comQuestionID						int PRIMARY KEY,
    comQuestionContent					NVARCHAR(200) NOT NULL DEFAULT N'_',
	comQuestionTypeID					int NOT NULL DEFAULT 1,
	comCorrectAnswer					nvarchar(100) default N'_',
	comWrongAnswer1						nvarchar(100) default N'_',
	comWrongAnswer2						nvarchar(100) default N'_',
	conNews								nvarchar(800) default N'_',
);
GO
insert  into TableCompanyQuestions values(1, N'How many employees does the company currently have in 2021? Please choose the correct answer:', 1, N'860', N'800', N'960',N'Answer: 860 members \nHitachi Vantara Vietnam (formerly known as Global CyberSoft Vietnam) is a leading global IT solutions provider founded in California in July 2000.  A Hitachi group company since October 2014, it was rebranded as Hitachi Vantara Vietnam (HVN) in January 2020. With over 800 professionals and engineers, three centers in Vietnam and offices in the US, Japan and Europe.')
insert  into TableCompanyQuestions values(2, N'When was Hitachi Vantara Vietnam Co., Ltd – Da Nang branch established? Please choose the correct answer:', 1, N'August 1, 2012', N'August 1, 2013', N'August 1, 2014',N'Answer: August 1, 2012 \nHitachi Vantara Vietnam Co., Ltd – Da Nang Branch was established on August 1, 2012.')
insert  into TableCompanyQuestions values(3, N'Which contest is this slogan “Powering Good – Unbound Space” for? Please choose the correct answer:', 1, N'HVN Innovation Contest 2021', N'CMMi Agile Transformation', N'Donate for COVID 19 crisis by Community Giving Portal', N'Answer: HVN Innovation Contest 2021 \nHVN Innovation Contest 2021 will start on July 12, 2021. This is an annual program to encourage all the employees of HVN to generate ideas to contribute to the happiness of our society and the growth of our organization toward a prosper.Today is deadline for submit the Idea? Don’t miss to submit.')
insert  into TableCompanyQuestions values(4, N'Which branch of Hitachi Vantara Vietnam has carried out vaccination against covid 19? Please choose the correct answer:', 1, N'Ho Chi Minh', N'Da Nang', N'Ha Noi', N'Answer: Ho Chi Minh \nHo Chi Minh branch carried out vaccinate on June 23, 24, and 25')
insert  into TableCompanyQuestions values(5, N'What contest is APAC Marketing team is launching? Please choose the correct answer:', 1, N'Internal Social Contest', N'Innovation Contest', N'Heathy Contest', N'Answer: Internal Social Contest \nAPAC Marketing team is launching an internal Social Contest for our latest event: Engineered for the Data-driven Watch Party. Here’s your chance to win a 50 USD e-voucher. ')
insert  into TableCompanyQuestions values(6, N'How many employees does Da Nang branch have in 2021?', 1, N'Nearly 90', N'Nearly 150', N'Nearly 120', N'Answer: Nearly 90')
insert  into TableCompanyQuestions values(7, N'Hot jobs at Hitachi Vantara Vietnam - Danang Branch. Ping Ad for more information!!! 🥳 \nDrop your CV at: \nEmail: quynh.nguyen1@hitachivantara.com \nSkype: lamquynh3004 (Josee Nguyen)', 2, N'_', N'_', N'_',N'Information is in the following image')
insert  into TableCompanyQuestions values(8, N'[WEBINAR] Digital Transformation: Improve Operational Efficiency and Reach Profitability Goals in Manufacturing. \n📧REGISTER HERE: https://bit.ly/HVNWebinar \nHVNMarketing@hitachivantara.com', 2, N'_', N'_', N'_',N'As the Covid-19 pandemic sweeps across the globe manufatoring organizations face significant operational challenges: How To Keep Your Company Running During Covid-19 is the question that keeps entrepreneurs business people awake at night. \n To help our clents to answer the above question HVN: Collaborates with Oracle NetSuite to organize the Digital Transfomation Improve Operational Efficiency and Reach Profitability Goals in Manufaturing.')
insert  into TableCompanyQuestions values(9, N'When will the contest "7 days of challenge - Campaign to repel Covid-19" take place? Please choose the correct answer: ', 1, N'22/05/2021 – 28/05/2021', N'22/06/2021 – 28/07/2021', N'19/05/2021 – 26/05/2021', N'Answer: 22/05/2021 – 28/05/2021 \n“7 ngày thử thách – Vận động đẩy lùi Covid-19” là cuộc thi được tổ chức nhằm khuyến khích, tạo động lực giúp mọi người thường xuyên thực hành các hoạt động thể dục thể thao để giữ cơ thể khỏe mạnh, sống tích cực, tăng cường hệ miễn dịch, đặc biệt là trong thời gian chúng ta phải làm việc tại nhà và hạn chế ra ngoài để phòng ngừa dịch Covid-19. \nThời gian: \n- Thời gian dự thi và tính bình chọn: từ ngày 22/05/2021 – 28/05/2021 \n- Thời gian công bố kết quả: 01/06/2021')
insert  into TableCompanyQuestions values(10, N'Are you ready for the biggest night party of the year at Da Nang branch?', 2, N'_', N'_', N'_', N'Information is in the following image')
go

create table TableVoting(
	voteID			int primary key,
	staffID			int foreign key references TableStaff(staffID),
	numVote1s		int default 0,
	numVote2s		int default 0,
	numVote3s		int default 0,
	numVote4s		int default 0,
	numVote5s		int default 0,
)
insert into TableVoting values(1, 1, 0, 0, 0, 0, 0);
--SELECT * FROM TableDepartmentList 
--SELECT * FROM TableAccounts
SELECT * FROM TableStaff
--SELECT * FROM TableDepartmentList as T1, TableAccounts as T2, TableStaff as T3 WHERE T1.departmentID = T3.departmentID and T2.userName = T3.userName
select * from TableQuestions
select * from TableCompanyQuestions

go
--Procedures
create proc USP_GetAccountList
as
begin
	select * from TableAccounts
end
go 
create proc USP_CheckLogInAccounts
@userName nvarchar(100),
@passWord nvarchar(100)
as
begin
	select adminType from TableAccounts where TableAccounts.userName=@userName and TableAccounts.passWord=@passWord
end
go
create proc USP_GetDisplayNameFromUserName
@userName nvarchar(100)
as
begin
	select displayName from TableAccounts as tb where tb.userName=@userName
end
go
--execution USP
exec USP_GetAccountList
go
exec USP_CheckLogInAccounts @userName = N'hahoang', @passWord = N'admin'
go
exec USP_GetDisplayNameFromUserName @userName =N'hahoang'

--drop USP
--drop proc USP_GetAccountList
--go
--drop proc USP_CheckLogInAccounts
--go

--DROP TABLE TableDepartments
--GO
--DROP TABLE TableHobbies
--GO
--DROP TABLE TableAccounts
--GO
--DROP TABLE TableStaff
--GO
--DROP TABLE TableCompanyQuestions
--GO
