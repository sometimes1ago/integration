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
		('Терницкая','Анастасия','Вячеславовна','2')
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
values	('Томашков','Артем','Алексеевич','Россия','1998-12-04','182','90','4'),
		('Кичеров','Павел','Олегович','Россия','2000-01-12','164','80','5'),
		('Жидарев','Даниил','Дмитриевич','Россия','1999-06-09','173','67','6'),
		('Макаров','Павел','Евгеньевич','Россия','2001-10-14','187','75','7'),
		('Генш','Данил','Алексеевич','Россия','2000-02-27','176','74','8'),
		('Жуйков','Крыса','Дебилович','Чехия','1998-04-13','184','68','9'),
		('Круч','Давыд','Георгиевич','Казахстан','1998-08-09','165','59','10'),
		('Собин','Максим','Владимирович','Казахстан','1997-03-18','165','52','11'),
		('Ниязов','Ильназ','Ахматович','Казахстан','2000-12-01','170','80','12'),
		('Демиденок','Алина','Олеговна','Россия','2000-08-12','165','50','13'),
		('Иванова','Дарья','Петровна','Россия','2000-09-15','167','52','14'),
		('Бойко','Мария','Ниятова','Украина','1999-11-11','175','60','15'),
		('Антименко','Юлия','Дмитриевна','Украина','2000-11-29','167','52','16'),
		('Шишкова','Алена','Алексеевна','Россия','1999-05-06','172','56','17'),
		('Карпов','Артем','Иванович','Россия','1998-04-20','178','70','18')
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
values	('1','16'),
		('1','17'),
		('1','18'),
		('1','19'),
		('1','20'),
		('2','21'),
		('2','22'),
		('2','23'),
		('2','24'),
		('2','25'),
		('3','26'),
		('3','27'),
		('3','28'),
		('3','29'),
		('3','30')
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
values	('1','1'),
		('2','3'),
		('3','2'),
		('4','1'),
		('5','3')
go

select ID_Типа_пользователей from Типы_пользователей where Наименование_типа =  'Менеджер'

/*Представления*/

create view GetAuthData 
(Логин, Пароль, Тип_пользователя)
as
select Логин, Пароль, Типы_пользователей.Наименование_типа
from Пользователи inner join Типы_пользователей on Пользователи.Тип_пользователя = Типы_пользователей.ID_Типа_пользователей
go

create view GetEmployeeData
(Фамилия, Имя, Отчество, Должность)
as
	select Фамилия, Имя, Отчество, Типы_пользователей.Наименование_типа
	from Сотрудники inner join Пользователи on Сотрудники.Данные_для_входа = Пользователи.ID_Пользователя
					inner join Типы_пользователей on Пользователи.Тип_пользователя = Типы_пользователей.ID_Типа_пользователей
go


create view GetSportsmanData
(Фамилия, Имя ,Отчество, Гражданство, Дата_рождения, Рост_см, Вес_кг, Команда, Вид_спорта)
as
select Фамилия, Имя, Отчество, Гражданство, Дата_рождения, Рост_см, Вес_кг, Команды.Наименование, Виды_спорта.Наименование
from Спортсмены inner join Спортсмены_в_команде on Спортсмены_в_команде.Спортсмен = Спортсмены.ID_Спортсмена
				inner join Команды on Команды.ID_Команды = Спортсмены_в_команде.Команда
				inner join Виды_спорта on Команды.Вид_спорта = Виды_спорта.ID_Вида_спорта
go

create view GetEventsData
(Название, Тип_мероприятия, Дата_проведения, Время_проведения, Место_проведения, Команда, Вид_спорта, Статус)
as
select Мероприятия.Наименование, Типы_мероприятий.Наименование, Дата_проведения, Время_проведения, Место_проведения, Команды.Наименование, Виды_спорта.Наименование, Мероприятия.Статус
from Команды_на_мероприятии inner join Команды on Команды_на_мероприятии.Команда = Команды.ID_Команды
							inner join Мероприятия on Команды_на_мероприятии.Мероприятие = Мероприятия.ID_Мероприятия
							inner join Типы_мероприятий on Мероприятия.Тип_мероприятия = Типы_мероприятий.ID_Типа
							inner join Виды_спорта on Команды.Вид_спорта = Виды_спорта.ID_Вида_спорта
go

select * from GetEventsData where Название = 'Гранд'

select Мероприятия.Наименование, Статус from Мероприятия where Наименование = @1

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

