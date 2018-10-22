CREATE DATABASE SEMANA09
use SEMANA09
go
CREATE TABLE lista(
	id int primary key,
	distrito varchar(50)
	)
insert lista values
(1,'Lima')
insert lista values
(2,'Ate')
insert lista values
(3,'Lince')
insert lista values
(4,'Rimac')
select * from lista

CREATE DATABASE PC02
use PC02
go
create table users(
	access char(10) primary key,
	password char(10)
)
go
create table category(
	idCategory char(10) primary key,
	name varchar(50),
	description varchar(50)
)
go
create table product(
	idProduct int primary key identity(1,1),
	name varchar(50),
	idCategory char(10) references category(idCategory),
	price int,
	expirationDate Datetime,
	unit int
)
insert users values('pacman','123456')
insert category values('1','tecnologia','componentes tecnologicos')
insert category values('2','calzado','zapatos u otros')
insert product values('AMD RX 580','1',290,convert(datetime,'18-06-12 13:13:13 PM',5),100);
insert product values('Iphone SE','1',20,convert(datetime,'18-06-12 13:13:13 PM',5),111);
select * from product
drop table product
delete from product where idProduct = 1
