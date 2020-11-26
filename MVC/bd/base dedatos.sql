create database ProyectoRecetas
GO
use ProyectoRecetas
GO
go
/*URIEL*/
CREATE TABLE TblUsuarios
(
	IDUsuario INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(50),
	Apellido VARCHAR(50),
	Correo VARCHAR(50),
	Contraseña VARCHAR(12),
	Genero VARCHAR(12),
	Rol VARCHAR(20),
	CHECK (Rol IN ('Administrador', 'Usuario'))
);
GO
/*
INSERT INTO TblUsuarios(Nombre, Apellido, Correo, Contraseña, Genero, Rol)
VALUES (@Nombre, @Apellido, @Correo, @Contraseña, @Genero, @Rol)
*/

/*ELAIN*/
CREATE TABLE TblReceta
(
   ID_Recetas INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
   Receta varchar(50),
   Tiempo varchar(25),
   Ingredientes varchar(8000),
   Preparacion varchar(8000),    
);

/*
INSERT INTO TblReceta(Receta, Tiempo, Ingredientes, Preparacion)
VALUES (@Receta, @Tiempo, @Ingredientes, @Preparación)
*/

