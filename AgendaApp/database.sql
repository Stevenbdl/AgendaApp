--Ejecuta este archivo en Microsoft SQL Server Managment o via el medio que quieras

/*Para hacer la conexion con la base de datos ve al archivo BD.cs y en el string de conexion cambia
  el servidor, tambien el usuario y la contrasena por tus datos de SQL Server
*/

CREATE DATABASE AGENDA;

USE AGENDA;

CREATE TABLE CONTACTOS 
(
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(20) NOT NULL,
	Numero VARCHAR(13) NOT NULL
)

--Luego de ejecutar este archivo puedes ejecutar la aplicacion.
