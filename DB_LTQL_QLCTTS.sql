CREATE DATABASE QLCTTS

GO

USE QLCTTS

GO

--Điểm thi:
CREATE TABLE DIEMTHI
(
	diemThiSo INT PRIMARY KEY,
	diaChiDiemThi NVARCHAR(200)
)

GO

--Phòng thi
CREATE TABLE PHONGTHI
(
	maPhong VARCHAR(10) PRIMARY KEY,
	diemThiSo INT,
	ghiChu NVARCHAR(200),

	FOREIGN KEY (diemThiSo) REFERENCES DIEMTHI(diemThiSo)
)


GO

--Ngành:
CREATE TABLE NGANH
(
	maNganh VARCHAR(10) PRIMARY KEY,
	tenNganh NVARCHAR(200)
)

GO

--Khu vực:
CREATE TABLE KHUVUC
(
	maKhuVuc VARCHAR(10) PRIMARY KEY,
	tenKhuVuc NVARCHAR(200)
)

GO

--Đối tượng:
CREATE TABLE DOITUONG
(
	maDoiTuong VARCHAR(10) PRIMARY KEY,
	tenDoiTuong NVARCHAR(200)
)

GO

--Thời gian thi:
CREATE TABLE THOIGIANTHI
(
	maThoiGian VARCHAR(10) PRIMARY KEY,
	thoiGian NVARCHAR(200)
)

GO

--Buổi thi:
CREATE TABLE BUOITHI
(
	maBuoiThi VARCHAR(10) PRIMARY KEY,
	buoiThi NVARCHAR(200)
)

GO

--Môn thi:
CREATE TABLE MONTHI
(
	maMon VARCHAR(10) PRIMARY KEY,
	tenMon NVARCHAR(200),
	ngayThi DATETIME,
	maBuoiThi VARCHAR(10),
	maThoiGian VARCHAR(10),
	maNganh VARCHAR(10),

	FOREIGN KEY (maBuoiThi) REFERENCES BUOITHI(maBuoiThi),
	FOREIGN KEY (maThoiGian) REFERENCES THOIGIANTHI(maThoiGian),
	FOREIGN KEY (maNganh) REFERENCES NGANH(maNganh)
)
	
GO

--Thí sinh:
CREATE TABLE THISINH
(
	soBaoDanh VARCHAR(10) PRIMARY KEY,
	hoTen NVARCHAR(200),
	ngaySinh DATETIME,
	gioiTinh NVARCHAR(5) CHECK (gioiTinh like N'Nam' OR gioiTinh like N'Nữ') DEFAULT  N'Nam',
	hoKhau NVARCHAR(200),
	maDoiTuong VARCHAR(10),
	maNganh VARCHAR(10),
	maKhuVuc VARCHAR(10),
	maPhong VARCHAR(10),
	images nvarchar(max)

	FOREIGN KEY (maDoiTuong) REFERENCES DOITUONG(maDoiTuong),
	FOREIGN KEY (maNganh) REFERENCES NGANH(maNganh),
	FOREIGN KEY (maKhuVuc) REFERENCES KHUVUC(maKhuVuc),
	FOREIGN KEY (maPhong) REFERENCES PHONGTHI(maPhong)
)


GO

--Tài khoản:
CREATE TABLE TAIKHOAN
( 
	tenDangNhap VARCHAR(200) PRIMARY KEY NOT NULL,
	matKhau VARCHAR(200) NOT NULL,
	loaiTaiKhoan INT DEFAULT 2,
	soBaoDanh VARCHAR(10)

	FOREIGN KEY (soBaoDanh) REFERENCES THISINH(soBaoDanh),
)



GO

--Đơn vị:
CREATE TABLE DONVI
(
	maDonVi VARCHAR(10) PRIMARY KEY,
	tenDonVi NVARCHAR(200),
)


GO

--Chức vụ
CREATE TABLE CHUCVU
(
	maChucVu VARCHAR(10) PRIMARY KEY,
	tenChucVu NVARCHAR(200)
)

GO

--Cán bộ coi thi:
CREATE TABLE CANBOCOITHI
(
	maCanBo  VARCHAR(10) PRIMARY KEY,
	tenCanBo NVARCHAR(200),
	maDonVi VARCHAR(10),
	gioiTinh NVARCHAR(5) CHECK (gioiTinh like N'Nam' OR gioiTinh like N'Nữ') DEFAULT  N'Nam',
	maChucVu VARCHAR(10),
	diemThiSo INT,

	FOREIGN KEY (maDonVi) REFERENCES DONVI(maDonVi),
	FOREIGN KEY (maChucVu) REFERENCES CHUCVU(maChucVu),
	FOREIGN KEY (diemThiSo) REFERENCES DIEMTHI(diemThiSo)
)

GO




/*Chèn dữ liệu*/

--BUỔI THI
INSERT INTO BUOITHI VALUES ('S', N'Sáng')
INSERT INTO BUOITHI VALUES ('C', N'Chiều')

--THỜI GIAN THI THI
INSERT INTO THOIGIANTHI VALUES ('T01', N'60 phút')
INSERT INTO THOIGIANTHI VALUES ('T02', N'90 phút')
INSERT INTO THOIGIANTHI VALUES ('T03', N'120 phút')
INSERT INTO THOIGIANTHI VALUES ('T04', N'150 phút')

