CREATE DATABASE BDFragmentaciones;
GO
USE BDFragmentaciones;
go
CREATE TABLE ProveedorServer(
	IDProveedor INT NOT NULL CONSTRAINT  pkProveedor PRIMARY KEY,
	Nombre varchar(50) not null, 
	Precio varchar(50), 
	IDCategoria varchar(100),
	IDZona varchar(100)
)
GO
CREATE PROC insertarProveedor
@IdProveedor INT, 
@Nombre varchar(50),
@Precio varchar(30),
@IDCategoria varchar(100),
@IDZona varchar(100)
AS
INSERT INTO ProveedorServer(IDProveedor, Nombre, Precio, IDCategoria, IDZona)
VALUES (@IdProveedor, @Nombre, @Precio, @IDCategoria, @IDZona)
GO
insertarProveedor 2,'Manuel (SQLServer)', '5 de mayo',1,1 

CREATE PROC mostrarProveedorServer
AS
SELECT TOP 200 * FROM ProveedorServer
ORDER BY IDProveedor ASC
go

CREATE PROC editarProveedorServer
@IdProveedor INT, 
@Nombre varchar(50),
@Precio varchar(30),
@IDCategoria varchar(100),
@IDZona varchar(100)
AS
UPDATE ProveedorServer SET 
Nombre = @Nombre,
Precio = @Precio,
IDCategoria = @IDCategoria,
IDZona = @IDZona
WHERE IdProveedor = @IdProveedor
go


CREATE PROC eliminarProveedorServer
@IdProveedor int
AS
DELETE FROM ProveedorServer
WHERE IDProveedor = @IdProveedor
go


--MYSQL Procedimientos


CREATE PROC mostrarProvedorMySQL
AS
select * from openquery (MySqlVinculado, 'select * from Productos')
GO

CREATE PROC eliminarProvedorMySQL --FALTA DE EJECUTAR
@IdProveedor int
AS
Delete openquery (MySqlVinculado, 'select * from Productos')
WHERE IdProveedor = @IdProveedor --de la tabla de mysql
GO

exec eliminarProvedorMySQL 3
go
exec insertarProveedorMySQL 4,'Jonathan', 'Juan'
go

go
CREATE PROC insertarProveedorMySQL
@IDProducto INT, 
@Nombre varchar(50),
@Precio varchar(30),
@IDCategoria varchar(100),
@IDZona varchar(100)
AS
INSERT INTO OPENQUERY(MySqlVinculado, 'select IDProducto, Nombre, Precio, IDCategoria, IDZona FROM BDFragmentaciones.Productos;')
VALUES 
(@IDProducto, @Nombre, @Precio, @IDCategoria, @IDZona);
--select * from openquery (MySqlVinculado, 'select * from Productos')
/* PRUEBA
go
CREATE PROC insertarProveedorMySQL2
@IDCategoria INT, 
@N_Catego varchar(50)
AS
INSERT INTO OPENQUERY(MYSQLVINCULADO, 'select ID, N_Catego FROM BDFragmentaciones.Categoria;')
VALUES 
(@IDCategoria, @N_Catego);
*/
GO
CREATE PROC actualizarProveedorMySQL2
@IdProveedor INT, 
@Nombre varchar(50),
@Precio varchar(30),
@IDCategoria varchar(100),
@IDZona varchar(100)
AS
UPDATE OPENQUERY(MySqlVinculado,'select IdProveedor,Nombre,Precio,IDCategoria, IDZona FROM BDFragmentaciones.Productos')  
SET 
Nombre = @Nombre,
Precio = @Precio,
IDCategoria = @IDCategoria,
IDZona = @IDZona
WHERE IdProveedor = @IdProveedor
go

exec actualizarProveedorMySQL 3,'Jonathan', 'Juan2'


--Fragmentacion Horizontal Deriva
create PROC mostrarProveedores
as
select * from OPENQUERY(MySqlVinculado, 'select * from Productos')
union all 
SELECT * FROM ProveedorServer
go 




