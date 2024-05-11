use QL_HSUT
GO
/*
create or alter proc thanh_toan (@ma_qc varchar, @lan_tra int, @so_tien numeric, @ngay_thanh_toan date, @phuong_thuc varchar)
as
begin
	insert into THANH_TOAN values (@ma_qc, @lan_tra, @so_tien, @ngay_thanh_toan, @phuong_thuc)
END
O
*/
GO
create or alter proc LayTTDangTuyen (@MaSoThue VARCHAR(10))
as
begin
	SELECT * FROM dbo.TT_DANG_TUYEN WHERE MaSoThue = @MaSoThue 
END

GO
create or alter proc LayBangCap (@MaHS VARCHAR(10))
as
begin
	SELECT TenBangCap,LoaiBangCap,ChiTietBangCap FROM dbo.BANG_CAP WHERE MaHS = @MaHS
END
GO
create or alter proc LayDangKyUngTuyen (@MaTT VARCHAR(10))
as
begin
	SELECT * FROM dbo.DANG_KY_UNG_TUYEN WHERE MaTT = @MaTT AND (TrangThai = 'ChapNhan' OR TrangThai = 'TuChoi' OR TrangThai = 'ChoGui') 
	ORDER BY DoUuTien desc
END
--SELECT * FROM dbo.DANG_KY_UNG_TUYEN AS d JOIN dbo.TT_DANG_TUYEN AS t ON d.MaTT = t.MaTT WHERE t.MaSoThue = 
go
create or alter proc LuuDangKyUngTuyen (@MaHS VARCHAR(10), @TrangThai VARCHAR(10))
as
begin
	UPDATE dbo.DANG_KY_UNG_TUYEN SET TrangThai = @TrangThai WHERE MaHS = @MaHS
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
