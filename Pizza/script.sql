USE [master]
GO
/****** Object:  Database [Pizza]    Script Date: 31/10/2019 08:46:59 p. m. ******/
CREATE DATABASE [Pizza]

GO
ALTER DATABASE [Pizza] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pizza].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pizza] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pizza] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pizza] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pizza] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pizza] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pizza] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Pizza] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Pizza] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pizza] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pizza] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pizza] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pizza] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pizza] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pizza] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pizza] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pizza] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Pizza] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pizza] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pizza] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pizza] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pizza] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pizza] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pizza] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pizza] SET RECOVERY FULL 
GO
ALTER DATABASE [Pizza] SET  MULTI_USER 
GO
ALTER DATABASE [Pizza] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pizza] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Pizza] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Pizza] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Pizza]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 31/10/2019 08:46:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Calle] [varchar](50) NOT NULL,
	[Numero] [varchar](10) NOT NULL,
	[Colonia] [varchar](50) NOT NULL,
	[CP] [int] NOT NULL,
	[Referencias] [varchar](150) NOT NULL,
	[Telefono] [varchar](15) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pizzas]    Script Date: 31/10/2019 08:46:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pizzas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[PrecioCH] [decimal](18, 0) NOT NULL,
	[PrecioM] [decimal](18, 0) NOT NULL,
	[PrecioG] [decimal](18, 0) NOT NULL,
	[TiempoPreparacion] [int] NOT NULL,
 CONSTRAINT [PK_Pizzas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 31/10/2019 08:46:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[FK_ID_Perfil] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([ID], [Nombre], [Calle], [Numero], [Colonia], [CP], [Referencias], [Telefono]) VALUES (1, N'Lulu', N'Lejos', N'00000', N'Muy Lejos', 31000, N'Cerca de un OXXO', N'(614)400-00-00')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
SET IDENTITY_INSERT [dbo].[Pizzas] ON 

INSERT [dbo].[Pizzas] ([ID], [Descripcion], [PrecioCH], [PrecioM], [PrecioG], [TiempoPreparacion]) VALUES (1, N'Pepperoni', CAST(60 AS Decimal(18, 0)), CAST(80 AS Decimal(18, 0)), CAST(100 AS Decimal(18, 0)), 15)
INSERT [dbo].[Pizzas] ([ID], [Descripcion], [PrecioCH], [PrecioM], [PrecioG], [TiempoPreparacion]) VALUES (2, N'Champiñones', CAST(60 AS Decimal(18, 0)), CAST(80 AS Decimal(18, 0)), CAST(100 AS Decimal(18, 0)), 15)
INSERT [dbo].[Pizzas] ([ID], [Descripcion], [PrecioCH], [PrecioM], [PrecioG], [TiempoPreparacion]) VALUES (3, N'Chorizo', CAST(70 AS Decimal(18, 0)), CAST(90 AS Decimal(18, 0)), CAST(110 AS Decimal(18, 0)), 15)
INSERT [dbo].[Pizzas] ([ID], [Descripcion], [PrecioCH], [PrecioM], [PrecioG], [TiempoPreparacion]) VALUES (4, N'Meat Lovers', CAST(80 AS Decimal(18, 0)), CAST(100 AS Decimal(18, 0)), CAST(120 AS Decimal(18, 0)), 20)
SET IDENTITY_INSERT [dbo].[Pizzas] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([ID], [Usuario], [Password], [FK_ID_Perfil]) VALUES (1, N'Oscar', N'Daniel', 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
USE [master]
GO
ALTER DATABASE [Pizza] SET  READ_WRITE 
GO
