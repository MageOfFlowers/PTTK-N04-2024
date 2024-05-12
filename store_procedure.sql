use QL_HSUT
GO
--Tai
create or alter proc lay_ds_hoa_don
as
begin
	select qc.MaQC, qc.TongSoTien, dt.MaSoThue, dn.TenCongTy, dt.MaTT, dt.ViTriTuyen, dt.BatDauTuyen NgayDangTuyen from TT_QUANG_CAO qc join TT_DANG_TUYEN dt on qc.MaTT = dt.MaTT join DOANH_NGHIEP dn on dt.MaSoThue = dn.MaSoThue where TrangThaiThanhToan = 0
end

go
create or alter proc lay_lan_thanh_toan (@maqc varchar(10))
as
begin
	select MAX(LanTra) + 1 LanGanNhat from THANH_TOAN where MaQC = @maqc
end

go
create or alter proc thuc_hien_thanh_toan (@ma_qc varchar(10), @lan_tra int, @so_tien numeric, @ngay_thanh_toan date, @phuong_thuc varchar(50))
as
begin
	insert into THANH_TOAN values (@ma_qc, @lan_tra, @so_tien, @ngay_thanh_toan, @phuong_thuc)
END
--------------------------------------
GO
create or alter proc LayTTDangTuyen (@MaSoThue VARCHAR(10))
as
begin
	SELECT * FROM dbo.TT_DANG_TUYEN WHERE MaSoThue = @MaSoThue 
END

GO

create or alter proc DangKyThanhVien (@MaSoThue VARCHAR(10),@TenCongTy varchar(50),@DiaChi varchar(100),@Email varchar(50),@NguoiDaiDien varchar(20),@TrangThai varchar(20),@UuDai varchar(10))
as
begin
	insert into DOANH_NGHIEP values(@MaSoThue,@TenCongTy,@DiaChi,@Email,@NguoiDaiDien,@TrangThai,@UuDai)
end
go

create or alter proc LayBangCap (@MaHS VARCHAR(10))
as
begin
	SELECT TenBangCap,LoaiBangCap,ChiTietBangCap FROM dbo.BANG_CAP WHERE MaHS = @MaHS
END
GO
create or alter proc LayDangKyUngTuyen (@MaTT VARCHAR(10))
as
begin
	SELECT MaHS,
	HoTen,DANG_KY_UNG_TUYEN.CCCD,
           DANG_KY_UNG_TUYEN.TrangThai,
           NgayGui,NgayNop,
           PhanHoi,
           DoUuTien FROM dbo.DANG_KY_UNG_TUYEN JOIN dbo.UNG_VIEN ON UNG_VIEN.CCCD = DANG_KY_UNG_TUYEN.CCCD WHERE MaTT = @MaTT AND (TrangThai = 'ChapNhan' OR TrangThai = 'TuChoi' OR TrangThai = 'ChoGui') 
	ORDER BY DoUuTien desc
END
--SELECT * FROM dbo.DANG_KY_UNG_TUYEN AS d JOIN dbo.TT_DANG_TUYEN AS t ON d.MaTT = t.MaTT WHERE t.MaSoThue = 
go
create or alter proc LuuDangKyUngTuyen (@MaHS VARCHAR(10), @TrangThai VARCHAR(10), @PhanHoi VARCHAR(10))
as
begin
	UPDATE dbo.DANG_KY_UNG_TUYEN SET TrangThai = @TrangThai, PhanHoi = @PhanHoi WHERE MaHS = @MaHS
END
GO
create or alter proc LayThongTinUngVien (@CCCD VARCHAR(10))
as
begin
	SELECT * FROM dbo.UNG_VIEN WHERE CCCD = @CCCD
END
go
create or alter proc DangKyUngVien(@anh varbinary(max),@CCCD varchar(10),@HoTen varchar(20),@SDT varchar(10),@DiaChi varchar(50))
as
begin
	insert into UNG_VIEN values(@anh,@CCCD,@HoTen,@SDT,@DiaChi)
end
go

