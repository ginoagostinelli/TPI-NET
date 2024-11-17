USE [master]
GO

/****** Object:  Database [ClienteDb]    Script Date: 16/11/2024 20:51:10 ******/
CREATE DATABASE [ClienteDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ClienteDb', FILENAME = N'C:\Users\lauta\ClienteDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ClienteDb_log', FILENAME = N'C:\Users\lauta\ClienteDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ClienteDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ClienteDb] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ClienteDb] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ClienteDb] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ClienteDb] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ClienteDb] SET ARITHABORT OFF 
GO

ALTER DATABASE [ClienteDb] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [ClienteDb] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ClienteDb] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ClienteDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ClienteDb] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ClienteDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ClienteDb] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ClienteDb] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ClienteDb] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ClienteDb] SET  ENABLE_BROKER 
GO

ALTER DATABASE [ClienteDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ClienteDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ClienteDb] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ClienteDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ClienteDb] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ClienteDb] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [ClienteDb] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ClienteDb] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [ClienteDb] SET  MULTI_USER 
GO

ALTER DATABASE [ClienteDb] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ClienteDb] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ClienteDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ClienteDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [ClienteDb] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ClienteDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [ClienteDb] SET QUERY_STORE = OFF
GO

ALTER DATABASE [ClienteDb] SET  READ_WRITE 
GO

USE [ClienteDb]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[ClientesVer] [bit] NOT NULL,
	[ClientesAgregar] [bit] NOT NULL,
	[ClientesModificar] [bit] NOT NULL,
	[ClientesEliminar] [bit] NOT NULL,
	[SolicitudesVer] [bit] NOT NULL,
	[SolicitudesAgregar] [bit] NOT NULL,
	[SolicitudesModificar] [bit] NOT NULL,
	[SolicitudesEliminar] [bit] NOT NULL,
	[VisitasVer] [bit] NOT NULL,
	[VisitasAgregar] [bit] NOT NULL,
	[VisitasModificar] [bit] NOT NULL,
	[VisitasEliminar] [bit] NOT NULL,
	[TecnicosVer] [bit] NOT NULL,
	[TecnicosAgregar] [bit] NOT NULL,
	[TecnicosModificar] [bit] NOT NULL,
	[TecnicosEliminar] [bit] NOT NULL,
	[TiposMaterialesVer] [bit] NOT NULL,
	[TiposMaterialesAgregar] [bit] NOT NULL,
	[TiposMaterialesModificar] [bit] NOT NULL,
	[TiposMaterialesEliminar] [bit] NOT NULL,
	[TiposSolicitudesVer] [bit] NOT NULL,
	[TiposSolicitudesAgregar] [bit] NOT NULL,
	[TiposSolicitudesModificar] [bit] NOT NULL,
	[TiposSolicitudesEliminar] [bit] NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Tecnicos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Apellido] [nvarchar](max) NOT NULL,
	[NombreMix] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Rol] [int] NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Tecnicos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

INSERT INTO [dbo].[Roles]
           ([Descripcion]
           ,[ClientesVer]
		   ,[ClientesAgregar]
           ,[ClientesModificar]
           ,[ClientesEliminar]
           ,[SolicitudesVer]
		   ,[SolicitudesAgregar]
           ,[SolicitudesModificar]
           ,[SolicitudesEliminar]
           ,[VisitasVer]
		   ,[VisitasAgregar]
           ,[VisitasModificar]
           ,[VisitasEliminar]
           ,[TecnicosVer]
		   ,[TecnicosAgregar]
           ,[TecnicosModificar]
           ,[TecnicosEliminar]
           ,[TiposMaterialesVer]
		   ,[TiposMaterialesAgregar]
           ,[TiposMaterialesModificar]
           ,[TiposMaterialesEliminar]
           ,[TiposSolicitudesVer]
		   ,[TiposSolicitudesAgregar]
           ,[TiposSolicitudesModificar]
           ,[TiposSolicitudesEliminar])
     VALUES
           ('Supervisor'
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
		   ,1
           ,1
		   ,1
           ,1
           ,1
           ,1
           ,1)
GO


INSERT INTO [dbo].[Roles]
           ([Descripcion]
           ,[ClientesVer]
		   ,[ClientesAgregar]
           ,[ClientesModificar]
           ,[ClientesEliminar]
           ,[SolicitudesVer]
		   ,[SolicitudesAgregar]
           ,[SolicitudesModificar]
           ,[SolicitudesEliminar]
           ,[VisitasVer]
		   ,[VisitasAgregar]
           ,[VisitasModificar]
           ,[VisitasEliminar]
           ,[TecnicosVer]
		   ,[TecnicosAgregar]
           ,[TecnicosModificar]
           ,[TecnicosEliminar]
           ,[TiposMaterialesVer]
		   ,[TiposMaterialesAgregar]
           ,[TiposMaterialesModificar]
           ,[TiposMaterialesEliminar]
           ,[TiposSolicitudesVer]
		   ,[TiposSolicitudesAgregar]
           ,[TiposSolicitudesModificar]
           ,[TiposSolicitudesEliminar])
     VALUES
           ('Tecnico'
           ,1
           ,0
           ,0
		   ,0
           ,1
           ,0
           ,0
		   ,0
           ,1
           ,1
		   ,1
           ,1
           ,1
           ,0
           ,0
		   ,0
           ,1
           ,0
           ,0
		   ,0
           ,1
           ,0
		   ,0
           ,0)
GO

INSERT INTO [dbo].[Tecnicos]
           ([Nombre]
           ,[Apellido]
           ,[NombreMix]
           ,[Email]
           ,[Password]
           ,[Rol]
           ,[Telefono])
     VALUES
           ('Supervisor'
           ,'Supervisor'
           ,'Supervisor'
           ,'supervisor@supervisor.sup'
           ,'Supervisor1'
           ,1
           ,'55555555555555')
GO