--ĐIỂM THI
INSERT INTO DIEMTHI VALUES (1, N'AN GIANG')
INSERT INTO DIEMTHI VALUES (2, N'CẦN THƠ')
INSERT INTO DIEMTHI VALUES (3, N'VĨNH LONG')
INSERT INTO DIEMTHI VALUES (4, N'GIA LAI')
INSERT INTO DIEMTHI VALUES (5, N'THÀNH PHỐ HỒ CHÍ MINH')
INSERT INTO DIEMTHI VALUES (6, N'HÀ NỘI')

--PHÒNG THI
INSERT INTO PHONGTHI VALUES ('AG1', 1, N'Nhà D lầu 2')
INSERT INTO PHONGTHI VALUES ('AG2', 1, N'Nhà A lầu 4')
INSERT INTO PHONGTHI VALUES ('AG3', 1, N'Nhà G lầu 4')
INSERT INTO PHONGTHI VALUES ('AG4', 1, N'Nhà F lầu 4')
INSERT INTO PHONGTHI VALUES ('AG5', 1, N'Nhà V lầu 4')
INSERT INTO PHONGTHI VALUES ('HN1', 1, N'Nhà C lầu 4')
INSERT INTO PHONGTHI VALUES ('THHCM1', 1, N'Nhà J lầu 4')
INSERT INTO PHONGTHI VALUES ('THHCM2', 2, N'Nhà N lầu 4')
INSERT INTO PHONGTHI VALUES ('THHCM3', 3, N'Nhà G lầu 4')
INSERT INTO PHONGTHI VALUES ('THHCM4', 4, N'Nhà F lầu 4')

--NGÀNH
INSERT INTO NGANH VALUES ('CNTT', N'CÔNG NGHỆ THÔNG TIN')
INSERT INTO NGANH VALUES ('BVTV', N'BẢO VỆ THỰC VẬT')
INSERT INTO NGANH VALUES ('KTQT', N'KINH TẾ QUỐC TẾ')
INSERT INTO NGANH VALUES ('QTKD', N'QUẢN TRỊ KINH DOANH')
INSERT INTO NGANH VALUES ('CNTP', N'CÔNG NGHỆ THỰC PHẨM')

--NGÀNH
INSERT INTO DOITUONG VALUES ('DT01', N'Đối tượng 1')
INSERT INTO DOITUONG VALUES ('DT02', N'Đối tượng 2')
INSERT INTO DOITUONG VALUES ('DT04', N'Đối tượng 3')
INSERT INTO DOITUONG VALUES ('DT05', N'Đối tượng 4')
INSERT INTO DOITUONG VALUES ('DT06', N'Đối tượng 5')

--KHU VỰC
INSERT INTO KHUVUC VALUES ('KV01', N'Khu Vực 1')
INSERT INTO KHUVUC VALUES ('KV02', N'Khu Vực 2')
INSERT INTO KHUVUC VALUES ('KV03', N'Khu Vực 3')
INSERT INTO KHUVUC VALUES ('KV04', N'Khu Vực 4')
INSERT INTO KHUVUC VALUES ('KV05', N'Khu Vực 5')


--ĐƠN VỊ
INSERT INTO DONVI VALUES ('A', N'ĐƠN VỊ A')
INSERT INTO DONVI VALUES ('B', N'ĐƠN VỊ B')
INSERT INTO DONVI VALUES ('C', N'ĐƠN VỊ C')
INSERT INTO DONVI VALUES ('D', N'ĐƠN VỊ D')
INSERT INTO DONVI VALUES ('E', N'ĐƠN VỊ E')
INSERT INTO DONVI VALUES ('F', N'ĐƠN VỊ F')

--CHỨC VỤ
INSERT INTO CHUCVU VALUES ('DT', N'Diểm trưởng')
INSERT INTO CHUCVU VALUES ('DF', N'Điểm phó')
INSERT INTO CHUCVU VALUES ('GS', N'Giám sát')
INSERT INTO CHUCVU VALUES ('TK', N'Thư ký')
INSERT INTO CHUCVU VALUES ('CBCT', N'Cán bộ coi thi')
INSERT INTO CHUCVU VALUES ('PV', N'Phục vụ')


INSERT INTO THISINH VALUES ('DTH195150', N'Nguyễn Vĩnh Kỳ', GETDATE(), N'Nam', N'An Giang', 'DT01', 'CNTT', 'KV01', 'AG1', '\Anh\gojo.png')
INSERT INTO THISINH VALUES ('DTH195XXX', N'Nguyễn Văn A', GETDATE(), N'Nam', N'Hà Nội', 'DT02', 'CNTP', 'KV02', 'AG4', '\Anh\images.jpg')
INSERT INTO TAIKHOAN VALUES ('admin', 'e99a18c428cb38d5f260853678922e03', 1, 'DTH195150')
INSERT INTO TAIKHOAN VALUES ('user', 'e99a18c428cb38d5f260853678922e03', 2, 'DTH195XXX')

/*===================================== Store_Proc =====================================*/

/*===================================== Store Tài Khoản=====================================*/
--Đăng nhập
	
	GO

	CREATE PROC proc_DangNhap
	@tendangnhap VARCHAR(200), @matkhau VARCHAR(200)
	AS
	BEGIN
		SELECT *
		FROM TAIKHOAN 
		WHERE tenDangNhap = @tendangnhap
		AND matKhau = @matkhau
	END
	GO

