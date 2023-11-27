create database Healthy_App
use Healthy_App
---TABLAS---
CREATE TABLE login_app
(
	ID_Usuario varchar (20) primary key,
	ID_Password int
)
CREATE TABLE create_account 
(
	ID_CrearUsuario varchar (20) primary key,
	ID_CrearPassword int
)
CREATE TABLE salud (
    peso varchar (10),
    fecha date,
    ID_Usuario varchar (20),
    FOREIGN KEY (ID_Usuario) REFERENCES login_app (ID_Usuario)
);
go
---REGISTRAR NUEVO USUARIO---
CREATE PROCEDURE spRegistrarUsuario
	@ID_CrearUsuario varchar(20),
	@ID_CrearPassword int
AS
BEGIN
	IF EXISTS (SELECT * FROM create_account WHERE ID_CrearUsuario = @ID_CrearUsuario)
BEGIN
RETURN;
END
	INSERT INTO create_account (ID_CrearUsuario, ID_CrearPassword)
	VALUES (@ID_CrearUsuario, @ID_CrearPassword);
END
---INGRESAR DATOS A TABLA SALUD POR USUARIO---
go
CREATE PROCEDURE sp_InsertarSalud
    @peso varchar(10),
    @fecha date,
    @ID_Usuario varchar(20)
AS
BEGIN
    INSERT INTO salud (peso, fecha, ID_Usuario)
    VALUES (@peso, @fecha, @ID_Usuario);
END
---VISTA DE DATOS INGRESADOS POR USUARIO---
go
CREATE PROCEDURE sp_DataSalud (@ID_Usuario varchar (20))
AS 
BEGIN
	SELECT*FROM salud 
	WHERE ID_Usuario = @ID_Usuario
	ORDER BY fecha DESC
END
---BORRAR DATOS DE USUARIO EN ESPECIFICO---
go
CREATE PROCEDURE BorrarDatosUsuario
	@ID_Usuario VARCHAR(20)
AS 
BEGIN
	DELETE FROM salud 
	WHERE ID_Usuario = @ID_Usuario;
END