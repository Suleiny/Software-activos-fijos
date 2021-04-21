CREATE DATABASE Afijos

USE  Afijos

CREATE TABLE LOGI (
[ID_LOGUEO] INT  IDENTITY (1,1) PRIMARY KEY ,
[NOMBRE] VARCHAR (50),
[CORREO] VARCHAR (50),
[PASSWORD] VARCHAR (50)
)

INSERT INTO LOGI VALUES( 'ANA','ANA@GMAIL.COM','NHKKA');
USE Afijos
SELECT* FROM LOGI



CREATE TABLE [Usuarios](
	[id_usuario] [int] IDENTITY (1,1) PRIMARY KEY,
	[nombre_usuario] [nvarchar](50) ,
	[apellido_usuario] [nvarchar](50) ,
	[fecha_nacimiento] [date] ,
	[sexo] [nchar](10) NOT NULL,
	[cedula_usuario] [nvarchar](50) UNIQUE  NOT NULL,
	[email_usuario] [nvarchar](50) ,
	[academico_usuario] [nvarchar](50),
	[direccion_usuario] [nvarchar](50) ,
	[telefono1_usuario] [nvarchar](15) ,
	[telefono2_usuario] [nchar](10) ,
	[ocupacion_usuario] [nchar](10) NOT NULL, )

	SELECT* FROM Usuarios



	CREATE TABLE [Empleados](
	[id_empleado] [int] IDENTITY (1,1) PRIMARY KEY ,
	[nombre] [nvarchar](50) ,
	[apellido] [nvarchar](50) ,
	[fecha_nacimiento] [date] ,
	[fecha_ingreso] [date] ,
	[cedula] [nvarchar](50) ,
	[direccion] [nvarchar](50) ,
	[email] [nvarchar](50) ,
	[telefono1] [nvarchar](50) ,
	[telefono2] [nvarchar](50) ,
	[ocupacion] [nchar](20) ,
	[sueldo] [int] ,
	Estado_empleado[nvarchar](50) 
	)

	SELECT*FROM Empleados


	CREATE TABLE [dbo].[activos](
	[id_activo] [int] IDENTITY (1,1) PRIMARY KEY ,
	[codigo_activo] [nchar](10) ,
	[metros_activo] [nchar](15),
	[tipos_activo] [nchar](15) ,
	[catastro_activo] [nvarchar](50) ,
	[propietario_activo] [nvarchar](50) ,
	[fecha_ingreso] [date] ,
	[ValorInicial_activo] [nchar](10) ,
	[ValorFinal_activo] [nchar](10),
	[marcaV_activo] [nvarchar](50),
	[AñoIngreso_activo] [nchar](10),
	[modelo_activo] [nvarchar](50),
	[cantidad_activo] [nvarchar](50),
	[TitPr_activo_activo] [nvarchar](50) ,
	)

	SELECT* FROM activos