--Reset mật khẩu
	
	CREATE PROC proc_ResetMK
	@tendangnhap VARCHAR(200), @matKhau VARCHAR(200)
	AS
	BEGIN
		UPDATE TAIKHOAN SET matKhau = @matKhau WHERE tenDangNhap = @tendangnhap
	END
	GO

--Cập nhật mật khẩu
	CREATE PROC proc_CapNhatMK
	@tendangnhap VARCHAR(200), @matkhaumoi VARCHAR(200)
	AS
	BEGIN
		UPDATE TAIKHOAN SET matKhau = @matkhaumoi WHERE tenDangNhap = @tendangnhap
	END
	GO

--Kiểm tra tên đăng nhập

	CREATE PROC proc_KiemTraID_TaiKhoan
	@tenDangNhapMoi VARCHAR(200)
	AS
	BEGIN
		SELECT * FROM TAIKHOAN WHERE tenDangNhap = @tenDangNhapMoi
	END
	GO

--Thêm tài khoản mới

	CREATE PROC proc_ThemTaiKhoanMoi
	@tenDangNhap VARCHAR(200), @matKhau VARCHAR(200), @loaiTaiKhoan INT, @soBaoDanh VARCHAR(200)
	AS
	BEGIN
		INSERT INTO TAIKHOAN VALUES (@tenDangNhap, @matKhau, @loaiTaiKhoan, @soBaoDanh)
	END
	GO

--Nâng hạ quyền quản trị

	CREATE PROC proc_PhanQuyen
	@tenDangNhap VARCHAR(200), @loaiTaiKhoan INT
	AS
	BEGIN
		SET @loaiTaiKhoan = 3 - @loaiTaiKhoan
		UPDATE TAIKHOAN SET loaiTaiKhoan = @loaiTaiKhoan WHERE tenDangNhap = @tenDangNhap
	END
	GO

--Xóa tài khoản

	CREATE PROC proc_XoaTaiKhoan
	@tenDangNhap VARCHAR(200)
	AS
	BEGIN
		DELETE TAIKHOAN 
		WHERE tenDangNhap = @tenDangNhap
	END
	GO

/*===================================== Store Ngành Học=====================================*/

--Thêm ngành học

	CREATE PROC proc_ThemNganhHoc
	@maNganh VARCHAR(10), @tenNganh NVARCHAR(200)
	AS
	BEGIN
		INSERT INTO NGANH VALUES (@maNganh, @tenNganh)
	END
	GO

--Kiêm tra ID mã ngành

	CREATE PROC proc_KiemTraID_NganhHoc
	@maNganh VARCHAR(10)
	AS
	BEGIN
		SELECT * FROM NGANH WHERE maNganh = @maNganh
	END
	GO

--Cập nhật ngành học

	CREATE PROC proc_CapNhatNganhHoc
	@maNganh VARCHAR(10), @tenNganh NVARCHAR(200)
	AS
	BEGIN
		UPDATE NGANH 
		SET tenNganh = @tenNganh
		WHERE maNganh = @maNganh
	END
	GO

--Xóa ngành học

	CREATE PROC proc_XoaNganhHoc
	@maNganh VARCHAR(10)
	AS
	BEGIN
		DELETE NGANH 
		WHERE maNganh = @maNganh
	END
	GO

--Xóa khóa phụ ngành học

	CREATE PROC proc_XoaFK_MonThi_IDNganhHoc
	@maNganh VARCHAR(10)
	AS
	BEGIN
		DELETE MONTHI 
		WHERE maNganh = @maNganh
	END
	GO
	 
/*===================================== Store Chức Vụ=====================================*/

--Kiểm tra ID chưc vụ

	CREATE PROC proc_KiemTraID_ChucVu
	@maChucVu VARCHAR(10)
	AS
	BEGIN
		SELECT * FROM CHUCVU WHERE maChucVu = @maChucVu
	END
	GO

--Thêm chức vụ

	CREATE PROC proc_ThemChucVu
	@maChucVu VARCHAR(10), @tenChucVu NVARCHAR(200)
	AS
	BEGIN
		INSERT INTO CHUCVU VALUES (@maChucVu, @tenChucVu)
	END
	GO

--Cập nhật chức vụ

	CREATE PROC proc_CapNhatChucVu
	@maChucVu VARCHAR(10), @tenChucVu NVARCHAR(200)
	AS
	BEGIN
		UPDATE CHUCVU 
		SET tenChucVu = @tenChucVu
		WHERE maChucVu = @maChucVu
	END
	GO

--Xóa chức vụ

	CREATE PROC proc_XoaChucVu
	@maChucVu VARCHAR(10)
	AS
	BEGIN
		DELETE CHUCVU 
		WHERE maChucVu = @maChucVu
	END
	GO

--Xóa giám thị tham chiếu chức vụ

	CREATE PROC proc_XoaFK_GiamThi_FChucVu
	@maChucVu VARCHAR(10)
	AS
	BEGIN
		DELETE CANBOCOITHI 
		WHERE maChucVu = @maChucVu
	END
	GO

/*===================================== Store Địa Điểm Thi=====================================*/

--Kiểm tra ID địa điểm thi

	CREATE PROC proc_KiemTraID_DiaDiemThi
	@diemThiSo VARCHAR(10)
	AS
	BEGIN
		SELECT * FROM DIEMTHI WHERE diemThiSo = @diemThiSo
	END
	GO

