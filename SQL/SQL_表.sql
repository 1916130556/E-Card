use eeeeee

--�û���
create table UserInfo(
    CardNumber nvarchar(20) primary key,
	UserName nvarchar(10) not null,
	UserGender nvarchar(2) not null,
	UserAge int not null
)

--��ֵ��
create table Top_up(
    ID int identity(1,1) primary key,
	TopupTime datetime not null,
	TopupMoney decimal(10,2),
	CardNumber nvarchar(20) FOREIGN KEY REFERENCES UserInfo(CardNumber),
)

--λ�ñ�
create table Location(
   ID int identity(1,1) primary key,
   Location nvarchar(50) not null unique
)

--ģ��������ѱ�
create table Subway(
   ID int identity(1,1) primary key,
   Entrance nvarchar(50) FOREIGN KEY REFERENCES Location(Location),
   Exitof nvarchar(50) FOREIGN KEY REFERENCES Location(Location),
   Cost decimal(10,2) not null,
   Time datetime not null,
   CardNumber nvarchar(20) FOREIGN KEY REFERENCES UserInfo(CardNumber)
)

--��¼��
create table Login(
    ID int identity(1,1) primary key,
    Account nvarchar(11) not null,
	Pwd nvarchar(30) not null
)