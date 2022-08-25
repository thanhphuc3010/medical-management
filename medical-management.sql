USE [QLHT]
GO
/****** Object:  Table [dbo].[tbl_Supplier]    Script Date: 11/24/2021 20:14:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Supplier](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[Diachi] [nvarchar](100) NULL,
	[Sdt] [char](15) NULL,
	[Email] [varchar](30) NULL,
 CONSTRAINT [PK_tbl_Supplier] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_Supplier] ([MaNCC], [TenNCC], [Diachi], [Sdt], [Email]) VALUES (N'CC001     ', N'CTCP Dược Phẩm Cửu Long ', N'150 đường 14 tháng 9 Vĩnh Long', N'0703822129     ', N'info@fitgroup.com.vn')
INSERT [dbo].[tbl_Supplier] ([MaNCC], [TenNCC], [Diachi], [Sdt], [Email]) VALUES (N'CC002     ', N'Vinphaco - ViệtNam', N'124 Trần Hưng Đạo Hà Nội', N'0914235730     ', N'vinphac@vietnam.com.vn')
INSERT [dbo].[tbl_Supplier] ([MaNCC], [TenNCC], [Diachi], [Sdt], [Email]) VALUES (N'CC003     ', N'Olic(Thailand) Ltd', N'Bangkrason, Bangpa-In, Ayutthaya Province 13160', N'0883450643     ', N'olic@ltd.com.vn')
INSERT [dbo].[tbl_Supplier] ([MaNCC], [TenNCC], [Diachi], [Sdt], [Email]) VALUES (N'CC004     ', N'CTCP Dược Hậu Giang ', N'132 Ngọ Khánh, quận Ba Đình', N'02923895209    ', N'dhgpharma@dhgpharma.com.vn')
INSERT [dbo].[tbl_Supplier] ([MaNCC], [TenNCC], [Diachi], [Sdt], [Email]) VALUES (N'CC005     ', N'Công ty CPDP Minh Dân', N'132 Ngọ Khánh, quận Ba Đình, Hà Nội.', N'0288335694     ', N'dp@minhdan.com.vn')
INSERT [dbo].[tbl_Supplier] ([MaNCC], [TenNCC], [Diachi], [Sdt], [Email]) VALUES (N'CC006     ', N'Công ty TNHH Traphaco Hưng Yên', N'số 86 Hoàng Ngân, quận Cầu Giấy, Hà Nội.', N'0769784544     ', N'traphaco@hungyen.com.vn')
INSERT [dbo].[tbl_Supplier] ([MaNCC], [TenNCC], [Diachi], [Sdt], [Email]) VALUES (N'CC007     ', N'CTCP Dược phẩm An Thiên ', N'số 173 Thái Hà Đống Đa Hà Nội.', N'0265767767     ', N'dp@anthien.com.vn')
INSERT [dbo].[tbl_Supplier] ([MaNCC], [TenNCC], [Diachi], [Sdt], [Email]) VALUES (N'CC008     ', N'CTCP vắc xin và sinh phẩm Nha Trang', N'số 105C2 Vĩnh Hồ Đống Đa Hà Nội.', N'NULL0345787588 ', N'vacxin@sp.com.vn')
INSERT [dbo].[tbl_Supplier] ([MaNCC], [TenNCC], [Diachi], [Sdt], [Email]) VALUES (N'CC009     ', N'CTCP Dược phẩm CPC1 Hà Nội', N'số 109 Ô Chợ Dừa Đống Đa Hà Nội.', N'NULL0987433765 ', N'dp@cpc1.com.vn')
INSERT [dbo].[tbl_Supplier] ([MaNCC], [TenNCC], [Diachi], [Sdt], [Email]) VALUES (N'CC010     ', N'CTCP Dược - Trang thiết bị Bình Định ', N'số 48 Phan Đình Phùng Ba Đình Hà Nội.', N'0295478432     ', N'bidiphar@dp.com.vn')
INSERT [dbo].[tbl_Supplier] ([MaNCC], [TenNCC], [Diachi], [Sdt], [Email]) VALUES (N'CC011', N'CTCP Dược phẩm Hà Tây', N'Thường Tín, Hà Nội', N'0125486245     ', N'ht@gmai.com')
INSERT [dbo].[tbl_Supplier] ([MaNCC], [TenNCC], [Diachi], [Sdt], [Email]) VALUES (N'CC012', N'Cty Dược Hà Nội', N'Thanh Oai, Hà Nội', N'0125486215     ', N'duoc@gmail.com')
/****** Object:  Table [dbo].[tbl_Staff]    Script Date: 11/24/2021 20:14:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Staff](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[Chucvu] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[Gioitinh] [bit] NULL,
	[Chungchihanhnghe] [varchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Email] [varchar](30) NULL,
	[Sdt] [char](15) NULL,
 CONSTRAINT [PK_tbl_Staff] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_Staff] ([MaNV], [TenNV], [Chucvu], [Ngaysinh], [Gioitinh], [Chungchihanhnghe], [Diachi], [Email], [Sdt]) VALUES (N'ADMIN', N'admin', N'admin', CAST(0x33430B00 AS Date), NULL, N'', N'', N'', N'               ')
INSERT [dbo].[tbl_Staff] ([MaNV], [TenNV], [Chucvu], [Ngaysinh], [Gioitinh], [Chungchihanhnghe], [Diachi], [Email], [Sdt]) VALUES (N'NV01     ', N'Nguyễn Thị Hoa', N'Chủ cửa hàng', CAST(0xBB140B00 AS Date), 0, N'000001/HCM-CCHN', N'80 Lê Đại Hành, Hai Bà Trưng, Hà Nội', N'nguyenhoa@gmail.com', N'0972154861     ')
INSERT [dbo].[tbl_Staff] ([MaNV], [TenNV], [Chucvu], [Ngaysinh], [Gioitinh], [Chungchihanhnghe], [Diachi], [Email], [Sdt]) VALUES (N'NV02', N'Phạm Ngọc Mai', N'Nhân viên bánh hàng', CAST(0xA40D0B00 AS Date), 0, N'346534/HN-CCHN', N'60 Võ Thị Sáu, Hai Bà Trưng, Hà Nội', N'ngocmai@gmail.com', N'0618143199     ')
INSERT [dbo].[tbl_Staff] ([MaNV], [TenNV], [Chucvu], [Ngaysinh], [Gioitinh], [Chungchihanhnghe], [Diachi], [Email], [Sdt]) VALUES (N'NV03', N'Bùi Anh Tuấn', N'Nhân viên bánh hàng', CAST(0x6A070B00 AS Date), 1, N'435423/HP-CCHN', N'72 Phương Mai, Đống Đa, Hà Nội', N'anhtuan@gmail.com', N'0648161611     ')
INSERT [dbo].[tbl_Staff] ([MaNV], [TenNV], [Chucvu], [Ngaysinh], [Gioitinh], [Chungchihanhnghe], [Diachi], [Email], [Sdt]) VALUES (N'NV04', N'Nguyễn Minh Ngọc', N'Nhân viên bánh hàng', CAST(0x70130B00 AS Date), 1, N'3565457/HCM-CCHN', N'90 Chùa Bộc, Đống Đa, Hà Nội', N'minhngoc@gmail.com', N'0348168616     ')
INSERT [dbo].[tbl_Staff] ([MaNV], [TenNV], [Chucvu], [Ngaysinh], [Gioitinh], [Chungchihanhnghe], [Diachi], [Email], [Sdt]) VALUES (N'NV05', N'Đặng Thị Minh', N'Nhân viên bánh hàng', CAST(0x180E0B00 AS Date), 0, N'4344442/HCM-CCHN', N'1080 Giải Phóng, Hai Bà Trưng, Hà Nội', N'dangminh@gmail.com', N'0348616895     ')
/****** Object:  Table [dbo].[tbl_Customer]    Script Date: 11/24/2021 20:14:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Customer](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[Loaidoituong] [bit] NULL,
	[Diachi] [nvarchar](50) NULL,
	[Sdt] [char](15) NULL,
	[Email] [varchar](30) NULL,
	[Ghichu] [text] NULL,
 CONSTRAINT [PK_tbl_Khachhang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'0AWALKINGUEST', N'Khách vãng lai', NULL, N'', N'               ', N'', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0001', N'Nguyễn Thị Mai', NULL, N'189 Nghi Tàm, Yên Phụ, Tây Hồ, Hà Nội.', N'0914625453     ', N'trongchien@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0002', N'Hoàng Đức Duy', NULL, N'số 8 Đỗ Đức Dục, Từ Liêm, Hà Nội.', N'0375263512     ', N'ducduy@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0003', N'Nguyễn Thanh Kim Lan', NULL, N'38 Gia Ngư, Hoàn Kiếm, Hà Nội.', N'0348765819     ', N'kimlan@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0004', N'Đoàn Thị Diễm My', NULL, N'Số 1 Ngụy Như Kon Tum, Thanh Xuân, Hà Nội.', N'0915746876     ', N'diemmy@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0005', N'Lê Thị Mai Suốt', NULL, N'12 Nguyễn Quang Bích, Hoàn Kiếm, Hà Nội.', N'0387541263     ', N'maisuot@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0006', N'Nguyễn Thị Anh Thư', NULL, N'Số 7 Đinh Tiên Hoàng, Hoàn Kiếm, Hà Nội.', N'0915654728     ', N'anhthu@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0007', N'Đặng Văn Giàu', NULL, N'24 Tông Đản, Tràng Tiền, Hoàn Kiếm, Hà Nội', N'0382291812     ', N'vangiau@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0008', N'Lê Nhật Huế', NULL, N'132 Ngọ Khánh, quận Ba Đình, Hà Nội.', N'0928123421     ', N'nhathue@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0009', N'Dương Quốc Huy', NULL, N'số 86 Hoàng Ngân, quận Cầu Giấy, Hà Nội.', N'0347123412     ', N'quochuy@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0010', N'Phạm Trí Luân', NULL, N'Số 173, Thái Hà, Đống Đa, Hà Nội.', N'0913846131     ', N'triluan@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0011', N'Nguyễn Thị Ngọc Mai', NULL, N'số 105C2 Vĩnh Hồ, Đống Đa, Hà Nội.', N'0857356423     ', N'ngocmai@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0012', N'Nguyễn Phi Phàm', NULL, N'số 109 Ô Chợ Dừa, Đống Đa, Hà Nội.', N'0931446133     ', N'phipham@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0013', N'Dương Vĩnh Phúc', NULL, N'48 Phan Đình Phùng, Ba Đình Hà Nội.', N'0383757451     ', N'vinhphuc@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0014', N'Trần Thị Mỹ Phượng', NULL, N'550 Trần Khát Trân, Hai Bà Trưng Hà Nội', N'0381425812     ', N'myphuong@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0015', N'Ngô Thành Tài', NULL, N'17T3 Hoàng Đạo Thúy, Cầu Giấy Hà Nội.', N'0384636243     ', N'thanhtai@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0016', N'Lâm Huỳnh Phan Thanh', NULL, N'số 2 ngõ 84 Trần Thái Tông,Cầu Giấy, Hà Nội.', N'0932131512     ', N'phanthanh@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0017', N'Nguyễn Thị Cẩm Tiên', NULL, N'số 10 Lý Quốc Sư, Hoàn Kiếm, Hà Nội.', N'0956362341     ', N'camtien@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0018', N'Nguyễn Thị Thanh Tuyền', NULL, N'số 169 Đội Cấn, Ba Đình, Hà Nội', N'0385347631     ', N'thanhtuyen@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0019', N'Nguyễn Phong Vinh', NULL, N'số 1 Hàng Điếu, Hoàn Kiếm, Hà Nội.', N'0425837631     ', N'phongvinh@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0020', N'Nguyễn Ngọc Ánh', NULL, N'số 27 Ngũ Xã, Ba Đình, Hà Nội.', N'0385624513     ', N'ngocanh@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0021', N'Huỳnh Thị Diễm My', NULL, N'số 57 phố Hàng Lược, Hoàn Kiếm, Hà Nội.', N'0947536234     ', N'diemmy@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0022', N'Phạm Kim Ngân', NULL, N'số 1 Hàng Mành, Hoàn Kiếm, Hà Nội.', N'0925735623     ', N'kimngan@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0023', N'Phạm Thành Phát', NULL, N'số 32 Cầu Gỗ, Hoàn Kiếm, Hà Nội.', N'0925734623     ', N'thanhphat@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0024', N'Hồ Minh Quân', NULL, N'số 573 Đê La Thành, Hà Nội', N'0947382572     ', N'minhquan@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0025', N'Đinh Thị Diễm Thi', NULL, N'số 686 Nguyễn Văn Cừ, Long Biên, Hà Nội.', N'0386252123     ', N'diemthi@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0026', N'Trần Kim Thoa', NULL, N'số 50 Phan Kế Bính ,Quận Ba Đình, Hà Nội.', N'0385636114     ', N'kimthoa@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0027', N'Nguyễn Anh Thư', NULL, N'số 12 Võ Văn Dũng, Đống Đa ,Hà Nội.', N'0931216311     ', N'anhthu@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0028', N'Nguyễn Thị Cẩm Tiên', NULL, N'số 96 Kim Ngưu, Hai Bà Trưng, Hà Nội.', N'0932542222     ', N'camtien@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0029', N'Nguyễn Thị Lan Anh', NULL, N'số 11 Trần Điền, Thanh Xuân, Hà Nội.', N'0382828282     ', N'lananh@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0030', N'Đặng Văn Duy', NULL, N'số 76 Hoàng Quốc Việt, Cầu Giấy, Hà Nội.', N'0939999999     ', N'vanduy@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0031', N'Nguyễn Ngọc Cừ', NULL, N'số 145 Hoàng Công Chất, Từ Liêm, Hà Nội.', N'0388888888     ', N'ngoccu@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0032', N'Nguyễn văn Hậu', NULL, N'75 Tăng Bạt Hổ, Hai Bà Trưng, Hà Nội', N'0451872642     ', N'vanhau@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0033', N'Đặng Ngọc Mai', NULL, N'245 Trần Khát Trân, Hai Bà Trưng, Hà Nội', N'0451975269     ', N'ngocmai@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0034', N'Phùng Văn Thanh', NULL, N'90 Thanh Nhàn, Ha Bà Trưng, Hà Nội', N'0461872649     ', N'vanthanh@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0035', N'Nguyễn Quốc Bình', NULL, N'90 Lò Đúc, Hai Bà Trưng, Hà Nội', N'0847647589     ', N'quocbinh@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0036', N'Mai Hồng Ngân', NULL, N'Ngõ 58 Nguyễn Khánh Toàn, Cầu Giấy, Hà Nội', N'0648451684     ', N'hongngan@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0037', N'Phạm Phương Thúy', NULL, N'60 Võ Thị Sáu, Hai Bà Trưng, Hà Nội', N'0541364812     ', N'phuongthuy@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0038', N'Nguyễn Chí Huy', NULL, N'90 Phương Mai, Đống Đa, Hà Nội', N'0246856649     ', N'chihuy@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0039', N'Phạm Thị Thu', NULL, N'45 Đông Các, Đống Đa, Hà Nội', N'0566534418     ', N'thithu@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0040', N'Đinh Quốc Tuấn', NULL, N'Số 6 Trần Thái Tông, Ha Bà Trưng, Hà Nội', N'0646389846     ', N'quoctuan@gmail.com', N'')
INSERT [dbo].[tbl_Customer] ([MaKH], [TenKH], [Loaidoituong], [Diachi], [Sdt], [Email], [Ghichu]) VALUES (N'KH0041', N'Hà Thu Phương', NULL, N'KDT Linh Đàm, Thanh Trì ,Hà Nội', N'0646389848     ', N'quoctuan123@gmail.com', N'')
/****** Object:  Table [dbo].[tbl_make]    Script Date: 11/24/2021 20:14:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_make](
	[MaNSX] [nvarchar](50) NOT NULL,
	[TenNSX] [nvarchar](50) NULL,
	[Diachi] [nvarchar](100) NULL,
	[Sdt] [char](15) NULL,
	[Email] [varchar](30) NULL,
 CONSTRAINT [PK_tbl_make] PRIMARY KEY CLUSTERED 
(
	[MaNSX] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_make] ([MaNSX], [TenNSX], [Diachi], [Sdt], [Email]) VALUES (N'SX001     ', N'Công ty Cổ Phần Dược Phẩm Cửu Long ', N'150 đường 14 tháng 9, Phường 5', N'0703822129     ', N'info@fitgroup.com.vn')
INSERT [dbo].[tbl_make] ([MaNSX], [TenNSX], [Diachi], [Sdt], [Email]) VALUES (N'SX002     ', N'Vinphaco-ViệtNam', N'777 đường Mê Linh, Khai Quang, Vĩnh Yên, Vĩnh Phúc', N'0914235730     ', N'vinphac@vietnam.com.vn')
INSERT [dbo].[tbl_make] ([MaNSX], [TenNSX], [Diachi], [Sdt], [Email]) VALUES (N'SX003     ', N'Olic(Thailand)Ltd', N'Bangkrason, Bangpa-In, Ayutthaya Province 13160, Thailand', N'0883450643     ', N'olic@ltd.com.vn')
INSERT [dbo].[tbl_make] ([MaNSX], [TenNSX], [Diachi], [Sdt], [Email]) VALUES (N'SX004     ', N'CTCP Dược Hậu Giang - CN nhà máy DPDHG', N'Lô E2, Đường N4 Khu Công Nghiệp Hòa Xá, Phường, Nam Định ', N'02923895209    ', N'dhgpharma@dhgpharma.com.vn')
INSERT [dbo].[tbl_make] ([MaNSX], [TenNSX], [Diachi], [Sdt], [Email]) VALUES (N'SX005     ', N'Công ty CPDP MinhDân-ViệtNam', N'Tân Quang, Văn Lâm, Hưng Yên', N'0288335694     ', N'dp@minhdan.com.vn')
INSERT [dbo].[tbl_make] ([MaNSX], [TenNSX], [Diachi], [Sdt], [Email]) VALUES (N'SX006     ', N'Công ty TNHH Traphaco HưngYên - Việt Nam', N'314 Bông Sao, Phường 5, Quận 8, TP.HCM', N'0769784544     ', N'traphaco@hungyen.com.vn')
INSERT [dbo].[tbl_make] ([MaNSX], [TenNSX], [Diachi], [Sdt], [Email]) VALUES (N'SX007     ', N'Công ty cổ phần dược phẩm An Thiên - Việt Nam', N'26 Hàn Thuyên, Phường Xương Huân, Thành phố Nha Trang, Khánh Hòa', N'0265767767     ', N'dp@anthien.com.vn')
INSERT [dbo].[tbl_make] ([MaNSX], [TenNSX], [Diachi], [Sdt], [Email]) VALUES (N'SX008     ', N'Công ty cổ phần vắc xin và sinh phẩm Nha Trang', N'Cụm Công Nghiệp Hà Bình Phương, Văn Binh, Thường Tín, Hà Nội', N'0345787588     ', N'vacxin@sp.com.vn')
INSERT [dbo].[tbl_make] ([MaNSX], [TenNSX], [Diachi], [Sdt], [Email]) VALUES (N'SX009     ', N'Công ty cổ phần dược phẩm CPC1 Hà Nội- Việt Nam', N'Số 498 Nguyễn Thái Học, Phường Quang Trung, Thành phố Quy Nhơn', N'0987433765     ', N'dp@cpc1.com.vn')
INSERT [dbo].[tbl_make] ([MaNSX], [TenNSX], [Diachi], [Sdt], [Email]) VALUES (N'SX010     ', N'Công ty cổ phần Dược - Trang thiết bị Bình Định', N'C4 bis Bửu Long, Phường 15, Quận 10, Thành phố Hồ Chí Minh', N'0295478432     ', N'bidiphar@dp.com.vn')
/****** Object:  Table [dbo].[tbl_Invoice]    Script Date: 11/24/2021 20:14:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Invoice](
	[MaHD] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[Tongtien] [float] NOT NULL,
	[Dathanhtoan] [float] NOT NULL,
	[Trangthaihoadon] [nvarchar](20) NULL,
	[NgayHD] [datetime] NULL,
 CONSTRAINT [PK_tbl_Invoice_1] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00002', N'KH0001', N'ADMIN', 60500, 60500, N'Đã hoàn thành', CAST(0x0000ADC601474085 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00003', N'KH0002', N'ADMIN', 48950, 48950, N'Đã hoàn thành', CAST(0x0000ADC60147864C AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00004', N'0AWALKINGUEST', N'ADMIN', 78370, 78370, N'Đã hoàn thành', CAST(0x0000ADC70147A3D4 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00005', N'0AWALKINGUEST', N'ADMIN', 313500, 313500, N'Đã hoàn thành', CAST(0x0000ADC80147B811 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00006', N'0AWALKINGUEST', N'ADMIN', 148500, 148500, N'Đã hoàn thành', CAST(0x0000ADC80147D0C9 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00007', N'KH0004', N'ADMIN', 363000, 363000, N'Đã hoàn thành', CAST(0x0000ADC901484279 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00008', N'KH0003', N'ADMIN', 133370, 133370, N'Đã hoàn thành', CAST(0x0000ADC901484279 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00009', N'KH0007', N'ADMIN', 154000, 154000, N'Đã hoàn thành', CAST(0x0000ADCA01487D7A AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00010', N'0AWALKINGUEST', N'ADMIN', 407000, 407000, N'Đã hoàn thành', CAST(0x0000ADCA0148AEE9 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00011', N'KH0008', N'ADMIN', 49500, 49500, N'Đã hoàn thành', CAST(0x0000ADCB0148D8FA AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00012', N'KH0008', N'ADMIN', 60500, 60500, N'Đã hoàn thành', CAST(0x0000ADCC01603F60 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00013', N'KH0009', N'ADMIN', 33000, 33000, N'Đã hoàn thành', CAST(0x0000ADCC00B93667 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00014', N'0AWALKINGUEST', N'ADMIN', 77000, 77000, N'Đã hoàn thành', CAST(0x0000ADCC00F6924F AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00015', N'KH0008', N'ADMIN', 44550, 44550, N'Đã hoàn thành', CAST(0x0000ADCD00F6D0CB AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00016', N'KH0009', N'ADMIN', 203500, 203500, N'Đã hoàn thành', CAST(0x0000ADCD00F6DD67 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00017', N'KH0010', N'ADMIN', 44000, 44000, N'Đã hoàn thành', CAST(0x0000ADCD00F6FA6E AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00018', N'0AWALKINGUEST', N'ADMIN', 121000, 121000, N'Đã hoàn thành', CAST(0x0000ADCD00F79A82 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00019', N'KH0015', N'ADMIN', 44000, 44000, N'Đã hoàn thành', CAST(0x0000ADCE00F7CAF8 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00020', N'KH0018', N'ADMIN', 264000, 264000, N'Đã hoàn thành', CAST(0x0000ADCF00FCAD07 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00021', N'KH0009', N'ADMIN', 66000, 66000, N'Đã hoàn thành', CAST(0x0000ADCF0152C4B9 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00022', N'KH0012', N'ADMIN', 49500, 49500, N'Đã hoàn thành', CAST(0x0000ADD00153A695 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00023', N'KH0004', N'ADMIN', 52250, 52250, N'Đã hoàn thành', CAST(0x0000ADD00153E0B6 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00024', N'KH0013', N'ADMIN', 203500, 203500, N'Đã hoàn thành', CAST(0x0000ADD101540F26 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00025', N'0AWALKINGUEST', N'ADMIN', 233750, 233750, N'Đã hoàn thành', CAST(0x0000ADD10154254C AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00026', N'KH0014', N'ADMIN', 154000, 154000, N'Đã hoàn thành', CAST(0x0000ADD30154FE31 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00027', N'KH0015', N'ADMIN', 60500, 60500, N'Đã hoàn thành', CAST(0x0000ADD301569A62 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00028', N'0AWALKINGUEST', N'ADMIN', 154000, 154000, N'Đã hoàn thành', CAST(0x0000ADD40156B565 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00029', N'KH0016', N'ADMIN', 203500, 203500, N'Đã hoàn thành', CAST(0x0000ADD40156FDE0 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00030', N'KH0017', N'ADMIN', 8250, 8250, N'Đã hoàn thành', CAST(0x0000ADD40158FC23 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00031', N'KH0018', N'ADMIN', 104500, 104500, N'Đã hoàn thành', CAST(0x0000ADD401596811 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00032', N'0AWALKINGUEST', N'ADMIN', 148500, 148500, N'Đã hoàn thành', CAST(0x0000ADD50159C870 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00033', N'KH0019', N'ADMIN', 44000, 44000, N'Đã hoàn thành', CAST(0x0000ADD5015ADD08 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00034', N'KH0020', N'ADMIN', 203500, 203500, N'Đã hoàn thành', CAST(0x0000ADD6015B2A82 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00035', N'0AWALKINGUEST', N'ADMIN', 30250, 30250, N'Đã hoàn thành', CAST(0x0000ADD6015B3DFD AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00036', N'KH0021', N'ADMIN', 253000, 253000, N'Đã hoàn thành', CAST(0x0000ADD7015B650B AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00037', N'KH0022', N'ADMIN', 313500, 313500, N'Đã hoàn thành', CAST(0x0000ADD7015B8889 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00038', N'0AWALKINGUEST', N'ADMIN', 154000, 154000, N'Đã hoàn thành', CAST(0x0000ADD8015BA1EC AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00039', N'KH0023', N'ADMIN', 264000, 264000, N'Đã hoàn thành', CAST(0x0000ADD9015BBF2F AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00040', N'KH0022', N'ADMIN', 341000, 341000, N'Đã hoàn thành', CAST(0x0000ADD9015DB7B2 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00041', N'KH0009', N'ADMIN', 176000, 176000, N'Đã hoàn thành', CAST(0x0000ADD9015F1003 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00042', N'0AWALKINGUEST', N'ADMIN', 78370, 78370, N'Đã hoàn thành', CAST(0x0000ADDA015F3833 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00043', N'0AWALKINGUEST', N'ADMIN', 313500, 313500, N'Đã hoàn thành', CAST(0x0000ADDA015F5F5B AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00044', N'KH0010', N'ADMIN', 55000, 55000, N'Đã hoàn thành', CAST(0x0000ADDA015F8D6C AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00045', N'0AWALKINGUEST', N'ADMIN', 16500, 16500, N'Đã hoàn thành', CAST(0x0000ADDB015FEEC8 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00046', N'KH0023', N'ADMIN', 156740, 156740, N'Đã hoàn thành', CAST(0x0000ADDB01616575 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00047', N'KH0025', N'ADMIN', 77000, 77000, N'Đã hoàn thành', CAST(0x0000ADDB01618A36 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00048', N'0AWALKINGUEST', N'ADMIN', 154000, 154000, N'Đã hoàn thành', CAST(0x0000ADDC0161CD52 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00049', N'KH0026', N'ADMIN', 176000, 176000, N'Đã hoàn thành', CAST(0x0000ADDC0161CD52 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00050', N'KH0026', N'ADMIN', 286000, 286000, N'Đã hoàn thành', CAST(0x0000ADDD0161ED92 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00051', N'0AWALKINGUEST', N'ADMIN', 231000, 231000, N'Đã hoàn thành', CAST(0x0000ADDD01641068 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00052', N'KH0026', N'ADMIN', 110000, 110000, N'Đã hoàn thành', CAST(0x0000ADDE00A33CB7 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00053', N'0AWALKINGUEST', N'ADMIN', 30250, 30250, N'Đã hoàn thành', CAST(0x0000ADDE00A719C7 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00054', N'KH0027', N'ADMIN', 99000, 99000, N'Đã hoàn thành', CAST(0x0000ADDF00A73C41 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00055', N'KH0028', N'ADMIN', 470250, 200000, N'Còn nợ', CAST(0x0000ADDF00A756FA AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00056', N'KH0029', N'ADMIN', 88000, 88000, N'Đã hoàn thành', CAST(0x0000ADDF00A79786 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00057', N'0AWALKINGUEST', N'ADMIN', 154000, 154000, N'Đã hoàn thành', CAST(0x0000ADE000A7BA85 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00058', N'KH0029', N'ADMIN', 148500, 148500, N'Đã hoàn thành', CAST(0x0000ADE000A7D4F6 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00059', N'KH0030', N'ADMIN', 264000, 264000, N'Đã hoàn thành', CAST(0x0000ADE000A7FE32 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00060', N'0AWALKINGUEST', N'ADMIN', 264000, 264000, N'Đã hoàn thành', CAST(0x0000ADE100A817C6 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00061', N'KH0031', N'ADMIN', 44550, 44550, N'Đã hoàn thành', CAST(0x0000ADE100A83B5F AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00062', N'0AWALKINGUEST', N'ADMIN', 222750, 222750, N'Đã hoàn thành', CAST(0x0000ADE200A85AA0 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00063', N'KH0032', N'ADMIN', 101750, 101750, N'Đã hoàn thành', CAST(0x0000ADE200A8828F AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00064', N'KH0033', N'ADMIN', 165000, 165000, N'Đã hoàn thành', CAST(0x0000ADE200A8A7D2 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00065', N'0AWALKINGUEST', N'ADMIN', 121000, 121000, N'Đã hoàn thành', CAST(0x0000ADE300A8BE6C AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00066', N'0AWALKINGUEST', N'ADMIN', 99000, 99000, N'Đã hoàn thành', CAST(0x0000ADE400A8D155 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00067', N'KH0034', N'ADMIN', 77000, 77000, N'Đã hoàn thành', CAST(0x0000ADE400A8E83E AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00068', N'KH0035', N'ADMIN', 30250, 30250, N'Đã hoàn thành', CAST(0x0000ADE500A9025C AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00069', N'0AWALKINGUEST', N'ADMIN', 77000, 77000, N'Đã hoàn thành', CAST(0x0000ADE500A915B9 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00070', N'KH0036', N'ADMIN', 101750, 101750, N'Đã hoàn thành', CAST(0x0000ADE600A9445D AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00071', N'KH0037', N'ADMIN', 66000, 66000, N'Đã hoàn thành', CAST(0x0000ADE7015963CE AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00072', N'KH0038', N'ADMIN', 60500, 60500, N'Đã hoàn thành', CAST(0x0000ADE701598A1C AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00073', N'KH0039', N'ADMIN', 156750, 156750, N'Đã hoàn thành', CAST(0x0000ADE70159A154 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00074', N'KH0040', N'ADMIN', 154000, 154000, N'Đã hoàn thành', CAST(0x0000ADE70159BCFE AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00075', N'0AWALKINGUEST', N'ADMIN', 16500, 16500, N'Đã hoàn thành', CAST(0x0000ADE70159D58B AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00076', N'KH0041', N'ADMIN', 264000, 264000, N'Đã hoàn thành', CAST(0x0000ADE70159E690 AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00077', N'0AWALKINGUEST', N'ADMIN', 101750, 101750, N'Đã hoàn thành', CAST(0x0000ADE70159FDDA AS DateTime))
INSERT [dbo].[tbl_Invoice] ([MaHD], [MaKH], [MaNV], [Tongtien], [Dathanhtoan], [Trangthaihoadon], [NgayHD]) VALUES (N'HD00078', N'KH0002', N'ADMIN', 167750, 167750, N'Đã hoàn thành', CAST(0x0000ADEA0088FFE7 AS DateTime))
/****** Object:  Table [dbo].[tbl_User]    Script Date: 11/24/2021 20:14:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[Tenuser] [char](20) NOT NULL,
	[Matkhau] [char](20) NOT NULL,
	[Ngaytao] [datetime] NULL,
	[Ngaychinhsua] [datetime] NULL,
 CONSTRAINT [PK_tbl_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_User] ON
INSERT [dbo].[tbl_User] ([id], [MaNV], [Tenuser], [Matkhau], [Ngaytao], [Ngaychinhsua]) VALUES (1, N'NV01', N'Hoa                 ', N'hoa12345678         ', CAST(0x0000ADB7011D908D AS DateTime), CAST(0x0000ADB7011D908D AS DateTime))
INSERT [dbo].[tbl_User] ([id], [MaNV], [Tenuser], [Matkhau], [Ngaytao], [Ngaychinhsua]) VALUES (2, N'NV02', N'Mai                 ', N'mai12345678         ', CAST(0x0000ADB7011F010D AS DateTime), CAST(0x0000ADB7011F010D AS DateTime))
INSERT [dbo].[tbl_User] ([id], [MaNV], [Tenuser], [Matkhau], [Ngaytao], [Ngaychinhsua]) VALUES (3, N'NV03', N'Tuan                ', N'tuan12345678        ', CAST(0x0000ADB70120CD39 AS DateTime), CAST(0x0000ADB70120CD39 AS DateTime))
INSERT [dbo].[tbl_User] ([id], [MaNV], [Tenuser], [Matkhau], [Ngaytao], [Ngaychinhsua]) VALUES (4, N'NV04', N'Ngoc                ', N'ngoc12345678        ', CAST(0x0000ADB70120F277 AS DateTime), CAST(0x0000ADB70120F277 AS DateTime))
INSERT [dbo].[tbl_User] ([id], [MaNV], [Tenuser], [Matkhau], [Ngaytao], [Ngaychinhsua]) VALUES (5, N'NV05', N'minhmt              ', N'123456              ', CAST(0x0000ADB701212C7F AS DateTime), CAST(0x0000ADB701212C7F AS DateTime))
INSERT [dbo].[tbl_User] ([id], [MaNV], [Tenuser], [Matkhau], [Ngaytao], [Ngaychinhsua]) VALUES (6, N'ADMIN', N'admin               ', N'admin               ', CAST(0x0000ADD8011C671E AS DateTime), CAST(0x0000ADD8011C671E AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_User] OFF
/****** Object:  Table [dbo].[tbl_Item]    Script Date: 11/24/2021 20:14:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Item](
	[Mathuoc] [nvarchar](50) NOT NULL,
	[Nhomthuoc] [nchar](10) NULL,
	[MaNSX] [nvarchar](50) NOT NULL,
	[Tenthuoc] [nvarchar](50) NOT NULL,
	[Donvi] [nchar](10) NOT NULL,
	[Hamluong] [nchar](20) NOT NULL,
	[Soluong] [int] NOT NULL,
	[Donggoi] [nvarchar](50) NOT NULL,
	[Thanhphan] [nvarchar](50) NOT NULL,
	[Dongia] [int] NOT NULL,
	[Gianhap] [int] NOT NULL,
	[Ghichu] [text] NULL,
 CONSTRAINT [PK_tbl_Item] PRIMARY KEY CLUSTERED 
(
	[Mathuoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020BD01', N'KS        ', N'SX001', N'Amoxicillin', N'Viên      ', N'500mg               ', 1020, N'Hộp: 10 vỉ x 10 viên', N'Amoxicillin', 5225, 4750, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020BD02', N'TB        ', N'SX005', N'Enat 400', N'Viên      ', N'400mg               ', 1670, N'Hộp: 3 vỉ x 10 viên', N'vitamin E', 4950, 4500, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020GA02', N'VT        ', N'SX008', N'Cồn', N'Chai      ', N'500ml               ', 549, N'Thùng 20 chai', N'Ethanol', 10450, 9500, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020GA05', N'KS        ', N'SX008', N'Cephalexin', N'Gói       ', N'250mg               ', 1050, N'Hộp: 12 gói', N'Cephalexin', 6600, 6000, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020GB01', N'VT        ', N'SX008', N'Oxy già', N'Chai      ', N'60ml                ', 694, N'Thùng 20 chai', N'3% W/W hydrogen peroxide', 8250, 7500, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020GD03', N'KV        ', N'SX002', N'Aspirin', N'Viên      ', N'100mg               ', 2150, N'Hộp: 3 vỉ x 10 viên', N'Acetylsalicylic acid', 7837, 7125, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020GE01', N'TM        ', N'SX003', N'Captopril', N'Viên      ', N'25mg                ', 1270, N'Hộp: 10 vỉ x 10 viên', N'Captopril', 5225, 4750, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020GH01', N'TPCN      ', N'SX001', N'Cốm Vi sinh', N'Hộp       ', N'2g/gói              ', 100, N'Hộp: 60 gói', N'vitamnin tổng hợp và axit béo', 66000, 60000, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020GR02', N'KV        ', N'SX007', N'Celecoxid', N'Viên      ', N'20mg                ', 2490, N'Hộp: 3 vỉ x 10 viên', N'Celecoxid', 1650, 1500, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020GX01', N'VT        ', N'SX002', N'Băng cá nhân', N'Cái       ', N'2cm x 6cm           ', 3110, N'Hộp: 10 miếng', N'Vải', 3025, 2750, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020GX02', N'TPCN      ', N'SX007', N'Bio - acimin', N'Hộp       ', N'40mg                ', 540, N'Hộp: 30 gói x 4g', N'Orafti Synergy 1/ Bacillus Clausii', 101750, 92500, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020GX03', N'KS        ', N'SX006', N'Cefixim', N'Viên      ', N'200 mg              ', 930, N'Hộp: 2 vỉ  x 10 viên', N'Cefixim', 2200, 2000, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020HD01', N'VT        ', N'SX009', N'Cồn đỏ', N'Chai      ', N'50ml                ', 996, N'Thùng 20 chai', N'Hydrogen peroxide', 7150, 6500, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020HD05', N'TB        ', N'SX008', N'Sandoz', N'Viên      ', N'500mg               ', 2410, N'Hộp: 20 viên sủi', N'Canxi', 7425, 6750, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020HD06', N'KV        ', N'SX001', N'Amlodpin', N'Viên      ', N'5mg                 ', 1000, N'Hộp: 3 vỉ x 10 viên', N'Amlodpin', 4950, 4500, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020HE02', N'TM        ', N'SX002', N'Nifedipin', N'Viên      ', N'10mg                ', 1460, N'Hộp: 10 vỉ x 10 viên', N'Nifedipin', 4950, 4500, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020HG01', N'KS        ', N'SX005', N'Azithromycin', N'Viên      ', N'500mg               ', 500, N'Hộp: 3 vỉ x 10 viên', N'Azithromycin', 4400, 4000, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020HG02', N'TPCN      ', N'SX001', N'Bảo Xuân', N'Lọ        ', N'500mg               ', 440, N'Lọ 120 viên', N'Mầm đậu nành/ Collagen từ cá/Vitamin E', 156750, 142500, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020HQ05', N'KS        ', N'SX007', N'Klacid', N'Viên      ', N'250mg               ', 990, N'Hộp: 1 vỉ x 10 viên', N'Clarithromycin', 4400, 4000, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020HX08', N'TPCN      ', N'SX002', N'Giải Độc gan tuệ Linh', N'Hộp       ', N'500mg               ', 284, N'Hộp: 60 viên', N'Cà gai leo/Cây mật nhân', 132000, 120000, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2020KE01', N'KV        ', N'SX008', N'Piroxicam', N'Viên      ', N'20mg                ', 1170, N'Hộp: 3 vỉ x 10 viên', N'Piroxicam', 5500, 5000, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2021GH02', N'TM        ', N'SX001', N'Vinzix', N'Viên      ', N'40mg                ', 780, N'Hộp: 5 vỉ x 50 viên', N'Vinzix', 4400, 4000, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2021GX07', N'Vitamin   ', N'SX009', N'Obimin', N'Viên      ', N'100mg               ', 1130, N'Hộp: 3 vỉ x 10 viên', N'Sắt', 5500, 5000, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2021HA05', N'TM        ', N'SX008', N'Nitromin', N'Viên      ', N'2,6mg               ', 560, N'Hộp: 3 vỉ x 10 viên', N'Nitromin', 7700, 7000, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2021HD02', N'KV        ', N'SX002', N'Meloxicam', N'Viên      ', N'7,5mg               ', 500, N'Hộp: 2 vỉ x 10 viên', N'Meloxicam', 4400, 4000, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2021KA02', N'Vitamin   ', N'SX010', N'Vitamin C', N'Viên      ', N'100mg               ', 690, N'Hộp: 10 vỉ x 30 viên', N'Vitamin C', 8800, 8000, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2021KE02', N'KV        ', N'SX007', N'Prednison', N'Viên      ', N'5mg                 ', 450, N'Hộp: 10 vỉ x 10 viên', N'Prednison', 4675, 4250, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2021KH08', N'TPCN      ', N'SX010', N'Trà Tâm Lan', N'Hộp       ', N'40mg                ', 488, N'Hộp: 30 túi', N'Cây Hoàn ngọc/ Cúc hoa/Kim ngân hoa', 77000, 70000, N'')
INSERT [dbo].[tbl_Item] ([Mathuoc], [Nhomthuoc], [MaNSX], [Tenthuoc], [Donvi], [Hamluong], [Soluong], [Donggoi], [Thanhphan], [Dongia], [Gianhap], [Ghichu]) VALUES (N'2021KX07', N'TPCN      ', N'SX006', N'Sâm alipas', N'Hộp       ', N'240mg               ', 94, N'Hộp: 30 viên', N'Cây mật nhân', 77000, 70000, N'')
/****** Object:  Table [dbo].[tbl_PurchaseOrder]    Script Date: 11/24/2021 20:14:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PurchaseOrder](
	[Manhap] [nvarchar](50) NOT NULL,
	[MaNCC] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[Ngaynhap] [datetime] NOT NULL,
	[Soluonglo] [int] NOT NULL,
	[Tongtien] [float] NOT NULL,
	[Dathanhtoan] [float] NOT NULL,
	[Thue] [int] NOT NULL,
 CONSTRAINT [PK_tbl_PuschaseOrder] PRIMARY KEY CLUSTERED 
(
	[Manhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00001', N'CC002     ', N'ADMIN', CAST(0x0000ADB40100FDBE AS DateTime), 1, 2500000, 2500000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00002', N'CC005     ', N'ADMIN', CAST(0x0000ADB801011778 AS DateTime), 3, 11700000, 11700000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00003', N'CC008     ', N'ADMIN', CAST(0x0000ADBA0101A3E4 AS DateTime), 1, 4800000, 4800000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00004', N'CC006     ', N'ADMIN', CAST(0x0000ADBD0101CC2A AS DateTime), 1, 3000000, 3000000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00005', N'CC007     ', N'ADMIN', CAST(0x0000ADBD01023821 AS DateTime), 1, 6000000, 6000000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00006', N'CC008     ', N'ADMIN', CAST(0x0000ADBD01027789 AS DateTime), 1, 2500000, 2500000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00007', N'CC008     ', N'ADMIN', CAST(0x0000ADC00102BC96 AS DateTime), 1, 1000000, 1000000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00008', N'CC005     ', N'ADMIN', CAST(0x0000ADC00102EE11 AS DateTime), 2, 25000000, 25000000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00009', N'CC005     ', N'ADMIN', CAST(0x0000ADC2010335FD AS DateTime), 2, 3200000, 3200000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00010', N'CC007     ', N'ADMIN', CAST(0x0000ADC701038DBB AS DateTime), 2, 12400000, 12400000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00011', N'CC011', N'ADMIN', CAST(0x0000ADC70103E392 AS DateTime), 1, 4200000, 4200000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00012', N'CC006     ', N'ADMIN', CAST(0x0000ADC701041F91 AS DateTime), 2, 9200000, 9200000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00013', N'CC004     ', N'ADMIN', CAST(0x0000ADC7010466A9 AS DateTime), 2, 17500000, 17500000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00014', N'CC005     ', N'ADMIN', CAST(0x0000ADC90106A1F3 AS DateTime), 1, 16000000, 16000000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00015', N'CC002     ', N'ADMIN', CAST(0x0000ADC90106C2E2 AS DateTime), 2, 4000000, 4000000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00016', N'CC006     ', N'ADMIN', CAST(0x0000ADC90106FAA3 AS DateTime), 1, 8000000, 8000000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00017', N'CC007     ', N'ADMIN', CAST(0x0000ADCC01076DFB AS DateTime), 1, 1600000, 1600000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00018', N'CC004     ', N'ADMIN', CAST(0x0000ADCC0107922B AS DateTime), 1, 2000000, 2000000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00019', N'CC008     ', N'ADMIN', CAST(0x0000ADCD0107B16F AS DateTime), 1, 6750000, 6750000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00020', N'CC003     ', N'ADMIN', CAST(0x0000ADD10107DB95 AS DateTime), 2, 7000000, 7000000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00021', N'CC004     ', N'ADMIN', CAST(0x0000ADDA0108206A AS DateTime), 1, 2500000, 2500000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00022', N'CC009     ', N'ADMIN', CAST(0x0000ADDA010855CF AS DateTime), 2, 7500000, 7500000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00023', N'CC004     ', N'ADMIN', CAST(0x0000ADDE0108B3EA AS DateTime), 2, 9200000, 9200000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00024', N'CC004     ', N'ADMIN', CAST(0x0000ADDF0109908C AS DateTime), 1, 28000000, 28000000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00025', N'CC010     ', N'ADMIN', CAST(0x0000ADDF0109C065 AS DateTime), 2, 28000000, 28000000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00026', N'CC011', N'ADMIN', CAST(0x0000ADDF010A2BD6 AS DateTime), 1, 800000, 800000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00027', N'CC006     ', N'ADMIN', CAST(0x0000ADE0010A5267 AS DateTime), 1, 3000000, 3000000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00028', N'CC008     ', N'ADMIN', CAST(0x0000ADE0010A775B AS DateTime), 1, 22500000, 22500000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00029', N'CC009     ', N'ADMIN', CAST(0x0000ADE0010AA5A3 AS DateTime), 2, 5500000, 5500000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00030', N'CC006     ', N'ADMIN', CAST(0x0000ADE2010AE121 AS DateTime), 1, 28000000, 28000000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00031', N'CC008     ', N'ADMIN', CAST(0x0000ADE2010B00EE AS DateTime), 1, 7200000, 7200000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00032', N'CC006     ', N'ADMIN', CAST(0x0000ADE3010B3EB3 AS DateTime), 1, 3500000, 3500000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00033', N'CC007     ', N'ADMIN', CAST(0x0000ADE3010C1281 AS DateTime), 1, 3000000, 3000000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00034', N'CC003     ', N'ADMIN', CAST(0x0000ADE400B73437 AS DateTime), 1, 2100000, 2100000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00035', N'CC011', N'ADMIN', CAST(0x0000ADE4011BC406 AS DateTime), 1, 450000, 450000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00036', N'CC007     ', N'ADMIN', CAST(0x0000ADE50145C639 AS DateTime), 1, 10000000, 10000000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00037', N'CC005     ', N'ADMIN', CAST(0x0000ADE600F481B1 AS DateTime), 1, 900000, 900000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00038', N'CC005     ', N'ADMIN', CAST(0x0000ADE600F4B90B AS DateTime), 1, 13000000, 13000000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00039', N'CC003     ', N'ADMIN', CAST(0x0000ADE90098D032 AS DateTime), 1, 675000, 675000, 0)
INSERT [dbo].[tbl_PurchaseOrder] ([Manhap], [MaNCC], [MaNV], [Ngaynhap], [Soluonglo], [Tongtien], [Dathanhtoan], [Thue]) VALUES (N'PN00040', N'CC003     ', N'ADMIN', CAST(0x0000ADEA00882108 AS DateTime), 2, 6400000, 6400000, 0)
/****** Object:  Table [dbo].[tbl_Payment]    Script Date: 11/24/2021 20:14:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Payment](
	[MaTT] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [nvarchar](50) NOT NULL,
	[NgayTT] [datetime] NOT NULL,
	[SoTienTT] [decimal](10, 0) NOT NULL,
	[PhuongThucTT] [nvarchar](20) NOT NULL,
	[NoidungTT] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Payment] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_Payment] ON
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (67, N'HD00002', CAST(0x0000ADC601474085 AS DateTime), CAST(60500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (68, N'HD00003', CAST(0x0000ADC60147864C AS DateTime), CAST(48950 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (69, N'HD00004', CAST(0x0000ADC70147A3D4 AS DateTime), CAST(78370 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (70, N'HD00005', CAST(0x0000ADC80147B811 AS DateTime), CAST(313500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (71, N'HD00006', CAST(0x0000ADC80147D0C9 AS DateTime), CAST(100000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (72, N'HD00006', CAST(0x0000ADC80147D0C9 AS DateTime), CAST(48500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (73, N'HD00007', CAST(0x0000ADC901484279 AS DateTime), CAST(363000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (74, N'HD00008', CAST(0x0000ADC901484279 AS DateTime), CAST(55000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (75, N'HD00008', CAST(0x0000ADC901484279 AS DateTime), CAST(78370 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (76, N'HD00009', CAST(0x0000ADCA01487D7A AS DateTime), CAST(154000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (77, N'HD00010', CAST(0x0000ADCA0148AEE9 AS DateTime), CAST(407000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (78, N'HD00011', CAST(0x0000ADCB0148D8FA AS DateTime), CAST(49500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (79, N'HD00012', CAST(0x0000ADCC01603F60 AS DateTime), CAST(60500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (80, N'HD00013', CAST(0x0000ADCC00B93667 AS DateTime), CAST(33000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (81, N'HD00014', CAST(0x0000ADCC00F6924F AS DateTime), CAST(77000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (82, N'HD00015', CAST(0x0000ADCD00F6D0CB AS DateTime), CAST(44550 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (83, N'HD00017', CAST(0x0000ADCD00F6FA6E AS DateTime), CAST(44000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (84, N'HD00018', CAST(0x0000ADCD00F79A82 AS DateTime), CAST(121000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (85, N'HD00019', CAST(0x0000ADCE00F7CAF8 AS DateTime), CAST(44000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (86, N'HD00020', CAST(0x0000ADCF00FCAD07 AS DateTime), CAST(264000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (87, N'HD00021', CAST(0x0000ADCF015307A0 AS DateTime), CAST(66000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (88, N'HD00022', CAST(0x0000ADD00153A695 AS DateTime), CAST(49500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (89, N'HD00023', CAST(0x0000ADD00153E0B6 AS DateTime), CAST(52250 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (90, N'HD00024', CAST(0x0000ADD101540F26 AS DateTime), CAST(203500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (91, N'HD00025', CAST(0x0000ADD10154254C AS DateTime), CAST(233750 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (92, N'HD00026', CAST(0x0000ADD30154FE31 AS DateTime), CAST(154000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (93, N'HD00027', CAST(0x0000ADD301569A62 AS DateTime), CAST(60500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (94, N'HD00028', CAST(0x0000ADD40156B565 AS DateTime), CAST(154000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (95, N'HD00029', CAST(0x0000ADD40156FDE0 AS DateTime), CAST(100000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (96, N'HD00029', CAST(0x0000ADD40156FDE0 AS DateTime), CAST(103500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (97, N'HD00030', CAST(0x0000ADD40158FC23 AS DateTime), CAST(8250 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (98, N'HD00031', CAST(0x0000ADD401596811 AS DateTime), CAST(104500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (99, N'HD00032', CAST(0x0000ADD50159C870 AS DateTime), CAST(148500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (100, N'HD00033', CAST(0x0000ADD5015ADD08 AS DateTime), CAST(44000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (101, N'HD00034', CAST(0x0000ADD6015B2A82 AS DateTime), CAST(203500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (102, N'HD00035', CAST(0x0000ADD6015B3DFD AS DateTime), CAST(30250 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (103, N'HD00036', CAST(0x0000ADD7015B650B AS DateTime), CAST(253000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (104, N'HD00037', CAST(0x0000ADD7015B8889 AS DateTime), CAST(313500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (105, N'HD00038', CAST(0x0000ADD8015BA1EC AS DateTime), CAST(154000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (106, N'HD00039', CAST(0x0000ADD9015BBF2F AS DateTime), CAST(264000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (107, N'HD00040', CAST(0x0000ADD9015DB7B2 AS DateTime), CAST(341000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (108, N'HD00041', CAST(0x0000ADD9015F1003 AS DateTime), CAST(176000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (109, N'HD00042', CAST(0x0000ADDA015F3833 AS DateTime), CAST(78370 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (110, N'HD00043', CAST(0x0000ADDA015F5F5B AS DateTime), CAST(313500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (111, N'HD00044', CAST(0x0000ADDA015F8D6C AS DateTime), CAST(55000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (112, N'HD00045', CAST(0x0000ADDB015FEEC8 AS DateTime), CAST(16500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (113, N'HD00046', CAST(0x0000ADDB01616575 AS DateTime), CAST(156740 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (114, N'HD00047', CAST(0x0000ADDB01618A36 AS DateTime), CAST(77000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (115, N'HD00049', CAST(0x0000ADDC0161CD52 AS DateTime), CAST(176000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (116, N'HD00050', CAST(0x0000ADDD0161ED92 AS DateTime), CAST(286000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (117, N'HD00051', CAST(0x0000ADDD01641068 AS DateTime), CAST(231000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (118, N'HD00052', CAST(0x0000ADDE00A33CB7 AS DateTime), CAST(110000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (120, N'HD00053', CAST(0x0000ADDE00A719C7 AS DateTime), CAST(30250 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (121, N'HD00054', CAST(0x0000ADDF00A73C41 AS DateTime), CAST(99000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (122, N'HD00055', CAST(0x0000ADDF00A756FA AS DateTime), CAST(200000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (123, N'HD00056', CAST(0x0000ADDF00A79786 AS DateTime), CAST(88000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (124, N'HD00057', CAST(0x0000ADE000A7BA85 AS DateTime), CAST(154000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (125, N'HD00058', CAST(0x0000ADE000A7D4F6 AS DateTime), CAST(148500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (126, N'HD00059', CAST(0x0000ADE000A7FE32 AS DateTime), CAST(264000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (127, N'HD00060', CAST(0x0000ADE100A817C6 AS DateTime), CAST(264000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (128, N'HD00061', CAST(0x0000ADE100A83B5F AS DateTime), CAST(44550 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (129, N'HD00062', CAST(0x0000ADE200A85AA0 AS DateTime), CAST(222750 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (130, N'HD00063', CAST(0x0000ADE200A8828F AS DateTime), CAST(101750 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (131, N'HD00064', CAST(0x0000ADE200A8A7D2 AS DateTime), CAST(165000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (132, N'HD00065', CAST(0x0000ADE300A8BE6C AS DateTime), CAST(121000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (133, N'HD00066', CAST(0x0000ADE400A8D155 AS DateTime), CAST(99000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (134, N'HD00067', CAST(0x0000ADE400A8E83E AS DateTime), CAST(77000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (135, N'HD00068', CAST(0x0000ADE500A9025C AS DateTime), CAST(30250 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (136, N'HD00069', CAST(0x0000ADE500A915B9 AS DateTime), CAST(77000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (137, N'HD00070', CAST(0x0000ADE600A9445D AS DateTime), CAST(101750 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (138, N'HD00016', CAST(0x0000ADE701590F05 AS DateTime), CAST(203500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (139, N'HD00071', CAST(0x0000ADE701598579 AS DateTime), CAST(66000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (140, N'HD00072', CAST(0x0000ADE701599D29 AS DateTime), CAST(60500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (141, N'HD00073', CAST(0x0000ADE70159B768 AS DateTime), CAST(156750 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (142, N'HD00074', CAST(0x0000ADE70159D095 AS DateTime), CAST(154000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (143, N'HD00075', CAST(0x0000ADE70159E3B8 AS DateTime), CAST(16500 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (144, N'HD00076', CAST(0x0000ADE70159F6F6 AS DateTime), CAST(264000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (145, N'HD00077', CAST(0x0000ADE7015A1673 AS DateTime), CAST(101750 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (146, N'HD00048', CAST(0x0000ADE90099DEBA AS DateTime), CAST(154000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (147, N'HD00078', CAST(0x0000ADEA0089C5CE AS DateTime), CAST(100000 AS Decimal(10, 0)), N'Tiền mặt', N'')
INSERT [dbo].[tbl_Payment] ([MaTT], [MaHD], [NgayTT], [SoTienTT], [PhuongThucTT], [NoidungTT]) VALUES (148, N'HD00078', CAST(0x0000ADEA0089D633 AS DateTime), CAST(67750 AS Decimal(10, 0)), N'Tiền mặt', N'')
SET IDENTITY_INSERT [dbo].[tbl_Payment] OFF
/****** Object:  Table [dbo].[tbl_InvoiceDetail]    Script Date: 11/24/2021 20:14:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_InvoiceDetail](
	[MaHD] [nvarchar](50) NOT NULL,
	[Mathuoc] [nvarchar](50) NOT NULL,
	[Soluong] [int] NOT NULL,
	[Dongia] [float] NOT NULL,
	[Ngaytao] [datetime] NULL,
	[Ngaychinhsua] [datetime] NULL,
 CONSTRAINT [PK_tbl_InvoiceDetail_1] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[Mathuoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00002', N'2020BD01', 10, 6050, CAST(0x0000ADC601474085 AS DateTime), CAST(0x0000ADC601474085 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00003', N'2020GA02', 1, 10450, CAST(0x0000ADC60147864C AS DateTime), CAST(0x0000ADC60147864C AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00003', N'2020GB01', 1, 8250, CAST(0x0000ADC7014772C3 AS DateTime), CAST(0x0000ADC7014772C3 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00003', N'2020GX01', 10, 3025, CAST(0x0000ADC70147784E AS DateTime), CAST(0x0000ADC70147784E AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00004', N'2020GD03', 10, 7837, CAST(0x0000ADC70147A3D4 AS DateTime), CAST(0x0000ADC70147A3D4 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00005', N'2020HG02', 2, 156750, CAST(0x0000ADC80147B811 AS DateTime), CAST(0x0000ADC80147B811 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00006', N'2020HD05', 20, 7425, CAST(0x0000ADC80147D0C9 AS DateTime), CAST(0x0000ADC80147D0C9 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00007', N'2020HX08', 3, 121000, CAST(0x0000ADC901484279 AS DateTime), CAST(0x0000ADC90148001A AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00008', N'2020GA05', 10, 3300, CAST(0x0000ADC901484279 AS DateTime), CAST(0x0000ADC901484279 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00008', N'2020GD03', 10, 7837, CAST(0x0000ADCA014852A3 AS DateTime), CAST(0x0000ADCA014852A3 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00008', N'2020GX03', 10, 2200, CAST(0x0000ADCA01483395 AS DateTime), CAST(0x0000ADCA01483395 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00009', N'2021HA05', 20, 7700, CAST(0x0000ADCA01487D7A AS DateTime), CAST(0x0000ADCA01487D7A AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00010', N'2020HX08', 1, 121000, CAST(0x0000ADCA0148AEE9 AS DateTime), CAST(0x0000ADCA0148AEE9 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00010', N'2021GX07', 20, 5500, CAST(0x0000ADCB0148A695 AS DateTime), CAST(0x0000ADCB0148A695 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00010', N'2021KA02', 20, 8800, CAST(0x0000ADCB01489AC7 AS DateTime), CAST(0x0000ADCB01489AC7 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00011', N'2020BD02', 10, 4950, CAST(0x0000ADCB0148D8FA AS DateTime), CAST(0x0000ADCB0148D8FA AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00012', N'2020BD01', 10, 6050, CAST(0x0000ADCC01603F60 AS DateTime), CAST(0x0000ADCC01603F60 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00013', N'2020GA05', 10, 3300, CAST(0x0000ADCC00B93667 AS DateTime), CAST(0x0000ADCC00B93667 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00014', N'2021KX07', 1, 77000, CAST(0x0000ADCC00F6924F AS DateTime), CAST(0x0000ADCC00F6924F AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00015', N'2020GX01', 10, 3025, CAST(0x0000ADCD00F6D0CB AS DateTime), CAST(0x0000ADCD00F6D0CB AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00015', N'2020HD01', 2, 7150, CAST(0x0000ADCD00F6C943 AS DateTime), CAST(0x0000ADCD00F6C943 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00016', N'2020GX02', 2, 101750, CAST(0x0000ADCD00F6FA6E AS DateTime), CAST(0x0000ADCD00F6FA6E AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00017', N'2020GX03', 20, 2200, CAST(0x0000ADCD00F6FA6E AS DateTime), CAST(0x0000ADCD00F7194B AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00018', N'2020BD01', 20, 6050, CAST(0x0000ADCD00F79A82 AS DateTime), CAST(0x0000ADCD00F79A82 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00019', N'2020GX03', 20, 2200, CAST(0x0000ADCE00F7CAF8 AS DateTime), CAST(0x0000ADCE00F7CAF8 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00020', N'2020HX08', 2, 132000, CAST(0x0000ADCF00FCAD07 AS DateTime), CAST(0x0000ADCF00FCAD07 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00021', N'2020GA05', 10, 6600, CAST(0x0000ADCF0152DB3E AS DateTime), CAST(0x0000ADCF0152DB3E AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00022', N'2020BD02', 10, 4950, CAST(0x0000ADD00153A695 AS DateTime), CAST(0x0000ADD00153A695 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00023', N'2020GE01', 10, 5225, CAST(0x0000ADD00153E0B6 AS DateTime), CAST(0x0000ADD00153E0B6 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00024', N'2020GX02', 2, 101750, CAST(0x0000ADD101540F26 AS DateTime), CAST(0x0000ADD101540F26 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00025', N'2020GX02', 1, 101750, CAST(0x0000ADD10154254C AS DateTime), CAST(0x0000ADD10154254C AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00025', N'2020HX08', 1, 132000, CAST(0x0000ADD101542CB6 AS DateTime), CAST(0x0000ADD301542CB6 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00026', N'2021KH08', 2, 77000, CAST(0x0000ADD30154FE31 AS DateTime), CAST(0x0000ADD30154FE31 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00027', N'2020BD01', 10, 6050, CAST(0x0000ADD301569A62 AS DateTime), CAST(0x0000ADD301569A62 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00028', N'2021KH08', 2, 77000, CAST(0x0000ADD40156B565 AS DateTime), CAST(0x0000ADD40156B565 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00029', N'2020GX02', 2, 101750, CAST(0x0000ADD40156FDE0 AS DateTime), CAST(0x0000ADD40156FDE0 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00030', N'2020GB01', 1, 8250, CAST(0x0000ADD40158FC23 AS DateTime), CAST(0x0000ADD40158FC23 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00031', N'2020GE01', 20, 5225, CAST(0x0000ADD401596811 AS DateTime), CAST(0x0000ADD401596811 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00032', N'2020HD05', 20, 7425, CAST(0x0000ADD50159C870 AS DateTime), CAST(0x0000ADD50159C870 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00033', N'2021GH02', 10, 4400, CAST(0x0000ADD5015ADD08 AS DateTime), CAST(0x0000ADD5015ADD08 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00034', N'2020GX02', 2, 101750, CAST(0x0000ADD6015B2A82 AS DateTime), CAST(0x0000ADD6015B2A82 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00035', N'2020GX01', 10, 3025, CAST(0x0000ADD6015B3DFD AS DateTime), CAST(0x0000ADD6015B3DFD AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00036', N'2021KA02', 20, 8800, CAST(0x0000ADD7015B650B AS DateTime), CAST(0x0000ADD7015B650B AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00036', N'2021KH08', 1, 77000, CAST(0x0000ADD7015B6D7E AS DateTime), CAST(0x0000ADD7015B6D7E AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00037', N'2020HG02', 2, 156750, CAST(0x0000ADD7015B8889 AS DateTime), CAST(0x0000ADD7015B8889 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00038', N'2021KX07', 2, 77000, CAST(0x0000ADD8015BA1EC AS DateTime), CAST(0x0000ADD8015BA1EC AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00039', N'2020HX08', 2, 132000, CAST(0x0000ADD9015BBF2F AS DateTime), CAST(0x0000ADD9015BBF2F AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00040', N'2020HX08', 2, 132000, CAST(0x0000ADD9015DB7B2 AS DateTime), CAST(0x0000ADD9015DB7B2 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00040', N'2021HA05', 10, 7700, CAST(0x0000ADD9015E6523 AS DateTime), CAST(0x0000ADD9015E6523 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00041', N'2020HX08', 1, 132000, CAST(0x0000ADD9015F1003 AS DateTime), CAST(0x0000ADD9015F1003 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00041', N'2021GH02', 10, 4400, CAST(0x0000ADD9015F1975 AS DateTime), CAST(0x0000ADD9015F1975 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00042', N'2020GD03', 10, 7837, CAST(0x0000ADDA015F3833 AS DateTime), CAST(0x0000ADDA015F3833 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00043', N'2020HG02', 2, 156750, CAST(0x0000ADDA015F5F5B AS DateTime), CAST(0x0000ADDA015F5F5B AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00044', N'2020KE01', 10, 5500, CAST(0x0000ADDA015F8D6C AS DateTime), CAST(0x0000ADDA015F8D6C AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00045', N'2020GB01', 2, 8250, CAST(0x0000ADDB015FEEC8 AS DateTime), CAST(0x0000ADDB015FEEC8 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00046', N'2020GD03', 20, 7837, CAST(0x0000ADDB01616575 AS DateTime), CAST(0x0000ADDB01616575 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00047', N'2020GB01', 2, 8250, CAST(0x0000ADDB01618A36 AS DateTime), CAST(0x0000ADDB01618A36 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00047', N'2020GX01', 20, 3025, CAST(0x0000ADDC016191B4 AS DateTime), CAST(0x0000ADDC016191B4 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00048', N'2021KH08', 2, 77000, CAST(0x0000ADDC0161ACB4 AS DateTime), CAST(0x0000ADDC0161ACB4 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00049', N'2021KA02', 20, 8800, CAST(0x0000ADDC0161CD52 AS DateTime), CAST(0x0000ADDC0161CD52 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00050', N'2021GX07', 20, 5500, CAST(0x0000ADDD0161ED92 AS DateTime), CAST(0x0000ADDD0161ED92 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00050', N'2021KA02', 20, 8800, CAST(0x0000ADDD0161F9E1 AS DateTime), CAST(0x0000ADDD0161F9E1 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00051', N'2021KH08', 3, 77000, CAST(0x0000ADDD01641068 AS DateTime), CAST(0x0000ADDD01641068 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00052', N'2020KE01', 20, 5500, CAST(0x0000ADDE00A33CB7 AS DateTime), CAST(0x0000ADDE00A33CB7 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00053', N'2020GX01', 10, 3025, CAST(0x0000ADDE00A719C7 AS DateTime), CAST(0x0000ADDE00A719C7 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00054', N'2020HE02', 20, 4950, CAST(0x0000ADDF00A73C41 AS DateTime), CAST(0x0000ADDF00A73C41 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00055', N'2020HG02', 3, 156750, CAST(0x0000ADDF00A756FA AS DateTime), CAST(0x0000ADDF00A756FA AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00056', N'2020GX03', 20, 2200, CAST(0x0000ADDF00A79786 AS DateTime), CAST(0x0000ADDF00A79786 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00056', N'2020HQ05', 10, 4400, CAST(0x0000ADDF00A79FBE AS DateTime), CAST(0x0000ADDF00A79FBE AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00057', N'2021KX07', 2, 77000, CAST(0x0000ADE000A7BA85 AS DateTime), CAST(0x0000ADE000A7BA85 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00058', N'2020HD05', 20, 7425, CAST(0x0000ADE000A7D4F6 AS DateTime), CAST(0x0000ADE000A7D4F6 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00059', N'2020HX08', 2, 132000, CAST(0x0000ADE000A7FE32 AS DateTime), CAST(0x0000ADE000A7FE32 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00060', N'2021KA02', 30, 8800, CAST(0x0000ADE100A817C6 AS DateTime), CAST(0x0000ADE100A817C6 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00061', N'2020GX01', 10, 3025, CAST(0x0000ADE100A83B5F AS DateTime), CAST(0x0000ADE100A83B5F AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00061', N'2020HD01', 2, 7150, CAST(0x0000ADE100A843E4 AS DateTime), CAST(0x0000ADE100A843E4 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00062', N'2020HD05', 30, 7425, CAST(0x0000ADE200A85AA0 AS DateTime), CAST(0x0000ADE200A85AA0 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00063', N'2020GX02', 1, 101750, CAST(0x0000ADE200A8828F AS DateTime), CAST(0x0000ADE200A8828F AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00064', N'2021GX07', 30, 5500, CAST(0x0000ADE200A8A7D2 AS DateTime), CAST(0x0000ADE200A8A7D2 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00065', N'2020BD01', 20, 6050, CAST(0x0000ADE300A8BE6C AS DateTime), CAST(0x0000ADE300A8BE6C AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00066', N'2020HE02', 20, 4950, CAST(0x0000ADE400A8D155 AS DateTime), CAST(0x0000ADE400A8D155 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00067', N'2021KX07', 1, 77000, CAST(0x0000ADE400A8E83E AS DateTime), CAST(0x0000ADE400A8E83E AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00068', N'2020GX01', 10, 3025, CAST(0x0000ADE500A9025C AS DateTime), CAST(0x0000ADE500A9025C AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00069', N'2021HA05', 10, 7700, CAST(0x0000ADE500A915B9 AS DateTime), CAST(0x0000ADE500A915B9 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00070', N'2020GX02', 1, 101750, CAST(0x0000ADE600A9445D AS DateTime), CAST(0x0000ADE600A9445D AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00071', N'2020GA05', 10, 6600, CAST(0x0000ADE7015980CD AS DateTime), CAST(0x0000ADE7015980CD AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00072', N'2020GX01', 20, 3025, CAST(0x0000ADE701599917 AS DateTime), CAST(0x0000ADE701599917 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00073', N'2020HG02', 1, 156750, CAST(0x0000ADE70159B01C AS DateTime), CAST(0x0000ADE70159B01C AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00074', N'2021KH08', 2, 77000, CAST(0x0000ADE70159CB5B AS DateTime), CAST(0x0000ADE70159CB5B AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00075', N'2020GR02', 10, 1650, CAST(0x0000ADE70159DE08 AS DateTime), CAST(0x0000ADE70159DE08 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00076', N'2020HX08', 2, 132000, CAST(0x0000ADE70159F2A9 AS DateTime), CAST(0x0000ADE70159F2AA AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00077', N'2020GX02', 1, 101750, CAST(0x0000ADE7015A1236 AS DateTime), CAST(0x0000ADE7015A1236 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00078', N'2020BD01', 10, 5225, CAST(0x0000ADEA00895091 AS DateTime), CAST(0x0000ADEA00895091 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00078', N'2020BD02', 10, 4950, CAST(0x0000ADEA00895AE5 AS DateTime), CAST(0x0000ADEA00895AE5 AS DateTime))
INSERT [dbo].[tbl_InvoiceDetail] ([MaHD], [Mathuoc], [Soluong], [Dongia], [Ngaytao], [Ngaychinhsua]) VALUES (N'HD00078', N'2020GA05', 10, 6600, CAST(0x0000ADEA0089B03B AS DateTime), CAST(0x0000ADEA0089B03B AS DateTime))
/****** Object:  Table [dbo].[tbl_Consignment]    Script Date: 11/24/2021 20:14:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Consignment](
	[Malo] [nvarchar](50) NOT NULL,
	[Manhap] [nvarchar](50) NOT NULL,
	[Mathuoc] [nvarchar](50) NOT NULL,
	[Soluong] [int] NOT NULL,
	[Gianhap] [float] NOT NULL,
	[Daban] [int] NULL,
	[Ngaysanxuat] [date] NOT NULL,
	[Ngayhethan] [date] NOT NULL,
 CONSTRAINT [PK_tbl_Consignment_1] PRIMARY KEY CLUSTERED 
(
	[Malo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00001', N'PN00001', N'2020BD01', 500, 5000, 70, CAST(0xAC3F0B00 AS Date), CAST(0x9C460B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00002', N'PN00002', N'2020GA02', 500, 10000, 0, CAST(0x1E410B00 AS Date), CAST(0x50440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00003', N'PN00002', N'2020GX01', 2000, 3000, 62, CAST(0x18430B00 AS Date), CAST(0x89470B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00004', N'PN00002', N'2020GB01', 100, 7000, 37, CAST(0xBA3F0B00 AS Date), CAST(0xC9430B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00005', N'PN00003', N'2020BD02', 1200, 4000, 20, CAST(0x31410B00 AS Date), CAST(0x50440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00006', N'PN00004', N'2020GA05', 1000, 3000, 60, CAST(0xDA420B00 AS Date), CAST(0xBD430B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00007', N'PN00005', N'2020GD03', 1000, 6000, 40, CAST(0xBF3F0B00 AS Date), CAST(0x58440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00008', N'PN00006', N'2020GE01', 500, 5000, 30, CAST(0x2E430B00 AS Date), CAST(0x9F450B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00009', N'PN00007', N'2020GR02', 1000, 1000, 10, CAST(0x09410B00 AS Date), CAST(0xBD450B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00010', N'PN00008', N'2021KX07', 100, 70000, 6, CAST(0xA1400B00 AS Date), CAST(0x2B470B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00011', N'PN00008', N'2021KH08', 300, 60000, 11, CAST(0xD2410B00 AS Date), CAST(0x6F430B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00012', N'PN00009', N'2021KE02', 300, 4000, 0, CAST(0xE93F0B00 AS Date), CAST(0x3F430B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00013', N'PN00009', N'2021HD02', 500, 4000, 0, CAST(0x24420B00 AS Date), CAST(0xAC440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00014', N'PN00010', N'2021KA02', 800, 8000, 112, CAST(0x2C420B00 AS Date), CAST(0x93450B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00015', N'PN00010', N'2021GX07', 1200, 5000, 81, CAST(0x01420B00 AS Date), CAST(0xC8440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00016', N'PN00011', N'2021HA05', 600, 7000, 30, CAST(0x37400B00 AS Date), CAST(0x70430B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00017', N'PN00012', N'2021GH02', 800, 4000, 10, CAST(0x09420B00 AS Date), CAST(0xA9430B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00018', N'PN00012', N'2020KE01', 1200, 5000, 30, CAST(0x1A410B00 AS Date), CAST(0x9E450B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00019', N'PN00013', N'2020HX08', 100, 100000, 25, CAST(0x1B410B00 AS Date), CAST(0x2D440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00020', N'PN00013', N'2020HG02', 50, 150000, 8, CAST(0x6F3F0B00 AS Date), CAST(0xC5430B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00021', N'PN00014', N'2020GX02', 200, 80000, 11, CAST(0x343F0B00 AS Date), CAST(0x9B430B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00022', N'PN00015', N'2020GX03', 1000, 2000, 100, CAST(0x1A410B00 AS Date), CAST(0x77430B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00023', N'PN00015', N'2020HG01', 500, 4000, 0, CAST(0xE93F0B00 AS Date), CAST(0xE3430B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00024', N'PN00016', N'2020HD05', 1000, 8000, 90, CAST(0x533F0B00 AS Date), CAST(0xD1430B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00025', N'PN00017', N'2020HD06', 400, 4000, 0, CAST(0x87420B00 AS Date), CAST(0x37460B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00026', N'PN00018', N'2020HD01', 400, 5000, 12, CAST(0x343F0B00 AS Date), CAST(0x2B470B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00027', N'PN00019', N'2020HE02', 1500, 4500, 40, CAST(0x08400B00 AS Date), CAST(0x8D450B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00028', N'PN00020', N'2020HQ05', 1000, 4000, 0, CAST(0xCB3F0B00 AS Date), CAST(0x50440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00029', N'PN00020', N'2020BD01', 500, 6000, 0, CAST(0xBB400B00 AS Date), CAST(0x8D430B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00030', N'PN00021', N'2020BD02', 500, 5000, 0, CAST(0x25420B00 AS Date), CAST(0x6D440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00031', N'PN00022', N'2020GB01', 500, 9000, 0, CAST(0x90400B00 AS Date), CAST(0x07450B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00032', N'PN00022', N'2020GX01', 1200, 2500, 0, CAST(0x55410B00 AS Date), CAST(0x32450B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00033', N'PN00023', N'2020GD03', 800, 7000, 0, CAST(0x32410B00 AS Date), CAST(0x77430B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00034', N'PN00023', N'2020GE01', 800, 4500, 0, CAST(0x30410B00 AS Date), CAST(0x34440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00035', N'PN00024', N'2020HG02', 200, 140000, 0, CAST(0xA6400B00 AS Date), CAST(0x26440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00036', N'PN00025', N'2021KH08', 200, 80000, 0, CAST(0x1A410B00 AS Date), CAST(0x9E450B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00037', N'PN00025', N'2020HX08', 100, 120000, 0, CAST(0x39410B00 AS Date), CAST(0x99450B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00038', N'PN00026', N'2020GD03', 100, 8000, 0, CAST(0x39410B00 AS Date), CAST(0x37460B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00039', N'PN00027', N'2020GR02', 1500, 2000, 0, CAST(0x39410B00 AS Date), CAST(0x31440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00040', N'PN00028', N'2020GX02', 250, 90000, 0, CAST(0xFA410B00 AS Date), CAST(0xE9440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00041', N'PN00029', N'2020GB01', 100, 7000, 0, CAST(0x92410B00 AS Date), CAST(0x5F440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00042', N'PN00029', N'2020HD01', 600, 8000, 0, CAST(0xC6420B00 AS Date), CAST(0xC4430B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00043', N'PN00030', N'2020HG02', 200, 140000, 0, CAST(0xEE420B00 AS Date), CAST(0x45480B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00044', N'PN00031', N'2020HD05', 800, 9000, 0, CAST(0x30410B00 AS Date), CAST(0x31440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00045', N'PN00032', N'2020HD05', 700, 5000, 0, CAST(0xC3410B00 AS Date), CAST(0xFA450B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00046', N'PN00033', N'2020HD06', 600, 5000, 0, CAST(0x39410B00 AS Date), CAST(0x12440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00047', N'PN00034', N'2020GD03', 300, 7000, 0, CAST(0x00420B00 AS Date), CAST(0x40430B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00048', N'PN00035', N'2020GA02', 50, 9000, 0, CAST(0x97400B00 AS Date), CAST(0x41430B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00049', N'PN00036', N'2020GX02', 100, 100000, 0, CAST(0xA6410B00 AS Date), CAST(0x02440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00050', N'PN00037', N'2020GA05', 100, 9000, 0, CAST(0x6E410B00 AS Date), CAST(0x2D470B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00051', N'PN00038', N'2020HX08', 100, 130000, 0, CAST(0x5B410B00 AS Date), CAST(0x52440B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00052', N'PN00039', N'2021KE02', 150, 4500, 0, CAST(0x28410B00 AS Date), CAST(0xC2450B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00053', N'PN00040', N'2020GH01', 100, 60000, 0, CAST(0x90400B00 AS Date), CAST(0xA4450B00 AS Date))
INSERT [dbo].[tbl_Consignment] ([Malo], [Manhap], [Mathuoc], [Soluong], [Gianhap], [Daban], [Ngaysanxuat], [Ngayhethan]) VALUES (N'ML00054', N'PN00040', N'2020BD01', 100, 4000, 0, CAST(0x16410B00 AS Date), CAST(0x57440B00 AS Date))
/****** Object:  StoredProcedure [dbo].[USP_Update_Quantity]    Script Date: 11/24/2021 20:14:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Update_Quantity]
@idItem NVARCHAR(50), @idConsignment NVARCHAR(50), @soldQuantity INT 
AS
BEGIN
	DECLARE @isExistMedicine INT
	SELECT @isExistMedicine = COUNT(*) FROM dbo.tbl_Item WHERE Mathuoc = @idItem
	IF (@isExistMedicine > 0)
	BEGIN
		DECLARE @itemQuantity INT
		DECLARE @soldConsignment INT
		DECLARE @inventory INT
		SELECT @itemQuantity = Soluong FROM dbo.tbl_Item WHERE Mathuoc = @idItem

		SELECT @soldConsignment = Daban, @inventory = (Soluong - Daban) FROM dbo.tbl_Consignment WHERE Malo = @idConsignment
		DECLARE @newQuantity INT = @itemQuantity - @soldQuantity
		DECLARE @newSold INT 
		DECLARE @nextSoldQuantity INT
		DECLARE @nextConsigment NVARCHAR(50)
		IF (@soldQuantity > @inventory) 
			BEGIN
			SELECT @newSold = @soldConsignment + @inventory
			SELECT @nextSoldQuantity = @soldQuantity - @newSold
			SELECT TOP 1 @nextConsigment = Malo FROM dbo.tbl_Consignment WHERE NOT Malo = @idConsignment AND Mathuoc = @idItem
			IF(@newQuantity > 0)
				UPDATE dbo.tbl_Item SET Soluong = @newQuantity WHERE Mathuoc = @idItem
				UPDATE dbo.tbl_Consignment SET Daban = @newSold WHERE Malo = @idConsignment
				UPDATE dbo.tbl_Consignment SET Daban = @nextSoldQuantity WHERE Malo = @nextConsigment
			END
		ELSE
			BEGIN
			SELECT @newSold = @soldConsignment + @soldQuantity
			IF(@newQuantity > 0)
			UPDATE dbo.tbl_Item SET Soluong = @newQuantity WHERE Mathuoc = @idItem
			UPDATE dbo.tbl_Consignment SET Daban = @newSold WHERE Malo = @idConsignment
			END
	END
END
GO
/****** Object:  Default [DF_tbl_Invoice_NgayHD]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_Invoice] ADD  CONSTRAINT [DF_tbl_Invoice_NgayHD]  DEFAULT (getdate()) FOR [NgayHD]
GO
/****** Object:  Default [DF_tbl_InvoiceDetail_Ngaytao]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_InvoiceDetail] ADD  CONSTRAINT [DF_tbl_InvoiceDetail_Ngaytao]  DEFAULT (getdate()) FOR [Ngaytao]
GO
/****** Object:  Default [DF_tbl_InvoiceDetail_Ngaychinhsua]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_InvoiceDetail] ADD  CONSTRAINT [DF_tbl_InvoiceDetail_Ngaychinhsua]  DEFAULT (getdate()) FOR [Ngaychinhsua]
GO
/****** Object:  Default [DF_tbl_Payment_NgayTT]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_Payment] ADD  CONSTRAINT [DF_tbl_Payment_NgayTT]  DEFAULT (getdate()) FOR [NgayTT]
GO
/****** Object:  Default [DF_tbl_PuschaseOrder_Ngaynhap]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_PurchaseOrder] ADD  CONSTRAINT [DF_tbl_PuschaseOrder_Ngaynhap]  DEFAULT (getdate()) FOR [Ngaynhap]
GO
/****** Object:  Default [DF_tbl_User_Ngaytao]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_User] ADD  CONSTRAINT [DF_tbl_User_Ngaytao]  DEFAULT (getdate()) FOR [Ngaytao]
GO
/****** Object:  Default [DF_tbl_User_Ngaychinhsua]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_User] ADD  CONSTRAINT [DF_tbl_User_Ngaychinhsua]  DEFAULT (getdate()) FOR [Ngaychinhsua]
GO
/****** Object:  ForeignKey [FK_tbl_Consignment_tbl_Item]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_Consignment]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Consignment_tbl_Item] FOREIGN KEY([Mathuoc])
REFERENCES [dbo].[tbl_Item] ([Mathuoc])
GO
ALTER TABLE [dbo].[tbl_Consignment] CHECK CONSTRAINT [FK_tbl_Consignment_tbl_Item]
GO
/****** Object:  ForeignKey [FK_tbl_Consignment_tbl_PuschaseOrder]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_Consignment]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Consignment_tbl_PuschaseOrder] FOREIGN KEY([Manhap])
REFERENCES [dbo].[tbl_PurchaseOrder] ([Manhap])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Consignment] CHECK CONSTRAINT [FK_tbl_Consignment_tbl_PuschaseOrder]
GO
/****** Object:  ForeignKey [FK_tbl_Invoice_tbl_Customer]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_Invoice]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Invoice_tbl_Customer] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tbl_Customer] ([MaKH])
GO
ALTER TABLE [dbo].[tbl_Invoice] CHECK CONSTRAINT [FK_tbl_Invoice_tbl_Customer]
GO
/****** Object:  ForeignKey [FK_tbl_Invoice_tbl_Staff]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_Invoice]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Invoice_tbl_Staff] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tbl_Staff] ([MaNV])
GO
ALTER TABLE [dbo].[tbl_Invoice] CHECK CONSTRAINT [FK_tbl_Invoice_tbl_Staff]
GO
/****** Object:  ForeignKey [FK_tbl_InvoiceDetail_tbl_Invoice1]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_InvoiceDetail_tbl_Invoice1] FOREIGN KEY([MaHD])
REFERENCES [dbo].[tbl_Invoice] ([MaHD])
GO
ALTER TABLE [dbo].[tbl_InvoiceDetail] CHECK CONSTRAINT [FK_tbl_InvoiceDetail_tbl_Invoice1]
GO
/****** Object:  ForeignKey [FK_tbl_InvoiceDetail_tbl_Item]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_InvoiceDetail_tbl_Item] FOREIGN KEY([Mathuoc])
REFERENCES [dbo].[tbl_Item] ([Mathuoc])
GO
ALTER TABLE [dbo].[tbl_InvoiceDetail] CHECK CONSTRAINT [FK_tbl_InvoiceDetail_tbl_Item]
GO
/****** Object:  ForeignKey [FK_tbl_Item_tbl_make]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_Item]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Item_tbl_make] FOREIGN KEY([MaNSX])
REFERENCES [dbo].[tbl_make] ([MaNSX])
GO
ALTER TABLE [dbo].[tbl_Item] CHECK CONSTRAINT [FK_tbl_Item_tbl_make]
GO
/****** Object:  ForeignKey [FK_tbl_Payment_tbl_Invoice]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_Payment]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Payment_tbl_Invoice] FOREIGN KEY([MaHD])
REFERENCES [dbo].[tbl_Invoice] ([MaHD])
GO
ALTER TABLE [dbo].[tbl_Payment] CHECK CONSTRAINT [FK_tbl_Payment_tbl_Invoice]
GO
/****** Object:  ForeignKey [FK_tbl_PuschaseOrder_tbl_Staff]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_PurchaseOrder]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PuschaseOrder_tbl_Staff] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tbl_Staff] ([MaNV])
GO
ALTER TABLE [dbo].[tbl_PurchaseOrder] CHECK CONSTRAINT [FK_tbl_PuschaseOrder_tbl_Staff]
GO
/****** Object:  ForeignKey [FK_tbl_PuschaseOrder_tbl_Supplier]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_PurchaseOrder]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PuschaseOrder_tbl_Supplier] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tbl_Supplier] ([MaNCC])
GO
ALTER TABLE [dbo].[tbl_PurchaseOrder] CHECK CONSTRAINT [FK_tbl_PuschaseOrder_tbl_Supplier]
GO
/****** Object:  ForeignKey [FK_tbl_User_tbl_Staff]    Script Date: 11/24/2021 20:14:41 ******/
ALTER TABLE [dbo].[tbl_User]  WITH CHECK ADD  CONSTRAINT [FK_tbl_User_tbl_Staff] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tbl_Staff] ([MaNV])
GO
ALTER TABLE [dbo].[tbl_User] CHECK CONSTRAINT [FK_tbl_User_tbl_Staff]
GO