--Thêm địa điểm thi

	CREATE PROC proc_ThemDiaDiemThi
	@diemThiSo INT, @diaChiDiemThi NVARCHAR(200)
	AS
	BEGIN
		INSERT INTO DIEMTHI VALUES (@diemThiSo, @diaChiDiemThi)
	END
	GO

--Cập nhật địa điểm thi

	CREATE PROC proc_CapNhatDiaDiemThi
	@diemThiSo VARCHAR(10), @diaChiDiemThi NVARCHAR(200)
	AS
	BEGIN
		UPDATE DIEMTHI 
		SET diaChiDiemThi = @diaChiDiemThi
		WHERE diemThiSo = @diemThiSo
	END
	GO

--Xóa địa điểm thi

	CREATE PROC proc_XoaDiaDiemThi
	@diemThiSo INT
	AS
	BEGIN
		DELETE DIEMTHI 
		WHERE diemThiSo = @diemThiSo
	END
	GO

--Xóa khóa phụ địa điểm thi của phòng thi

	CREATE PROC proc_XoaFK_PhongThi_FDiaDiemThi
	@diemThiSo INT
	AS
	BEGIN
		DELETE PHONGTHI 
		WHERE diemThiSo = @diemThiSo
	END
	GO

--Xóa khóa phụ địa điểm thi của giám thị

	CREATE PROC proc_XoaFK_GiamThi_FDiaDiemThi
	@diemThiSo INT
	AS
	BEGIN
		DELETE  CANBOCOITHI
		WHERE diemThiSo = @diemThiSo
	END
	GO

--Xóa khóa phụ địa điểm thi của phòng thi của thí sinh

	CREATE PROC proc_XoaFK_ThiSinh_FDiaDiemThi
	@maPhong VARCHAR(10)
	AS
	BEGIN
		DELETE  THISINH
		WHERE maPhong = @maPhong
	END
	GO

/*===================================== Store Địa Đơn Vị=====================================*/

--Kiểm tra ID đơn vị
	
	CREATE PROC proc_KiemTraID_DonVi
	@maDonVi VARCHAR(10)
	AS
	BEGIN
		SELECT * FROM DONVI WHERE maDonVi = @maDonVi
	END
	GO

--Thêm đơn vị

	CREATE PROC proc_ThemDonVi
	@maDonVi VARCHAR(10), @tenDonVi NVARCHAR(200)
	AS
	BEGIN
		INSERT INTO DONVI VALUES (@maDonVi, @tenDonVi)
	END
	GO

--Cập nhật đơn vị

	CREATE PROC proc_CapNhatDonVi
	@maDonVi VARCHAR(10), @tenDonVi NVARCHAR(200)
	AS
	BEGIN
		UPDATE DONVI 
		SET tenDonVi = @tenDonVi
		WHERE maDonVi = @maDonVi
	END
	GO

--Xóa đơn vị

	CREATE PROC proc_XoaDonVi
	@maDonVi VARCHAR(10)
	AS
	BEGIN
		DELETE DONVI 
		WHERE maDonVi = @maDonVi
	END
	GO

--Xóa giám thị có tham chiếu đơn vị

	CREATE PROC proc_XoaFK_GiamThi_FDonVi
	@maDonVi VARCHAR(10)
	AS
	BEGIN
		DELETE CANBOCOITHI 
		WHERE maDonVi = @maDonVi
	END
	GO

/*===================================== Store Khu Vực=====================================*/

--Kiểm tra ID khuc vực
	
	CREATE PROC proc_KiemTraID_KhuVuc
	@maKhuVuc VARCHAR(10)
	AS
	BEGIN
		SELECT * FROM KHUVUC WHERE maKhuVuc = @maKhuVuc
	END
	GO

--Thêm khu vực

	CREATE PROC proc_ThemKhuVuc
	@maKhuVuc VARCHAR(10), @tenKhuVuc NVARCHAR(200)
	AS
	BEGIN
		INSERT INTO KHUVUC VALUES (@maKhuVuc, @tenKhuVuc)
	END
	GO

--Sửa khu vực

	CREATE PROC proc_CapNhatKhuVuc
	@maKhuVuc VARCHAR(10), @tenKhuVuc NVARCHAR(200)
	AS
	BEGIN
		UPDATE KHUVUC 
		SET tenKhuVuc = @tenKhuVuc
		WHERE maKhuVuc = @maKhuVuc
	END
	GO

--Xóa khu vực

	CREATE PROC proc_XoaKhuVuc
	@maKhuVuc VARCHAR(10)
	AS
	BEGIN
		DELETE KHUVUC
		WHERE maKhuVuc = @maKhuVuc
	END
	GO

--Xóa khóa phụ khu vực

	CREATE PROC proc_XoaFK_ThiSinh_FKhuVuc
	@maKhuVuc VARCHAR(10)
	AS
	BEGIN
		DELETE THISINH
		WHERE maKhuVuc = @maKhuVuc
	END
	GO

/*===================================== Store Đối Tượng=====================================*/

--Kiểm tra ID đối tượng

	CREATE PROC proc_KiemTraID_DoiTuong
	@maDoiTuong VARCHAR(10)
	AS
	BEGIN
		SELECT * FROM DOITUONG WHERE maDoiTuong = @maDoiTuong
	END
	GO

--Thêm đối tượng

	CREATE PROC proc_ThemDoiTuong
	@maDoiTuong VARCHAR(10), @tenDoiTuong NVARCHAR(200)
	AS
	BEGIN
		INSERT INTO DOITUONG VALUES (@maDoiTuong, @tenDoiTuong)
	END
	GO

