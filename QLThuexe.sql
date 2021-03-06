USE [QLThueXe]
GO
/****** Object:  Table [dbo].[Khachhang]    Script Date: 1/2/2022 10:06:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khachhang](
	[Makh] [nvarchar](15) NOT NULL,
	[Tenkh] [nvarchar](15) NULL,
	[Dienthoai] [nvarchar](15) NULL,
	[Diachi] [nvarchar](15) NULL,
	[Socmt] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[Makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loaixe]    Script Date: 1/2/2022 10:06:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaixe](
	[loaixe] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[loaixe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phieuthuexe]    Script Date: 1/2/2022 10:06:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieuthuexe](
	[Maphieu] [nvarchar](15) NOT NULL,
	[Ngaythue] [date] NULL,
	[Makh] [nvarchar](15) NULL,
	[Songaythue] [int] NULL,
	[Maxe] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[Maphieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 1/2/2022 10:06:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[Taikhoan] [nvarchar](15) NOT NULL,
	[Matkhau] [nvarchar](15) NULL,
	[Quyen] [varchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thongtinxe]    Script Date: 1/2/2022 10:06:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thongtinxe](
	[Bienso] [nvarchar](10) NOT NULL,
	[Hangxe] [nvarchar](10) NULL,
	[Tenxe] [nvarchar](15) NULL,
	[Loaixe] [nvarchar](10) NULL,
	[Mauson] [nvarchar](10) NULL,
	[Tinhtrang] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Bienso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tinhtrang]    Script Date: 1/2/2022 10:06:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tinhtrang](
	[tinhtrang] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tinhtrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xethue]    Script Date: 1/2/2022 10:06:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xethue](
	[Maxe] [nvarchar](15) NOT NULL,
	[Makh] [nvarchar](15) NULL,
	[DongiaNgay] [int] NULL,
	[Bienso] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Maxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Khachhang] ([Makh], [Tenkh], [Dienthoai], [Diachi], [Socmt]) VALUES (N'KH01', N'khai', N'01234567', N'test1', N'0123434')
INSERT [dbo].[Khachhang] ([Makh], [Tenkh], [Dienthoai], [Diachi], [Socmt]) VALUES (N'KH02', N'khanh', N'01234567', N'test2', N'013411')
INSERT [dbo].[Khachhang] ([Makh], [Tenkh], [Dienthoai], [Diachi], [Socmt]) VALUES (N'KH03', N'lan', N'01234567', N'test3', N'0143521')
GO
INSERT [dbo].[loaixe] ([loaixe]) VALUES (N'Ô tô')
INSERT [dbo].[loaixe] ([loaixe]) VALUES (N'Xe bus')
INSERT [dbo].[loaixe] ([loaixe]) VALUES (N'Xe đạp')
INSERT [dbo].[loaixe] ([loaixe]) VALUES (N'Xe điện')
INSERT [dbo].[loaixe] ([loaixe]) VALUES (N'Xe máy')
GO
INSERT [dbo].[Phieuthuexe] ([Maphieu], [Ngaythue], [Makh], [Songaythue], [Maxe]) VALUES (N'P02', CAST(N'2022-01-02' AS Date), N'KH02', 2, N'X02')
INSERT [dbo].[Phieuthuexe] ([Maphieu], [Ngaythue], [Makh], [Songaythue], [Maxe]) VALUES (N'P04', CAST(N'2022-01-02' AS Date), N'KH01', 3, N'X04')
GO
INSERT [dbo].[Taikhoan] ([Taikhoan], [Matkhau], [Quyen]) VALUES (N'admin', N'123', N'AD')
INSERT [dbo].[Taikhoan] ([Taikhoan], [Matkhau], [Quyen]) VALUES (N'nhanvien', N'123', N'NV')
GO
INSERT [dbo].[Thongtinxe] ([Bienso], [Hangxe], [Tenxe], [Loaixe], [Mauson], [Tinhtrang]) VALUES (N'16H-0001', N'Toyota', N'Toyota Vios', N'Ô tô', N'Trắng', N'Chưa thuê')
INSERT [dbo].[Thongtinxe] ([Bienso], [Hangxe], [Tenxe], [Loaixe], [Mauson], [Tinhtrang]) VALUES (N'29A-1888', N'Honda', N'SH-2020', N'Xe máy', N'Trắng', N'Đã thuê')
INSERT [dbo].[Thongtinxe] ([Bienso], [Hangxe], [Tenxe], [Loaixe], [Mauson], [Tinhtrang]) VALUES (N'29HN-1951', N'Cub19', N'MTB-20', N'Xe máy', N'Đen', N'Đã thuê')
INSERT [dbo].[Thongtinxe] ([Bienso], [Hangxe], [Tenxe], [Loaixe], [Mauson], [Tinhtrang]) VALUES (N'30A-1111', N'Mazda', N'Mazda CX9', N'Ô tô', N'Trắng', N'Chưa thuê')
INSERT [dbo].[Thongtinxe] ([Bienso], [Hangxe], [Tenxe], [Loaixe], [Mauson], [Tinhtrang]) VALUES (N'90C-1234', N'VinFast', N'Bus-204', N'Xe bus', N'Trắng', N'Chưa thuê')
GO
INSERT [dbo].[Tinhtrang] ([tinhtrang]) VALUES (N'Chưa thuê')
INSERT [dbo].[Tinhtrang] ([tinhtrang]) VALUES (N'Đã thuê')
GO
INSERT [dbo].[Xethue] ([Maxe], [Makh], [DongiaNgay], [Bienso]) VALUES (N'X02', N'KH02', 200000, N'29A-1888')
INSERT [dbo].[Xethue] ([Maxe], [Makh], [DongiaNgay], [Bienso]) VALUES (N'X04', N'KH01', 300000, N'29HN-1951')
GO
ALTER TABLE [dbo].[Phieuthuexe]  WITH CHECK ADD  CONSTRAINT [FKPhieu_KH] FOREIGN KEY([Makh])
REFERENCES [dbo].[Khachhang] ([Makh])
GO
ALTER TABLE [dbo].[Phieuthuexe] CHECK CONSTRAINT [FKPhieu_KH]
GO
ALTER TABLE [dbo].[Xethue]  WITH CHECK ADD  CONSTRAINT [FKXethue_KH] FOREIGN KEY([Makh])
REFERENCES [dbo].[Khachhang] ([Makh])
GO
ALTER TABLE [dbo].[Xethue] CHECK CONSTRAINT [FKXethue_KH]
GO
ALTER TABLE [dbo].[Xethue]  WITH CHECK ADD  CONSTRAINT [FKXethue_Thongtinxe] FOREIGN KEY([Bienso])
REFERENCES [dbo].[Thongtinxe] ([Bienso])
GO
ALTER TABLE [dbo].[Xethue] CHECK CONSTRAINT [FKXethue_Thongtinxe]
GO
