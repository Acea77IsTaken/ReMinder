create database ProyectoReMinder;
use ProyectoReMinder;

--crear las distintas tablas

create table Usuarios(
id int not null identity(1,1) primary key,
Nombre varchar(50) not null,
ApellidoP varchar(50) not null,
ApellidoM varchar(50) not null,
Usuario nvarchar(50) not null,
Clave nvarchar(50) not null,
Salario money not null,
Telefono bigint,
FechaContrato varchar(50) not null,
);

SELECT * FROM Usuarios WHERE Usuario = 'JORY13G' and Clave = 'T3OD!O13G'

alter table Usuarios add constraint UC_Credenciales Unique (Clave,Usuario);

insert into Usuarios (Nombre,ApellidoP,ApellidoM,Usuario,Clave,Salario,Telefono,FechaContrato) values (
'Rodrigo','Eguez','Gareca','JORY13G','T3OD!O13G',23.00,78554895,'02/09/1999'),
('Kathleen','Barrientos','Rodriguez','kat','8912823',4200.01,71439684,'01/10/1999');



drop table Usuarios;

create table Jefes(
id int not null identity(1,1) primary key,
Nombre varchar(50) not null,
ApellidoP varchar(50) not null,
ApellidoM varchar(50) not null, 
FechaContrato varchar(50) not null,
Correo varchar(50) not null,
Telefono bigint not null,
Usuario varchar (50) not null,
Clave varchar (50) not null,
constraint UC_CredencialesJefes Unique (Usuario, Clave)
);

SELECT * FROM Usuarios WHERE Nombre = '@nombre' AND ApellidoP = '@apellido'
insert into Jefes (Nombre,ApellidoP,ApellidoM,FechaContrato,Correo,Telefono,Usuario,Clave) Values('Santiago','Camacho','Echalar','ayer','Correo@gmail.com',78951264,'ElJefaso','ClaveSegura');

select * from Jefes;

create table anuncios(
id int not null identity (1,1) primary key,
Titulo varchar(50) not null,
cuerpo varchar(50) not null,
);

ALTER TABLE anuncios add IdJefeCreador int foreign key references Jefes(id);

select * from anuncios where id = 1

create table Tareas(
Id int not null identity (1,1) primary key,
Titulo varchar(50) not null,
Cuerpo varchar(50) not null,
FechaAsignacion varchar(50) not null,
HoraAsignacion varchar(50) not null,
FechaFinalizacion varchar(50),
HoraFinalizacion varchar(50),
);

update Tareas set JefeAsignadorTarea = 1 where Id = 2
INSERT INTO Tareas (Titulo, Cuerpo, FechaAsignacion, HoraAsignacion, JefeAsignadorTarea, TrabajadorAsignadoTarea, Finalizada) VALUES ('caaaaaal','prudsdsdbasql','hoy','ahora',1,1,'No Completada');
insert into Tareas (Titulo,Cuerpo,FechaAsignacion,HoraAsignacion,Finalizada) Values('Franco grande','y tambien los otros','hoy','ahora','No Completada');


truncate table Tareas
select * from Tareas
select * from usuarios
Select Nombre, ApellidoP, ApellidoM, Telefono from usuarios

drop table Tareas;

ALTER TABLE Tareas add Finalizada varchar (50) not null;
ALTER TABLE Tareas add JefeAsignadorTarea int foreign key references Jefes(id);
ALTER TABLE Tareas add TrabajadorAsignadoTarea int foreign key references Usuarios(id);

create table TareasCompletadas(
Id int not null identity (1,1) primary key,
Titulo varchar(50) not null,
Cuerpo varchar(50) not null,
FechaAsignacion varchar(50) not null,
HoraAsignacion varchar(50) not null,
FechaDeEntrega varchar(50) not null,
HoraDeEntrega varchar(50) not null,
TrabajadorAsignado int foreign key references Usuarios(id),
JefeAsignador int foreign key references Jefes(id)
);

ALTER TABLE Tareas add JefeAsignadorTC int foreign key references Jefes(id);
ALTER TABLE Tareas add TrabajadorAsignadoTC int foreign key references Usuarios(id);

drop table TareasCompletadas;

truncate table Jefes;

select * from anuncios;
truncate table anuncios;

drop database ProyectoReMinder;
