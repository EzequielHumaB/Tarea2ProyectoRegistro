create database PersonasDB
go

use PersonasDB
go

create table Personas
(
  Id int primary key identity,
  nombre varchar(30),
  Telefono varchar (12),
  Cedula varchar(13),
  Direccion varchar(max)
)