--Cập nhật đối tượng

	CREATE PROC proc_CapNhatDoiTuong
	@maDoiTuong VARCHAR(10), @tenDoiTuong NVARCHAR(200)
	AS
	BEGIN
		UPDATE DOITUONG 
		SET tenDoiTuong = @tenDoiTuong
		WHERE maDoiTuong = @maDoiTuong
	END
	GO

--Xóa FK đối tượng

	CREATE PROC proc_XoaF_ThiSinh_FDoiTuong
	@maDoiTuong VARCHAR(10)
	AS
	BEGIN
		DELETE THISINH 
		WHERE maDoiTuong = @maDoiTuong
	END
	GO

--Xóa đối tượng

	CREATE PROC proc_DoiTuong
	@maDoiTuong VARCHAR(10)
	AS
	BEGIN
		DELETE DOITUONG
		WHERE maDoiTuong = @maDoiTuong
	END
	GO

/*===================================== Store Thời Gian Thi=====================================*/

--Kiểm tra ID thời gian
	
	CREATE PROC proc_KiemTraID_ThoiGian
	@maThoiGian VARCHAR(10)
	AS
	BEGIN
		SELECT * FROM THOIGIANTHI WHERE maThoiGian = @maThoiGian
	END
	GO

--Thêm thời gian

	CREATE PROC proc_ThemThoiGian
	@maThoiGian VARCHAR(10), @thoiGian NVARCHAR(200)
	AS
	BEGIN
		INSERT INTO THOIGIANTHI VALUES (@maThoiGian, @thoiGian)
	END
	GO

--Cập nhật thời gian

	CREATE PROC proc_CapNhatThoiGian
	@maThoiGian VARCHAR(10), @thoiGian NVARCHAR(200)
	AS
	BEGIN
		UPDATE THOIGIANTHI 
		SET thoiGian = @thoiGian
		WHERE maThoiGian = @maThoiGian
	END
	GO

--Xóa thời gian

	CREATE PROC proc_XoaThoiGianThi
	@maThoiGian VARCHAR(10)
	AS
	BEGIN
		DELETE THOIGIANTHI 
		WHERE maThoiGian = @maThoiGian
	END
	GO

--Xóa Môn tham chiếu thời gian

	CREATE PROC proc_XoaFK_Mon_FThoiGianThi
	@maThoiGian VARCHAR(10)
	AS
	BEGIN
		DELETE MONTHI 
		WHERE maThoiGian = @maThoiGian
	END
	GO

/*===================================== Store Buổi Thi=====================================*/

--Kiểm tra ID buổi thi

	CREATE PROC proc_KiemTraID_BuoiThi
	@maBuoiThi VARCHAR(10)
	AS
	BEGIN
		SELECT * FROM BUOITHI WHERE maBuoiThi = @maBuoiThi
	END
	GO

--Thêm buổi thi

	CREATE PROC proc_ThemBuoiThi
	@maBuoiThi VARCHAR(10), @buoiThi NVARCHAR(200)
	AS
	BEGIN
		INSERT INTO BUOITHI VALUES (@maBuoiThi, @buoiThi)
	END
	GO

--Cập nhật buổi thi

	CREATE PROC proc_CapNhatBuoiThi
	@maBuoiThi VARCHAR(10), @buoiThi NVARCHAR(200)
	AS
	BEGIN
		UPDATE BUOITHI 
		SET buoiThi = @buoiThi
		WHERE maBuoiThi = @maBuoiThi
	END
	GO

--Xóa buổi thi

	CREATE PROC proc_XoaBuoiThi
	@maBuoiThi VARCHAR(10)
	AS
	BEGIN
		DELETE BUOITHI 
		WHERE maBuoiThi = @maBuoiThi
	END
	GO

--Xóa khóa phụ môn tham chiếu buổi thi

	CREATE PROC proc_XoaFK_Mon_FBuoiThi
	@maBuoiThi VARCHAR(10)
	AS
	BEGIN
		DELETE MONTHI 
		WHERE maBuoiThi = @maBuoiThi
	END
	GO

/*===================================== Store Giám Thị Coi Thi=====================================*/

--View danh sách giám thị coi thi

	CREATE VIEW view_DanhSachGiamThi AS
	SELECT CB.maCanBo, CB.tenCanBo, DV.tenDonVi, CB.gioiTinh, CV.tenChucVu, DT.diaChiDiemThi
	FROM CANBOCOITHI CB, DONVI DV, CHUCVU CV, DIEMTHI DT
	WHERE CB.maDonVi = DV.maDonVi
	AND CB.maChucVu = CV.maChucVu
	AND CB.diemThiSo = DT.diemThiSo
	GO

--Kiểm tra ID giám thị

	CREATE PROC proc_KiemTraID_GiamThi
	@maCanBo VARCHAR(10)
	AS
	BEGIN
		SELECT * FROM CANBOCOITHI WHERE maCanBo = @maCanBo
	END
	GO

--Thêm giám thị

	CREATE PROC proc_ThemGiamThi
	@maCanBo VARCHAR(10), @tenCanBo NVARCHAR(200), @maDonVi VARCHAR(10), @gioiTinh NVARCHAR(10), @maChucVu VARCHAR(10), @diemThiSo VARCHAR(10)
	AS
	BEGIN
		INSERT INTO CANBOCOITHI VALUES (@maCanBo, @tenCanBo, @maDonVi, @gioiTinh, @maChucVu, @diemThiSo)
	END
	GO

