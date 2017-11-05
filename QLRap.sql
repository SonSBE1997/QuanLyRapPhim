/****** Object:  Database [CinemaManagement]    Script Date: 11/05/2017 9:21:16 PM ******/
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
/****** Object:  Table [dbo].[BuoiChieu]    Script Date: 11/05/2017 9:21:16 PM ******/
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
/****** Object:  Table [dbo].[GioChieu]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  Table [dbo].[HangSX]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  Table [dbo].[NuocSanXuat]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  Table [dbo].[Phim]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  Table [dbo].[PhongChieu]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  Table [dbo].[Rap]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  Table [dbo].[TheLoai]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  Table [dbo].[Ve]    Script Date: 11/05/2017 9:21:17 PM ******/
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
INSERT [dbo].[BuoiChieu] ([mashow], [maphim], [marap], [maphong], [ngaychieu], [magiochieu], [sovedaban], [tongtien]) VALUES (N's1', N'p1', N'r2', N'p112', CAST(N'2017-01-21 00:00:00.000' AS DateTime), N'10h', 60, 3000000)
INSERT [dbo].[BuoiChieu] ([mashow], [maphim], [marap], [maphong], [ngaychieu], [magiochieu], [sovedaban], [tongtien]) VALUES (N's2', N'p2', N'r1', N'p1', CAST(N'2017-07-12 00:00:00.000' AS DateTime), N'3h', 70, 4200000)
INSERT [dbo].[BuoiChieu] ([mashow], [maphim], [marap], [maphong], [ngaychieu], [magiochieu], [sovedaban], [tongtien]) VALUES (N's3', N'p1', N'r1', N'p1', CAST(N'2017-11-05 00:00:00.000' AS DateTime), N'10h', 0, 0)
INSERT [dbo].[GioChieu] ([magiochieu], [dongia]) VALUES (N'10h', 50000)
INSERT [dbo].[GioChieu] ([magiochieu], [dongia]) VALUES (N'3h', 60000)
INSERT [dbo].[GioChieu] ([magiochieu], [dongia]) VALUES (N'4h', 65000)
INSERT [dbo].[GioChieu] ([magiochieu], [dongia]) VALUES (N'5h30', 70000)
INSERT [dbo].[GioChieu] ([magiochieu], [dongia]) VALUES (N'8h', 65000)
INSERT [dbo].[HangSX] ([mahangsx], [tenhangsx]) VALUES (N'1', N'1')
INSERT [dbo].[HangSX] ([mahangsx], [tenhangsx]) VALUES (N'25', N'20TH CENTURY FOX')
INSERT [dbo].[HangSX] ([mahangsx], [tenhangsx]) VALUES (N'C6', N'COMCAST')
INSERT [dbo].[HangSX] ([mahangsx], [tenhangsx]) VALUES (N'S2', N'SONY PICTURES')
INSERT [dbo].[HangSX] ([mahangsx], [tenhangsx]) VALUES (N'V4', N'VIACOM')
INSERT [dbo].[HangSX] ([mahangsx], [tenhangsx]) VALUES (N'W1', N'WARNER BROS')
INSERT [dbo].[HangSX] ([mahangsx], [tenhangsx]) VALUES (N'W3', N' WALT DISNEY PICTURES')
INSERT [dbo].[NuocSanXuat] ([manuocsx], [tennuocsx]) VALUES (N'CHI', N'Trung Quốc')
INSERT [dbo].[NuocSanXuat] ([manuocsx], [tennuocsx]) VALUES (N'ENG', N'Anh')
INSERT [dbo].[NuocSanXuat] ([manuocsx], [tennuocsx]) VALUES (N'FRA', N'Pháp')
INSERT [dbo].[NuocSanXuat] ([manuocsx], [tennuocsx]) VALUES (N'IND', N'Ấn độ')
INSERT [dbo].[NuocSanXuat] ([manuocsx], [tennuocsx]) VALUES (N'JAP', N'Nhật Bản')
INSERT [dbo].[NuocSanXuat] ([manuocsx], [tennuocsx]) VALUES (N'THA', N'Thái Lan')
INSERT [dbo].[NuocSanXuat] ([manuocsx], [tennuocsx]) VALUES (N'USA', N'Hoa Kì')
INSERT [dbo].[NuocSanXuat] ([manuocsx], [tennuocsx]) VALUES (N'VIE', N'Việt Nam')
INSERT [dbo].[Phim] ([maphim], [tenphim], [manuocsx], [mahangsx], [daodien], [matheloai], [ngaykhoichieu], [ngayketthuc], [nudienvienchinh], [namdienvienchinh], [noidungchinh], [tongchiphi], [tongthu]) VALUES (N'p1', N'phim 1', N'ENG', N'1', N'a', N'action', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-11 00:00:00.000' AS DateTime), N'a', N'a', N'a', 10000, 1000)
INSERT [dbo].[Phim] ([maphim], [tenphim], [manuocsx], [mahangsx], [daodien], [matheloai], [ngaykhoichieu], [ngayketthuc], [nudienvienchinh], [namdienvienchinh], [noidungchinh], [tongchiphi], [tongthu]) VALUES (N'p2', N'p1', N'IND', N'1', N'b', N'action', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-02-22 00:00:00.000' AS DateTime), N'a', N'a', N'a', 121, 121)
INSERT [dbo].[PhongChieu] ([marap], [maphong], [tenphong], [soghe]) VALUES (N'r1', N'p1', N'Phòng 1', 22)
INSERT [dbo].[PhongChieu] ([marap], [maphong], [tenphong], [soghe]) VALUES (N'r2', N'p112', N'Phòng 112', 45)
INSERT [dbo].[PhongChieu] ([marap], [maphong], [tenphong], [soghe]) VALUES (N'r2', N'p121', N'Phòng 121', 55)
INSERT [dbo].[PhongChieu] ([marap], [maphong], [tenphong], [soghe]) VALUES (N'r2', N'p1212', N'Phòng 1212', 56)
INSERT [dbo].[PhongChieu] ([marap], [maphong], [tenphong], [soghe]) VALUES (N'r1', N'p2', N'Phòng 2', 56)
INSERT [dbo].[Rap] ([marap], [tenrap], [diachi], [dienthoai], [sophong], [tongsoghe]) VALUES (N'r1', N'Rạp chiếu phim Quốc Gia', N'87 Láng Hạ, Quận Ba Đình, Hà Nội', N'0435141791', 12, 1185)
INSERT [dbo].[Rap] ([marap], [tenrap], [diachi], [dienthoai], [sophong], [tongsoghe]) VALUES (N'r2', N'Rạp Lotte Cinema Landmark', N'Tấng 6 Parkson, Tòa nhà Keangnam, E6 Phạm Hùng, Q. Cầu Giấy, Hà Nội ', N'043837 8031', 12, 1231)
INSERT [dbo].[TaiKhoan] ([userName], [password], [tenhienthi], [loaitaikhoan]) VALUES (N'admin1', N'c4ca4238a0b923820dcc509a6f75849b', N'Back', 1)
INSERT [dbo].[TaiKhoan] ([userName], [password], [tenhienthi], [loaitaikhoan]) VALUES (N'admin2', N'c4ca4238a0b923820dcc509a6f75849b', N'nhầm tên rồi', 0)
INSERT [dbo].[TaiKhoan] ([userName], [password], [tenhienthi], [loaitaikhoan]) VALUES (N'admin3', N'c4ca4238a0b923820dcc509a6f75849b', N'1', 0)
INSERT [dbo].[TaiKhoan] ([userName], [password], [tenhienthi], [loaitaikhoan]) VALUES (N'admin4', N'c4ca4238a0b923820dcc509a6f75849b', N'1', 0)
INSERT [dbo].[TaiKhoan] ([userName], [password], [tenhienthi], [loaitaikhoan]) VALUES (N'admin5', N'c4ca4238a0b923820dcc509a6f75849b', N'1', 0)
INSERT [dbo].[TheLoai] ([matheloai], [tentheloai]) VALUES (N'action', N'Hành động')
INSERT [dbo].[TheLoai] ([matheloai], [tentheloai]) VALUES (N'adventure ', N'Phiêu lưu')
INSERT [dbo].[TheLoai] ([matheloai], [tentheloai]) VALUES (N'Cartoon', N'Hoạt hình')
INSERT [dbo].[TheLoai] ([matheloai], [tentheloai]) VALUES (N'drama', N'Tâm lý')
INSERT [dbo].[TheLoai] ([matheloai], [tentheloai]) VALUES (N'horror', N'Kinh dị')
INSERT [dbo].[TheLoai] ([matheloai], [tentheloai]) VALUES (N'war ', N'Chiến tranh')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v0', N'h1', 0, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v1', N'1', 1, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v10', N'h1', 10, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v11', N'h2', 0, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v12', N'h2', 1, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v13', N'h2', 2, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v14', N'h2', 3, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v15', N'h2', 4, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v16', N'h2', 5, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v17', N'h2', 6, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v18', N'h2', 7, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v19', N'h2', 8, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v2', N'h1', 2, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v20', N'h2', 9, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v21', N'h2', 10, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v3', N'1', 1, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v4', N'h1', 4, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v5', N'h1', 5, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v6', N'h1', 6, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v7', N'h1', 7, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v8', N'h1', 8, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's1', N'v9', N'h1', 9, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v22', N'h2', 0, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v23', N'h2', 1, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v24', N'h2', 2, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v25', N'h2', 3, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v26', N'h2', 4, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v27', N'h2', 5, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v28', N'h2', 6, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v29', N'h2', 7, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v30', N'h2', 8, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v31', N'h2', 9, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v32', N'h2', 10, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v33', N'h3', 0, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v34', N'h3', 1, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v35', N'h3', 2, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v36', N'h3', 3, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v37', N'h3', 4, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v38', N'h3', 5, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v39', N'h3', 6, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v40', N'h3', 7, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v41', N'h3', 8, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v42', N'h3', 9, N'Chưa bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's2', N'v43', N'h3', 10, N'Đã bán')
INSERT [dbo].[Ve] ([mashow], [mave], [hangghe], [soghe], [trangthai]) VALUES (N's3', N'3', N'3', 2, N'Đã bán')
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
/****** Object:  StoredProcedure [dbo].[USP_GetAllFilm]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  StoredProcedure [dbo].[USP_XoaBuoiChieu]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  StoredProcedure [dbo].[USP_XoaGioChieu]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  StoredProcedure [dbo].[USP_XoaHangSX]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  StoredProcedure [dbo].[USP_XoaNuocSX]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  StoredProcedure [dbo].[USP_XoaPhim]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  StoredProcedure [dbo].[USP_XoaPhongChieu]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  StoredProcedure [dbo].[USP_XoaRapChieu]    Script Date: 11/05/2017 9:21:17 PM ******/
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
/****** Object:  StoredProcedure [dbo].[USP_XoaTheLoai]    Script Date: 11/05/2017 9:21:17 PM ******/
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
ALTER DATABASE [CinemaManagement] SET  READ_WRITE 
GO
