create database СпортКлуб
go

use СпортКлуб
go

create table Типы_пользователей
(
ID_Типа_пользователей int primary key identity,
Наименование_типа varchar(25) not null unique
)
go

insert into Типы_пользователей(Наименование_типа)
values	('Тренер'),
		('Менеджер'),
		('Спортсмен'),
		('Администратор')
go

create table Пользователи
(
ID_Пользователя int primary key identity,
Логин varchar(25) not null unique,
Пароль varchar(25) not null,
Тип_пользователя int foreign key references Типы_пользователей(ID_Типа_пользователей) not null
)
go

insert into Пользователи(Логин, Пароль, Тип_пользователя)
values	('trainer','trainer','1'),
		('manager','manager','2'),
		('sportsman','sportsman','3'),
		('administrator','administrator','4')
go

insert into Пользователи(Логин, Пароль, Тип_пользователя)
values	('sportsman1','sportsman1','3'),
		('sportsman2','sportsman2','3'),
		('sportsman3','sportsman3','3'),
		('sportsman4','sportsman4','3'),
		('sportsman5','sportsman5','3'),
		('sportsman6','sportsman6','3'),
		('sportsman7','sportsman7','3'),
		('sportsman8','sportsman8','3'),
		('sportsman9','sportsman9','3'),
		('sportsman10','sportsman10','3'),
		('sportsman11','sportsman11','3'),
		('sportsman12','sportsman12','3'),
		('sportsman13','sportsman13','3'),
		('sportsman14','sportsman14','3'),
		('sportsman15','sportsman15','3')
go

create table Сотрудники
(
ID_Сотрудника int primary key identity,
Фамилия varchar(25) not null,
Имя varchar(25) not null,
Отчество varchar(25) not null,
Данные_для_входа int foreign key references Пользователи(ID_Пользователя) not null
)
go

insert into Сотрудники(Фамилия, Имя, Отчество, Данные_для_входа)
values	('Чудаев','Александр','Петрович','4'),
		('Руденко','Дмитрий','Андреевич','1'),
		('Терницкая','Анастасия','Вячеславовна','3')
go

create table Номинации 
(
ID_Номинации int primary key identity,
Наименование varchar(150) not null unique
)
go

insert into Номинации(Наименование)
values	('МС'),
		('ЗМС'),
		('КМС'),
		('МСМК')
go

create table Спортсмены
(
ID_Спортсмена int primary key identity,
Фамилия varchar(25) not null,
Имя varchar(25) not null,
Отчество varchar(25) not null,
Гражданство varchar(25) not null,
Дата_рождения date not null,
Рост_см int not null,
Вес_кг int not null,
Данные_для_входа int foreign key references Пользователи(ID_Пользователя)
)
go


insert into Спортсмены(Фамилия, Имя, Отчество, Гражданство, Дата_рождения, Рост_см, Вес_кг, Данные_для_входа)
values	('Томашков','Артем','Алексеевич','Россия','1998-12-04','182','90','5'),
		('Кичеров','Павел','Олегович','Россия','2000-01-12','164','80','6'),
		('Жидарев','Даниил','Дмитриевич','Россия','1999-06-09','173','67','7'),
		('Макаров','Павел','Евгеньевич','Россия','2001-10-14','187','75','8'),
		('Генш','Данил','Алексеевич','Россия','2000-02-27','176','74','9'),
		('Жуйков','Крыса','Дебилович','Чехия','1998-04-13','184','68','10'),
		('Круч','Давыд','Георгиевич','Казахстан','1998-08-09','165','59','11'),
		('Собин','Максим','Владимирович','Казахстан','1997-03-18','165','52','12'),
		('Ниязов','Ильназ','Ахматович','Казахстан','2000-12-01','170','80','13'),
		('Демиденок','Алина','Олеговна','Россия','2000-08-12','165','50','14'),
		('Иванова','Дарья','Петровна','Россия','2000-09-15','167','52','15'),
		('Бойко','Мария','Ниятова','Украина','1999-11-11','175','60','16'),
		('Антименко','Юлия','Дмитриевна','Украина','2000-11-29','167','52','17'),
		('Шишкова','Алена','Алексеевна','Россия','1999-05-06','172','56','18'),
		('Карпов','Артем','Иванович','Россия','1998-04-20','178','70','19')
go

create table Награды_спортсменов
(
ID_Записи int primary key,
Спортсмен int foreign key references Спортсмены(ID_Спортсмена) not null,
Награда int foreign key references Номинации(ID_Номинации) not null 
)
go

insert into Награды_спортсменов(Спортсмен, Награда)
values	('2','1'),
		('3','1'),
		('4','1'),
		('5','2'),
		('6','2'),
		('7','2'),
		('8','3'),
		('9','3'),
		('10','3'),
		('11','4'),
		('12','4'),
		('13','4'),
		('14','1'),
		('15','2'),
		('16','3')
go

create table Виды_спорта
(
ID_Вида_спорта int primary key identity,
Наименование varchar(35) not null unique
)
go

insert into Виды_спорта(Наименование)
values	('Футбол'),
		('Волейбол'),
		('Баскетбол')
go

create table Команды
(
ID_Команды int primary key identity,
Наименование varchar(25) not null unique,
Вид_спорта int foreign key references Виды_спорта(ID_Вида_спорта) not null,
Тренер int foreign key references Сотрудники(ID_Сотрудника) not null
)
go

insert into Команды(Наименование, Вид_спорта, Тренер)
values	('Локомотив','1','2'),
		('Ястребы','2','1'),
		('Буревестник','3','3')
