Create Database IEFI
USE IEFI
CREATE TABLe Provincias(

Id INT IDENTITY(1,1) NOT NULL,
Descripcion NVARCHAR(50) NOT NULL);


CREATE TABLe Clientes(
Id INT IDENTITY(1,1) NOT NULL,
	Descripcion NVARCHAR(10) NOT NULL,
	IdProvincia int not null,)
	
	
	