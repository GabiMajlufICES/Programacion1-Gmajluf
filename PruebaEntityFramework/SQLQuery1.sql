create database PruebaEF1

--use PruebaEF

create table Productos 
( id int IDENTITY(1,1) PRIMARY KEY,
  nombre nvarchar(200), 
  precio float)

use PruebaEF

--drop table Productos
 
   
insert into Productos values ('Martillo' , 10000)
   
insert into Productos values ('hacha' , 20000)

select * from Productos


