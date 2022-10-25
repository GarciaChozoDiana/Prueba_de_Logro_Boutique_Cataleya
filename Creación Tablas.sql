
Create Database BDCataleya
create table Marca
(
id_marca int identity (1,1) primary key not null,
nom_marca varchar(20),
)
create table Departamento
(
id_depa int identity (1,1)primary key not null,
nom_depart varchar (50)
)
create table Proveedor
(
id_proveedor int identity (1,1) primary key not null,
nom_proveedor varchar (30),
)
create table Cliente
(
id_cliente int identity (1,1) primary key not null,
nom_cliente varchar (50),
dom_cliente varchar (60),
telefono int
)
CREATE table Prenda
(
id_prenda int identity,
tipo_prenda nvarchar(50),
talla_prenda nvarchar(50)

)

create table Ventas
(
id_venta int identity not null,
id_prenda int,
id_cliente int,
vendido int,
fecha datetime
)

create table Productos
(
id_producto int identity (1,1) primary key not null,
id_marca int,
id_prenda int,
id_proveedor int,
nom_producto varchar(50),
precio_producto int
)