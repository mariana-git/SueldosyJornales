create database SistemaSueldos
go

use SistemaSueldos

create table Puestos 
(
Id int identity (1,1) primary key,
Puesto nvarchar (100),
HsSemanales int,
DiasSemana nvarchar (50)
)
insert into Puestos 
values
('Empleado',40,'LU MIE VIE'),
('Franquero',16,'LU A VIE'),
('Coordinador',40,'LU A VIE'),
('Gerente',40,'LU A VIE')

create table Personal 
(
Id int identity (1,1) primary key,
Nombre nvarchar (100),
Apellido nvarchar (100),
CUIL bigint,
FechaIngreso date,
PuestosId int,
CONSTRAINT FK_Puesto FOREIGN KEY (PuestosId) REFERENCES Puestos(Id),
Activo bit DEFAULT 1
)


insert into Personal 
values
('Tito','Puente',20111111110,'10/01/2020',1,1),
('Maria','Menegel',27111111110,'10/01/2022',2,1),
('Juan Salvador','Bilardo',25111111119,'10/01/2021',3,1),
('Diego','Maradona',24111111110,'10/06/2022',4,1)


---PROCEDIMIENTOS ALMACENADOS 
--------------------------MOSTRAR 
create proc MostrarPersonal
as
select *from Personal
go

create proc MostrarLiquidaciones
as
select *from Personal
go

create proc BuscarPersonal
@apellido nvarchar (100),
@cuil bigint
as
select *from Personal where Apellido=@apellido or CUIL=@cuil
go

exec BuscarPersonal Maradona,00000000000

create proc MostrarPuestos
as
select *from Puestos
go

create proc BuscarPuesto
@puesto nvarchar (100),
@hs int
as
select *from Puestos where Puesto like '%'+ @puesto +'%' or HsSemanales=@hs
go

exec BuscarPuesto '',40
--------------------------INSERTAR 
create proc InsetarPersonal
@nombre nvarchar (100),
@apellido nvarchar (100),
@cuil bigint,
@ingreso date,
@puesto int,
@activo bit
as
insert into Personal values (@nombre,@apellido,@cuil,@ingreso,@puesto,@activo)
go

create proc InsertarLiquidaciones
@anio smallint,
@aportes decimal(10,2),
@os decimal(10,2),
@extras decimal(10,2),
@anticipos decimal(10,2),
@idPersonal int,
@idPeriodo int
as
insert into Personal values (@anio,@aportes,@os,@extras,@anticipos,@idPersonal,@idPeriodo)
go

create proc InsertarPuestos
@puesto nvarchar (100),
@hsSemanales int,
@diasSemana nvarchar (100)
as
insert into Puestos values (@puesto,@hsSemanales,@diasSemana)
go

------------------------ELIMINAR
create proc EliminarPersonal
@idpersonal int
as
delete from Personal where Id=@idpersonal
go

create proc EliminarPuestos
@idpuesto int
as
delete from Puestos where Id=@idpuesto
go

------------------EDITAR

create proc EditarPersonal
@nombre nvarchar (100),
@apellido nvarchar (100),
@cuil bigint,
@ingreso date,
@puesto int,
@activo bit,
@id int
as
update Personal set Nombre=@nombre, Apellido=@apellido, CUIL=@cuil, FechaIngreso=@ingreso, PuestosId=@puesto, Activo=@activo where Id=@id
go

create proc EditarPuestos
@puesto nvarchar (100),
@hsSemanales int,
@diasSemana nvarchar (100),
@id int
as
update Puestos set Puesto=@puesto, HsSemanales=@hsSemanales, DiasSemana=@diasSemana where Id=@id
go