create procedure TestDBv2
@sortby varchar(25), @orderby varchar(4)
as
	select * from GetEventsData
	order by case when @sortby = 'Название' and @orderby = 'ASC' then Название end ASC,
				case when @sortby = 'Название' and @orderby = 'DESC' then Название end DESC,
				case when @sortby = 'Тип_мероприятия' and @orderby = 'ASC' then Тип_мероприятия end ASC,
				case when @sortby = 'Тип_мероприятия' and @orderby = 'DESC' then Тип_мероприятия end DESC,
				case when @sortby = 'Дата_проведения' and @orderby = 'ASC' then Дата_проведения end ASC,
				case when @sortby = 'Дата_проведения' and @orderby = 'DESC' then Дата_проведения end DESC,
				case when @sortby = 'Время_проведения' and @orderby = 'ASC' then Время_проведения end ASC,
				case when @sortby = 'Время_проведения' and @orderby = 'DESC' then Время_проведения end DESC,
				case when @sortby = 'Место_проведения' and @orderby = 'ASC' then Место_проведения end ASC,
				case when @sortby = 'Место_проведения' and @orderby = 'DESC' then Место_проведения end DESC,
				case when @sortby = 'Команда' and @orderby = 'ASC' then Команда end ASC,
				case when @sortby = 'Команда' and @orderby = 'DESC' then Команда end DESC
go

execute TestDBv2 'Название', 'ASC'
go

create procedure TestDBv
@sortby varchar(25)
as
	select * from GetEventsData
	order by case when @sortby = 'Название' then Название end ASC,
				case when @sortby = 'Тип_мероприятия' then Тип_мероприятия end ASC,
				case when @sortby = 'Дата_проведения'  then Дата_проведения end ASC,
				case when @sortby = 'Время_проведения' then Время_проведения end ASC,
				case when @sortby = 'Место_проведения' then Место_проведения end ASC,
				case when @sortby = 'Команда'  then Команда end ASC
go

execute TestDBv2 'Место_проведения','ASC'

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

create procedure GetSportsmanIDByUserlogin
@userlogin varchar(25), @temp int = 0
as
	begin
		set @temp = (select ID_Пользователя from Пользователи where Логин = @userlogin)
		select ID_Спортсмена from Спортсмены where Данные_для_входа = @temp
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

create procedure AddNewEmployee
@surname varchar(25), @name varchar(25), @lastName varchar(25), @authData int
as
	begin
		if exists (select Фамилия, Имя from Сотрудники where Фамилия = @surname and Имя = @name)
			begin
				rollback tran
				raiserror('Сотрудник с такими фамилией и именем уже существует!',0,1)
			end
		else
			begin
				insert into Сотрудники(Фамилия, Имя, Отчество, Данные_для_входа)
				values	(@surname, @name, @lastName, @authData)
			end
	end
go

create procedure GetEmpIDBySurnameName
@surname varchar(25), @name varchar(25)
as
	begin
		select ID_Сотрудника
		from Сотрудники
		where Фамилия = @surname and Имя = @name
	end
go


create procedure GetEmpIDByAuthUser
@userlogin varchar(25)
as
	begin
		select ID_Сотрудника 
		from Сотрудники inner join Пользователи on Сотрудники.Данные_для_входа = Пользователи.ID_Пользователя
		where Пользователи.Логин = @userlogin
	end
go


create procedure CreateNewEvent
@name varchar(50), @evtType int, @evtDate date, @evtTime time, @evtPlace varchar(150), @status varchar(25)
as
	begin
		if exists (select Наименование from Мероприятия where Наименование = @name)
			begin	
				rollback tran
				raiserror('Мероприятие с таким названием уже существует!',0,1)
			end
		else 
			begin
				insert into Мероприятия(Наименование, Тип_мероприятия, Дата_проведения, Время_проведения, Место_проведения, Статус)
				values	(@name, @evtType, @evtDate, @evtTime, @evtPlace, @status)
			end
	end
go

create procedure GetSurnameNameByLogin
@login varchar(25)
as
	begin
		select Фамилия, Имя
		from Сотрудники inner join Пользователи on Сотрудники.Данные_для_входа = Пользователи.ID_Пользователя
		where Пользователи.Логин = @login
	end
go

create procedure GetTrainerSpData
@trainerID int, @temp int = 0, @teamName varchar(25) = ''
as
	begin
		set @temp = (select ID_Команды from Команды where Тренер = @trainerID)
		set @teamName = (select Наименование from Команды where ID_Команды = @temp)
		select * from  GetSportsmanData where Команда = @teamName
	end
go

create trigger CreateEventDateValidator
on Мероприятия
for insert, update
as
	declare @evtID int = (select ID_Мероприятия from inserted)
	declare @evtDate date = (select Дата_проведения from inserted)
		begin
			if ((select Дата_проведения from Мероприятия where ID_Мероприятия = @evtID) < getdate()) 
				begin
					rollback tran 
					raiserror('Добавить мероприятие с датой меньше сегодняшней невозможно',0,1)
				end
		end
go