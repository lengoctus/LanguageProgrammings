USE [master]
GO
/****** Object:  Database [DemoSession16]    Script Date: 2020-01-04 11:29:24 AM ******/
CREATE DATABASE [DemoSession16]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DemoSession16', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DemoSession16.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DemoSession16_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DemoSession16_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DemoSession16] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DemoSession16].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DemoSession16] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DemoSession16] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DemoSession16] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DemoSession16] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DemoSession16] SET ARITHABORT OFF 
GO
ALTER DATABASE [DemoSession16] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DemoSession16] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DemoSession16] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DemoSession16] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DemoSession16] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DemoSession16] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DemoSession16] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DemoSession16] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DemoSession16] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DemoSession16] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DemoSession16] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DemoSession16] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DemoSession16] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DemoSession16] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DemoSession16] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DemoSession16] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DemoSession16] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DemoSession16] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DemoSession16] SET  MULTI_USER 
GO
ALTER DATABASE [DemoSession16] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DemoSession16] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DemoSession16] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DemoSession16] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DemoSession16] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DemoSession16]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 2020-01-04 11:29:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Gender] [bit] NULL,
	[Email] [nvarchar](50) NULL,
	[Birthday] [date] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 2020-01-04 11:29:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Price] [decimal](18, 0) NULL,
	[Quantity] [int] NULL,
	[Status] [bit] NULL,
	[Description] [text] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([Id], [UserName], [Password], [Gender], [Email], [Birthday]) VALUES (1, N'ngoctu', N'1234', 1, N'ngoctuaka205@hotmail.com', CAST(N'2000-05-20' AS Date))
INSERT [dbo].[Account] ([Id], [UserName], [Password], [Gender], [Email], [Birthday]) VALUES (2, N'ngocsang', N'1234', 0, N'nt@gmaiil.com', CAST(N'2000-01-11' AS Date))
SET IDENTITY_INSERT [dbo].[Account] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [Status], [Description]) VALUES (3, N'Bánh Quy', CAST(6000 AS Decimal(18, 0)), 4, 1, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [Status], [Description]) VALUES (4, N'Bánh Nếp', CAST(1000 AS Decimal(18, 0)), 5, 0, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [Status], [Description]) VALUES (5, N'Bánh Đa', CAST(6000 AS Decimal(18, 0)), 4, 1, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [Status], [Description]) VALUES (6, N'Bánh Thập cẩm', CAST(4000 AS Decimal(18, 0)), 5, 1, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [Status], [Description]) VALUES (7, N'Bánh Hoa Tiêu', CAST(2000 AS Decimal(18, 0)), 1, 0, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [Status], [Description]) VALUES (8, N'Bánh Mật', CAST(7000 AS Decimal(18, 0)), 8, 0, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [Status], [Description]) VALUES (9, N'Bánh Gai', CAST(2000 AS Decimal(18, 0)), 6, 1, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [Status], [Description]) VALUES (10, N'Bánh Mứt', CAST(12000 AS Decimal(18, 0)), 4, 1, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [Status], [Description]) VALUES (11, N'Bánh Khoaiiii', CAST(3000 AS Decimal(18, 0)), 4, 1, N'ngon vai')
SET IDENTITY_INSERT [dbo].[Product] OFF
USE [master]
GO
ALTER DATABASE [DemoSession16] SET  READ_WRITE 
GO
