USE [master]
GO
/****** Object:  Database [QLPhongTro3]    Script Date: 5/18/2023 12:55:14 AM ******/
CREATE DATABASE [QLPhongTro3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLPhongTro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLPhongTro3.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLPhongTro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLPhongTro3_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLPhongTro3] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLPhongTro3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLPhongTro3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLPhongTro3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLPhongTro3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLPhongTro3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLPhongTro3] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLPhongTro3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLPhongTro3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLPhongTro3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLPhongTro3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLPhongTro3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLPhongTro3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLPhongTro3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLPhongTro3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLPhongTro3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLPhongTro3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLPhongTro3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLPhongTro3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLPhongTro3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLPhongTro3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLPhongTro3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLPhongTro3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLPhongTro3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLPhongTro3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLPhongTro3] SET  MULTI_USER 
GO
ALTER DATABASE [QLPhongTro3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLPhongTro3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLPhongTro3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLPhongTro3] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLPhongTro3] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLPhongTro3', N'ON'
GO
USE [QLPhongTro3]
GO
/****** Object:  Table [dbo].[_User]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[_User](
	[username] [varchar](20) NOT NULL,
	[password] [varchar](250) NOT NULL,
 CONSTRAINT [PK_tblQuanLy] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCauHinh]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCauHinh](
	[TenPhongTro] [nvarchar](150) NULL,
	[ChuPhongTro] [nvarchar](50) NOT NULL,
	[DiaChiPhongTro] [nvarchar](250) NOT NULL,
	[SoDienThoai] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblDichVu]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDichVu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDichVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblDichVu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDVChiTiet]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDVChiTiet](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[IDThue] [bigint] NULL,
	[IDLoaiDV] [int] NULL,
	[TuNgay] [date] NULL,
	[ToiNgay] [date] NULL,
	[ChiSoCu] [int] NULL,
	[ChiSoMoi] [int] NULL,
	[DonGia] [int] NULL,
	[DaThanhToan] [tinyint] NULL,
 CONSTRAINT [PK_tblDienNuoc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ho] [nvarchar](10) NULL,
	[TenDem] [nvarchar](20) NULL,
	[Ten] [nvarchar](10) NULL,
	[CMND_CanCuoc] [varchar](10) NULL,
	[DienThoai] [varchar](10) NULL,
	[QueQuan] [nvarchar](150) NULL,
	[HKTT] [nvarchar](150) NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblLoaiPhong]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiPhong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_tblLoaiPhong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPhong]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[IDLoaiPhong] [int] NULL,
	[TrangThai] [tinyint] NULL,
	[DaXoa] [tinyint] NULL CONSTRAINT [DF_tblPhong_DaXoa]  DEFAULT ((0)),
 CONSTRAINT [PK_tblPhong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblThuePhong]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThuePhong](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[IDKhachHang] [int] NULL,
	[IDPhong] [int] NULL,
	[GiaPhong] [int] NULL,
	[TienDatCoc] [int] NULL,
	[NgayThue] [date] NULL,
	[NgayTraPhong] [date] NULL,
	[DaThanhToan] [int] NULL,
 CONSTRAINT [PK_tblThuePhong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[_User] ([username], [password]) VALUES (N'admin', N'admin')
INSERT [dbo].[_User] ([username], [password]) VALUES (N'banana', N'banana')
INSERT [dbo].[_User] ([username], [password]) VALUES (N'Thuy Ngan', N'thuyngan')
INSERT [dbo].[_User] ([username], [password]) VALUES (N'Trong Huy', N'tronghuy')
INSERT [dbo].[_User] ([username], [password]) VALUES (N'Van Hieu', N'vanhieu')
SET IDENTITY_INSERT [dbo].[tblDichVu] ON 

INSERT [dbo].[tblDichVu] ([ID], [TenDichVu]) VALUES (1, N'Điện')
INSERT [dbo].[tblDichVu] ([ID], [TenDichVu]) VALUES (2, N'Nước')
INSERT [dbo].[tblDichVu] ([ID], [TenDichVu]) VALUES (4, N'Internet')
INSERT [dbo].[tblDichVu] ([ID], [TenDichVu]) VALUES (5, N'Vệ sinh')
SET IDENTITY_INSERT [dbo].[tblDichVu] OFF
SET IDENTITY_INSERT [dbo].[tblKhachHang] ON 

INSERT [dbo].[tblKhachHang] ([ID], [Ho], [TenDem], [Ten], [CMND_CanCuoc], [DienThoai], [QueQuan], [HKTT]) VALUES (1, N'Trần ', N'Văn ', N'Hiếu', N'09322222', N'09283746', N'Huế', N'Huế')
INSERT [dbo].[tblKhachHang] ([ID], [Ho], [TenDem], [Ten], [CMND_CanCuoc], [DienThoai], [QueQuan], [HKTT]) VALUES (2, N'Nguyễn', N'Văn ', N'Thanh', N'10322322', N'03334342', N'Quảng Trị', N'Huế')
INSERT [dbo].[tblKhachHang] ([ID], [Ho], [TenDem], [Ten], [CMND_CanCuoc], [DienThoai], [QueQuan], [HKTT]) VALUES (3, N'Đăng', N'Anh', N'Khoa', N'10233556', N'09334555', N'Hà Nội', N'Huế')
INSERT [dbo].[tblKhachHang] ([ID], [Ho], [TenDem], [Ten], [CMND_CanCuoc], [DienThoai], [QueQuan], [HKTT]) VALUES (4, N'Trần', N'Đức', N'Bo', N'190323432', N'0932487922', N'Nghệ An', N'Huế')
INSERT [dbo].[tblKhachHang] ([ID], [Ho], [TenDem], [Ten], [CMND_CanCuoc], [DienThoai], [QueQuan], [HKTT]) VALUES (5, N'Nguyễn', N'Thù', N'Độ', N'190320324', N'098421223', N'Bình Định', N'Huế')
INSERT [dbo].[tblKhachHang] ([ID], [Ho], [TenDem], [Ten], [CMND_CanCuoc], [DienThoai], [QueQuan], [HKTT]) VALUES (6, N'Võ', N'Trọng', N'Huy', N'1099983833', N'0938387363', N'Trung Đông', N'Trung Đông')
INSERT [dbo].[tblKhachHang] ([ID], [Ho], [TenDem], [Ten], [CMND_CanCuoc], [DienThoai], [QueQuan], [HKTT]) VALUES (7, N'Nguyễn', N'Đức', N'Anh', N'1039847799', N'02332344', N'Hà Giang', N'Huế')
INSERT [dbo].[tblKhachHang] ([ID], [Ho], [TenDem], [Ten], [CMND_CanCuoc], [DienThoai], [QueQuan], [HKTT]) VALUES (8, N'Anh', N'Lộc', N'FuHo', N'1099999999', N'0993939393', N'Trung Đông', N'Huế')
SET IDENTITY_INSERT [dbo].[tblKhachHang] OFF
SET IDENTITY_INSERT [dbo].[tblLoaiPhong] ON 

INSERT [dbo].[tblLoaiPhong] ([ID], [TenLoaiPhong], [DonGia]) VALUES (1, N'Phòng đơn', 1000000)
INSERT [dbo].[tblLoaiPhong] ([ID], [TenLoaiPhong], [DonGia]) VALUES (2, N'Phòng đôi', 1250000)
INSERT [dbo].[tblLoaiPhong] ([ID], [TenLoaiPhong], [DonGia]) VALUES (3, N'Phòng lớn', 1000000)
INSERT [dbo].[tblLoaiPhong] ([ID], [TenLoaiPhong], [DonGia]) VALUES (6, N'Phòng đơn 123', 999923)
INSERT [dbo].[tblLoaiPhong] ([ID], [TenLoaiPhong], [DonGia]) VALUES (1007, N'Vip', 1700000)
INSERT [dbo].[tblLoaiPhong] ([ID], [TenLoaiPhong], [DonGia]) VALUES (1008, N'Vip 2', 1900000)
INSERT [dbo].[tblLoaiPhong] ([ID], [TenLoaiPhong], [DonGia]) VALUES (1009, N'Vip 3', 2000000)
SET IDENTITY_INSERT [dbo].[tblLoaiPhong] OFF
SET IDENTITY_INSERT [dbo].[tblPhong] ON 

INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (6, N'D01', 1, 0, 0)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (7, N'D02', 1, 0, 1)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (8, N'D03', 1, 0, 1)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (9, N'V01', 1007, 1, 1)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (10, N'V02', 1007, 0, 0)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (11, N'D03', 1, 1, 0)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (12, N'D02', 1, 0, 0)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (13, N'D03', 1, 0, 0)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (14, N'D04', 1, 0, 0)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (15, N'D05', 1, 0, 0)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (16, N'DD01', 2, 0, 0)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (17, N'DD02', 1, 0, 1)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (18, N'DD03', 1, 0, 1)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (19, N'DD04', 1, 0, 1)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (20, N'DD05', 1, 0, 1)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (21, N'DD02', 2, 0, 0)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (22, N'DD03', 2, 0, 0)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (23, N'DD04', 2, 0, 0)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (24, N'DD05', 2, 0, 0)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (25, N'V01', 1007, 0, 0)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (26, N'V03', 1007, 0, 0)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (27, N'V04', 1007, 0, 0)
INSERT [dbo].[tblPhong] ([ID], [TenPhong], [IDLoaiPhong], [TrangThai], [DaXoa]) VALUES (28, N'V05', 1007, 0, 0)
SET IDENTITY_INSERT [dbo].[tblPhong] OFF
SET IDENTITY_INSERT [dbo].[tblThuePhong] ON 

INSERT [dbo].[tblThuePhong] ([ID], [IDKhachHang], [IDPhong], [GiaPhong], [TienDatCoc], [NgayThue], [NgayTraPhong], [DaThanhToan]) VALUES (43, 2, 10, 1500000, 2000000, CAST(N'2023-04-05' AS Date), CAST(N'2023-04-09' AS Date), 1000000)
INSERT [dbo].[tblThuePhong] ([ID], [IDKhachHang], [IDPhong], [GiaPhong], [TienDatCoc], [NgayThue], [NgayTraPhong], [DaThanhToan]) VALUES (44, 4, 8, 450000, 9000000, CAST(N'2023-04-05' AS Date), CAST(N'2023-04-12' AS Date), 40000)
INSERT [dbo].[tblThuePhong] ([ID], [IDKhachHang], [IDPhong], [GiaPhong], [TienDatCoc], [NgayThue], [NgayTraPhong], [DaThanhToan]) VALUES (45, 5, 8, 450000, 800000, CAST(N'2023-04-05' AS Date), CAST(N'2023-04-06' AS Date), 430000)
INSERT [dbo].[tblThuePhong] ([ID], [IDKhachHang], [IDPhong], [GiaPhong], [TienDatCoc], [NgayThue], [NgayTraPhong], [DaThanhToan]) VALUES (46, 4, 8, 450000, 2000000, CAST(N'2023-04-05' AS Date), CAST(N'2023-08-09' AS Date), 200000)
INSERT [dbo].[tblThuePhong] ([ID], [IDKhachHang], [IDPhong], [GiaPhong], [TienDatCoc], [NgayThue], [NgayTraPhong], [DaThanhToan]) VALUES (58, 2, 9, 1500000, 900000, CAST(N'2023-09-20' AS Date), CAST(N'2024-11-20' AS Date), 1500000)
INSERT [dbo].[tblThuePhong] ([ID], [IDKhachHang], [IDPhong], [GiaPhong], [TienDatCoc], [NgayThue], [NgayTraPhong], [DaThanhToan]) VALUES (60, 2, 7, 450000, 90000000, CAST(N'2023-05-05' AS Date), CAST(N'2023-06-05' AS Date), 450000)
INSERT [dbo].[tblThuePhong] ([ID], [IDKhachHang], [IDPhong], [GiaPhong], [TienDatCoc], [NgayThue], [NgayTraPhong], [DaThanhToan]) VALUES (61, 4, 10, 1500000, 900000000, CAST(N'2023-05-05' AS Date), CAST(N'2023-11-05' AS Date), NULL)
INSERT [dbo].[tblThuePhong] ([ID], [IDKhachHang], [IDPhong], [GiaPhong], [TienDatCoc], [NgayThue], [NgayTraPhong], [DaThanhToan]) VALUES (62, 6, 11, 450000, 900000, CAST(N'2023-05-15' AS Date), CAST(N'2023-06-15' AS Date), NULL)
INSERT [dbo].[tblThuePhong] ([ID], [IDKhachHang], [IDPhong], [GiaPhong], [TienDatCoc], [NgayThue], [NgayTraPhong], [DaThanhToan]) VALUES (63, 2, 9, 1500000, 900000, CAST(N'2024-11-21' AS Date), CAST(N'2026-01-21' AS Date), NULL)
INSERT [dbo].[tblThuePhong] ([ID], [IDKhachHang], [IDPhong], [GiaPhong], [TienDatCoc], [NgayThue], [NgayTraPhong], [DaThanhToan]) VALUES (64, 8, 28, 1700000, 900000, CAST(N'2023-05-17' AS Date), CAST(N'2023-06-17' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[tblThuePhong] OFF
ALTER TABLE [dbo].[tblDVChiTiet] ADD  CONSTRAINT [DF_tblDienNuoc_DaThanhToan]  DEFAULT ((0)) FOR [DaThanhToan]
GO
ALTER TABLE [dbo].[tblDVChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_tblDienNuoc_tblDichVu] FOREIGN KEY([IDLoaiDV])
REFERENCES [dbo].[tblDichVu] ([ID])
GO
ALTER TABLE [dbo].[tblDVChiTiet] CHECK CONSTRAINT [FK_tblDienNuoc_tblDichVu]
GO
ALTER TABLE [dbo].[tblDVChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_tblDienNuoc_tblThuePhong] FOREIGN KEY([IDThue])
REFERENCES [dbo].[tblThuePhong] ([ID])
GO
ALTER TABLE [dbo].[tblDVChiTiet] CHECK CONSTRAINT [FK_tblDienNuoc_tblThuePhong]
GO
ALTER TABLE [dbo].[tblPhong]  WITH CHECK ADD  CONSTRAINT [FK_tblPhong_tblLoaiPhong] FOREIGN KEY([IDLoaiPhong])
REFERENCES [dbo].[tblLoaiPhong] ([ID])
GO
ALTER TABLE [dbo].[tblPhong] CHECK CONSTRAINT [FK_tblPhong_tblLoaiPhong]
GO
ALTER TABLE [dbo].[tblThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_tblThuePhong_tblKhachHang] FOREIGN KEY([IDKhachHang])
REFERENCES [dbo].[tblKhachHang] ([ID])
GO
ALTER TABLE [dbo].[tblThuePhong] CHECK CONSTRAINT [FK_tblThuePhong_tblKhachHang]
GO
ALTER TABLE [dbo].[tblThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_tblThuePhong_tblPhong] FOREIGN KEY([IDPhong])
REFERENCES [dbo].[tblPhong] ([ID])
GO
ALTER TABLE [dbo].[tblThuePhong] CHECK CONSTRAINT [FK_tblThuePhong_tblPhong]
GO
/****** Object:  StoredProcedure [dbo].[capNhatDichVu]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[capNhatDichVu] 
@id int ,
@tenDV nvarchar(100)

as
begin 
  update tblDichVu 
  set TenDichVu = @tenDV
  where ID = @id;

  if @@ROWCOUNT > 0 return 1 
  else return 0 ;

end 
GO
/****** Object:  StoredProcedure [dbo].[capNhatLoaiPhong]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[capNhatLoaiPhong]
	@idLoaiPhong int,
	@tenLoaiPhong nvarchar(50),
	@donGia int
as
begin
	update tblLoaiPhong
	set TenLoaiPhong = @tenLoaiPhong,
		DonGia = @donGia
	where ID = @idLoaiPhong;

	if @@ROWCOUNT > 0 return 1; --- cập nhật thành công
	else return 0;--cập nhật thất bại
end
GO
/****** Object:  StoredProcedure [dbo].[deleteDichVu]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deleteDichVu]
@id int 

as 
begin 
 delete tblDichVu
 where ID = @id

 if @@ROWCOUNT > 0 return 1
 else return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[deletePhong]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- khai báo 1 proc để thực thi việc xóa phòng 
CREATE proc [dbo].[deletePhong] 
@idPhong int 
as
begin 

-- trường hợp xóa "Cứng" 
	--delete from tblPhong
	--where ID = @idPhong;
	 --if(@@ROWCOUNT>0)
	 --return 1;
	 --else 
	 --return 0;
-- trường hợp xóa mềm 
	update tblPhong
	set DaXoa = 1
	where ID = @idPhong
	if @@ROWCOUNT >0 return 1
	else return 0;
	
end

GO
/****** Object:  StoredProcedure [dbo].[GiaHan]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GiaHan]
	@Id bigint -- tham số truyền vào để xác định được dữ liệu của khách hàng hiện tại
as
begin	

	-- khai báo các biến để lấy thông tin hiện có của khách hàng
	declare @v_IdKhachHang int; 
	declare @v_IdPhong int;
	declare @v_GiaPhong int;
	declare @v_DatCoc int;
	declare @v_NgayThueMoi date;
	declare @v_NgayTraMoi date;

	-- gán giá trị cho các biến đã khai báo phía trên
	set @v_IdKhachHang= (select IDKhachHang from tblThuePhong where ID = @Id );
	set @v_IdPhong= (select IDPhong from tblThuePhong where ID = @Id );	
	set @v_GiaPhong= (select GiaPhong from tblThuePhong where ID = @Id );	
	set @v_DatCoc= (select TienDatCoc from tblThuePhong where ID = @Id );
	set @v_NgayThueMoi= (select DATEADD(day,1,NgayTraPhong) from tblThuePhong where ID = @Id );

	set @v_NgayTraMoi= (select DATEADD(day,DATEDIFF(DAY,NgayThue , NgayTraPhong),NgayTraPhong) from tblThuePhong where ID = @Id );

	-- thêm mới 1 dòng dữ liệu vào bảng tblThuePhong <=> gia hạn hợp đồng
	insert into tblThuePhong(IDKhachHang,IDPhong,GiaPhong,TienDatCoc,NgayThue,NgayTraPhong)
	values(@v_IdKhachHang, @v_IdPhong,@v_GiaPhong,@v_DatCoc,@v_NgayThueMoi,@v_NgayTraMoi);

	if @@ROWCOUNT > 0 return 1; -- nếu gia hạn thành công thì trả về 1
	else return 0; -- trả về 0 nếu gia hạn thất bại	
end

GO
/****** Object:  StoredProcedure [dbo].[LoadAllDSPhong]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LoadAllDSPhong]
as
begin
	select p.ID ,
	CONCAT(l.TenLoaiPhong,' ',p.TenPhong) as TenPhong 
	from tblPhong p 
	inner join tblLoaiPhong l 
	on p.IDLoaiPhong = l.ID
	where p.DaXoa!=1
	and p.id  not in (select IDPhong from tblThuePhong where NgayTraPhong > GETDATE() )



end


GO
/****** Object:  StoredProcedure [dbo].[loadDSDichVu]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[loadDSDichVu] 
@timKiem nvarchar(100)
as 
begin
  select * from tblDichVu
  where TenDichVu like '%'+@timKiem+'%'

end 
GO
/****** Object:  StoredProcedure [dbo].[loadDSKhachHang]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[loadDSKhachHang]
 -- @timKiem nvarchar (50)

as 
begin 
	select  CONCAT(k.Ho,' ',k.TenDem,' ',k.Ten) as Hoten, *
	 from tblKhachHang as k
		
end	
GO
/****** Object:  StoredProcedure [dbo].[loadDsLoaiPhong]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[loadDsLoaiPhong]
as
begin
	select * from tblLoaiPhong;
end
GO
/****** Object:  StoredProcedure [dbo].[loadDSPhong]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[loadDSPhong] 
  @timkiem nvarchar (50)

as 
begin 
	select 
	   p.ID,
	   lp.TenLoaiPhong,
	   p.TenPhong,
	   lp.DonGia,
		case 
			when p.trangThai = 1 then N'Hoạt động'
			else N'Không hoạt động'
		end as trangThai
	from tblPhong as p 
	inner join tblLoaiPhong as lp on p.IDLoaiPhong = lp.ID 
	where DaXoa = 0 
end	
GO
/****** Object:  StoredProcedure [dbo].[LoadDSThuePhong]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LoadDSThuePhong]

 @tuKhoa nvarchar(50)
as  

begin 

select 
tp.ID,
l.TenLoaiPhong , p.TenPhong, 
CONCAT(kh.Ho,' ',kh.TenDem,' ',kh.Ten) as HoTen,
kh.DienThoai,
kh.CMND_CanCuoc,
kh.HKTT,
 convert(varchar(10),tp.NgayThue,103) as NgayThue,
 convert(varchar(10),tp.NgayTraPhong,103) as NgayTraPhong,
 tp.GiaPhong,
 tp.DaThanhToan,
( tp.GiaPhong- tp.DaThanhToan) as ConLai,
tp.TienDatCoc
from tblThuePhong as tp
inner join tblPhong as p on tp.IDPhong = p.ID
inner join tblLoaiPhong as l on p.IDLoaiPhong = l.ID
inner join tblKhachHang as kh on tp.IDKhachHang= kh.ID

where kh.DienThoai like '%'+@tuKhoa+'%' 
or kh.CMND_CanCuoc like '%'+@tuKhoa+'%'
or CONCAT(kh.Ho,' ',kh.TenDem,' ',kh.Ten) like '%'+@tuKhoa+'%'  
order by tp.NgayThue desc , kh.Ten

end
GO
/****** Object:  StoredProcedure [dbo].[LoadThongTinHopDongThueTro]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LoadThongTinHopDongThueTro] 
 @ID bigint 
as
begin 
select  
	case
	  when kh.TenDem is not null then CONCAT(kh.Ho ,' ', kh.TenDem,' ', kh.Ten)
	  else CONCAT(kh.Ho ,' ', kh.Ten)
	end as Hoten, tp.GiaPhong,tp.DaThanhToan,(tp.GiaPhong-tp.DaThanhToan) ConLai
	from tblThuePhong tp 
	inner join tblKhachHang kh on tp.IDKhachHang = kh.ID
	where tp.ID = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[searchDichvu]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[searchDichvu]
@tenDV nvarchar(50) 
as
begin
  select * from tblDichVu where TenDichVu like N'%'+@tenDV+'%'
  

end
GO
/****** Object:  StoredProcedure [dbo].[selectPhong]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- khai báo một produre để lấy thông tin phòng dựa vào id phòng 

create proc [dbo].[selectPhong] 
@idPhong int 
as 
begin 
        select * from tblPhong where ID = @idPhong

end
GO
/****** Object:  StoredProcedure [dbo].[ThanhToan]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThanhToan]

@ID bigint,
@SoTien int 

as
begin 
update tblThuePhong
set DaThanhToan = @SoTien
where ID = @ID

if @@ROWCOUNT > 0 return 1;
else return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[themDichVu]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themDichVu]
@tenDV nvarchar(100)
as 
begin 
 insert into tblDichVu values (@tenDV)
 if @@ROWCOUNT > 0 return 1
 else return 0;

end
GO
/****** Object:  StoredProcedure [dbo].[themKH]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themKH] 
 
 @ho nvarchar(50),
 @hoDem nvarchar(50),
 @ten nvarchar(50),
 @cmnd nvarchar(50),
 @dienThoai nvarchar(50),
 @queQuan nvarchar(50),
 @hktt nvarchar(50)
 
 as
 

begin
	insert into tblKhachHang(Ho,TenDem,Ten,CMND_CanCuoc,DienThoai,QueQuan,HKTT)  values (@ho,@hoDem,@ten,@cmnd,@dienThoai,@queQuan,@hktt);
	if (@@ROWCOUNT >0) return 1;
	else return 0;
 
end 

GO
/****** Object:  StoredProcedure [dbo].[themLoaiPhong]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themLoaiPhong]
	@tenLoaiPhong nvarchar(50),
	@donGia int
as
begin
	insert into tblLoaiPhong values(@tenLoaiPhong,@donGia);
	if @@ROWCOUNT > 0 return 1
	else return 0;
end

GO
/****** Object:  StoredProcedure [dbo].[themMoiPhong]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themMoiPhong] 
 @idLoaiPhong int ,
 @tenPhong nvarchar(50),
 @trangThai tinyint
as
begin
	insert into tblPhong(TenPhong,IDLoaiPhong,TrangThai)  values (@tenPhong, @idLoaiPhong,@trangThai);
	if (@@ROWCOUNT >0) return 1;
	else return 0;
 
end 

GO
/****** Object:  StoredProcedure [dbo].[ThuePhong]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThuePhong] 
@idPhong int,
@idKhachHang int ,
@datCoc int ,
@ngayThue varchar(10),
@ngayTra varchar(10)
as
begin
 
 insert tblThuePhong(IDPhong , IDKhachHang , GiaPhong , TienDatCoc ,NgayThue,NgayTraPhong)
 values(
	@idPhong,
	@idKhachHang,
	( select l.DonGia
	  from tblPhong as p 
	  inner join tblLoaiPhong as l on p.IDLoaiPhong= l.ID
	  where p.ID = @idPhong	
	),
	@datCoc,
	--@ngayThue,
	--@ngayTra);
	CONVERT(varchar(10), CONVERT(DATE, @ngayThue, 111),  111) ,
	CONVERT(varchar(10), CONVERT(DATE, @ngayTra, 111),  111)) ;
	
	if (@@ROWCOUNT >0) return 1
	else return 0;
 
end
GO
/****** Object:  StoredProcedure [dbo].[updatePhong]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[updatePhong] 
--để cập nhật thông tin phòng cần có 
-- id phòng cần cập nhật 
-- tên phòng sau khi thay đổi 
-- trạng thái phòng sau khi thay đổi 
-- id sau khi thay đổi 
@idPhong int ,
@tenPhong nvarchar(150),
@idLoaiPhong int ,
@trangThai tinyint 

as
begin 
   update tblPhong 
   set TenPhong = @tenPhong,
       IDLoaiPhong = @idLoaiPhong,
	   TrangThai = @trangThai

   where ID = @idPhong -- chỉ update 1 phòng có id truyền vào 

   if @@ROWCOUNT > 0 return 1 -- nếu update thành công 
   else return 0 ;
end
GO
/****** Object:  StoredProcedure [dbo].[xoaLoaiPhong]    Script Date: 5/18/2023 12:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaLoaiPhong] 
 @idLoaiPhong int 
as 
begin
  delete from tblLoaiPhong where ID = @idLoaiPhong;
  if (@@ROWCOUNT >0) return 1;
  else return 0; 
   
end
GO
USE [master]
GO
ALTER DATABASE [QLPhongTro3] SET  READ_WRITE 
GO