go

create table Спортсмены_в_команде
(
ID_Записи int primary key identity,
Команда int foreign key references Команды(ID_Команды) not null,
Спортсмен int foreign key references Спортсмены(ID_Спортсмена) not null
)
go

insert into Спортсмены_в_команде(Команда, Спортсмен)
values	('2','2'),
		('2','3'),
		('2','4'),
		('2','5'),
		('2','6'),
		('3','7'),
		('3','8'),
		('3','9'),
		('3','10'),
		('3','11'),
		('4','12'),
		('4','13'),
		('4','14'),
		('4','15'),
		('4','16')
go

create table Типы_мероприятий 
(
ID_Типа int primary key identity,
Наименование varchar(30) not null unique
)
go

insert into Типы_мероприятий(Наименование)
values	('Турнир'),
		('Соревнование'),
		('Олимпиада')
go

create table Мероприятия 
(
ID_Мероприятия int primary key identity,
Наименование varchar(50) not null,
Тип_мероприятия int foreign key references Типы_мероприятий(ID_Типа) not null,
Дата_проведения date not null,
Время_проведения time not null,
Место_проведения varchar(100) not null
)
go

insert into Мероприятия(Наименование, Тип_мероприятия, Дата_проведения, Время_проведения, Место_проведения)
values	('Весенние игры','1','20-04-2021','12:00:00','Омск, Красный путь 201А'),
		('Гранд','1','15-05-2021','16:00:00','Омск, Химиков 51'),
		('Финал','1','18-05-2021','14:00:00','Омск, Химиков 51'),
		('Полет ястребов','2','09-06-2021','19:30:00','Барнаул, Ленина 194Д'),
		('Спортакиада','3','17-08-2021','13:20:00','Новосибирск, Гражданская 94')
go

create table Команды_на_мероприятии
(
ID_Записи int primary key identity,
Мероприятие int foreign key references Мероприятия(ID_Мероприятия) not null,
Команда int foreign key references Команды(ID_Команды) not null
)
go

insert into Команды_на_мероприятии(Мероприятие, Команда)
values	('1','2'),
		('2','4'),
		('3','3'),
		('4','2'),
		('5','3')
go


/*Представления*/

create view GetAuthData 
(Логин, Пароль, Тип_пользователя)
as
select Логин, Пароль, Типы_пользователей.Наименование_типа
from Пользователи inner join Типы_пользователей on Пользователи.Тип_пользователя = Типы_пользователей.ID_Типа_пользователей
go

create view GetSportsmanData
(Фамилия, Имя ,Отчество, Гражданство, Дата_рождения, Рост_см, Вес_кг, Команда)
as
select Фамилия, Имя, Отчество, Гражданство, Дата_рождения, Рост_см, Вес_кг, Команды.Наименование
from Спортсмены inner join Спортсмены_в_команде on Спортсмены_в_команде.Спортсмен = Спортсмены.ID_Спортсмена
				inner join Команды on Команды.ID_Команды = Спортсмены_в_команде.Команда
go

create view GetEventsData
(Название, Тип_мероприятия, Дата_проведения, Время_проведения, Место_проведения, Команда)
as
select Мероприятия.Наименование, Типы_мероприятий.Наименование, Дата_проведения, Время_проведения, Место_проведения, Команды.Наименование
from Команды_на_мероприятии inner join Команды on Команды_на_мероприятии.Команда = Команды.ID_Команды
							inner join Мероприятия on Команды_на_мероприятии.Мероприятие = Мероприятия.ID_Мероприятия
							inner join Типы_мероприятий on Мероприятия.Тип_мероприятия = Типы_мероприятий.ID_Типа
go

/*Процедуры*/

create procedure GetAuthUserData
@userlogin varchar(25)
as
	begin
		select Фамилия, Имя, Отчество
		from Сотрудники inner join Пользователи on Сотрудники.Данные_для_входа = Пользователи.ID_Пользователя
						inner join Типы_пользователей on Пользователи.Тип_пользователя = Типы_пользователей.ID_Типа_пользователей 
		where Пользователи.Логин = @userlogin
	end
go

create procedure CreateNewUser
@login varchar(25), @password varchar(25), @userType int
as
	begin
		if exists(select Логин from Пользователи where Логин = @login)
			begin
				rollback transaction
				raiserror('Пользователь с таким логином уже существует!',0,1)
			end
		else
			begin
				insert into Пользователи(Логин, Пароль, Тип_пользователя)
				values	(@login, @password, @userType)
			end
	end
go

create procedure AddNewSportsman
@surname varchar(25), @name varchar(25), @lastName varchar(25), @citizen varchar(25), @birthdate date, @weight int, @height int, @authData int
as
	begin
		if ((select count(ID_Спортсмена) from Спортсмены where Фамилия = @surname and Имя = @name) > 1)
			begin
				rollback transaction 
				raiserror('Спортсмен с данными фамилией и именем уже существует',0,1)
			end
		else
			begin
				insert into Спортсмены(Фамилия, Имя, Отчество, Гражданство, Дата_рождения, Вес_кг, Рост_см, Данные_для_входа)
				values	(@surname, @name, @lastName, @citizen, @birthdate, @weight, @height, @authData)
			end
	end
go

create procedure GetEmpIDByAuthUser
@userlogin varchar(25), @temp int = 0
as
	begin
		set @temp = (select ID_Пользователя from Пользователи where Логин = @userlogin)
		select ID_Сотрудника from Сотрудники where ID_Сотрудника = @temp
	end
go

