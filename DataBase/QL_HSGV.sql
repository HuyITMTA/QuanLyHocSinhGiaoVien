USE [master]
GO
/****** Object:  Database [QL_HSGV]    Script Date: 5/28/2017 10:47:54 PM ******/
CREATE DATABASE [QL_HSGV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_HSGV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QL_HSGV.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QL_HSGV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QL_HSGV_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QL_HSGV] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_HSGV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_HSGV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_HSGV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_HSGV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_HSGV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_HSGV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_HSGV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_HSGV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_HSGV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_HSGV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_HSGV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_HSGV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_HSGV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_HSGV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_HSGV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_HSGV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QL_HSGV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_HSGV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_HSGV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_HSGV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_HSGV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_HSGV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_HSGV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_HSGV] SET RECOVERY FULL 
GO
ALTER DATABASE [QL_HSGV] SET  MULTI_USER 
GO
ALTER DATABASE [QL_HSGV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_HSGV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_HSGV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_HSGV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QL_HSGV] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QL_HSGV', N'ON'
GO
USE [QL_HSGV]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 5/28/2017 10:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGV] [nchar](10) NOT NULL,
	[TenGV] [nvarchar](30) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaMH] [nchar](10) NULL,
	[DienThoai] [nchar](11) NULL,
	[LoaiThiDua] [nvarchar](50) NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 5/28/2017 10:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHS] [nchar](10) NOT NULL,
	[TenHS] [nvarchar](30) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Lop] [nchar](10) NULL,
	[HanhKiem] [nchar](10) NULL,
	[HocLuc] [nchar](10) NULL,
 CONSTRAINT [PK_HocSinh] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LichDayHoc]    Script Date: 5/28/2017 10:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichDayHoc](
	[MaGV] [nchar](10) NOT NULL,
	[MaLop] [nchar](10) NOT NULL,
	[Thu] [nchar](10) NULL,
	[Tiet] [nchar](10) NULL,
 CONSTRAINT [PK_LichDayHoc] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC,
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lop]    Script Date: 5/28/2017 10:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [nchar](10) NOT NULL,
	[TenLop] [nvarchar](30) NULL,
	[SiSo] [nchar](2) NULL,
	[GVCN] [nchar](10) NULL,
	[PhongHoc] [nchar](10) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 5/28/2017 10:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [nchar](10) NOT NULL,
	[TenMH] [nvarchar](30) NULL,
	[BoMon] [nvarchar](30) NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 5/28/2017 10:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[TenDangNhap] [nchar](30) NOT NULL,
	[MatKhau] [nchar](30) NOT NULL,
	[Quyen] [nchar](10) NOT NULL
) ON [PRIMARY]

