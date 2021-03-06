USE [master]
GO
/****** Object:  Database [Cementerio]    Script Date: 22/10/2019 08:59:08 p. m. ******/
CREATE DATABASE [Cementerio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cementerio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Cementerio.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Cementerio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Cementerio_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Cementerio] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cementerio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cementerio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Cementerio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Cementerio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Cementerio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Cementerio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Cementerio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Cementerio] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Cementerio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Cementerio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Cementerio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Cementerio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Cementerio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Cementerio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Cementerio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Cementerio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Cementerio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Cementerio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Cementerio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Cementerio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Cementerio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Cementerio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Cementerio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Cementerio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Cementerio] SET RECOVERY FULL 
GO
ALTER DATABASE [Cementerio] SET  MULTI_USER 
GO
ALTER DATABASE [Cementerio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Cementerio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Cementerio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Cementerio] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Cementerio]
GO
/****** Object:  Table [dbo].[Lotes]    Script Date: 22/10/2019 08:59:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lotes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nomenclatura] [varchar](10) NOT NULL,
	[Capacidad] [int] NOT NULL,
	[Titular] [varchar](200) NOT NULL,
	[Beneficiario1] [varchar](200) NOT NULL,
	[Beneficiario2] [varchar](200) NULL,
	[Beneficiario3] [varchar](200) NULL,
	[Lugar1] [varchar](200) NULL,
	[Lugar2] [varchar](200) NULL,
	[Lugar3] [varchar](200) NULL,
	[Lugar4] [varchar](200) NULL,
	[Pagado] [bit] NOT NULL,
 CONSTRAINT [PK_Lotes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Lotes] ON 

INSERT [dbo].[Lotes] ([ID], [Nomenclatura], [Capacidad], [Titular], [Beneficiario1], [Beneficiario2], [Beneficiario3], [Lugar1], [Lugar2], [Lugar3], [Lugar4], [Pagado]) VALUES (2, N'PJ1-A1', 4, N'Oscar Perez', N'Larissa Perez', N'Ricardo Arjona', N'', N'Lulú', N'', N'', N' ', 1)
INSERT [dbo].[Lotes] ([ID], [Nomenclatura], [Capacidad], [Titular], [Beneficiario1], [Beneficiario2], [Beneficiario3], [Lugar1], [Lugar2], [Lugar3], [Lugar4], [Pagado]) VALUES (3, N'PJ1-A2', 4, N'Marcela Barrera', N'Daniel Zapata', N'', N'', N'Eidu', N'', N'', N'', 0)
SET IDENTITY_INSERT [dbo].[Lotes] OFF
USE [master]
GO
ALTER DATABASE [Cementerio] SET  READ_WRITE 
GO