--Cập nhật giám thị

	CREATE PROC proc_CapNhatGiamThi
	@maCanBo VARCHAR(10), @tenCanBo NVARCHAR(200), @maDonVi VARCHAR(10), @gioiTinh NVARCHAR(10), @maChucVu VARCHAR(10), @diemThiSo VARCHAR(10)
	AS
	BEGIN
		UPDATE CANBOCOITHI
		SET tenCanBo = @tenCanBo, maDonVi = @maDonVi, gioiTinh = @gioiTinh, maChucVu = @maChucVu, diemThiSo = @diemThiSo
		WHERE maCanBo = @maCanBo
	END
	GO

--Xóa giám thị

	CREATE PROC proc_XoaGiamThi
	@maCanBo VARCHAR(10)
	AS
	BEGIN
		DELETE CANBOCOITHI 
		WHERE maCanBo = @maCanBo
	END
	GO

--Tìm giám thị theo tên

	CREATE PROC proc_TimTenGiamThi
	@tenCanBo NVARCHAR(200)
	AS
	BEGIN
		SELECT CB.maCanBo, CB.tenCanBo, DV.tenDonVi, CB.gioiTinh, CV.tenChucVu, DT.diaChiDiemThi
		FROM CANBOCOITHI CB, DONVI DV, CHUCVU CV, DIEMTHI DT
		WHERE CB.maDonVi = DV.maDonVi
		AND CB.maChucVu = CV.maChucVu
		AND CB.diemThiSo = DT.diemThiSo
		AND CB.tenCanBo LIKE @tenCanBo
	END
	GO

--Tìm giám thị theo địa chỉ

	CREATE PROC proc_TimGiamThi_TheoDiaChi
	@tenDiaDiem NVARCHAR(200)
	AS
	BEGIN
		SELECT CB.maCanBo, CB.tenCanBo, DV.tenDonVi, CB.gioiTinh, CV.tenChucVu, DT.diaChiDiemThi
		FROM CANBOCOITHI CB, DONVI DV, CHUCVU CV, DIEMTHI DT
		WHERE CB.maDonVi = DV.maDonVi
		AND CB.maChucVu = CV.maChucVu
		AND CB.diemThiSo = DT.diemThiSo
		AND DT.diaChiDiemThi LIKE @tenDiaDiem
	END
	GO

/*===================================== Store môn thi=====================================*/

--View môn thi
	
	CREATE VIEW view_DanhSachMonThi AS
	SELECT MT.maMon, MT.tenMon, MT.ngayThi, BT.buoiThi, TG.thoiGian, N.tenNganh
	FROM MONTHi MT, BUOITHI BT, THOIGIANTHI TG, NGANH N
	WHERE MT.maBuoiThi = BT.maBuoiThi
	AND MT.maThoiGian = TG.maThoiGian
	AND MT.maNganh = N.maNganh
	GO

--Kiểm tra ID môn thi

	CREATE PROC proc_KiemTraID_MonThi
	@maMon VARCHAR(10)
	AS
	BEGIN
		SELECT * FROM MONTHI WHERE maMon = @maMon
	END
	GO

--Thêm môn học

	CREATE PROC proc_ThemMonHoc
	@maMon VARCHAR(10), @tenMon NVARCHAR(200), @ngayThi DATETIME, @buoiThi NVARCHAR(5), @thoiGian VARCHAR(10), @maNganh VARCHAR(10)
	AS
	BEGIN
		INSERT INTO MONTHI VALUES (@maMon, @tenMon, @ngayThi, @buoiThi, @thoiGian, @maNganh)
	END
	GO

--Cập nhật môn học

	CREATE PROC proc_CapNhatMonHoc
	@maMon VARCHAR(10), @tenMon NVARCHAR(200), @ngayThi DATETIME, @maBuoiThi NVARCHAR(5), @maThoiGian VARCHAR(10), @maNganh VARCHAR(10)
	AS
	BEGIN
		UPDATE MONTHI
		SET tenMon = @tenMon, ngayThi = @ngayThi, maBuoiThi = @maBuoiThi, maThoiGian = @maThoiGian, maNganh = @maNganh
		WHERE maMon = @maMon
	END
	GO

--Xóa môn thi

	CREATE PROC proc_XoaMonThi
	@maMon VARCHAR(10)
	AS
	BEGIN
		DELETE MONTHI 
		WHERE maMon = @maMon
	END
	GO

--Tìm tên môn học

	CREATE PROC proc_TimTenMonHoc
	@tenMon NVARCHAR(200)
	AS
	BEGIN
		SELECT MT.maMon, MT.tenMon, MT.ngayThi, BT.buoiThi, TG.thoiGian, N.tenNganh
		FROM MONTHi MT, BUOITHI BT, THOIGIANTHI TG, NGANH N
		WHERE MT.maBuoiThi = BT.maBuoiThi
		AND MT.maThoiGian = TG.maThoiGian
		AND MT.maNganh = N.maNganh
		AND MT.tenMon LIKE @tenMon
	END
	GO

