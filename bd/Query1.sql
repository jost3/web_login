
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

CREATE PROC SP_Registrar(
@Correo varchar(80),
@Clave varchar(80),
@Nombre varchar(80),
@apellido varchar(80),
@Registrado bit output,
@Mensaje varchar(100) output
)
as
begin

	if(not exists(select * from USUARIO where Correo = @Correo))
	begin
		insert into USUARIO (Correo,Clave,Nombre,apellido) values (@Correo,@Clave,@Nombre,@apellido)
		set  @Registrado = 1
		set  @Mensaje = 'usuario registrado'
	end
	else
	begin
		set @Registrado = 0
		set	@Mensaje = 'Correo ya existente'
	end
end