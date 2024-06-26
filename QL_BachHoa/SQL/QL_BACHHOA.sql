CREATE DATABASE QL_BACHHOA
GO
USE [QL_BACHHOA]
GO
/****** Object:  Table [dbo].[CHITIET_HD]    Script Date: 11/4/2023 5:29:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIET_HD](
	[MASP] [int] NOT NULL,
	[MAHD] [char](20) NOT NULL,
	[SL] [int] NULL,
	[GIABAN] [int] NULL,
 CONSTRAINT [PK_CHITIET_HD] PRIMARY KEY CLUSTERED 
(
	[MASP] ASC,
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIET_PN]    Script Date: 11/4/2023 5:29:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIET_PN](
	[MAPN] [int] NOT NULL,
	[MASP] [int] NOT NULL,
	[SL] [int] NULL,
	[GIANHAP] [int] NULL,
	[THANHTIEN] [int] NULL,
 CONSTRAINT [PK_CHITIET_PN] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC,
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIET_QUYEN]    Script Date: 11/4/2023 5:29:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIET_QUYEN](
	[MACT] [int] IDENTITY(1,1) NOT NULL,
	[MAQUYEN] [int] NOT NULL,
	[TENCT] [nvarchar](50) NULL,
	[CAP_PHEP] [int] NULL,
 CONSTRAINT [PK_CHITIET_QUYEN] PRIMARY KEY CLUSTERED 
(
	[MACT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOITRA]    Script Date: 11/4/2023 5:29:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOITRA](
	[MADT] [int] IDENTITY(1,1) NOT NULL,
	[MAHD] [char](20) NOT NULL,
	[NGAYDOI] [datetime] NULL,
	[MASP] [int] NULL,
	[SL] [int] NULL,
	[GIABAN] [int] NULL,
 CONSTRAINT [PK_DOITRA] PRIMARY KEY CLUSTERED 
(
	[MADT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 11/4/2023 5:29:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHD] [char](20) NOT NULL,
	[SDT_KH] [char](50) NOT NULL,
	[MANV] [int] NOT NULL,
	[NGAYLAP] [datetime] NULL,
	[TONGTIEN] [int] NULL,
	[TRANGTHAI_DH] [nvarchar](50) NULL,
	[HINHTHUC_TT] [nvarchar](50) NULL,
	[LIDO] [nvarchar](100) NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 11/4/2023 5:29:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[SDT_KH] [char](50) NOT NULL,
	[TENKH] [nvarchar](100) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[EMAIL] [char](50) NULL,
	[MATKHAU] [char](50) NULL,
	[SDT_NHANHANG] [char](10) NULL,
	[TEN_NHANHANG] [nvarchar](50) NULL,
	[DIACHI_NHANHANG] [nvarchar](50) NULL,
	[OTP] [char](6) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[SDT_KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 11/4/2023 5:29:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MANCC] [int] IDENTITY(1,1) NOT NULL,
	[TENNCC] [nvarchar](100) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[SDT] [char](20) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/4/2023 5:29:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [int] IDENTITY(1,1) NOT NULL,
	[TENNV] [nvarchar](100) NULL,
	[GIOITINH] [nvarchar](50) NULL,
	[SDT] [char](20) NULL,
	[MATKHAU] [char](50) NULL,
	[TAIKHOAN] [nvarchar](100) NULL,
	[MAQUYEN] [int] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHOMHANG]    Script Date: 11/4/2023 5:29:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHOMHANG](
	[MANH] [int] IDENTITY(1,1) NOT NULL,
	[TENNH] [nvarchar](100) NULL,
 CONSTRAINT [PK_NHOMHANG] PRIMARY KEY CLUSTERED 
(
	[MANH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHOMQUYEN]    Script Date: 11/4/2023 5:29:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHOMQUYEN](
	[MAQUYEN] [int] IDENTITY(1,1) NOT NULL,
	[TENQUYEN] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHOMQUYEN] PRIMARY KEY CLUSTERED 
(
	[MAQUYEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 11/4/2023 5:29:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MAPN] [int] IDENTITY(1,1) NOT NULL,
	[MANCC] [int] NOT NULL,
	[NGAYNHAP] [datetime] NULL,
	[TONGNHAP] [int] NULL,
	[MANV] [int] NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 11/4/2023 5:29:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MASP] [int] IDENTITY(1,1) NOT NULL,
	[MANH] [int] NOT NULL,
	[TENSP] [nvarchar](100) NULL,
	[HINH] [char](50) NULL,
	[SOLUONG] [int] NULL,
	[KHOILUONG] [nchar](10) NULL,
	[GIABAN] [int] NULL,
	[LUOTBAN] [int] NULL,
	[MANCC] [int] NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY CLUSTERED 
(
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (1, N'1                   ', 1, 55000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (1, N'12                  ', 3, 55000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (2, N'1                   ', 2, 45000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (3, N'1                   ', 4, 50000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (3, N'14                  ', 3, 50000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (5, N'15                  ', 5, 50000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (7, N'13                  ', 6, 15000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (7, N'15                  ', 4, 15000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (8, N'13                  ', 7, 15000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (9, N'14                  ', 8, 15000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (10, N'13                  ', 2, 30000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (10, N'2                   ', 3, 30000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (12, N'2                   ', 6, 410000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (12, N'6                   ', 4, 410000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (15, N'15                  ', 3, 35000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (17, N'3                   ', 3, 350000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (18, N'15                  ', 6, 100000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (18, N'6                   ', 5, 100000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (19, N'16                  ', 7, 28000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (20, N'2                   ', 2, 35000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (22, N'3                   ', 4, 7000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (22, N'9                   ', 5, 7000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (23, N'12                  ', 4, 8000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (23, N'14                  ', 9, 8000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (23, N'26                  ', 1, 8000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (23, N'9                   ', 6, 8000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (24, N'3                   ', 5, 9000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (24, N'7                   ', 2, 9000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (25, N'4                   ', 1, 9000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (26, N'8                   ', 4, 36000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (27, N'18                  ', 8, 18000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (30, N'11                  ', 3, 9000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (30, N'4                   ', 2, 9000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (31, N'10                  ', 10, 60000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (32, N'18                  ', 5, 60000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (32, N'4                   ', 3, 60000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (32, N'7                   ', 3, 60000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (33, N'10                  ', 23, 62000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (35, N'27                  ', 1, 150000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (35, N'7                   ', 6, 150000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (36, N'16                  ', 3, 170000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (37, N'16                  ', 5, 105000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (38, N'17                  ', 2, 35000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (42, N'5                   ', 4, 42000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (44, N'8                   ', 2, 66000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (45, N'10                  ', 10, 65000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (45, N'11                  ', 4, 65000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (45, N'5                   ', 5, 65000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (45, N'8                   ', 1, 65000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (49, N'17                  ', 3, 78000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (50, N'17                  ', 4, 78000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (50, N'19                  ', 5, 78000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (50, N'5                   ', 4, 7800)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (55, N'6                   ', 3, 375000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (57, N'20                  ', 3, 165000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (58, N'20                  ', 4, 120000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (59, N'9                   ', 3, 125000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (60, N'12                  ', 2, 194000)
INSERT [dbo].[CHITIET_HD] ([MASP], [MAHD], [SL], [GIABAN]) VALUES (60, N'19                  ', 6, 194000)
GO
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (1, 1, 100, 45000, 4500000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (1, 2, 100, 35000, 3500000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (1, 3, 100, 40000, 4000000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (2, 7, 100, 5000, 500000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (2, 8, 100, 5000, 500000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (2, 9, 100, 5000, 500000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (3, 43, 100, 40000, 4000000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (3, 44, 100, 56000, 5600000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (3, 49, 100, 68000, 6800000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (4, 22, 100, 5000, 500000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (4, 23, 100, 5000, 500000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (4, 24, 100, 5000, 500000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (5, 32, 100, 50000, 5000000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (5, 33, 100, 52000, 5200000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (5, 34, 100, 140000, 14000000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (6, 11, 100, 330000, 33000000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (6, 14, 100, 20000, 2000000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (6, 18, 100, 90000, 9000000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (7, 12, 100, 400000, 40000000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (7, 13, 100, 360000, 36000000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (7, 15, 100, 25000, 2500000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (7, 16, 100, 46000, 4600000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (8, 55, 100, 365000, 36500000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (8, 56, 100, 90000, 9000000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (9, 8, 100, 5000, 500000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (9, 9, 100, 5000, 500000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (9, 10, 100, 20000, 2000000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (10, 47, 100, 36000, 3600000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (10, 48, 100, 55000, 5500000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (10, 50, 100, 68000, 6800000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (13, 31, 10, 100000, 1000000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (13, 33, 10, 100000, 1000000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (14, 44, 10, 20000, 200000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (14, 45, 20, 30000, 600000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (15, 6, 10, 24000, 240000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (15, 8, 5, 23000, 115000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (16, 2, 10, 40000, 400000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (17, 2, 20, 40000, 800000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (17, 3, 10, 45000, 450000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (18, 42, 10, 35000, 350000)
INSERT [dbo].[CHITIET_PN] ([MAPN], [MASP], [SL], [GIANHAP], [THANHTIEN]) VALUES (18, 47, 10, 40000, 400000)
GO
SET IDENTITY_INSERT [dbo].[CHITIET_QUYEN] ON 

INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (1, 1, N'SF_SANPHAM', 1)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (2, 1, N'SF_NHANVIEN', 1)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (3, 1, N'SF_NHAPHANG', 1)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (4, 1, N'SF_BANHANG', 1)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (5, 1, N'SF_DOITRA', 1)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (6, 1, N'SF_THONGKE', 1)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (7, 1, N'SF_PHANQUYEN', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (8, 2, N'SF_SANPHAM', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (9, 2, N'SF_NHANVIEN', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (10, 2, N'SF_NHAPHANG', 1)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (11, 2, N'SF_BANHANG', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (12, 2, N'SF_DOITRA', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (22, 2, N'SF_THONGKE', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (23, 2, N'SF_PHANQUYEN', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (24, 3, N'SF_SANPHAM', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (25, 3, N'SF_NHANVIEN', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (26, 3, N'SF_NHAPHANG', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (27, 3, N'SF_BANHANG', 1)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (28, 3, N'SF_DOITRA', 1)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (30, 3, N'SF_THONGKE', 1)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (31, 3, N'SF_PHANQUYEN', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (36, 4, N'SF_SANPHAM', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (37, 4, N'SF_NHANVIEN', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (38, 4, N'SF_NHAPHANG', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (39, 4, N'SF_BANHANG', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (40, 4, N'SF_DOITRA', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (41, 4, N'SF_THONGKE', 1)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (42, 4, N'SF_PHANQUYEN', 1)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (43, 5, N'SF_SANPHAM', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (44, 5, N'SF_NHANVIEN', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (45, 5, N'SF_NHAPHANG', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (46, 5, N'SF_BANHANG', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (47, 5, N'SF_DOITRA', 1)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (48, 5, N'SF_THONGKE', 0)
INSERT [dbo].[CHITIET_QUYEN] ([MACT], [MAQUYEN], [TENCT], [CAP_PHEP]) VALUES (49, 5, N'SF_PHANQUYEN', 0)
SET IDENTITY_INSERT [dbo].[CHITIET_QUYEN] OFF
GO
SET IDENTITY_INSERT [dbo].[DOITRA] ON 

INSERT [dbo].[DOITRA] ([MADT], [MAHD], [NGAYDOI], [MASP], [SL], [GIABAN]) VALUES (1, N'2                   ', CAST(N'2023-09-27T00:00:00.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[DOITRA] ([MADT], [MAHD], [NGAYDOI], [MASP], [SL], [GIABAN]) VALUES (2, N'3                   ', CAST(N'2023-09-27T00:00:00.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[DOITRA] ([MADT], [MAHD], [NGAYDOI], [MASP], [SL], [GIABAN]) VALUES (3, N'1                   ', CAST(N'2023-09-27T00:00:00.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[DOITRA] ([MADT], [MAHD], [NGAYDOI], [MASP], [SL], [GIABAN]) VALUES (4, N'10                  ', CAST(N'2023-11-02T16:13:10.997' AS DateTime), 33, 3, 62000)
INSERT [dbo].[DOITRA] ([MADT], [MAHD], [NGAYDOI], [MASP], [SL], [GIABAN]) VALUES (5, N'3                   ', CAST(N'2023-11-02T16:44:40.637' AS DateTime), 22, 1, 7000)
INSERT [dbo].[DOITRA] ([MADT], [MAHD], [NGAYDOI], [MASP], [SL], [GIABAN]) VALUES (6, N'3                   ', CAST(N'2023-11-02T16:44:40.680' AS DateTime), 24, 1, 9000)
INSERT [dbo].[DOITRA] ([MADT], [MAHD], [NGAYDOI], [MASP], [SL], [GIABAN]) VALUES (7, N'2                   ', CAST(N'2023-11-02T17:17:45.317' AS DateTime), 12, 6, 410000)
INSERT [dbo].[DOITRA] ([MADT], [MAHD], [NGAYDOI], [MASP], [SL], [GIABAN]) VALUES (8, N'5                   ', CAST(N'2023-11-02T17:26:23.437' AS DateTime), 45, 5, 65000)
INSERT [dbo].[DOITRA] ([MADT], [MAHD], [NGAYDOI], [MASP], [SL], [GIABAN]) VALUES (9, N'4                   ', CAST(N'2023-11-02T17:27:09.510' AS DateTime), 25, 1, 9000)
SET IDENTITY_INSERT [dbo].[DOITRA] OFF
GO
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'1                   ', N'0341112113                                        ', 1, CAST(N'2023-08-15T00:00:00.000' AS DateTime), 345000, N'Đã giao', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'10                  ', N'0341112114                                        ', 2, CAST(N'2023-09-05T00:00:00.000' AS DateTime), 2676000, N'Đã đổi trả', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'11                  ', N'0341112115                                        ', 1, CAST(N'2023-09-06T00:00:00.000' AS DateTime), 287000, N'Đã giao', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'12                  ', N'0341112116                                        ', 1, CAST(N'2023-09-07T00:00:00.000' AS DateTime), 585000, N'Đã giao', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'13                  ', N'0341112117                                        ', 1, CAST(N'2023-09-08T00:00:00.000' AS DateTime), 255000, N'Đã giao', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'14                  ', N'0341112118                                        ', 1, CAST(N'2023-09-09T00:00:00.000' AS DateTime), 342000, N'Đã xác nhận', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'15                  ', N'0341112119                                        ', 1, CAST(N'2023-09-10T00:00:00.000' AS DateTime), 1015000, N'Đã xác nhận', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'16                  ', N'0341112120                                        ', 4, CAST(N'2023-09-10T00:00:00.000' AS DateTime), 1231000, N'Chờ xác nhận', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'17                  ', N'0341112113                                        ', 4, CAST(N'2023-09-11T00:00:00.000' AS DateTime), 616000, N'Chờ đổi trả', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'18                  ', N'0341112114                                        ', 1, CAST(N'2023-09-12T00:00:00.000' AS DateTime), 444000, N'Chờ đổi trả', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'19                  ', N'0341112115                                        ', 4, CAST(N'2023-09-12T00:00:00.000' AS DateTime), 1554000, N'Chờ đổi trả', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'2                   ', N'0341112114                                        ', 1, CAST(N'2023-08-16T00:00:00.000' AS DateTime), 2620000, N'Đã đổi trả', NULL, N'Sản phẩm hết hạn')
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'20                  ', N'0341112116                                        ', 4, CAST(N'2023-09-12T00:00:00.000' AS DateTime), 975000, N'Đã hủy', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'26                  ', N'0341112116                                        ', 1, CAST(N'2023-10-14T07:14:53.147' AS DateTime), 8000, N'Đã hủy', N'Ship COD', NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'27                  ', N'0341112116                                        ', 1, CAST(N'2023-10-14T07:16:48.383' AS DateTime), 150000, N'Đã hủy', N'Thẻ tín dụng', NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'3                   ', N'0341112115                                        ', 1, CAST(N'2023-08-17T00:00:00.000' AS DateTime), 1123000, N'Đã đổi trả', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'4                   ', N'0341112116                                        ', 1, CAST(N'2023-08-18T00:00:00.000' AS DateTime), 207000, N'Đã đổi trả', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'5                   ', N'0341112117                                        ', 1, CAST(N'2023-08-09T00:00:00.000' AS DateTime), 524200, N'Đã đổi trả', NULL, N'Sản phẩm bị hỏng')
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'6                   ', N'0341112118                                        ', 2, CAST(N'2023-08-20T00:00:00.000' AS DateTime), 3265000, N'Chờ đổi trả', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'7                   ', N'0341112119                                        ', 2, CAST(N'2023-08-21T00:00:00.000' AS DateTime), 1098000, N'Chờ xác nhận', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'8                   ', N'0341112120                                        ', 2, CAST(N'2023-08-21T00:00:00.000' AS DateTime), 341000, N'Chờ đổi trả', NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [SDT_KH], [MANV], [NGAYLAP], [TONGTIEN], [TRANGTHAI_DH], [HINHTHUC_TT], [LIDO]) VALUES (N'9                   ', N'0341112113                                        ', 2, CAST(N'2023-08-23T00:00:00.000' AS DateTime), 458000, N'Chờ xác nhận', NULL, NULL)
GO
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TENKH], [DIACHI], [EMAIL], [MATKHAU], [SDT_NHANHANG], [TEN_NHANHANG], [DIACHI_NHANHANG], [OTP]) VALUES (N'0000000000                                        ', N'Phan Ánh Linh', NULL, N'linhpta@gmail.com                                 ', N'123456                                            ', NULL, NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TENKH], [DIACHI], [EMAIL], [MATKHAU], [SDT_NHANHANG], [TEN_NHANHANG], [DIACHI_NHANHANG], [OTP]) VALUES (N'0341112113                                        ', N'Lê Minh Kha', N'TP.HCM', N'khale@gmail.com                                   ', N'123456                                            ', NULL, NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TENKH], [DIACHI], [EMAIL], [MATKHAU], [SDT_NHANHANG], [TEN_NHANHANG], [DIACHI_NHANHANG], [OTP]) VALUES (N'0341112114                                        ', N'Biện Thanh Nhựt', N'Tây Ninh', N'nhutbien@gmail.com                                ', N'123456                                            ', NULL, NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TENKH], [DIACHI], [EMAIL], [MATKHAU], [SDT_NHANHANG], [TEN_NHANHANG], [DIACHI_NHANHANG], [OTP]) VALUES (N'0341112115                                        ', N'Vũ Hoàng Tiên', N'Đồng Nai', N'tienvu@gmai.com                                   ', N'123456                                            ', NULL, NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TENKH], [DIACHI], [EMAIL], [MATKHAU], [SDT_NHANHANG], [TEN_NHANHANG], [DIACHI_NHANHANG], [OTP]) VALUES (N'0341112116                                        ', N'Phan Thị Ánh Linh', N'Bình Thuận', N'linhphan@gmail.com                                ', N'123456                                            ', NULL, NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TENKH], [DIACHI], [EMAIL], [MATKHAU], [SDT_NHANHANG], [TEN_NHANHANG], [DIACHI_NHANHANG], [OTP]) VALUES (N'0341112117                                        ', N'Huỳnh Thị Kiều Mai', N'Gia Lai', N'maihuynh@gmai.com                                 ', N'123456                                            ', NULL, NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TENKH], [DIACHI], [EMAIL], [MATKHAU], [SDT_NHANHANG], [TEN_NHANHANG], [DIACHI_NHANHANG], [OTP]) VALUES (N'0341112118                                        ', N'Nguyễn Hữu Trung', N'Trà Vinh', N'trungnguyen@gmail.com                             ', N'123456                                            ', NULL, NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TENKH], [DIACHI], [EMAIL], [MATKHAU], [SDT_NHANHANG], [TEN_NHANHANG], [DIACHI_NHANHANG], [OTP]) VALUES (N'0341112119                                        ', N'Tống Duy Trường Đạt ', N'Quãng Ngãi', N'truongdat@gmail.com                               ', N'Truongdat..123                                    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TENKH], [DIACHI], [EMAIL], [MATKHAU], [SDT_NHANHANG], [TEN_NHANHANG], [DIACHI_NHANHANG], [OTP]) VALUES (N'0341112120                                        ', N'Hồ Phương Thảo', N'TP.HCM', N'thaoho@gmail.com                                  ', N'123456                                            ', NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] ON 

INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (1, N'Công ty cổ phần thực phẩm Hữu Nghị', N'122 Định Công,  phường Định Công, quận Hoàng Mai, Hà Nội', N'02546649451         ')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (2, N'Công ty TNHH Phạm Nguyên', N'Số 613, Đường Trần Đại Nghĩa, Phường Tân Tạo A, quận Bình Tân, thành phố Hồ Chí Minh', N'028 3765 7979       ')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (3, N'Công ty TNHH Nước giải khát SUNTORY PEPSICO Việt Nam', N'Tầng 5, Khách sạn Sheraton, 88 Đồng Khởi, Quận 1, TP. HCM', N'08 3821 9437        ')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (4, N'Thực Phẩm Đại Thuận - Công Ty Cổ Phần Hàng Tiêu Dùng Đại Thuận', N'Số 42 Củ Chi, P. Vĩnh Hải, TP. Nha Trang, Khánh Hòa', N'08 3836 825         ')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (5, N'Gia Dụng Vietcook - Công Ty TNHH Thương Mại Và Đầu Tư Gia Phú', N'Số 61, Hẻm 72/73/40, phố Quan Nhân, Phường Nhân Chính, Quận Thanh Xuân, Hà Nội', N'0903 443 003        ')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (6, N'Công ty Cổ phần Sữa Việt Nam (Vinamilk)', N'Số 10, Đường Tân Trào, Phường Tân Phú, Quận 7, TP.HCM', N'(08) 54 155 555     ')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (7, N'Công ty Cổ phần sữa TH True Milk', N'Tầng 5 Tòa nhà 97 – 99 Láng Hạ, phường Láng Hạ, quận Đống Đa, TP. Hà Nội', N'02462538566         ')
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] OFF
GO
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [GIOITINH], [SDT], [MATKHAU], [TAIKHOAN], [MAQUYEN]) VALUES (1, N'Phan Linh', N'Nữ', N'0325615846          ', N'123                                               ', N'linhphan', 1)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [GIOITINH], [SDT], [MATKHAU], [TAIKHOAN], [MAQUYEN]) VALUES (2, N'Huỳnh Mai', N'Nữ', N'0254875633          ', N'123                                               ', N'maihuynh', 3)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [GIOITINH], [SDT], [MATKHAU], [TAIKHOAN], [MAQUYEN]) VALUES (3, N'Trường Đạt', N'Nam', N'0362512585          ', N'123                                               ', N'truongdat', 2)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [GIOITINH], [SDT], [MATKHAU], [TAIKHOAN], [MAQUYEN]) VALUES (4, N'Hữu Trung', N'Nam', N'0541254626          ', N'123                                               ', N'huutrung', 3)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [GIOITINH], [SDT], [MATKHAU], [TAIKHOAN], [MAQUYEN]) VALUES (5, N'Admin', NULL, N'Admin               ', N'admin1234                                         ', N'admin', 4)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
GO
SET IDENTITY_INSERT [dbo].[NHOMHANG] ON 

INSERT [dbo].[NHOMHANG] ([MANH], [TENNH]) VALUES (1, N'Bánh kẹo')
INSERT [dbo].[NHOMHANG] ([MANH], [TENNH]) VALUES (2, N'Sữa')
INSERT [dbo].[NHOMHANG] ([MANH], [TENNH]) VALUES (3, N'Gia vị')
INSERT [dbo].[NHOMHANG] ([MANH], [TENNH]) VALUES (4, N'Vệ sinh nhà cửa')
INSERT [dbo].[NHOMHANG] ([MANH], [TENNH]) VALUES (5, N'Nước giải khát')
INSERT [dbo].[NHOMHANG] ([MANH], [TENNH]) VALUES (6, N'Dầu gội')
SET IDENTITY_INSERT [dbo].[NHOMHANG] OFF
GO
SET IDENTITY_INSERT [dbo].[NHOMQUYEN] ON 

INSERT [dbo].[NHOMQUYEN] ([MAQUYEN], [TENQUYEN]) VALUES (1, N'Quản lý')
INSERT [dbo].[NHOMQUYEN] ([MAQUYEN], [TENQUYEN]) VALUES (2, N'Nhân viên kho')
INSERT [dbo].[NHOMQUYEN] ([MAQUYEN], [TENQUYEN]) VALUES (3, N'Nhân viên bán hàng')
INSERT [dbo].[NHOMQUYEN] ([MAQUYEN], [TENQUYEN]) VALUES (4, N'Admin')
INSERT [dbo].[NHOMQUYEN] ([MAQUYEN], [TENQUYEN]) VALUES (5, N'Nhân viên bán hàng')
SET IDENTITY_INSERT [dbo].[NHOMQUYEN] OFF
GO
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] ON 

INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (1, 1, CAST(N'2023-08-01T00:00:00.000' AS DateTime), 12000000, 3)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (2, 2, CAST(N'2023-08-01T00:00:00.000' AS DateTime), 1500000, 3)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (3, 3, CAST(N'2023-08-01T00:00:00.000' AS DateTime), 16400000, 3)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (4, 4, CAST(N'2023-08-02T00:00:00.000' AS DateTime), 1500000, 3)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (5, 5, CAST(N'2023-08-03T00:00:00.000' AS DateTime), 24200000, 3)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (6, 6, CAST(N'2023-08-04T00:00:00.000' AS DateTime), 44000000, 3)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (7, 7, CAST(N'2023-08-05T00:00:00.000' AS DateTime), 83100000, 3)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (8, 5, CAST(N'2023-08-06T00:00:00.000' AS DateTime), 45500000, 3)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (9, 2, CAST(N'2023-08-07T00:00:00.000' AS DateTime), 3000000, 3)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (10, 3, CAST(N'2023-08-08T00:00:00.000' AS DateTime), 15900000, 3)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (11, 1, CAST(N'2023-10-26T22:27:03.620' AS DateTime), 0, 1)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (12, 1, CAST(N'2023-10-26T22:31:24.007' AS DateTime), 0, 1)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (13, 5, CAST(N'2023-10-26T22:55:34.653' AS DateTime), 0, 1)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (14, 3, CAST(N'2023-10-26T22:58:24.700' AS DateTime), 0, 1)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (15, 2, CAST(N'2023-10-26T23:14:19.773' AS DateTime), 0, 1)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (16, 1, CAST(N'2023-10-28T22:14:28.657' AS DateTime), 0, 1)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (17, 1, CAST(N'2023-10-28T22:23:06.667' AS DateTime), 1250000, 1)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGNHAP], [MANV]) VALUES (18, 3, CAST(N'2023-10-28T22:32:24.227' AS DateTime), 750000, 1)
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] OFF
GO
SET IDENTITY_INSERT [dbo].[SANPHAM] ON 

INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (1, 1, N'Bánh trứng Tipo hộp', N'1                                                 ', 100, N'250g      ', 50000, 34, 1)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (2, 1, N'Bánh Trứng Tipo gói', N'1                                                 ', 54, N'220g      ', 10000, 12, 1)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (3, 1, N'Bánh xốp nhân phô mai Nabati hộp', N'1                                                 ', 33, N'300g      ', 50000, 3, 1)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (4, 1, N'Bánh xốp phúc bồn tử Nabati hộp', N'1                                                 ', 12, N'300g      ', 50000, 6, 1)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (5, 1, N'Bánh xốp nhân socola Nabati hộp', N'1                                                 ', 56, N'300g      ', 50000, 9, 1)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (6, 1, N'Kẹo cà phê Coffeeshot Cappuccino KOPIKO gói', N'1                                                 ', 78, N'150g      ', 16000, 12, 2)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (7, 1, N'Kẹo hương xoài nhân muối ớt Alpenliebe gói', N'1                                                 ', 34, N'100g      ', 15000, 9, 2)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (8, 1, N'Kẹo nhai socola hương bạc hà Dynamite Chews gói', N'1                                                 ', 58, N'150g      ', 15000, 2, 2)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (9, 1, N'Kẹo dừa giòn nước cốt dừa Bibica Michoco gói', N'1                                                 ', 95, N'100g      ', 15000, 4, 2)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (10, 1, N'Kẹo ngậm không đường hương bạc hà Anytime Bluemarine gói', N'1                                                 ', 12, N'100g      ', 30000, 1, 2)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (11, 2, N'Thùng 48 hộp sữa tươi hương dâu Vinamilk 100% Sữa tươi', N'1                                                 ', 34, N'180ml     ', 340000, 4, 6)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (12, 2, N'Thùng 48 hộp sữa tươi tiệt trùng socola TH true MILK', N'1                                                 ', 23, N'180ml     ', 410000, 7, 7)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (13, 2, N'Thùng 48 bịch sữa tươi tiệt trùng có đường Dalat Milk', N'1                                                 ', 13, N'220ml     ', 370000, 13, 7)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (14, 2, N'Lốc 4 hộp sữa tươi tiệt trùng có đường Dutch Lady', N'1                                                 ', 45, N'180ml     ', 30000, 2, 6)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (15, 2, N'Lốc 4 hộp sữa tươi tiệt trùng socola TH true MILK', N'1                                                 ', 67, N'180ml     ', 35000, 3, 7)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (16, 2, N'Lốc 4 hộp sữa tươi kem vanilla tự nhiên TH true MILK Top Kid Organic', N'1                                                 ', 12, N'180ml     ', 56000, 89, 7)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (17, 2, N'Thùng 48 hộp thức uống lúa mạch Milo Active Go', N'1                                                 ', 38, N'180ml     ', 350000, 3, 6)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (18, 2, N'Thùng 24 túi sữa socola lúa mạch LiF Kun', N'1                                                 ', 92, N'180ml     ', 100000, 5, 6)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (19, 2, N'Lốc 4 hộp sữa lúa mạch hương socola LOF Malto', N'1                                                 ', 11, N'180ml     ', 28000, 67, 6)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (20, 2, N'Lốc 4 hộp sữa lúa mạch vị socola Ovaltine bổ sung canxi', N'1                                                 ', 3, N'180ml     ', 35000, 2, 6)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (21, 3, N'Gia vị kho thịt Cholimex gói', N'1                                                 ', 2, N'50g       ', 7000, 43, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (22, 3, N'Gia vị kho cá Cholimex gói', N'1                                                 ', 8, N'50g       ', 7000, 5, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (23, 3, N'Gia vị hoàn chỉnh thịt kho Knorr gói', N'1                                                 ', 1, N'50g       ', 8000, 90, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (24, 3, N'Gia vị nêm sẵn lẩu Thái Fadely', N'1                                                 ', 6, N'50g       ', 9000, 6, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (25, 3, N'Gia vị hoàn chỉnh dạng xốt thịt kho Chinsu gói', N'1                                                 ', 8, N'50g       ', 9000, 5, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (26, 3, N'Nước gia vị cô đặc Maggi chai', N'1                                                 ', 9, N'250g      ', 36000, 4, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (27, 3, N'Xốt gia vị hoàn chỉnh bò kho Barona hũ', N'1                                                 ', 16, N'150g      ', 18000, 3, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (28, 3, N'Muối chấm Hảo Hảo tôm chua cay hũ', N'1                                                 ', 18, N'150g      ', 18000, 41, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (29, 3, N'Muối tôm ớt xanh Tây Ninh Dh Foods hũ', N'1                                                 ', 3, N'100g      ', 20000, 23, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (30, 3, N'Muối tiêu Guyumi hũ', N'1                                                 ', 9, N'50g       ', 9000, 81, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (31, 4, N'Nước rửa chén Lix siêu sạch hương chanh túi', N'1                                                 ', 26, N'3,5l      ', 60000, 23, 5)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (32, 4, N'Nước rửa chén Lix siêu sạch hương trà xanh túi', N'1                                                 ', 56, N'3,5l      ', 60000, 15, 5)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (33, 4, N'Nước rửa chén POWER100 tiết kiệm hương chanh túi', N'1                                                 ', 23, N'3,5l      ', 62000, 25, 5)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (34, 4, N'Nước giặt Downy vườn hoa thơm ngát túi', N'1                                                 ', 56, N'3kg       ', 150000, 12, 5)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (35, 4, N'Nước giặt Downy biển xanh tươi mát túi', N'1                                                 ', 1, N'3kg       ', 150000, 92, 5)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (36, 4, N'2 can nước giặt IZI HOME sạch ngát hương', N'1                                                 ', 78, N'3kg       ', 170000, 2, 5)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (37, 4, N'Nước giặt Lix Matic hương nước hoa can', N'1                                                 ', 3, N'3,6kg     ', 105000, 61, 5)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (38, 4, N'Bình xịt côn trùng Jumbo Vape SUPER hương cam chanh', N'1                                                 ', 2, N'300ml     ', 35000, 45, 5)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (39, 4, N'Bình xịt côn trùng Red Foxx POWER hương chanh', N'1                                                 ', 445, N'600ml     ', 65000, 32, 5)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (40, 4, N'2 túi nước rửa chén IZI HOME hương sả chanh', N'1                                                 ', 23, N'600ml     ', 35000, 4, 5)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (41, 5, N'6 lon nước ngọt Pepsi không calo vị chanh', N'1                                                 ', 45, N'320ml     ', 42000, 51, 3)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (42, 5, N'6 lon nước ngọt Mirinda vị cam', N'1                                                 ', 11, N'320ml     ', 42000, 3, 3)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (43, 5, N'6 lon nước ngọt Coca Cola', N'1                                                 ', 89, N'320ml     ', 60000, 64, 3)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (44, 5, N'6 lon nước tăng lực Sting hương dâu', N'1                                                 ', 74, N'320ml     ', 66000, 71, 3)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (45, 5, N'6 chai nước bù khoáng Revive muối khoáng ', N'1                                                 ', 56, N'500ml     ', 65000, 83, 3)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (46, 5, N'6 chai nước tăng lực Thums Up Charged kiwi', N'1                                                 ', 6, N'320ml     ', 58000, 5, 3)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (47, 5, N'6 lon nước tăng lực Lipovitan mật ong', N'1                                                 ', 13, N'220ml     ', 46000, 1, 3)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (48, 5, N'6 lon nước tăng lực Warrior hương nho', N'1                                                 ', 7, N'320ml     ', 65000, 27, 3)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (49, 5, N'6 chai trà ô long Tea Plus', N'1                                                 ', 89, N'1l        ', 78000, 53, 3)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (50, 5, N'6 chai trà đào và hạt chia Fuze Tea', N'1                                                 ', 23, N'1l        ', 78000, 5, 3)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (51, 6, N'Dầu gội Pantene Hair Fall Control ngăn rụng tóc', N'1                                                 ', 82, N'600ml     ', 115000, 6, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (52, 6, N'Dầu gội Ôliv dưỡng tóc bồng bềnh', N'1                                                 ', 51, N'600ml     ', 140000, 87, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (53, 6, N'Dầu gội nước hoa Old Spice 2 In 1 hương thể thao', N'1                                                 ', 39, N'600ml     ', 150000, 12, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (54, 6, N'Dầu gội mềm mượt Purité hoa hồng & Olive', N'1                                                 ', 26, N'600ml     ', 135000, 34, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (55, 6, N'Dầu gội Rejoice siêu mềm mượt', N'1                                                 ', 41, N'1.8l      ', 375000, 34, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (56, 6, N'Dầu gội có dầu xả Palmolive Natural phục hồi hư tổn', N'1                                                 ', 18, N'750ml     ', 100000, 12, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (57, 6, N'Dầu gội Tsubaki dưỡng tóc bóng mượt', N'1                                                 ', 15, N'490ml     ', 165000, 37, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (58, 6, N'Dầu gội Herbal Essences bưởi bạc hà', N'1                                                 ', 59, N'400ml     ', 120000, 3, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (59, 6, N'Dầu gội cho nam Head & Shoulders Ultra Men bạc hà làm sạch gàu', N'1                                                 ', 4, N'400ml     ', 125000, 7, 4)
INSERT [dbo].[SANPHAM] ([MASP], [MANH], [TENSP], [HINH], [SOLUONG], [KHOILUONG], [GIABAN], [LUOTBAN], [MANCC]) VALUES (60, 6, N'Dầu ủ tóc Coboté dưỡng tóc mềm mượt', N'1                                                 ', 7, N'200ml     ', 194000, 8, 4)
SET IDENTITY_INSERT [dbo].[SANPHAM] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__SANPHAM__A58DE95C8D450D2E]    Script Date: 11/4/2023 5:29:57 PM ******/
ALTER TABLE [dbo].[SANPHAM] ADD UNIQUE NONCLUSTERED 
(
	[TENSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHITIET_HD]  WITH CHECK ADD  CONSTRAINT [FK_CHITIET_HD_HOADON] FOREIGN KEY([MAHD])
REFERENCES [dbo].[HOADON] ([MAHD])
GO
ALTER TABLE [dbo].[CHITIET_HD] CHECK CONSTRAINT [FK_CHITIET_HD_HOADON]
GO
ALTER TABLE [dbo].[CHITIET_HD]  WITH CHECK ADD  CONSTRAINT [FK_CHITIET_HD_SANPHAM] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CHITIET_HD] CHECK CONSTRAINT [FK_CHITIET_HD_SANPHAM]
GO
ALTER TABLE [dbo].[CHITIET_PN]  WITH CHECK ADD  CONSTRAINT [FK_CHITIET_PN_PHIEUNHAP] FOREIGN KEY([MAPN])
REFERENCES [dbo].[PHIEUNHAP] ([MAPN])
GO
ALTER TABLE [dbo].[CHITIET_PN] CHECK CONSTRAINT [FK_CHITIET_PN_PHIEUNHAP]
GO
ALTER TABLE [dbo].[CHITIET_PN]  WITH CHECK ADD  CONSTRAINT [FK_CHITIET_PN_SANPHAM] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CHITIET_PN] CHECK CONSTRAINT [FK_CHITIET_PN_SANPHAM]
GO
ALTER TABLE [dbo].[CHITIET_QUYEN]  WITH CHECK ADD  CONSTRAINT [FK_CHITIET_QUYEN_NHOMQUYEN] FOREIGN KEY([MAQUYEN])
REFERENCES [dbo].[NHOMQUYEN] ([MAQUYEN])
GO
ALTER TABLE [dbo].[CHITIET_QUYEN] CHECK CONSTRAINT [FK_CHITIET_QUYEN_NHOMQUYEN]
GO
ALTER TABLE [dbo].[DOITRA]  WITH CHECK ADD  CONSTRAINT [FK_DOITRA_HOADON] FOREIGN KEY([MAHD])
REFERENCES [dbo].[HOADON] ([MAHD])
GO
ALTER TABLE [dbo].[DOITRA] CHECK CONSTRAINT [FK_DOITRA_HOADON]
GO
ALTER TABLE [dbo].[DOITRA]  WITH CHECK ADD  CONSTRAINT [FK_DOITRA_SANPHAM] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[DOITRA] CHECK CONSTRAINT [FK_DOITRA_SANPHAM]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([SDT_KH])
REFERENCES [dbo].[KHACHHANG] ([SDT_KH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_NHOMQUYEN] FOREIGN KEY([MAQUYEN])
REFERENCES [dbo].[NHOMQUYEN] ([MAQUYEN])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_NHOMQUYEN]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP] FOREIGN KEY([MANCC])
REFERENCES [dbo].[NHACUNGCAP] ([MANCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_NHACUNGCAP] FOREIGN KEY([MANCC])
REFERENCES [dbo].[NHACUNGCAP] ([MANCC])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_NHACUNGCAP]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_NHOMHANG] FOREIGN KEY([MANH])
REFERENCES [dbo].[NHOMHANG] ([MANH])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_NHOMHANG]
GO
