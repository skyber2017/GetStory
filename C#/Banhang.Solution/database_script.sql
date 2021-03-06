USE [QuanlySinhvien]
GO
CREATE TABLE [dbo].[Hanghoa](
	[HanghoaId] [nvarchar](50) NOT NULL,
	[TenHanghoa] [nvarchar](200) NULL,
	[GiaBan] [float] NULL,
	[Mota] [nvarchar](500) NULL,
	[SoLuongTonKho] [int] NULL,
	[NhomHanghoaId] [nvarchar](50) NULL,
 CONSTRAINT [PK_Hanghoa] PRIMARY KEY CLUSTERED 
(
	[HanghoaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[NhomHanghoa](
	[NhomHanghoaId] [nvarchar](50) NOT NULL,
	[TenNhomHanghoa] [nvarchar](200) NULL,
	[Ghichu] [nvarchar](500) NULL,
 CONSTRAINT [PK_NhomHanghoa] PRIMARY KEY CLUSTERED 
(
	[NhomHanghoaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[Sinhvien](
	[Maso] [nvarchar](50) NOT NULL,
	[Holot] [nvarchar](200) NULL,
	[Ten] [nvarchar](50) NULL,
	[Ngaysinh] [datetime] NULL,
	[Gioitinh] [bit] NULL,
 CONSTRAINT [PK_Sinhvien] PRIMARY KEY CLUSTERED 
(
	[Maso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Hanghoa] ([HanghoaId], [TenHanghoa], [GiaBan], [Mota], [SoLuongTonKho], [NhomHanghoaId]) VALUES (N'sp001', N'Cocacola', 15000, N'Nước uống', 0, NULL)
INSERT [dbo].[Sinhvien] ([Maso], [Holot], [Ten], [Ngaysinh], [Gioitinh]) VALUES (N'sv02', N'Nguyễn Văn', N'Còn Đó', CAST(0x0000A02400000000 AS DateTime), 0)
INSERT [dbo].[Sinhvien] ([Maso], [Holot], [Ten], [Ngaysinh], [Gioitinh]) VALUES (N'sv03', N'Mai Văn', N'Tới', CAST(0x00009FFD00000000 AS DateTime), 1)
INSERT [dbo].[Sinhvien] ([Maso], [Holot], [Ten], [Ngaysinh], [Gioitinh]) VALUES (N'sv04', N'Nguyễn Thị Hoài', N'Thương', CAST(0x00009FFE00000000 AS DateTime), 1)
