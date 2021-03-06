USE [master]
GO
/****** Object:  Database [uniON]    Script Date: 2/6/2020 16:59:04 ******/
CREATE DATABASE [uniON]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'uniON', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\uniON.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'uniON_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\uniON_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [uniON] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [uniON].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [uniON] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [uniON] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [uniON] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [uniON] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [uniON] SET ARITHABORT OFF 
GO
ALTER DATABASE [uniON] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [uniON] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [uniON] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [uniON] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [uniON] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [uniON] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [uniON] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [uniON] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [uniON] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [uniON] SET  DISABLE_BROKER 
GO
ALTER DATABASE [uniON] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [uniON] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [uniON] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [uniON] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [uniON] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [uniON] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [uniON] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [uniON] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [uniON] SET  MULTI_USER 
GO
ALTER DATABASE [uniON] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [uniON] SET DB_CHAINING OFF 
GO
ALTER DATABASE [uniON] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [uniON] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [uniON] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [uniON] SET QUERY_STORE = OFF
GO
USE [uniON]
GO
/****** Object:  Table [dbo].[Ciudades]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudades](
	[IdCiudad] [int] IDENTITY(1,1) NOT NULL,
	[IdProvincia] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Ciudades] PRIMARY KEY CLUSTERED 
(
	[IdCiudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresas]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresas](
	[IdEmpresa] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Foto] [image] NULL,
	[IdCiudad] [int] NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eventos]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventos](
	[IdEvento] [int] IDENTITY(1,1) NOT NULL,
	[IdTipoEvento] [int] NULL,
	[IdCiudad] [int] NULL,
	[IdPersona] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](max) NULL,
	[Puntaje] [int] NULL,
	[Fecha] [date] NULL,
	[Activo] [bit] NULL,
	[Foto] [varchar](50) NULL,
 CONSTRAINT [PK_Eventos] PRIMARY KEY CLUSTERED 
(
	[IdEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventosTipos]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventosTipos](
	[IdTipoEvento] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_EventosTipos] PRIMARY KEY CLUSTERED 
(
	[IdTipoEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paises](
	[IdPais] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Paises] PRIMARY KEY CLUSTERED 
(
	[IdPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[IdPersona] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[IdCiudad] [int] NULL,
	[Foto] [image] NULL,
	[PuntosAcumulados] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[IdPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Premios]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Premios](
	[IdPremio] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpresa] [int] NULL,
	[IdTipoPremio] [int] NULL,
	[Titulo] [varchar](max) NULL,
	[Descripcion] [varchar](max) NULL,
	[Cantidad] [int] NULL,
	[CostoPuntos] [int] NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Premios] PRIMARY KEY CLUSTERED 
(
	[IdPremio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PremiosTipos]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PremiosTipos](
	[IdTipoPremio] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](max) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_PremiosTipos] PRIMARY KEY CLUSTERED 
(
	[IdTipoPremio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[IdProvincia] [int] IDENTITY(1,1) NOT NULL,
	[IdPais] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED 
(
	[IdProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[IdTipoUsuario] [int] NULL,
 CONSTRAINT [PK_Logins] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosTipos]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosTipos](
	[IdTipoUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_UsuariosTipos] PRIMARY KEY CLUSTERED 
(
	[IdTipoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[CiudadesAgregar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure [dbo].[CiudadesEliminar]
--@IdCiudad as int
--as
--delete Ciudades
--where IdCiudad=@IdCiudad

create procedure [dbo].[CiudadesAgregar]
 @Nombre varchar(50),
 @IdProvincia int,
 @Activo bit
 as
 insert
 into Ciudades 
 values (@Nombre,@IdProvincia,@Activo)
GO
/****** Object:  StoredProcedure [dbo].[CiudadesBuscarPorId]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure [dbo].[CiudadesEliminar]
--@IdCiudad as int
--as
--delete Ciudades
--where IdCiudad=@IdCiudad

--create procedure [dbo].[CiudadesAgregar]
-- @Nombre varchar(50),
-- @IdProvincia int,
-- @Activo bit
-- as
-- insert
-- into Ciudades 
-- values (@Nombre,@IdProvincia,@Activo)

create procedure [dbo].[CiudadesBuscarPorId]
 @IdCiudad int
 as
 select Paises.IdPais, Ciudades .IdProvincia, IdCiudad, Ciudades.Nombre, Ciudades.Activo
 from Ciudades join Provincias on Ciudades .IdProvincia = Provincias .IdProvincia 
 join Paises on Paises .IdPais = Provincias .IdPais 
GO
/****** Object:  StoredProcedure [dbo].[CiudadesBuscarPorIdProvincia]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CiudadesBuscarPorIdProvincia]
@IdProvincia int
as
select * 
from Ciudades
where IdProvincia = @IdProvincia
GO
/****** Object:  StoredProcedure [dbo].[CiudadesBuscarTodos]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CiudadesBuscarTodos]

 as
 select *
 from Ciudades 
GO
/****** Object:  StoredProcedure [dbo].[CiudadesEliminar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CiudadesEliminar]
@IdCiudad as int
as
delete Ciudades
where IdCiudad=@IdCiudad
GO
/****** Object:  StoredProcedure [dbo].[CiudadesModificar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure [dbo].[CiudadesEliminar]
--@IdCiudad as int
--as
--delete Ciudades
--where IdCiudad=@IdCiudad

--create procedure [dbo].[CiudadesAgregar]
-- @Nombre varchar(50),
-- @IdProvincia int,
-- @Activo bit
-- as
-- insert
-- into Ciudades 
-- values (@Nombre,@IdProvincia,@Activo)

--create procedure [dbo].[CiudadesBuscarPorId]
-- @IdCiudad int
-- as
-- select Paises.IdPais, Ciudades .IdProvincia, IdCiudad, Ciudades.Nombre, Ciudades.Activo
-- from Ciudades join Provincias on Ciudades .IdProvincia = Provincias .IdProvincia 
-- join Paises on Paises .IdPais = Provincias .IdPais 

create procedure [dbo].[CiudadesModificar]
 @IdCiudad int,
 @IdProvincia int,
 @Nombre varchar(50),
 @Activo bit
 as
 update Ciudades 
 set IdProvincia = @IdProvincia , Nombre = @Nombre, Activo = @Activo
 where IdCiudad = @IdCiudad 
GO
/****** Object:  StoredProcedure [dbo].[EmpresaCargarDatos]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EmpresaCargarDatos]
@IdEmpresa int,
@Nombre varchar(50),
@IdCiudad int
as
update Empresas
set Nombre=@Nombre, IdCiudad=@IdCiudad
where IdEmpresa=@IdEmpresa
GO
/****** Object:  StoredProcedure [dbo].[EmpresaModificar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EmpresaModificar]
@IdEmpresa int,
@Nombre varchar(50),
@IdCiudad int
as
update Empresas 
set Nombre = @Nombre,
IdCiudad = @IdCiudad

where IdEmpresa = @IdEmpresa 

GO
/****** Object:  StoredProcedure [dbo].[EmpresasAgregar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure [dbo].[UsuariosAgregar]
--@Email varchar(50),
--@Password varchar(50),
--@IdTipo int
--as
--insert into Usuarios 
--values(@Email,@Password,@IdTipo )
--select @@IDENTITY 

CREATE procedure [dbo].[EmpresasAgregar]
@IdUsuario int
as
insert into Empresas
values (@IdUsuario,'','','')
select @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[EmpresasBuscarPorId]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[EmpresasBuscarPorId]
@IdEmpresa int
as
select *
from Empresas
where IdEmpresa = @IdEmpresa
GO
/****** Object:  StoredProcedure [dbo].[EstadosAgregar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EstadosAgregar]
@IdCategoria int,
@Descripcion varchar(50),
@Activo bit
as
insert into Provincias  
values (@IdCategoria, @Descripcion, @Activo)
GO
/****** Object:  StoredProcedure [dbo].[EstadosBuscarPorId]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EstadosBuscarPorId]
@IdEstado int
as
select *
from Estados
where IdEstado = @IdEstado
GO
/****** Object:  StoredProcedure [dbo].[EstadosBuscarPorIdCategorias]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EstadosBuscarPorIdCategorias]
@IdCategoria int
as
select C.IdCategoria, e.IdEstado, e.Descripcion, e.Activo
from Estados E join EstadosCategorias C on E.IdCategoria = C.IdCategoria
where e.IdCategoria = @IdCategoria
GO
/****** Object:  StoredProcedure [dbo].[EstadosBuscarTodos]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EstadosBuscarTodos]
as
select *
from Estados 
GO
/****** Object:  StoredProcedure [dbo].[EstadosCategoriasAgregar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EstadosCategoriasAgregar]
@Descripcion varchar(50),
@Activo bit
as
insert into EstadosCategorias
values (@Descripcion,@Activo)
GO
/****** Object:  StoredProcedure [dbo].[EstadosCategoriasBuscarPorId]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EstadosCategoriasBuscarPorId]
@IdEstadoCategoria int
as
select *
from EstadosCategorias
where IdCategoria=@IdEstadoCategoria
GO
/****** Object:  StoredProcedure [dbo].[EstadosCategoriasBuscarTodos]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EstadosCategoriasBuscarTodos]

as
select *
from EstadosCategorias
GO
/****** Object:  StoredProcedure [dbo].[EstadosCategoriasEliminar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EstadosCategoriasEliminar]
@IdEstadoCategoria int
as
delete EstadosCategorias
where IdCategoria= @IdEstadoCategoria
GO
/****** Object:  StoredProcedure [dbo].[EstadosCategoriasModificar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EstadosCategoriasModificar]
@IdEstadoCategoria int,
@Descripcion varchar(50),
@Activo bit
as
update EstadosCategorias
set Descripcion=@Descripcion, Activo=@Activo
where IdCategoria=@IdEstadoCategoria
GO
/****** Object:  StoredProcedure [dbo].[EstadosModificar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EstadosModificar]
@IdEstado int,
@IdCategoria int,
@Descripcion varchar (50),
@Activo bit
as
update Estados
set IdCategoria= @IdCategoria, Descripcion = @Descripcion, Activo = @Activo
where IdEstado = @IdEstado
GO
/****** Object:  StoredProcedure [dbo].[EventosAgregar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure [dbo].[PremiosModificar]
--@IdPremio int,
--@IdEmpresa int,
--@IdTipoPremio int,
--@Titulo varchar(max),
--@Descripcion varchar(max),
--@Cantidad int,
--@CostoPuntos int
--as
--update Premios
--set IdEmpresa= @IdEmpresa, IdTipoPremio=@IdTipoPremio, Titulo=@Titulo, Descripcion=@Descripcion, Cantidad=@Cantidad, CostoPuntos=@CostoPuntos
--where IdPremio= @IdPremio

--alter procedure [dbo].[EmpresaCargarDatos]
--@IdEmpresa int,
--@Nombre varchar(50),
--@IdCiudad int
--as
--update Empresas
--set Nombre=@Nombre, IdCiudad=@IdCiudad
--where IdEmpresa=@IdEmpresa

--create procedure [dbo].[EmpresaModificar]
--@IdEmpresa int,
--@Nombre varchar(50),
--@IdCiudad int
--as
--update Empresas 
--set Nombre = @Nombre,
--IdCiudad = @IdCiudad

--where IdEmpresa = @IdEmpresa 



--create procedure [dbo].[EmpresasBuscarPorId]
--@IdEmpresa int
--as
--select *
--from Empresas
--where IdEmpresa = @IdEmpresa

--create procedure [dbo].[PremiosAgregar]
--@IdEmpresa int,
--@IdTipoPremio int,
--@Titulo varchar(50),
--@Descripcion varchar(50),
--@Cantidad int,
--@CostoPuntos int
--as 
--insert 
--into Premios
--values(@IdEmpresa, @IdTipoPremio, @Titulo, @Descripcion, @Cantidad, @CostoPuntos, 1)

--create procedure [dbo].[PremiosBuscarPorId]
--@IdPremio int
--as
--select *
--from  Premios
--where IdPremio= @IdPremio

--create procedure [dbo].[PremiosBuscarTodos]
--as 
--select *
--from Premios

create procedure [dbo].[EventosAgregar]
@IdTipoEvento int,
@IdCiudad int,
@IdPersona int,
@Nombre varchar(50),
@Descripcion varchar(max),
@Puntaje  int,
@Fecha date,
@Foto varchar(50)

as 
insert into Eventos
values (@IdTipoEvento,@IdCiudad, @idPersona, @Nombre, @Descripcion, @Puntaje,  @Fecha,1,@Foto)
GO
/****** Object:  StoredProcedure [dbo].[EventosTipoModificar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EventosTipoModificar]
@IdTipoEvento int,
@Descripcion varchar(50),
@Activo varchar(50)
as update EventosTipos
set  Descripcion=@Descripcion, Activo=@Activo
where IdTipoEvento=@IdTipoEvento
GO
/****** Object:  StoredProcedure [dbo].[EventosTiposAgregar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EventosTiposAgregar]
@Descripcion varchar(50),
@Activo bit
as
insert into EventosTipos
values (@Descripcion, @Activo)
GO
/****** Object:  StoredProcedure [dbo].[EventosTiposBuscarPorId]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EventosTiposBuscarPorId]
 @IdTipoEvento int
 as
 select *
 from EventosTipos
 where IdTipoEvento=@IdTipoEvento
GO
/****** Object:  StoredProcedure [dbo].[EventosTiposBuscarTodos]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EventosTiposBuscarTodos]
as 
select *
from EventosTipos
GO
/****** Object:  StoredProcedure [dbo].[EventosTiposEliminar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EventosTiposEliminar]
@IdTipoEvento as int 
as 
delete EventosTipos
where IdTipoEvento=@IdTipoEvento
GO
/****** Object:  StoredProcedure [dbo].[PaisesAgregar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PaisesAgregar]
@Nombre varchar(50),
@Activo bit
as
insert into Paises
values (@Nombre,@Activo)
GO
/****** Object:  StoredProcedure [dbo].[PaisesBuscarPorId]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure PaisesAgregar
--@Nombre varchar(50),
--@Activo bit
--as
--insert into Paises
--values (@Nombre,@Activo)

create procedure [dbo].[PaisesBuscarPorId]
@IdPais int
as
select *
from Paises
where IdPais = @IdPais
GO
/****** Object:  StoredProcedure [dbo].[PaisesBuscarTodos]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure PaisesAgregar
--@Nombre varchar(50),
--@Activo bit
--as
--insert into Paises
--values (@Nombre,@Activo)

--create procedure PaisesBuscarPorId
--@IdPais int
--as
--select *
--from Paises
--where IdPais = @IdPais

create procedure [dbo].[PaisesBuscarTodos]
as
select *
from
Paises
GO
/****** Object:  StoredProcedure [dbo].[PaisesModificar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure PaisesAgregar
--@Nombre varchar(50),
--@Activo bit
--as
--insert into Paises
--values (@Nombre,@Activo)

--create procedure PaisesBuscarPorId
--@IdPais int
--as
--select *
--from Paises
--where IdPais = @IdPais

--create procedure PaisesBuscarTodos
--as
--select *
--from
--Paises

create procedure [dbo].[PaisesModificar]
@IdPais int,
@Nombre varchar (50),
@Activo bit
as
update Paises
set Nombre = @Nombre, Activo = @Activo
where IdPais = @IdPais
GO
/****** Object:  StoredProcedure [dbo].[PersonasAgregar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PersonasAgregar]
@IdUsuario int
as
insert into Personas
values (@IdUsuario,'','','','','')
select @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[PersonasBuscarPorId]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure CiudadesBuscarPorIdProvincia
--@IdProvincia int
--as
--select * 
--from Ciudades
--where IdProvincia = @IdProvincia

CREATE procedure [dbo].[PersonasBuscarPorId]
@IdPersona int
as
select pe.Nombre,pe.Apellido,c.IdCiudad,pr.IdProvincia,pr.IdPais
from Personas pe join Ciudades c on pe.IdCiudad=c.IdCiudad
join Provincias pr on c.IdProvincia=pr.IdProvincia
where IdPersona=@IdPersona

--create procedure PersonasModificarDatos
--@IdPersona int,
--@IdCiudad int,
--@Nombre varchar(50),
--@Apellido varchar(50)
--as
--update Personas
--set IdCiudad=@IdCiudad,Nombre=@Nombre,Apellido=@Apellido
--where IdPersona=IdPersona
GO
/****** Object:  StoredProcedure [dbo].[PersonasCargarDatos]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PersonasCargarDatos]
@IdPersona int,
@IdCiudad int,
@Nombre varchar(50),
@Apellido varchar(50)
as
update Personas
set IdCiudad=@IdCiudad, Nombre=@Nombre, Apellido=@Apellido
where IdPersona=@IdPersona
GO
/****** Object:  StoredProcedure [dbo].[PersonasModificarDatos]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure CiudadesBuscarPorIdProvincia
--@IdProvincia int
--as
--select * 
--from Ciudades
--where IdProvincia = @IdProvincia

--create procedure PersonasBuscarPorId
--@IdPerona int
--as
--select pe.Nombre, pe.Apellido,pe.Foto,pe.IdCiudad,pr.IdProvincia,pr.IdPais,pe.Foto
--from Personas pe join ciudades c on pe . IdCiudad=c.IdCiudad
--join provincias pr on c.IdProvincia=pr.IdProvincia

create procedure [dbo].[PersonasModificarDatos]
@IdPersona int,
@IdCiudad int,
@Nombre varchar(50),
@Apellido varchar(50)
as
update Personas
set IdCiudad=@IdCiudad,Nombre=@Nombre,Apellido=@Apellido
where IdPersona=IdPersona
GO
/****** Object:  StoredProcedure [dbo].[PremiosAgregar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PremiosAgregar]
@IdEmpresa int,
@IdTipoPremio int,
@Titulo varchar(50),
@Descripcion varchar(50),
@Cantidad int,
@CostoPuntos int
as 
insert 
into Premios
values(@IdEmpresa, @IdTipoPremio, @Titulo, @Descripcion, @Cantidad, @CostoPuntos, 1)
GO
/****** Object:  StoredProcedure [dbo].[PremiosBuscarPorId]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PremiosBuscarPorId]
@IdPremio int
as
select *
from  Premios
where IdPremio= @IdPremio
GO
/****** Object:  StoredProcedure [dbo].[PremiosBuscarTodos]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PremiosBuscarTodos]
as 
select *
from Premios
GO
/****** Object:  StoredProcedure [dbo].[PremiosModificar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PremiosModificar]
@IdPremio int,
@IdEmpresa int,
@IdTipoPremio int,
@Titulo varchar(max),
@Descripcion varchar(max),
@Cantidad int,
@CostoPuntos int
as
update Premios
set IdEmpresa= @IdEmpresa, IdTipoPremio=@IdTipoPremio, Titulo=@Titulo, Descripcion=@Descripcion, Cantidad=@Cantidad, CostoPuntos=@CostoPuntos
where IdPremio= @IdPremio
GO
/****** Object:  StoredProcedure [dbo].[PremiosTiposAgregar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PremiosTiposAgregar]
@Descripcion varchar(50),
@Activo bit
as 
insert 
into PremiosTipos
values(@Descripcion, @Activo)
GO
/****** Object:  StoredProcedure [dbo].[PremiosTiposBuscarPorId]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PremiosTiposBuscarPorId]
@IdPremiosTipo int
as
select *
from  PremiosTipos
where IdTipoPremio= @IdPremiosTipo
GO
/****** Object:  StoredProcedure [dbo].[PremiosTiposBuscarTodos]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PremiosTiposBuscarTodos]
as 
select *
from PremiosTipos
GO
/****** Object:  StoredProcedure [dbo].[PremiosTiposModificar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PremiosTiposModificar]
@IdPremioTipo int,
@Descripcion varchar(50),
@Activo int
as
update PremiosTipos
set  Descripcion=@Descripcion, Activo=@Activo
where IdTipoPremio=  @IdPremioTipo
GO
/****** Object:  StoredProcedure [dbo].[ProvinciasAgregar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure PaisesAgregar
--@Nombre varchar(50),
--@Activo bit
--as
--insert into Paises
--values (@Nombre,@Activo)

--create procedure PaisesBuscarPorId
--@IdPais int
--as
--select *
--from Paises
--where IdPais = @IdPais

--create procedure PaisesBuscarTodos
--as
--select *
--from
--Paises

--create procedure PaisesModificar
--@IdPais int,
--@Nombre varchar (50),
--@Activo bit
--as
--update Paises
--set Nombre = @Nombre, Activo = @Activo
--where IdPais = @IdPais

create procedure [dbo].[ProvinciasAgregar]
@IdPais int,
@Nombre varchar(50),
@Activo bit
as
insert into Provincias  
values (@IdPais, @Nombre, @Activo)
GO
/****** Object:  StoredProcedure [dbo].[ProvinciasBuscarPorId]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure PaisesAgregar
--@Nombre varchar(50),
--@Activo bit
--as
--insert into Paises
--values (@Nombre,@Activo)

--create procedure PaisesBuscarPorId
--@IdPais int
--as
--select *
--from Paises
--where IdPais = @IdPais

--create procedure PaisesBuscarTodos
--as
--select *
--from
--Paises

--create procedure PaisesModificar
--@IdPais int,
--@Nombre varchar (50),
--@Activo bit
--as
--update Paises
--set Nombre = @Nombre, Activo = @Activo
--where IdPais = @IdPais

--create procedure ProvinciasAgregar
--@IdPais int,
--@Nombre varchar(50),
--@Activo bit
--as
--insert into Provincias  
--values (@IdPais, @Nombre, @Activo)

--create procedure ProvinciasModificar
--@Idprovincia int,
--@IdPais int,
--@Nombre varchar (50),
--@Activo bit
--as
--update Provincias
--set IdPais= @IdPais, Nombre = @Nombre, Activo = @Activo
--where IdProvincia = @IdProvincia

create procedure [dbo].[ProvinciasBuscarPorId]
@IdProvincia int
as
select *
from Provincias
where IdProvincia = @IdProvincia
GO
/****** Object:  StoredProcedure [dbo].[ProvinciasBuscarPorPais]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure PaisesAgregar
--@Nombre varchar(50),
--@Activo bit
--as
--insert into Paises
--values (@Nombre,@Activo)

--create procedure PaisesBuscarPorId
--@IdPais int
--as
--select *
--from Paises
--where IdPais = @IdPais

--create procedure PaisesBuscarTodos
--as
--select *
--from
--Paises

--create procedure PaisesModificar
--@IdPais int,
--@Nombre varchar (50),
--@Activo bit
--as
--update Paises
--set Nombre = @Nombre, Activo = @Activo
--where IdPais = @IdPais

--create procedure ProvinciasAgregar
--@IdPais int,
--@Nombre varchar(50),
--@Activo bit
--as
--insert into Provincias  
--values (@IdPais, @Nombre, @Activo)

--create procedure ProvinciasModificar
--@Idprovincia int,
--@IdPais int,
--@Nombre varchar (50),
--@Activo bit
--as
--update Provincias
--set IdPais= @IdPais, Nombre = @Nombre, Activo = @Activo
--where IdProvincia = @IdProvincia

--create procedure ProvinciasBuscarPorId
--@IdProvincia int
--as
--select *
--from Provincias
--where IdProvincia = @IdProvincia

create procedure [dbo].[ProvinciasBuscarPorPais]
@IdPais int
as
select *
from Provincias
where IdPais = @IdPais
GO
/****** Object:  StoredProcedure [dbo].[ProvinciasBuscarTodos]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure PaisesAgregar
--@Nombre varchar(50),
--@Activo bit
--as
--insert into Paises
--values (@Nombre,@Activo)

--create procedure PaisesBuscarPorId
--@IdPais int
--as
--select *
--from Paises
--where IdPais = @IdPais

--create procedure PaisesBuscarTodos
--as
--select *
--from
--Paises

--create procedure PaisesModificar
--@IdPais int,
--@Nombre varchar (50),
--@Activo bit
--as
--update Paises
--set Nombre = @Nombre, Activo = @Activo
--where IdPais = @IdPais

--create procedure ProvinciasAgregar
--@IdPais int,
--@Nombre varchar(50),
--@Activo bit
--as
--insert into Provincias  
--values (@IdPais, @Nombre, @Activo)

--create procedure ProvinciasModificar
--@Idprovincia int,
--@IdPais int,
--@Nombre varchar (50),
--@Activo bit
--as
--update Provincias
--set IdPais= @IdPais, Nombre = @Nombre, Activo = @Activo
--where IdProvincia = @IdProvincia

--create procedure ProvinciasBuscarPorId
--@IdProvincia int
--as
--select *
--from Provincias
--where IdProvincia = @IdProvincia

--create procedure ProvinciasBuscarPorPais
--@IdPais int
--as
--select *
--from Provincias
--where IdPais = @IdPais

CREATE procedure [dbo].[ProvinciasBuscarTodos]
as
select *
from Provincias
GO
/****** Object:  StoredProcedure [dbo].[ProvinciasModificar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure PaisesAgregar
--@Nombre varchar(50),
--@Activo bit
--as
--insert into Paises
--values (@Nombre,@Activo)

--create procedure PaisesBuscarPorId
--@IdPais int
--as
--select *
--from Paises
--where IdPais = @IdPais

--create procedure PaisesBuscarTodos
--as
--select *
--from
--Paises

--create procedure PaisesModificar
--@IdPais int,
--@Nombre varchar (50),
--@Activo bit
--as
--update Paises
--set Nombre = @Nombre, Activo = @Activo
--where IdPais = @IdPais

--create procedure ProvinciasAgregar
--@IdPais int,
--@Nombre varchar(50),
--@Activo bit
--as
--insert into Provincias  
--values (@IdPais, @Nombre, @Activo)

create procedure [dbo].[ProvinciasModificar]
@Idprovincia int,
@IdPais int,
@Nombre varchar (50),
@Activo bit
as
update Provincias
set IdPais= @IdPais, Nombre = @Nombre, Activo = @Activo
where IdProvincia = @IdProvincia
GO
/****** Object:  StoredProcedure [dbo].[UsuariosAgregar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UsuariosAgregar]
@Email varchar(50),
@Password varchar(50),
@IdTipo int
as
insert into Usuarios 
values(@Email,@Password,@IdTipo )
select @@IDENTITY 
GO
/****** Object:  StoredProcedure [dbo].[UsuariosBuscarPorLoginPass]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UsuariosBuscarPorLoginPass]
@Email varchar(50),
@Password varchar(50)
as
SELECT *

FROM Usuarios

WHERE Email =rtrim(@Email) and Password = rtrim(@Password)
GO
/****** Object:  StoredProcedure [dbo].[UsuariosTiposAgregar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UsuariosTiposAgregar]
@Descripcion varchar(50),
@Activo bit
as
insert 
into UsuariosTipos
values (@Descripcion, @Activo)
GO
/****** Object:  StoredProcedure [dbo].[UsuariosTiposBuscarPorId]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UsuariosTiposBuscarPorId] 
@IdTipoUsuario int
as
select * 
from UsuariosTipos
where IdTipoUsuario = @IdTipoUsuario
GO
/****** Object:  StoredProcedure [dbo].[UsuariosTiposBuscarTodos]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UsuariosTiposBuscarTodos]
as 
select *
from UsuariosTipos
GO
/****** Object:  StoredProcedure [dbo].[UsuariosTiposModificar]    Script Date: 2/6/2020 16:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UsuariosTiposModificar]
@IdUsuarioTipo int,
@Descripcion varchar(50),
@Activo bit
as 
update UsuariosTipos
set Descripcion= @Descripcion, Activo= @Activo
where IdTipoUsuario = @IdUsuarioTipo
GO
USE [master]
GO
ALTER DATABASE [uniON] SET  READ_WRITE 
GO
