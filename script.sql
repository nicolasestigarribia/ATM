USE [master]
GO
/****** Object:  Database [Cajero]    Script Date: 16/6/2022 18:35:36 ******/
CREATE DATABASE [Cajero]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cajero', FILENAME = N'C:\Users\nestigarribia\Cajero.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Cajero_log', FILENAME = N'C:\Users\nestigarribia\Cajero_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Cajero] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cajero].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cajero] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Cajero] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Cajero] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Cajero] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Cajero] SET ARITHABORT OFF 
GO
ALTER DATABASE [Cajero] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Cajero] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Cajero] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Cajero] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Cajero] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Cajero] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Cajero] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Cajero] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Cajero] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Cajero] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Cajero] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Cajero] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Cajero] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Cajero] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Cajero] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Cajero] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Cajero] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Cajero] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Cajero] SET  MULTI_USER 
GO
ALTER DATABASE [Cajero] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Cajero] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Cajero] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Cajero] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Cajero] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Cajero] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Cajero] SET QUERY_STORE = OFF
GO
USE [Cajero]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 16/6/2022 18:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[operaciones]    Script Date: 16/6/2022 18:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[operaciones](
	[IdOperacion] [int] IDENTITY(1,1) NOT NULL,
	[IdTarjeta] [int] NOT NULL,
	[CodigoOperacion] [int] NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
	[FechaHora] [datetime] NOT NULL,
	[Monto] [float] NOT NULL,
 CONSTRAINT [PK_operaciones] PRIMARY KEY CLUSTERED 
(
	[IdOperacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tarjetas]    Script Date: 16/6/2022 18:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tarjetas](
	[IdTarjeta] [int] IDENTITY(1,1) NOT NULL,
	[NumeroTarjeta] [nvarchar](max) NULL,
	[Bloqueada] [bit] NOT NULL,
	[Balance] [float] NOT NULL,
	[Pin] [int] NOT NULL,
	[FechaVencimiento] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tarjetas] PRIMARY KEY CLUSTERED 
(
	[IdTarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220615023050_firstMigration', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220616120803_agregoVencimiento', N'5.0.17')
GO
SET IDENTITY_INSERT [dbo].[operaciones] ON 

INSERT [dbo].[operaciones] ([IdOperacion], [IdTarjeta], [CodigoOperacion], [Descripcion], [FechaHora], [Monto]) VALUES (1, 1, 2, N'Balance', CAST(N'2022-06-16T09:23:50.327' AS DateTime), 0)
INSERT [dbo].[operaciones] ([IdOperacion], [IdTarjeta], [CodigoOperacion], [Descripcion], [FechaHora], [Monto]) VALUES (2, 1, 1, N'Retiro', CAST(N'2022-06-16T09:24:25.050' AS DateTime), 200)
INSERT [dbo].[operaciones] ([IdOperacion], [IdTarjeta], [CodigoOperacion], [Descripcion], [FechaHora], [Monto]) VALUES (1002, 1, 2, N'Balance', CAST(N'2022-06-16T16:02:58.780' AS DateTime), 0)
INSERT [dbo].[operaciones] ([IdOperacion], [IdTarjeta], [CodigoOperacion], [Descripcion], [FechaHora], [Monto]) VALUES (1003, 1, 2, N'Balance', CAST(N'2022-06-16T16:04:15.813' AS DateTime), 0)
INSERT [dbo].[operaciones] ([IdOperacion], [IdTarjeta], [CodigoOperacion], [Descripcion], [FechaHora], [Monto]) VALUES (1004, 1, 2, N'Balance', CAST(N'2022-06-16T16:06:27.933' AS DateTime), 0)
INSERT [dbo].[operaciones] ([IdOperacion], [IdTarjeta], [CodigoOperacion], [Descripcion], [FechaHora], [Monto]) VALUES (1007, 1, 3, N'Ingreso', CAST(N'2022-06-06T00:00:00.000' AS DateTime), 10000)
INSERT [dbo].[operaciones] ([IdOperacion], [IdTarjeta], [CodigoOperacion], [Descripcion], [FechaHora], [Monto]) VALUES (1008, 1, 1, N'Retiro', CAST(N'2022-06-16T16:16:43.150' AS DateTime), 300)
INSERT [dbo].[operaciones] ([IdOperacion], [IdTarjeta], [CodigoOperacion], [Descripcion], [FechaHora], [Monto]) VALUES (1009, 1, 1, N'Retiro', CAST(N'2022-06-16T17:03:21.640' AS DateTime), 100)
INSERT [dbo].[operaciones] ([IdOperacion], [IdTarjeta], [CodigoOperacion], [Descripcion], [FechaHora], [Monto]) VALUES (1010, 1, 1, N'Retiro', CAST(N'2022-06-16T17:04:12.400' AS DateTime), 100)
INSERT [dbo].[operaciones] ([IdOperacion], [IdTarjeta], [CodigoOperacion], [Descripcion], [FechaHora], [Monto]) VALUES (1011, 1, 1, N'Retiro', CAST(N'2022-06-16T17:09:05.233' AS DateTime), 10)
INSERT [dbo].[operaciones] ([IdOperacion], [IdTarjeta], [CodigoOperacion], [Descripcion], [FechaHora], [Monto]) VALUES (1012, 1, 1, N'Retiro', CAST(N'2022-06-16T17:11:06.240' AS DateTime), 100)
INSERT [dbo].[operaciones] ([IdOperacion], [IdTarjeta], [CodigoOperacion], [Descripcion], [FechaHora], [Monto]) VALUES (1013, 1, 1, N'Retiro', CAST(N'2022-06-16T17:16:22.893' AS DateTime), 100)
INSERT [dbo].[operaciones] ([IdOperacion], [IdTarjeta], [CodigoOperacion], [Descripcion], [FechaHora], [Monto]) VALUES (1014, 1, 1, N'Retiro', CAST(N'2022-06-16T17:16:57.880' AS DateTime), 100)
SET IDENTITY_INSERT [dbo].[operaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[tarjetas] ON 

INSERT [dbo].[tarjetas] ([IdTarjeta], [NumeroTarjeta], [Bloqueada], [Balance], [Pin], [FechaVencimiento]) VALUES (1, N'1234567891234567', 0, 8990, 123, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[tarjetas] OFF
GO
ALTER TABLE [dbo].[tarjetas] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [FechaVencimiento]
GO
USE [master]
GO
ALTER DATABASE [Cajero] SET  READ_WRITE 
GO