--Tìm tên môn học theo ngành

	CREATE PROC proc_TimTenMon_TheoNganh
	@maNganh NVARCHAR(200)
	AS
	BEGIN
		SELECT MT.maMon, MT.tenMon, MT.ngayThi, BT.buoiThi, TG.thoiGian, N.tenNganh
		FROM MONTHi MT, BUOITHI BT, THOIGIANTHI TG, NGANH N
		WHERE MT.maBuoiThi = BT.maBuoiThi
		AND MT.maThoiGian = TG.maThoiGian
		AND MT.maNganh = N.maNganh
		AND MT.maNganh LIKE @maNganh
	END
	GO

/*===================================== Store Phòng Thi=====================================*/

--View danh sách phong thi

	CREATE VIEW view_DanhSachPhongThi AS
	SELECT PT.maPhong, DT.diaChiDiemThi, PT.ghiChu
	FROM PHONGTHI PT, DIEMTHI DT
	WHERE PT.diemThiSo = DT.diemThiSo
	GO

--Kiểm tra ID phòng thi

	CREATE PROC proc_KiemTraID_PhongThi
	@maPhong VARCHAR(10)
	AS
	BEGIN
		SELECT * FROM PHONGTHI WHERE maPhong = @maPhong
	END
	GO

--Thêm phong thi

	CREATE PROC proc_ThemPhongThi
	@maPhong VARCHAR(10), @diemThiSo INT, @ghiChu NVARCHAR(200)
	AS
	BEGIN
		INSERT INTO PHONGTHI VALUES (@maPhong, @diemThiSo, @ghiChu)
	END
	GO

--Cập nhật phòng thi

	CREATE PROC proc_CapNhatPhongThi
	@maPhong VARCHAR(10), @diemThiSo INT, @ghiChu NVARCHAR(200)
	AS
	BEGIN
		UPDATE PHONGTHI
		SET diemThiSo = @diemThiSo, ghiChu = @ghiChu
		WHERE maPhong = @maPhong
	END
	GO

--Xóa phòng thi

	CREATE PROC proc_XoaPhongThi
	@maPhong VARCHAR(10)
	AS
	BEGIN
		DELETE PHONGTHI 
		WHERE maPhong = @maPhong
	END
	GO

--Xóa khóa phụ phòng thi

	CREATE PROC proc_XoaFK_ThiSinh_FPhongThi_DAO
	@maPhong VARCHAR(10)
	AS
	BEGIN
		DELETE THISINH 
		WHERE maPhong = @maPhong
	END
	GO

--Tìm phong thi theo mã

	CREATE PROC proc_TimMaPhong
	@maPhong NVARCHAR(10)
	AS
	BEGIN
		SELECT PT.maPhong, DT.diaChiDiemThi, PT.ghiChu
		FROM PHONGTHI PT, DIEMTHI DT
		WHERE PT.diemThiSo = DT.diemThiSo
		AND PT.maPhong like @maPhong
	END
	GO

--Tìm phong thi theo địa chỉ

	CREATE PROC proc_TimPhong_TheoDiaDiem
	@diaChiDiemThi NVARCHAR(10)
	AS
	BEGIN
		SELECT PT.maPhong, DT.diaChiDiemThi, PT.ghiChu
		FROM PHONGTHI PT, DIEMTHI DT
		WHERE PT.diemThiSo = DT.diemThiSo
		AND DT.diaChiDiemThi like @diaChiDiemThi
	END
	GO

/*===================================== Store Thí Sinh=====================================*/

--View Thí Sinh

	CREATE VIEW view_DanhSachThiSinh AS
	SELECT TS.soBaoDanh, TS.hoTen, TS.ngaySinh, TS.gioiTinh, TS.hoKhau, DT.tenDoiTuong, N.tenNganh, KV.tenKhuVuc, P.maPhong, TS.images
	FROM THISINH TS, DOITUONG DT, NGANH N, KHUVUC KV, PHONGTHI P
	WHERE TS.maDoiTuong = DT.maDoiTuong
	AND TS.maNganh = N.maNganh
	AND TS.maKhuVuc = KV.maKhuVuc
	AND TS.maPhong = P. maPhong
	GO

--Kiểm tra ID Thí Sinh

	CREATE PROC proc_KiemTraID_ThiSinh
	@soBaoDanh VARCHAR(10)
	AS
	BEGIN
		SELECT * FROM THISINH WHERE soBaoDanh = @soBaoDanh
	END
	GO

--Thêm thí sinh

	create PROC proc_ThemThiSinh
	@soBaoDanh VARCHAR(10), @hoTen NVARCHAR(200), @ngaySinh DATETIME, @gioiTinh NVARCHAR(10), @hoKhau NVARCHAR(200), @maDoiTuong VARCHAR(10), @maNganh VARCHAR(10), @maKhuVuc VARCHAR(10), @maPhong VARCHAR(10), @images nvarchar(max)
	AS
	BEGIN
		INSERT INTO THISINH VALUES (@soBaoDanh, @hoTen, @ngaySinh, @gioiTinh , @hoKhau, @maDoiTuong, @maNganh, @maKhuVuc, @maPhong, @images)
	END
	GO

--Cập nhật thí sinh

	create PROC proc_CapNhatThiSinh
	@soBaoDanh VARCHAR(10), @hoTen NVARCHAR(200), @ngaySinh DATETIME, @gioiTinh NVARCHAR(10), @hoKhau NVARCHAR(200), @maDoiTuong VARCHAR(10), @maNganh VARCHAR(10), @maKhuVuc VARCHAR(10), @maPhong VARCHAR(10), @images nvarchar(max)
	AS
	BEGIN
		UPDATE THISINH
		SET hoTen = @hoTen, ngaySinh = @ngaySinh, gioiTinh = @gioiTinh, hoKhau = @hoKhau, maDoiTuong = @maDoiTuong, maNganh = @maNganh, maKhuVuc = @maKhuVuc, maPhong = @maPhong, images = @images
		WHERE soBaoDanh = @soBaoDanh
	END
	GO

