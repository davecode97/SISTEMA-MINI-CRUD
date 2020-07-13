/*
 * Proyecto NCAPAS MINICRUD SQL 
 * AUTOR DAVID LLANES
 * FECHA 04/04/2020
 * HERMOSILLO, SON
*/


CREATE DATABASE Practica_MiniCRUD
GO

USE Practica_MiniCRUD


CREATE TABLE Productos(
	Id INT IDENTITY (1, 1) PRIMARY KEY NOT NULL,
	Nombre VARCHAR (100) NOT NULL,
	Descripcion VARCHAR (100) NOT NULL,
	Marca VARCHAR (100) NOT NULL,
	Precio MONEY NOT NULL,
	STOCK INT NOT NULL
)


----  NULL TO NOT NULL
ALTER TABLE Productos ALTER COLUMN Id INT NOT NULL
ALTER TABLE Productos ALTER COLUMN Nombre VARCHAR(100) NOT NULL
ALTER TABLE Productos ALTER COLUMN Descripcion VARCHAR(100) NOT NULL
ALTER TABLE Productos ALTER COLUMN Marca VARCHAR(100) NOT NULL
ALTER TABLE Productos ALTER COLUMN Precio MONEY NOT NULL
ALTER TABLE Productos ALTER COLUMN STOCK INT NOT NULL


INSERT INTO Productos
VALUES
('Gaseosa'  , '3 Litros'                , 'marcacola'    , 7.5 , 24),
('Chocolate', 'Tableta 100 gramos'      , 'iberica'      , 12.5, 36),
('Leche'    , 'Deslactosada'            , 'supervacia'   , 3   , 48),
('Mazomorra', 'Bolsa 1kg'               , 'standar'      , 2.0 , 24),
('Harina'   , 'Bolsa 1kg'               , 'Purotrigo'    , 3.5 , 24),
('Nectar'   , '1 litro'                 , 'alljugos'     , 4.5 , 20),
('Aceite'   , '1 litro'                 , 'cocinero'     , 7.5 , 24)

SELECT * FROM Productos
-------------------------------------------------------------------------


CREATE TABLE ACCESO(
	ID INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	NOMBRE_ACCESO VARCHAR(100) UNIQUE NOT NULL,
	PASSWORD VARCHAR(100) NOT NULL
);


INSERT INTO ACCESO VALUES('ADMIN', '123');

-------------------------------------------------------------------------



			 ------------PRODIMIENTOS ALMACENADOS-----------     

CREATE PROC MostrarProductos
AS
SELECT * FROM Productos
GO

EXEC MostrarProductos


CREATE PROCEDURE InsertarProductos
	@Nombre varchar(100),
	@Descripcion varchar(100),
	@Marca varchar(100),
	@Precio float,
	@STOCK int
AS
INSERT INTO Productos VALUES (@Nombre, @Descripcion, @Marca, @Precio, @STOCK)
GO

EXEC InsertarProductos 'Prueba2', 'Prueba2', 'Desconocida', 32.32, 32


CREATE PROCEDURE EditarProductos
	@Nombre varchar(100),
	@Descripcion varchar(100),
	@Marca varchar(100),
	@Precio float,
	@STOCK int,
	@Id int 
AS
UPDATE Productos SET Nombre=@Nombre, Descripcion=@Descripcion, Marca=@Marca, Precio=@Precio, STOCK=@STOCK
WHERE Id=@Id
GO

EXEC EditarProductos 'Soda Stereo', 'Rockeron', 'Argentina', 1, 424,1
SELECT * FROM PRODUCTOS



CREATE PROCEDURE EliminarProducto
	@IdProd int
AS
DELETE FROM Productos WHERE Id=@IdProd
GO

EXEC EliminarProducto 12
SELECT * FROM Productos


CREATE PROCEDURE BusquedaProducto
	@Condicion varchar(100)
AS
SELECT * FROM Productos 
WHERE Id LIKE @Condicion + '%' or Nombre like @Condicion + '%'
GO

-- '%' BUSCARA CUALQUIER LETRA PARECIDA

----------------------------------------------------------------------
-- ACCESO --
-- PRIMERA MANERA
SELECT * FROM ACCESO WHERE NOMBRE_ACCESO = 'ADMIN' AND PASSWORD = '123';

DECLARE @nombre VARCHAR(100) = 'ADMIN'
DECLARE @pass VARCHAR(100) = '123';
SELECT * FROM ACCESO WHERE NOMBRE_ACCESO = @nombre AND PASSWORD =  @pass


-- SEGUNDA MANERA
CREATE PROCEDURE SP_ACCESO
	@NOMBRE VARCHAR(100) = 'ADMIN',
	@PASSWORD VARCHAR(100) = '123'
AS
SELECT * FROM ACCESO WHERE NOMBRE_ACCESO = @NOMBRE AND PASSWORD =  @PASSWORD
GO