--Tin
CREATE or alter PROCEDURE [dbo].[usp_GetDoanhNghiep]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT *
    FROM DOANH_NGHIEP;
END;

go

CREATE OR ALTER PROCEDURE [dbo].[usp_LocDoanhNghiepQuaHanTT]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT DN.MaSoThue, DN.TenCongTy, DN.DiaChi, DN.Email, DN.NguoiDaiDien
    FROM DOANH_NGHIEP DN
    INNER JOIN TT_DANG_TUYEN TT ON DN.MaSoThue = TT.MaSoThue
    WHERE TT.TrangThai = '1';
END;
go

CREATE OR ALTER PROCEDURE [dbo].[usp_LocDangTuyenQuaHanTT]
	@MaSoThue VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM TT_DANG_TUYEN TT
    WHERE MaSoThue = @MaSoThue and TrangThai = '1';
END;
go

CREATE OR ALTER PROCEDURE [dbo].[usp_GetTTDangTuyenByMaTT]
    @MaTT VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
	SELECT TT.MaTT, DN.MaSoThue, DN.TenCongTy,
           TT.ViTriTuyen, TT.SoLuongTuyen, TT.BatDauTuyen, TT.KetThucTuyen, TT.YeuCau
    FROM DOANH_NGHIEP DN
    INNER JOIN TT_DANG_TUYEN TT ON DN.MaSoThue = TT.MaSoThue
    WHERE TT.MaTT = @MaTT;
END;
go

CREATE OR ALTER PROCEDURE [dbo].[usp_UpdateTTDangTuyen]
    @MaTT VARCHAR(10),
    @BatDauTuyen DATETIME,
    @KetThucTuyen DATETIME
AS
BEGIN
    UPDATE TT_DANG_TUYEN
    SET BatDauTuyen = @BatDauTuyen,
        KetThucTuyen = @KetThucTuyen,
        TrangThai = '0'
    WHERE MaTT = @MaTT;
END;
go

CREATE OR ALTER PROCEDURE [dbo].[usp_HuyGiahan_TTDangTuyen]
    @MaTT VARCHAR(10)
AS
BEGIN
    UPDATE TT_DANG_TUYEN
    SET TrangThai = '-1'
    WHERE MaTT = @MaTT;
END;
GO
create or alter proc DangNhap (@TaiKhoan VARCHAR(10), @MatKhau VARCHAR(50))
as
BEGIN
declare @vt AS VARCHAR(5)
	IF EXISTS(SELECT VaiTro FROM taikhoan WHERE TenDangNhap = @TaiKhoan AND @MatKhau = @MatKhau)
	BEGIN 
	IF ((SELECT VaiTro FROM taikhoan WHERE TenDangNhap = @TaiKhoan AND @MatKhau = @MatKhau)='DN')
	BEGIN 
	SELECT d.MaSoThue AS TenDangNhap, d.TenCongTy AS Ten, t.VaiTro AS VaiTro FROM taikhoan t JOIN dbo.DOANH_NGHIEP d ON t.TenDangNhap = d.MaSoThue 
	WHERE t.TenDangNhap = @TaiKhoan END
	ELSE IF ((SELECT VaiTro FROM taikhoan WHERE TenDangNhap = @TaiKhoan AND @MatKhau = @MatKhau)='UV')
	BEGIN 
	SELECT d.CCCD AS TenDangNhap, d.HoTen AS Ten, t.VaiTro AS VaiTro FROM taikhoan t JOIN dbo.UNG_VIEN d ON t.TenDangNhap = d.CCCD 
	WHERE t.TenDangNhap = @TaiKhoan END
	ELSE 
	BEGIN 
	SELECT t.TenDangNhap AS Ten, t.TenDangNhap AS TenDangNhap, t.VaiTro FROM taikhoan t WHERE t.TenDangNhap = @TaiKhoan END
    END 
	ELSE BEGIN SELECT VaiTro FROM taikhoan WHERE TenDangNhap = @TaiKhoan AND @MatKhau = @MatKhau END
END