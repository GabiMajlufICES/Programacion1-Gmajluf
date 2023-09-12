use PruebaEF1

create table Productos 
( id int IDENTITY(1,1) PRIMARY KEY,
  nombre nvarchar(200), 
  precio float)

  create table Proveedores 
( id int IDENTITY(1,1) PRIMARY KEY,
  razon_social nvarchar(200), 
  direccion nvarchar(200))

  create table Clientes 
( id int IDENTITY(1,1) PRIMARY KEY,
  nombre nvarchar(200),
  apellido nvarchar(200),
  direccion nvarchar(200))

  drop table Productos

  delete from Proveedores where id = 1