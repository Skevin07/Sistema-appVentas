create database sistema_ventas;
use sistema_ventas;

create table tb_usuarios(
Id int primary key identity(1,1),
Email varchar (50),
Contrasena varchar(100)
);


create table roles_usuarios
(
id_Rol_Usuario int primary key identity (1,1),
id_usuario int,
tipo_rol varchar (50)
);
go

--insertando codigo de la clase de las nuevas tablas

Create table tb_venta
(
idVenta int primary Key identity(1,1),
idDocumento int,
iDCliente int,
iDUsuario int,
totalVenta decimal,
fecha Date
);
insert into tb_venta (idDocumento,iDCliente,iDUsuario,totalVenta,fecha) values (1,1,1,5.5,GETDATE());
go


create table tb_documento
(
iDDocumento int primary key identity (1,1),
nombreDocumento varchar (50)
);
insert into tb_documento (nombreDocumento) values ('TICKET');
insert into tb_documento (nombreDocumento) values ('FACTURA');
go


create table tb_cliente 
(
iDCliente int primary key identity(1,1),
nombreCliente varchar (50),
direccionCliente varchar(50),
duiCliente varchar(50)
);
insert into tb_cliente(nombreCliente,direccionCliente,duiCliente) values ('William Diaz','El Paraiso','000000017');
insert into tb_cliente(nombreCliente,direccionCliente,duiCliente) values ('Jenny','Chalatenango','15654545132');
go


create table detalleVenta(
iDDetalleVenta int primary key identity(1,1),
idVenta int,
idProducto int,
cantidad int,
precio Decimal(12,5),
total Decimal
);
go


create table producto(
idProducto int primary key identity (1,1),
nombreProducto varchar(50),
precioProducto varchar (50),
estadoProducto varchar (50)
);
go


--El inner join 

select id, Email, tipo_rol
from tb_usuarios
inner join roles_usuarios
on tb_usuarios.Id = roles_usuarios.id_Rol_Usuario;



alter table detalleventa alter column precio decimal(18,5)
alter table detalleventa alter column total decimal(18,5)

alter table tb_venta alter column totalventa decimal(18,5)


