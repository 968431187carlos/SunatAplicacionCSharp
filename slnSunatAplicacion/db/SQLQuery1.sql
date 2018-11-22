create database BD_Sunat1
go
USE [BD_Sunat1]
GO

/****** Object:  Table [dbo].[Empresa]    Script Date: 12/11/2018 12:44:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Empresa](
	[IdEmpresa] [varchar](10) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Llave] [varchar](20) NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

GO
/****** Object:  StoredProcedure [dbo].[ObtenerEmpresa]    Script Date: 12/11/2018 12:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[ObtenerEmpresa]
@idEmpresa varchar(10),@key varchar(20)
as
begin
	Select IdEmpresa,Nombre,Llave,Estado from Empresa
	where IdEmpresa=@idEmpresa And Llave=@key;
END


GO

/****** Object:  StoredProcedure [dbo].[ObtenerEmpresaTodas]    Script Date: 12/11/2018 12:45:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[ObtenerEmpresaTodas]
as
begin
	Select IdEmpresa,Nombre,Llave,Estado from Empresa;
END
GO
 insert into empresa values ('e001', 'idat', '0001', 1)
 insert into empresa values ('e002', 'utp', '0002', 2)
 insert into empresa values ('e003', 'senati', '0003', 3)
 go

 exec ObtenerEmpresa 'e001','0001'

 Create table Usuario(
IdUsuario int primary key identity,
Nombre varchar(50),
Apellido varchar(50),
Username varchar(15),
DNI char(8),
Pass varchar(10),
Estado int
)
go

 insert into Usuario values('Carli','Papucho','prosor','70384767','123456',1)
 insert into Usuario values('Pepe','Ampuero','eldestrozador','70000000','123456',1)
 insert into Usuario values('Olivia','perez','Tongo','42000000','123456',1)
 go
 
 


create Procedure [dbo].[ValidarUsuario]
@Username varchar(15),@Pass varchar(10)
as
begin
	select count(*) as Cantidad from Usuario
	where Username=@Username and Pass=@Pass;
END
GO




create Procedure [dbo].[Login]
@Username varchar(15),@Pass varchar(10)
as
begin
	select count(*) as Cantidad from Usuario
	where Username=@Username and Pass=@Pass;

END
GO



exec ValidarUsuario 'prosor','123456'
go

select*from Usuario

Create procedure AgregarEmpresa
@IdEmpresa Varchar(10) , @Nombre varchar(50),
@Llave Varchar(20), @Estado int
as
begin
Insert Into Empresa (IdEmpresa,Nombre,Llave,Estado)
Values(@IdEmpresa,@Nombre,@Llave,@Estado);
end 
go

Create procedure ModificarEmpresa
@Idempresa varchar(10), @Nombre varchar(50),@Llave Varchar(20), @Estado int
AS
Begin
-- Update rows in table 'TableName'
UPDATE Empresa
SET
	Nombre = @Nombre,
	Llave = @Llave,
	Estado = @Estado
	-- add more columns and values here
WHERE 	IdEmpresa = @IdEmpresa
end
go

Select* from Empresa
go

Create procedure BorrarEmpresa
@Idempresa varchar(10)
As
Begin
-- Delete rows from table 'TableName'
DELETE FROM Empresa
WHERE 	IdEmpresa = @IdEmpresa/* add search conditions here */
END
GO

--exec AgregarEmpresa 'e004','Selene','0004',3

--exec BorrarEmpresa 'e004'

--select * FROM empresa


