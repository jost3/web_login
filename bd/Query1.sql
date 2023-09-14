
--CREACION DE NUESTRA BD--

create database DB_ACCESO

use DB_ACCESO

create table USUARIO(
IdUser INT PRIMARY KEY identity(1,1),
Correo varchar(80),
Clave varchar(80),
Nombre varchar(80),
apellido varchar(80)
)