--base de datos DoDesign
use master
go
if DB_ID('DoDesign') is not null
drop database DoDesign
go
create database DoDesign
go
----------------------------------------------
use DoDesign
go
-------------------------------------------

if OBJECT_ID('Polo') is not null
drop table Polo
go
create table Polo
(
IdPolo int identity primary key,
IdDesign int not null,
IdColor int not null,
Talla varchar(20),
Precio decimal(5,2) not null

);
----------------------------------------------------



if OBJECT_ID('Design') is not null
drop table Design
go
create table Design
(
IdDesign int identity primary key not null,
Nombre varchar(50) not null,
Descripcion nvarchar(2000)
);

-----------------------------------



-----------------------------------


if OBJECT_ID('Pedido') is not null
drop table Pedido
go
create table Pedido
(
IdPedido int identity primary key,
IdPolo int  not null,
IdPago int not null,
IdCliente int not null,
NroTarjeta char(10) null
);
------------------------------------------
if OBJECT_ID('DetallePedido') is not null
drop table DetallePedido
go
create table DetallePedido
(
IdDetallePedido int identity primary key,
IdPedido int not null,
Cantidad int not null,
Costo decimal(8,2)
);
--------------------------------
if OBJECT_ID('Pago') is not null
drop table Pago
go
create table Pago
(
IdPago int identity primary key,
Tipo varchar(20) not null
);
---------------------------------------------

-----------------------------------
if OBJECT_ID('Color') is not null
drop table Color
go
create table Color
(
IdColor int identity primary key not null,
Nombre varchar(20) not null,
Estado bit not null
);
----------------------------------

if OBJECT_ID('TLogin') is not null
drop table TLogin
go
create table TLogin
(
IdTLogin int identity primary key not null,
NombreUsuario varchar(50) not null constraint uq_NombreUsuario unique nonclustered ,
Email varchar(50) not null constraint uq_Email unique nonclustered ,
Contrasenia varchar(50)
);
-----------------------------------
if OBJECT_ID('Cliente') is not null
drop table Cliente
go
create table Cliente
(
IdCliente int identity primary key not null,
IdTLogin int not null,
NombreUsuario varchar(50) not null,
Email varchar(50) not null,
Nombre varchar(50) not null,
Apellido varchar(50) not null,
Telefono varchar(9) not null,
Direccion varchar(50) not null,
FechaNacimiento datetime not null,
DNI char(8) not null,
NroTarjeta char(10) null
);
----------------------------------