--Xóa khóa phụ của học sinh

	CREATE PROC proc_XoaFK_TaiKhoan
	@soBaoDanh VARCHAR(10)
	AS
	BEGIN
		DELETE TAIKHOAN 
		WHERE soBaoDanh = @soBaoDanh
	END
	GO

--Xóa thí sinh

	CREATE PROC proc_XoaThiSinh
	@soBaoDanh VARCHAR(10)
	AS
	BEGIN
		DELETE THISINH 
		WHERE soBaoDanh = @soBaoDanh
	END
	GO


--Xóa khóa phụ ngành từ thí sinh

	CREATE PROC proc_XoaFK_Nganh_FThiSinh
	@maNganh VARCHAR(10)
	AS
	BEGIN
		DELETE THISINH 
		WHERE maNganh = @maNganh
	END
	GO

--Get Values thông tin Thí Sinh

	CREATE PROC proc_GetValue_Info
	@soBaoDanh VARCHAR(10)
	AS
	BEGIN
		SELECT TS.soBaoDanh, TS.hoTen, TS.ngaySinh, TS.gioiTinh, TS.hoKhau, DT.tenDoiTuong, N.tenNganh, KV.tenKhuVuc, P.maPhong, TS.images
		FROM THISINH TS, DOITUONG DT, NGANH N, KHUVUC KV, PHONGTHI P
		WHERE TS.maDoiTuong = DT.maDoiTuong
		AND TS.maNganh = N.maNganh
		AND TS.maKhuVuc = KV.maKhuVuc
		AND TS.maPhong = P. maPhong
		AND TS.soBaoDanh = @soBaoDanh
	END
	GO

--Tìm tên thí sinh
	
	CREATE PROC proc_FindName_ThiSinh
	@hoTen NVARCHAR(200)
	AS
	BEGIN
		SELECT TS.soBaoDanh, TS.hoTen, TS.ngaySinh, TS.gioiTinh, TS.hoKhau, DT.tenDoiTuong, N.tenNganh, KV.tenKhuVuc, P.maPhong, TS.images
		FROM THISINH TS, DOITUONG DT, NGANH N, KHUVUC KV, PHONGTHI P
		WHERE TS.maDoiTuong = DT.maDoiTuong
		AND TS.maNganh = N.maNganh
		AND TS.maKhuVuc = KV.maKhuVuc
		AND TS.maPhong = P. maPhong
		AND TS.hoTen like @hoTen
	END
	GO

--Tìm theo ngành

	CREATE PROC proc_FindMajor_ThiSinh
	@maNganh NVARCHAR(200)
	AS
	BEGIN
		SELECT TS.soBaoDanh, TS.hoTen, TS.ngaySinh, TS.gioiTinh, TS.hoKhau, DT.tenDoiTuong, N.tenNganh, KV.tenKhuVuc, P.maPhong, TS.images
		FROM THISINH TS, DOITUONG DT, NGANH N, KHUVUC KV, PHONGTHI P
		WHERE TS.maDoiTuong = DT.maDoiTuong
		AND TS.maNganh = N.maNganh
		AND TS.maKhuVuc = KV.maKhuVuc
		AND TS.maPhong = P. maPhong
		AND TS.maNganh like @maNganh
	END
	GO

--Tìm theo mã phòng

	CREATE PROC proc_FindIDPhong_ThiSinh
	@maPhong NVARCHAR(200)
	AS
	BEGIN
		SELECT TS.soBaoDanh, TS.hoTen, TS.ngaySinh, TS.gioiTinh, TS.hoKhau, DT.tenDoiTuong, N.tenNganh, KV.tenKhuVuc, P.maPhong, TS.images
		FROM THISINH TS, DOITUONG DT, NGANH N, KHUVUC KV, PHONGTHI P
		WHERE TS.maDoiTuong = DT.maDoiTuong
		AND TS.maNganh = N.maNganh
		AND TS.maKhuVuc = KV.maKhuVuc
		AND TS.maPhong = P. maPhong
		AND TS.maPhong like @maPhong
	END
	GO

--Số Lượng thí Sinh

	CREATE VIEW view_SoLuongThiSinh AS
	SELECT SUM([rows]) AS SLTS
	FROM SYS.PARTITIONS
	WHERE OBJECT_ID = OBJECT_ID('THISINH')
	AND INDEX_ID in (0,1)
	GO

--Số Địa Điểm Tổ Chức

	CREATE VIEW view_SoDiaDiemToChuc AS
	SELECT SUM([rows]) AS SLDDT
	FROM SYS.PARTITIONS
	WHERE OBJECT_ID = OBJECT_ID('DIEMTHI')
	AND INDEX_ID in (0,1)
	GO

--Số Giảng Viên

	CREATE VIEW view_SoGiangVien AS
	SELECT SUM([rows]) AS SLGV
	FROM SYS.PARTITIONS
	WHERE OBJECT_ID = OBJECT_ID('CANBOCOITHI')
	AND INDEX_ID in (0,1)
	GO
