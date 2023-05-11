CREATE DATABASE TiendaCarBD;
GO
USE TiendaCarBD;
go
CREATE TABLE ProveedorServer(
	IDProveedor INT NOT NULL CONSTRAINT  pkProveedor PRIMARY KEY,
	Nombre varchar(50) not null, 
	Calle varchar(30) not null
)
GO
CREATE PROC insertarProveedor
@IdProveedor INT, 
@Nombre varchar(50),
@Calle varchar(30)
AS
INSERT INTO ProveedorServer(IDProveedor, Nombre, Calle)
VALUES (@IdProveedor, @Nombre, @Calle)
GO
insertarProveedor 5,'Manuel (SQLServer)', '5 de mayo' 

CREATE PROC mostrarProveedorServer
AS
SELECT TOP 200 * FROM ProveedorServer
ORDER BY IDProveedor ASC
go

CREATE PROC editarProveedorServer
@IdProveedor INT, 
@Nombre varchar(50),
@Calle varchar(30)
AS
UPDATE ProveedorServer SET 
Nombre = @Nombre,
Calle = @Calle
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
select * from openquery (Prueba, 'select * from proveedorMySQL')
GO

CREATE PROC eliminarProvedorMySQL --FALTA DE EJECUTAR
@IdProveedor int
AS
Delete openquery (Prueba, 'select * from proveedorMySQL')
WHERE IdProveedor = @IdProveedor --de la tabla de mysql
GO

exec eliminarProvedorMySQL 3
go
exec insertarProveedorMySQL 4,'Jonathan', 'Juan'
go

go
CREATE PROC insertarProveedorMySQL
@IDProveedor INT, 
@Nombre varchar(50),
@Calle varchar(30)
AS
INSERT INTO OPENQUERY(Prueba, 'select IDProveedor, Nombre, Calle FROM TiendaCarBD.proveedorMySQL;')
VALUES 
(@IDProveedor, @Nombre, @Calle);

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
CREATE PROC actualizarProveedorMySQL
@IdProveedor INT, 
@Nombre varchar(50),
@Calle varchar(30)
AS
UPDATE OPENQUERY(Prueba,'select IdProveedor,Nombre,Calle FROM TiendaCardBD.proveedorMySQL')  
SET 
Nombre = @Nombre,
Calle = @Calle
WHERE IdProveedor = @IdProveedor
go

exec actualizarProveedorMySQL 3,'Jonathan', 'Juan2'

--Fragmentacion Horizontal Deriva
CREATE PROC mostrarProveedores
as
select * from OPENQUERY(Prueba, 'select * from proveedorMySQL')
union all 
SELECT * FROM ProveedorServer
go 
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

select  d.IdProveedor, d.Nombre, j.Calle as proveedorMySQL
from Escuela2.dbo.Alumno2 as d, [192.168.16.147].Escuela3.dbo.Carrera as j
where d.IDAlumno=j.IdAlumno

union
--De Manuel de Jhon 
select  m.IdAlumno, m.Nombre,j.Nombre as Carrera
from [192.168.16.61].Escuela.dbo.Alumno as m, [192.168.16.147].Escuela3.dbo.Carrera as j
where m.IdAlumno =j.IdAlumno
