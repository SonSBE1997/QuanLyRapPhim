USE [master]
GO
/****** Object:  Database [CinemaManagement]    Script Date: 11/06/2017 12:16:24 AM ******/
CREATE DATABASE [CinemaManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CinemaManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\CinemaManagement.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CinemaManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\CinemaManagement_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CinemaManagement] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CinemaManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CinemaManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CinemaManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CinemaManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CinemaManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CinemaManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [CinemaManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CinemaManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CinemaManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CinemaManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CinemaManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CinemaManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CinemaManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CinemaManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CinemaManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CinemaManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CinemaManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CinemaManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CinemaManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CinemaManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CinemaManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CinemaManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CinemaManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CinemaManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CinemaManagement] SET  MULTI_USER 
GO
ALTER DATABASE [CinemaManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CinemaManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CinemaManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CinemaManagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CinemaManagement] SET DELAYED_DURABILITY = DISABLED 
GO
USE [CinemaManagement]
GO
/****** Object:  Table [dbo].[BuoiChieu]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BuoiChieu](
	[mashow] [varchar](50) NOT NULL,
	[maphim] [varchar](50) NULL,
	[marap] [varchar](50) NULL,
	[maphong] [varchar](50) NULL,
	[ngaychieu] [datetime] NULL,
	[magiochieu] [varchar](50) NULL,
	[sovedaban] [int] NULL DEFAULT ((0)),
	[tongtien] [bigint] NULL DEFAULT ((0)),
 CONSTRAINT [pk_MaShow] PRIMARY KEY CLUSTERED 
(
	[mashow] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GioChieu]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GioChieu](
	[magiochieu] [varchar](50) NOT NULL,
	[dongia] [int] NULL,
 CONSTRAINT [pk_MaGioChieu] PRIMARY KEY CLUSTERED 
(
	[magiochieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HangSX]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HangSX](
	[mahangsx] [varchar](50) NOT NULL,
	[tenhangsx] [nvarchar](255) NULL,
 CONSTRAINT [pk_MaHangSX] PRIMARY KEY CLUSTERED 
(
	[mahangsx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NuocSanXuat]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NuocSanXuat](
	[manuocsx] [varchar](50) NOT NULL,
	[tennuocsx] [nvarchar](255) NULL,
 CONSTRAINT [pk_MaNuocSX] PRIMARY KEY CLUSTERED 
(
	[manuocsx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phim]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phim](
	[maphim] [varchar](50) NOT NULL,
	[tenphim] [nvarchar](255) NULL,
	[manuocsx] [varchar](50) NULL,
	[mahangsx] [varchar](50) NULL,
	[daodien] [nvarchar](100) NULL,
	[matheloai] [varchar](50) NULL,
	[ngaykhoichieu] [datetime] NULL,
	[ngayketthuc] [datetime] NULL,
	[nudienvienchinh] [nvarchar](100) NULL,
	[namdienvienchinh] [nvarchar](100) NULL,
	[noidungchinh] [nvarchar](1000) NULL,
	[tongchiphi] [bigint] NULL,
	[tongthu] [bigint] NULL DEFAULT ((0)),
 CONSTRAINT [pk_MaPhim] PRIMARY KEY CLUSTERED 
(
	[maphim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhongChieu]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhongChieu](
	[marap] [varchar](50) NOT NULL,
	[maphong] [varchar](50) NOT NULL,
	[tenphong] [nvarchar](255) NULL,
	[soghe] [int] NULL,
 CONSTRAINT [pk_MaPhong] PRIMARY KEY CLUSTERED 
(
	[maphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rap]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rap](
	[marap] [varchar](50) NOT NULL,
	[tenrap] [nvarchar](255) NOT NULL,
	[diachi] [nvarchar](255) NOT NULL,
	[dienthoai] [varchar](30) NOT NULL,
	[sophong] [int] NOT NULL,
	[tongsoghe] [int] NOT NULL CONSTRAINT [DF_Rap_tongsoghe]  DEFAULT ((0)),
 CONSTRAINT [pk_MaRap] PRIMARY KEY CLUSTERED 
(
	[marap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[userName] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[tenhienthi] [nvarchar](255) NULL,
	[loaitaikhoan] [int] NULL DEFAULT ((0)),
 CONSTRAINT [pk_TaiKhoan_Username] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TheLoai](
	[matheloai] [varchar](50) NOT NULL,
	[tentheloai] [nvarchar](100) NULL,
 CONSTRAINT [pk_MaTheLoai] PRIMARY KEY CLUSTERED 
(
	[matheloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ve]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ve](
	[mashow] [varchar](50) NOT NULL,
	[mave] [varchar](50) NOT NULL,
	[hangghe] [varchar](20) NULL,
	[soghe] [int] NULL,
	[trangthai] [nvarchar](50) NULL DEFAULT (N'Chưa đặt'),
 CONSTRAINT [pk_MaShow_MaVe] PRIMARY KEY CLUSTERED 
(
	[mashow] ASC,
	[mave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BuoiChieu] ([mashow], [maphim], [marap], [maphong], [ngaychieu], [magiochieu], [sovedaban], [tongtien]) VALUES (N'S01', N'F01', N'R01', N'P01', CAST(N'2017-03-04 00:00:00.000' AS DateTime), N'GC03', 3, 130000)
INSERT [dbo].[BuoiChieu] ([mashow], [maphim], [marap], [maphong], [ngaychieu], [magiochieu], [sovedaban], [tongtien]) VALUES (N'S012', N'F03', N'R03', N'P07', CAST(N'2017-12-11 00:00:00.000' AS DateTime), N'GC03', 0, 0)
INSERT [dbo].[BuoiChieu] ([mashow], [maphim], [marap], [maphong], [ngaychieu], [magiochieu], [sovedaban], [tongtien]) VALUES (N'S02', N'F02', N'R02', N'P04', CAST(N'2017-03-09 00:00:00.000' AS DateTime), N'GC01', 3, 140000)
INSERT [dbo].[BuoiChieu] ([mashow], [maphim], [marap], [maphong], [ngaychieu], [magiochieu], [sovedaban], [tongtien]) VALUES (N'S03', N'F03', N'R02', N'P04', CAST(N'2017-03-04 00:00:00.000' AS DateTime), N'GC02', 3, 60000)
INSERT [dbo].[BuoiChieu] ([mashow], [maphim], [marap], [maphong], [ngaychieu], [magiochieu], [sovedaban], [tongtien]) VALUES (N'S04', N'F03', N'R04', N'P08', CAST(N'2017-06-02 00:00:00.000' AS DateTime), N'GC05', 3, 180000)
INSERT [dbo].[BuoiChieu] ([mashow], [maphim], [marap], [maphong], [ngaychieu], [magiochieu], [sovedaban], [tongtien]) VALUES (N'S05', N'F05', N'R02', N'P05', CAST(N'2016-10-18 00:00:00.000' AS DateTime), N'GC04', 1, 80000)
INSERT [dbo].[BuoiChieu] ([mashow], [maphim], [marap], [maphong], [ngaychieu], [magiochieu], [sovedaban], [tongtien]) VALUES (N'S06', N'F06', N'R05', N'P09', CAST(N'2017-09-22 00:00:00.000' AS DateTime), N'GC06', 1, 65000)
INSERT [dbo].[BuoiChieu] ([mashow], [maphim], [marap], [maphong], [ngaychieu], [magiochieu], [sovedaban], [tongtien]) VALUES (N'S07', N'F07', N'R04', N'P10', CAST(N'2016-07-30 00:00:00.000' AS DateTime), N'GC01', 1, 70000)
INSERT [dbo].[BuoiChieu] ([mashow], [maphim], [marap], [maphong], [ngaychieu], [magiochieu], [sovedaban], [tongtien]) VALUES (N'S08', N'F08', N'R02', N'P04', CAST(N'2017-06-22 00:00:00.000' AS DateTime), N'GC07', 0, 0)
INSERT [dbo].[BuoiChieu] ([mashow], [maphim], [marap], [maphong], [ngaychieu], [magiochieu], [sovedaban], [tongtien]) VALUES (N'S09', N'F09', N'R01', N'P01', CAST(N'2017-12-21 00:00:00.000' AS DateTime), N'GC08', 0, 0)
INSERT [dbo].[BuoiChieu] ([mashow], [maphim], [marap], [maphong], [ngaychieu], [magiochieu], [sovedaban], [tongtien]) VALUES (N'S10', N'F01', N'R04', N'P10', CAST(N'2016-03-04 00:00:00.000' AS DateTime), N'GC03', 0, 0)
INSERT [dbo].[BuoiChieu] ([mashow], [maphim], [marap], [maphong], [ngaychieu], [magiochieu], [sovedaban], [tongtien]) VALUES (N'S11', N'F02', N'R03', N'P07', CAST(N'2016-04-26 00:00:00.000' AS DateTime), N'GC09', 0, 0)
INSERT [dbo].[GioChieu] ([magiochieu], [dongia]) VALUES (N'GC01', 70000)
INSERT [dbo].[GioChieu] ([magiochieu], [dongia]) VALUES (N'GC02', 60000)
INSERT [dbo].[GioChieu] ([magiochieu], [dongia]) VALUES (N'GC03', 65000)
INSERT [dbo].[GioChieu] ([magiochieu], [dongia]) VALUES (N'GC04', 80000)
INSERT [dbo].[GioChieu] ([magiochieu], [dongia]) VALUES (N'GC05', 90000)
INSERT [dbo].[GioChieu] ([magiochieu], [dongia]) VALUES (N'GC06', 65000)
INSERT [dbo].[GioChieu] ([magiochieu], [dongia]) VALUES (N'GC07', 50000)
INSERT [dbo].[GioChieu] ([magiochieu], [dongia]) VALUES (N'GC08', 60000)
INSERT [dbo].[GioChieu] ([magiochieu], [dongia]) VALUES (N'GC09', 75000)
INSERT [dbo].[HangSX] ([mahangsx], [tenhangsx]) VALUES (N'HSX01', N'Warner Bros')
INSERT [dbo].[HangSX] ([mahangsx], [tenhangsx]) VALUES (N'HSX02', N'20th Century Fox')
INSERT [dbo].[HangSX] ([mahangsx], [tenhangsx]) VALUES (N'HSX03', N'Marvel Studios')
INSERT [dbo].[HangSX] ([mahangsx], [tenhangsx]) VALUES (N'HSX04', N'DreamWorks')
INSERT [dbo].[HangSX] ([mahangsx], [tenhangsx]) VALUES (N'HSX05', N'Metro-Goldwyn-Mayer')
INSERT [dbo].[HangSX] ([mahangsx], [tenhangsx]) VALUES (N'HSX06', N'New Line Cinema')
INSERT [dbo].[HangSX] ([mahangsx], [tenhangsx]) VALUES (N'HSX07', N'Disney')
INSERT [dbo].[HangSX] ([mahangsx], [tenhangsx]) VALUES (N'HSX08', N'THVN')
INSERT [dbo].[NuocSanXuat] ([manuocsx], [tennuocsx]) VALUES (N'NSX01', N'Mỹ')
INSERT [dbo].[NuocSanXuat] ([manuocsx], [tennuocsx]) VALUES (N'NSX02', N'Ấn Độ')
INSERT [dbo].[NuocSanXuat] ([manuocsx], [tennuocsx]) VALUES (N'NSX03', N'Việt Nam')
INSERT [dbo].[NuocSanXuat] ([manuocsx], [tennuocsx]) VALUES (N'NSX04', N'HongKong')
INSERT [dbo].[NuocSanXuat] ([manuocsx], [tennuocsx]) VALUES (N'NSX05', N'Trung Quốc')
INSERT [dbo].[NuocSanXuat] ([manuocsx], [tennuocsx]) VALUES (N'NSX06', N'Đài Loan')
INSERT [dbo].[NuocSanXuat] ([manuocsx], [tennuocsx]) VALUES (N'NSX07', N'Hàn Quốc')
INSERT [dbo].[Phim] ([maphim], [tenphim], [manuocsx], [mahangsx], [daodien], [matheloai], [ngaykhoichieu], [ngayketthuc], [nudienvienchinh], [namdienvienchinh], [noidungchinh], [tongchiphi], [tongthu]) VALUES (N'F01', N'Tranformer', N'NSX01', N'HSX01', N'Tom Can', N'TL01', CAST(N'2016-12-11 00:00:00.000' AS DateTime), CAST(N'2017-01-02 00:00:00.000' AS DateTime), N'Jenny But', N'Tom Clevery', N'Cuoc chien robot o Mahaz', 1000000000, 130000)
INSERT [dbo].[Phim] ([maphim], [tenphim], [manuocsx], [mahangsx], [daodien], [matheloai], [ngaykhoichieu], [ngayketthuc], [nudienvienchinh], [namdienvienchinh], [noidungchinh], [tongchiphi], [tongthu]) VALUES (N'F02', N'Lorries', N'NSX01', N'HSX02', N'BicaFonds', N'TL01', CAST(N'2017-05-08 00:00:00.000' AS DateTime), CAST(N'2017-07-01 00:00:00.000' AS DateTime), N'Carley', N'Leo Vardi', N'Ngay 16 thang 3 1997...', 900000000, 140000)
INSERT [dbo].[Phim] ([maphim], [tenphim], [manuocsx], [mahangsx], [daodien], [matheloai], [ngaykhoichieu], [ngayketthuc], [nudienvienchinh], [namdienvienchinh], [noidungchinh], [tongchiphi], [tongthu]) VALUES (N'F03', N'Thu 6 Ngay 13', N'NSX01', N'HSX03', N'Lewan', N'TL02', CAST(N'2017-04-30 00:00:00.000' AS DateTime), CAST(N'2017-05-11 00:00:00.000' AS DateTime), N'Traiss', N'Maris Gui', N'Ngay toi te nhat ', 1000000000, 240000)
INSERT [dbo].[Phim] ([maphim], [tenphim], [manuocsx], [mahangsx], [daodien], [matheloai], [ngaykhoichieu], [ngayketthuc], [nudienvienchinh], [namdienvienchinh], [noidungchinh], [tongchiphi], [tongthu]) VALUES (N'F05', N'Chiến lang', N'NSX05', N'HSX07', N'Cheng Lee', N'TL01', CAST(N'2016-11-22 00:00:00.000' AS DateTime), CAST(N'2016-12-11 00:00:00.000' AS DateTime), N'Vinh Du', N'Saiz Long', N'Chiến Lang', 500000000, 80000)
INSERT [dbo].[Phim] ([maphim], [tenphim], [manuocsx], [mahangsx], [daodien], [matheloai], [ngaykhoichieu], [ngayketthuc], [nudienvienchinh], [namdienvienchinh], [noidungchinh], [tongchiphi], [tongthu]) VALUES (N'F06', N'Mười năm của chúng ta', N'NSX05', N'HSX03', N'Kì Vân', N'TL05', CAST(N'2017-09-10 00:00:00.000' AS DateTime), CAST(N'2017-10-11 00:00:00.000' AS DateTime), N'Khai Rong', N'Vô Bị', N'Mười năm của chúng ta', 390000000, 65000)
INSERT [dbo].[Phim] ([maphim], [tenphim], [manuocsx], [mahangsx], [daodien], [matheloai], [ngaykhoichieu], [ngayketthuc], [nudienvienchinh], [namdienvienchinh], [noidungchinh], [tongchiphi], [tongthu]) VALUES (N'F07', N'Vùng Môn', N'NSX05', N'HSX07', N'Ngô Chí C?nh', N'TL04', CAST(N'2017-02-22 00:00:00.000' AS DateTime), CAST(N'2017-03-09 00:00:00.000' AS DateTime), N'Tôn Thư', N'Lã Hạnh', N'Vùng Môn', 500000000, 70000)
INSERT [dbo].[Phim] ([maphim], [tenphim], [manuocsx], [mahangsx], [daodien], [matheloai], [ngaykhoichieu], [ngayketthuc], [nudienvienchinh], [namdienvienchinh], [noidungchinh], [tongchiphi], [tongthu]) VALUES (N'F08', N'Chiến lang', N'NSX05', N'HSX07', N'Cheng Lee', N'TL01', CAST(N'2017-05-01 00:00:00.000' AS DateTime), CAST(N'2017-05-23 00:00:00.000' AS DateTime), N'Vinh Du', N'Saiz Long', N'Chiến Lang', 500000000, 0)
INSERT [dbo].[Phim] ([maphim], [tenphim], [manuocsx], [mahangsx], [daodien], [matheloai], [ngaykhoichieu], [ngayketthuc], [nudienvienchinh], [namdienvienchinh], [noidungchinh], [tongchiphi], [tongthu]) VALUES (N'F09', N'Mất ngủ', N'NSX04', N'HSX01', N'Jan Bi', N'TL06', CAST(N'2016-05-18 00:00:00.000' AS DateTime), CAST(N'2016-06-23 00:00:00.000' AS DateTime), N'Twj Woo', N'Po Lab', N'Mất ngủ', 1234000000, 0)
INSERT [dbo].[Phim] ([maphim], [tenphim], [manuocsx], [mahangsx], [daodien], [matheloai], [ngaykhoichieu], [ngayketthuc], [nudienvienchinh], [namdienvienchinh], [noidungchinh], [tongchiphi], [tongthu]) VALUES (N'F10', N'Aladin và vua trộm', N'NSX01', N'HSX07', N'Robert Wall', N'TL03', CAST(N'2017-11-02 00:00:00.000' AS DateTime), CAST(N'2017-12-04 00:00:00.000' AS DateTime), N'Kenne', N'Mosses', N'Aladin và vua trộm', 1000200000, 1400000000)
INSERT [dbo].[Phim] ([maphim], [tenphim], [manuocsx], [mahangsx], [daodien], [matheloai], [ngaykhoichieu], [ngayketthuc], [nudienvienchinh], [namdienvienchinh], [noidungchinh], [tongchiphi], [tongthu]) VALUES (N'F11', N'Đám tang mèo', N'NSX07', N'HSX02', N'Choise Lams', N'TL06', CAST(N'2016-02-23 00:00:00.000' AS DateTime), CAST(N'2016-03-29 00:00:00.000' AS DateTime), N'The Hook', N'Che Jean', N'Đám tang mèo', 1000200000, 1400000000)
INSERT [dbo].[PhongChieu] ([marap], [maphong], [tenphong], [soghe]) VALUES (N'R01', N'P01', N'P101', 100)
INSERT [dbo].[PhongChieu] ([marap], [maphong], [tenphong], [soghe]) VALUES (N'R01', N'P02', N'P102', 100)
INSERT [dbo].[PhongChieu] ([marap], [maphong], [tenphong], [soghe]) VALUES (N'R01', N'P03', N'P103', 100)
INSERT [dbo].[PhongChieu] ([marap], [maphong], [tenphong], [soghe]) VALUES (N'R02', N'P04', N'P101', 100)
INSERT [dbo].[PhongChieu] ([marap], [maphong], [tenphong], [soghe]) VALUES (N'R02', N'P05', N'P102', 100)
INSERT [dbo].[PhongChieu] ([marap], [maphong], [tenphong], [soghe]) VALUES (N'R02', N'P06', N'P201', 100)
INSERT [dbo].[PhongChieu] ([marap], [maphong], [tenphong], [soghe]) VALUES (N'R03', N'P07', N'P202', 100)
INSERT [dbo].[PhongChieu] ([marap], [maphong], [tenphong], [soghe]) VALUES (N'R04', N'P08', N'P203', 100)
INSERT [dbo].[PhongChieu] ([marap], [maphong], [tenphong], [soghe]) VALUES (N'R05', N'P09', N'P102', 100)
INSERT [dbo].[PhongChieu] ([marap], [maphong], [tenphong], [soghe]) VALUES (N'R04', N'P10', N'P202', 100)
INSERT [dbo].[Rap] ([marap], [tenrap], [diachi], [dienthoai], [sophong], [tongsoghe]) VALUES (N'R01', N'Rap Chieu Phim QG', N'87 Lang Ha-Ha Noi', N'01684710281', 5, 300)
INSERT [dbo].[Rap] ([marap], [tenrap], [diachi], [dienthoai], [sophong], [tongsoghe]) VALUES (N'R02', N'Rap Chieu Phim Lotte Xuan Thuy', N'213 Xuan Thuy-Ha Noi', N'01684710281', 2, 300)
INSERT [dbo].[Rap] ([marap], [tenrap], [diachi], [dienthoai], [sophong], [tongsoghe]) VALUES (N'R03', N'Rap Chieu Phim CGV Vincom Ba Trieu', N'89 Ba Trieu-Ha Noi', N'01684710281', 4, 100)
INSERT [dbo].[Rap] ([marap], [tenrap], [diachi], [dienthoai], [sophong], [tongsoghe]) VALUES (N'R04', N'Rap Chieu Phim CGV Keangnam', N'72 Pham Hung-Ha Noi', N'01684710281', 3, 200)
INSERT [dbo].[Rap] ([marap], [tenrap], [diachi], [dienthoai], [sophong], [tongsoghe]) VALUES (N'R05', N'Rap Chieu Phim BestMall', N'Nga Tu Nhon-Ha Noi', N'01684710281', 2, 100)
INSERT [dbo].[TaiKhoan] ([userName], [password], [tenhienthi], [loaitaikhoan]) VALUES (N'admin1', N'c4ca4238a0b923820dcc509a6f75849b', N'Back', 1)
INSERT [dbo].[TaiKhoan] ([userName], [password], [tenhienthi], [loaitaikhoan]) VALUES (N'admin2', N'c4ca4238a0b923820dcc509a6f75849b', N'nhầm tên rồi', 0)
INSERT [dbo].[TaiKhoan] ([userName], [password], [tenhienthi], [loaitaikhoan]) VALUES (N'admin3', N'c4ca4238a0b923820dcc509a6f75849b', N'1', 0)
INSERT [dbo].[TaiKhoan] ([userName], [password], [tenhienthi], [loaitaikhoan]) VALUES (N'admin4', N'c4ca4238a0b923820dcc509a6f75849b', N'1', 0)
INSERT [dbo].[TaiKhoan] ([userName], [password], [tenhienthi], [loaitaikhoan]) VALUES (N'admin5', N'c4ca4238a0b923820dcc509a6f75849b', N'1', 0)
INSERT [dbo].[TheLoai] ([matheloai], [tentheloai]) VALUES (N'TL01', N'Hanh dong')
INSERT [dbo].[TheLoai] ([matheloai], [tentheloai]) VALUES (N'TL02', N'Hai huoc')
INSERT [dbo].[TheLoai] ([matheloai], [tentheloai]) VALUES (N'TL03', N'Hoat hinh')
INSERT [dbo].[TheLoai] ([matheloai], [tentheloai]) VALUES (N'TL04', N'KH-Vien tuong')
INSERT [dbo].[TheLoai] ([matheloai], [tentheloai]) VALUES (N'TL05', N'Tam ly-tinh cam')
INSERT [dbo].[TheLoai] ([matheloai], [tentheloai]) VALUES (N'TL06', N'Kinh di')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N'S01', N'V01', N'A', 1, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N'S01', N'V02', N'B', 2, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N'S01', N'V03', N'H', 2, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N'S02', N'V04', N'A', 3, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N'S02', N'V05', N'A', 1, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N'S02', N'V06', N'B', 5, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N'S03', N'V07', N'A', 1, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N'S03', N'V08', N'G', 1, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N'S03', N'V09', N'A', 6, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N'S04', N'V10', N'J', 3, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N'S04', N'V11', N'A', 3, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N'S05', N'V12', N'B', 2, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N'S06', N'V13', N'C', 4, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N'S07', N'V01', N'A', 1, N'Đã bán')
ALTER TABLE [dbo].[BuoiChieu]  WITH CHECK ADD  CONSTRAINT [fk_BuoiChieu_MaGioChieu] FOREIGN KEY([magiochieu])
REFERENCES [dbo].[GioChieu] ([magiochieu])
GO
ALTER TABLE [dbo].[BuoiChieu] CHECK CONSTRAINT [fk_BuoiChieu_MaGioChieu]
GO
ALTER TABLE [dbo].[BuoiChieu]  WITH CHECK ADD  CONSTRAINT [fk_BuoiChieu_MaPhim] FOREIGN KEY([maphim])
REFERENCES [dbo].[Phim] ([maphim])
GO
ALTER TABLE [dbo].[BuoiChieu] CHECK CONSTRAINT [fk_BuoiChieu_MaPhim]
GO
ALTER TABLE [dbo].[BuoiChieu]  WITH CHECK ADD  CONSTRAINT [fk_BuoiChieu_MaPhong] FOREIGN KEY([maphong])
REFERENCES [dbo].[PhongChieu] ([maphong])
GO
ALTER TABLE [dbo].[BuoiChieu] CHECK CONSTRAINT [fk_BuoiChieu_MaPhong]
GO
ALTER TABLE [dbo].[BuoiChieu]  WITH CHECK ADD  CONSTRAINT [fk_BuoiChieu_MaRap] FOREIGN KEY([marap])
REFERENCES [dbo].[Rap] ([marap])
GO
ALTER TABLE [dbo].[BuoiChieu] CHECK CONSTRAINT [fk_BuoiChieu_MaRap]
GO
ALTER TABLE [dbo].[Phim]  WITH CHECK ADD  CONSTRAINT [fk_Phim_MaHangSX] FOREIGN KEY([mahangsx])
REFERENCES [dbo].[HangSX] ([mahangsx])
GO
ALTER TABLE [dbo].[Phim] CHECK CONSTRAINT [fk_Phim_MaHangSX]
GO
ALTER TABLE [dbo].[Phim]  WITH CHECK ADD  CONSTRAINT [fk_Phim_MaNuocSX] FOREIGN KEY([manuocsx])
REFERENCES [dbo].[NuocSanXuat] ([manuocsx])
GO
ALTER TABLE [dbo].[Phim] CHECK CONSTRAINT [fk_Phim_MaNuocSX]
GO
ALTER TABLE [dbo].[Phim]  WITH CHECK ADD  CONSTRAINT [fk_Phim_MaTheLoai] FOREIGN KEY([matheloai])
REFERENCES [dbo].[TheLoai] ([matheloai])
GO
ALTER TABLE [dbo].[Phim] CHECK CONSTRAINT [fk_Phim_MaTheLoai]
GO
ALTER TABLE [dbo].[PhongChieu]  WITH CHECK ADD  CONSTRAINT [fk_PhongChieu_MaRap] FOREIGN KEY([marap])
REFERENCES [dbo].[Rap] ([marap])
GO
ALTER TABLE [dbo].[PhongChieu] CHECK CONSTRAINT [fk_PhongChieu_MaRap]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [fk_Ve_MaShow] FOREIGN KEY([mashow])
REFERENCES [dbo].[BuoiChieu] ([mashow])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [fk_Ve_MaShow]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllFilm]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetAllFilm]
AS
    BEGIN

        SELECT  p.maphim ,
                p.tenphim ,
                n.tennuocsx ,
                h.tenhangsx ,
                p.daodien ,
                t.tentheloai ,
                p.ngaykhoichieu ,
                p.ngayketthuc ,
                p.nudienvienchinh ,
                p.namdienvienchinh ,
                p.noidungchinh ,
                p.tongchiphi ,
                p.tongthu
        FROM    dbo.Phim AS p ,
                dbo.HangSX AS h ,
                dbo.NuocSanXuat AS n ,
                dbo.TheLoai AS t
        WHERE   p.manuocsx = n.manuocsx
                AND p.mahangsx = h.mahangsx
                AND p.matheloai = t.matheloai

    END

GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_Login]
@username VARCHAR(50), @password VARCHAR(50)
AS BEGIN
	SELECT * FROM dbo.TaiKhoan WHERE userName = @username AND password = @password
END

GO
/****** Object:  StoredProcedure [dbo].[USP_XoaBuoiChieu]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_XoaBuoiChieu] @mashow VARCHAR(50)
AS
	BEGIN
		DELETE dbo.Ve WHERE mashow = @mashow
		DELETE dbo.BuoiChieu WHERE mashow = @mashow
	END

GO
/****** Object:  StoredProcedure [dbo].[USP_XoaGioChieu]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_XoaGioChieu] @magiochieu VARCHAR(50)
AS
    BEGIN
		;WITH Show AS (SELECT mashow FROM dbo.BuoiChieu WHERE magiochieu = @magiochieu)
		DELETE dbo.Ve WHERE mashow IN ( SELECT * FROM Show)
		DELETE dbo.BuoiChieu WHERE magiochieu = @magiochieu
		DELETE dbo.GioChieu WHERE magiochieu = @magiochieu
    END

GO
/****** Object:  StoredProcedure [dbo].[USP_XoaHangSX]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_XoaHangSX] @mahangsx VARCHAR(50)
AS
    BEGIN
		SELECT maphim INTO Film FROM dbo.Phim WHERE mahangsx = @mahangsx;
		WITH Show AS (SELECT mashow FROM dbo.BuoiChieu WHERE maphim IN (SELECT * FROM Film))
		DELETE dbo.Ve WHERE mashow IN ( SELECT * FROM Show)
		DELETE dbo.BuoiChieu WHERE maphim IN (SELECT * FROM Film)
		DELETE dbo.Phim WHERE mahangsx = @mahangsx
		DELETE dbo.HangSX WHERE mahangsx = @mahangsx
		DROP TABLE Film
    END

GO
/****** Object:  StoredProcedure [dbo].[USP_XoaNuocSX]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_XoaNuocSX] @manuocsx VARCHAR(50)
AS
    BEGIN
		SELECT maphim INTO Film FROM dbo.Phim WHERE manuocsx = @manuocsx;
		WITH Show AS (SELECT mashow FROM dbo.BuoiChieu WHERE maphim IN (SELECT * FROM Film))
		DELETE dbo.Ve WHERE mashow IN ( SELECT * FROM Show)
		DELETE dbo.BuoiChieu WHERE maphim IN (SELECT * FROM Film)
		DELETE dbo.Phim WHERE manuocsx = @manuocsx
		DELETE dbo.NuocSanXuat WHERE manuocsx = @manuocsx
		DROP TABLE Film
    END

GO
/****** Object:  StoredProcedure [dbo].[USP_XoaPhim]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_XoaPhim]
@maphim VARCHAR(50)
AS 
BEGIN
	;WITH Show AS (SELECT mashow FROM dbo.BuoiChieu WHERE maphim =@maphim)
	DELETE dbo.Ve WHERE mashow IN ( SELECT * FROM Show)
	DELETE dbo.BuoiChieu WHERE maphim = @maphim
	DELETE dbo.Phim WHERE maphim = @maphim
END

GO
/****** Object:  StoredProcedure [dbo].[USP_XoaPhongChieu]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_XoaPhongChieu] @maphongchieu VARCHAR(50)
AS
    BEGIN
		;WITH Show AS (SELECT mashow FROM dbo.BuoiChieu WHERE maphong = @maphongchieu)
		DELETE dbo.Ve WHERE mashow IN ( SELECT * FROM Show)
		DELETE dbo.BuoiChieu WHERE maphong = @maphongchieu
		DELETE dbo.PhongChieu WHERE maphong = @maphongchieu
    END

GO
/****** Object:  StoredProcedure [dbo].[USP_XoaRapChieu]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_XoaRapChieu] @marapchieu VARCHAR(50)
AS
	BEGIN
		;WITH Show AS (SELECT mashow FROM dbo.BuoiChieu WHERE marap = @marapchieu)
		DELETE dbo.Ve WHERE mashow IN ( SELECT * FROM Show)
		DELETE dbo.BuoiChieu WHERE marap = @marapchieu
		DELETE dbo.PhongChieu WHERE marap = @marapchieu
		DELETE dbo.Rap WHERE marap = @marapchieu
	END

GO
/****** Object:  StoredProcedure [dbo].[USP_XoaTheLoai]    Script Date: 11/06/2017 12:16:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_XoaTheLoai] @matheloai VARCHAR(50)
AS
    BEGIN
		SELECT maphim INTO Film FROM dbo.Phim WHERE matheloai = @matheloai;
		WITH Show AS (SELECT mashow FROM dbo.BuoiChieu WHERE maphim IN (SELECT * FROM Film))
		DELETE dbo.Ve WHERE mashow IN ( SELECT * FROM Show)
		DELETE dbo.BuoiChieu WHERE maphim IN (SELECT * FROM Film)
		DELETE dbo.Phim WHERE matheloai = @matheloai
		DELETE dbo.TheLoai WHERE matheloai = @matheloai
		DROP TABLE Film
    END

GO
USE [master]
GO
ALTER DATABASE [CinemaManagement] SET  READ_WRITE 
GO
