create database PersonasDB
go

use PersonasDB
go

create table Usuarios
(
  IdUsuario int primary key identity,
  Nombre varchar(30),
  Email varchar(25),
  NivelUsuario varchar(20),
  Usuario varchar(20),
  Clave varchar(15),
  FechaIngreso date,
  CargoID int,
  DescripcionCargo varchar(100)
)

create table Cargo
(
  CargoId int primary key,
  DescripcionCargo varchar(50)
)