--Fragmentacion Horizontal
	create PROC mostrarProveedoresHorizontal
	@IDZona varchar(10)
	as
	SELECT *
	FROM OPENQUERY(MySqlVinculado, '
	 SELECT Nombre, Precio, IDCategoria, IDZona
	 FROM Productos
	 INNER JOIN Categoria
	 ON Productos.IDCategoria = Categoria.ID_C
	 INNER JOIN Zona
	 ON Productos.IDZona = Zona.ID_Z where IDZona = 1')




	 SELECT *
	FROM OPENQUERY(MySqlVinculado, '
	 SELECT *
	 FROM Categoria')


--Fragmentacion Vertical
/**/

/*Esta se ocupo*/

CREATE alter PROCEDURE mostrarProveedoresVertical2
@IDZona nvarchar(50)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL nvarchar(2000)
    SET @SQL = 'SELECT * FROM OPENQUERY(MySqlVinculado, ''SELECT Nombre, Precio FROM Productos WHERE IDZona = ''''' + @IDZona + ''''''')'
    EXEC sp_executesql @SQL
END

/*Horizontal 2 - E*/
CREATE alter PROCEDURE mostrarProveedoresHorizontal2
@IDZona varchar(10)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL nvarchar(300)
    SET @SQL = 'SELECT * FROM OPENQUERY(MySqlVinculado, ''SELECT Nombre, Precio, N_Catego, Nombre_Zona
	 FROM Productos
	 INNER JOIN Categoria
	 ON Productos.IDCategoria = Categoria.ID_C
	 INNER JOIN Zona
	 ON Productos.IDZona = Zona.ID_Z where IDZona = ''''' + @IDZona + ''''''')'
    EXEC sp_executesql @SQL
END


	 SELECT *
	FROM OPENQUERY(MySqlVinculado, '
	 SELECT *
	 FROM Productos')
/**


Pruebas:
select * from openquery (MySqlVinculado, 'select * from Categoria')

INSERT INTO OPENQUERY(MYSQLVINCULADO, 'select ID, N_Catego FROM BDFragmentaciones.Categoria;')
VALUES 
(3, 'Pastas')


DELETE OPENQUERY(MYSQLVINCULADO, 'select * from Zona')


DELETE OPENQUERY(MySqlVinculado, '* FROM BDFragmentaciones.Zona WHERE ID = 2')


UPDATE OPENQUERY(MYSQLVINCULADO, 'select ID, N_Catego FROM Categoria;')
VALUES 
(3, 'Pastas')


SELECT * FROM [MYSQLINCULADO].[BDFragmentaciones]..[Zona];
*/

--select  d.IdProveedor, d.Nombre, j.Calle as proveedorMySQL
--from Escuela2.dbo.Alumno2 as d, [192.168.16.147].Escuela3.dbo.Carrera as j
--where d.IDAlumno=j.IdAlumno

--union
----De Manuel de Jhon 
--select  m.IdAlumno, m.Nombre,j.Nombre as Carrera
--from [192.168.16.61].Escuela.dbo.Alumno as m, [192.168.16.147].Escuela3.dbo.Carrera as j
--where m.IdAlumno =j.IdAlumno


update ProveedorServer set Nombre = 'Corona Especial (SQL Server)' where IDProveedor= 2;




select Nombre, Precio, IDCategoria, IDZon from Productos INNER JOIN Categoria 
ON Productos.IDCategoria = Categoria.ID
INNER JOIN ZONA ON Productos.IDZona = Zona.ID where IDZona = 2;

select * from OPENQUERY(MySqlVinculado, 'select Nombre, Precio, IDCategoria, IDZona from Productos')
inner join select * from OPENQUERY(MySqlVinculado, 'select Nombre, Precio, IDCategoria, IDZona from Productos')
SELECT * FROM ProveedorServer
go 

SELECT *
FROM OPENQUERY(MySqlVinculado, '
 SELECT Nombre, Precio, IDCategoria, IDZona
 FROM Productos
 INNER JOIN Categoria
 ON Productos.IDCategoria = Categoria.ID_C
 INNER JOIN Zona
 ON Productos.IDZona = Zona.ID_Z where IDZona = 1')


 select * from OPENQUERY(MySqlVinculado, 'select * from Zona')
  select * from OPENQUERY(MySqlVinculado, 'select * from Categoria')


  SELECT * FROM ProveedorServer