GO
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaySinh], [GioiTinh], [DiaChi], [MaMH], [DienThoai], [LoaiThiDua]) VALUES (N'GV05      ', N'Nguyễn Quang Hòa', CAST(N'1996-05-09 00:00:00.000' AS DateTime), N'Nam', N'HCMC', N'Ly        ', N'0936563369 ', N'Hoàn thành tốt nhiệm vụ')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaySinh], [GioiTinh], [DiaChi], [MaMH], [DienThoai], [LoaiThiDua]) VALUES (N'GV06      ', N'Đằng Thùy Trâm', CAST(N'1981-06-22 00:00:00.000' AS DateTime), N'Nữ', N'Cà Mau', N'Toa       ', N'01575368157', N'Hoàn thành nhiệm vụ')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaySinh], [GioiTinh], [DiaChi], [MaMH], [DienThoai], [LoaiThiDua]) VALUES (N'GV07      ', N'Nguyễn Phong Săc', CAST(N'1962-12-12 00:00:00.000' AS DateTime), N'Nam', N'Lào Cai', N'Van       ', N'0961514616 ', N'Chưa hoàn thành nhiệm vụ')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaySinh], [GioiTinh], [DiaChi], [MaMH], [DienThoai], [LoaiThiDua]) VALUES (N'GV08      ', N'Lê Đức Huy', CAST(N'1975-11-30 00:00:00.000' AS DateTime), N'Nam', N'Quảng Ninh', N'Ly        ', N'0882265655 ', N'Hoàn thành tốt nhiệm vụ')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaySinh], [GioiTinh], [DiaChi], [MaMH], [DienThoai], [LoaiThiDua]) VALUES (N'GV09      ', N'Phạm Hùng', CAST(N'1987-04-14 00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', N'GDCD      ', N'01450592696', N'Hoàn thành nhiệm vụ')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaySinh], [GioiTinh], [DiaChi], [MaMH], [DienThoai], [LoaiThiDua]) VALUES (N'GV10      ', N' Nguyễn Trãi', CAST(N'1987-01-05 00:00:00.000' AS DateTime), N'Nam', N'Hải Dương', N'Toa       ', N'01584953217', N'Hoàn thành nhiệm vụ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS02      ', N'Hoàng Quốc Huy', CAST(N'1996-06-10 00:00:00.000' AS DateTime), N'Nam', N'Hải Phòng', N'10b       ', N'Trung bình', N'Khá       ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS03      ', N'Mã Văn Tài', CAST(N'1996-05-11 00:00:00.000' AS DateTime), N'Nữ', N'Bình Định', N'10b       ', N'Khá       ', N'Trung Bình')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS04      ', N'Phan Quân', CAST(N'1996-07-21 00:00:00.000' AS DateTime), N'Nam', N'Sơn La', N'10b       ', N'Tốt       ', N'Giỏi      ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS05      ', N'Phan Hải', CAST(N'1996-08-12 00:00:00.000' AS DateTime), N'Nam', N'Sơn La', N'10c       ', N'Trung Bình', N'Kém       ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS06      ', N'Lê Thành', CAST(N'1996-12-06 00:00:00.000' AS DateTime), N'Nam', N'Sơn La', N'10c       ', N'Khá       ', N'Giỏi      ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS07      ', N'Lương Bổng', CAST(N'1996-01-15 00:00:00.000' AS DateTime), N'Nữ', N'Cà Mau', N'10d       ', N'Khá       ', N'Giỏi      ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS08      ', N'Huy Kình', CAST(N'1996-12-04 00:00:00.000' AS DateTime), N'Nam', N'Thanh Hóa', N'10d       ', N'Trung Bình', N'Trung Bình')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS09      ', N'Huy Bá', CAST(N'1996-12-04 00:00:00.000' AS DateTime), N'Nam', N'Thanh Hóa', N'10d       ', N'Tốt       ', N'Giỏi      ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS10      ', N'Bảo Ngậu', CAST(N'1996-06-08 00:00:00.000' AS DateTime), N'Nữ', N'Hà Nam', N'11a       ', N'Tốt       ', N'Giỏi      ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS11      ', N'Sở Khanh', CAST(N'1996-07-26 00:00:00.000' AS DateTime), N'Nam', N'Quảng Ninh', N'11a       ', N'Trung Bình', N'Yếu       ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS12      ', N'Sơn Tung MTP', CAST(N'1994-07-05 00:00:00.000' AS DateTime), N'Nam', N'Thái Bình', N'11b       ', N'Khá       ', N'Giỏi      ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS13      ', N'Tuấn Hưng', CAST(N'1978-12-05 00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', N'11b       ', N'Trung Bình', N'Khá       ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS14      ', N'Bảo Thy', CAST(N'1985-08-07 00:00:00.000' AS DateTime), N'Nữ', N'Cần Thơ', NULL, N'Khá       ', N'Khá       ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS15      ', N'Lương Bằng Quang', CAST(N'1996-11-27 00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', N'10a       ', N'Trung Bình', N'Khá       ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS16      ', N'Yến Xôi', CAST(N'1996-02-14 00:00:00.000' AS DateTime), N'Nữ', N'Hà Nội', N'10a       ', N'Trung Bình', N'Khá       ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS17      ', N'Trung Ruồi', CAST(N'1995-11-23 00:00:00.000' AS DateTime), N'Nam', N'Cô Đô Nhuê', N'10a       ', N'Khá       ', N'Giỏi      ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS18      ', N'Minh Tít', CAST(N'1994-10-14 00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', N'10b       ', N'Khá       ', N'Khá       ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS19      ', N'Yến Nhi', CAST(N'1995-06-16 00:00:00.000' AS DateTime), N'Nữ', N'Hải Phòng', N'10b       ', N'Tốt       ', N'Giỏi      ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS20      ', N'Đan Trường', CAST(N'1984-05-28 00:00:00.000' AS DateTime), N'Nữ', N'HCMC', N'10c       ', N'Khá       ', N'Khá       ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS205     ', N'Nguyễn Quang Huy', CAST(N'1996-05-20 00:00:00.000' AS DateTime), N'Nam', N'Hải Dương', N'10a       ', N'Trung Bình', N'Khá       ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS21      ', N'Donal Trump', CAST(N'1970-02-03 00:00:00.000' AS DateTime), N'Nam', N'New York', N'11a       ', N'Trung bình', N'Yếu       ')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [DiaChi], [Lop], [HanhKiem], [HocLuc]) VALUES (N'HS22      ', N'Ngô Kiến Huy', CAST(N'1999-06-15 00:00:00.000' AS DateTime), N'Nam', N'Phú Thọ', N'10a       ', N'Khá       ', N'Khá       ')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [GVCN], [PhongHoc]) VALUES (N'10a       ', N'10A', N'39', N'GV05      ', N'0601      ')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [GVCN], [PhongHoc]) VALUES (N'10b       ', N'10B', N'40', N'GV09      ', N'0602      ')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [GVCN], [PhongHoc]) VALUES (N'10c       ', N'10C', N'39', N'GV10      ', N'0603      ')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [GVCN], [PhongHoc]) VALUES (N'10d       ', N'10D', N'38', N'GV06      ', N'0604      ')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [GVCN], [PhongHoc]) VALUES (N'11a       ', N'11A', N'39', N'GV07      ', N'0605      ')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [GVCN], [PhongHoc]) VALUES (N'11b       ', N'11B', N'38', N'GV08      ', N'0606      ')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [BoMon]) VALUES (N'GDCD      ', N'Giáo dục công dân', N'Tự Nhiên')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [BoMon]) VALUES (N'Hoa       ', N'Hóa Học', N'Tự Nhiên')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [BoMon]) VALUES (N'Ly        ', N'Vật Lý', N'Tự Nhiên')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [BoMon]) VALUES (N'TA        ', N'Tiếng Anh', N'Tự Nhiên')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [BoMon]) VALUES (N'TD        ', N'Thể dục', N'Tự Nhiên')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [BoMon]) VALUES (N'Toa       ', N'Toán', N'Tự Nhiên')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [BoMon]) VALUES (N'Van       ', N'Văn', N'Xã Hội')
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_MonHoc] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_MonHoc]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_Lop] FOREIGN KEY([Lop])
REFERENCES [dbo].[Lop] ([MaLop])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_Lop]
GO
ALTER TABLE [dbo].[LichDayHoc]  WITH CHECK ADD  CONSTRAINT [FK_LichDayHoc_GiaoVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiaoVien] ([MaGV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichDayHoc] CHECK CONSTRAINT [FK_LichDayHoc_GiaoVien]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_GiaoVien] FOREIGN KEY([GVCN])
REFERENCES [dbo].[GiaoVien] ([MaGV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_GiaoVien]
GO
USE [master]
GO
ALTER DATABASE [QL_HSGV] SET  READ_WRITE 
GO
