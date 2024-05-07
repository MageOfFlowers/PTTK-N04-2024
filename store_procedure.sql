use QL_HSUT
go
create or alter proc thanh_toan (@ma_qc varchar, @lan_tra int, @so_tien numeric, @ngay_thanh_toan date, @phuong_thuc varchar)
as
begin
	insert into THANH_TOAN values (@ma_qc, @lan_tra, @so_tien, @ngay_thanh_toan, @phuong_thuc)
END
GO
create or alter proc LayTTDangTuyen (@MaSoThue varchar)
as
begin
	SELECT * FROM dbo.TT_DANG_TUYEN WHERE MaSoThue = @MaSoThue
END
GO
create or alter proc LayBangCap (@MaHS varchar)
as
begin
	SELECT TenBangCap,LoaiBangCap,ChiTietBangCap FROM dbo.BANG_CAP WHERE MaHS = @MaHS
END
GO
create or alter proc LayDangKyUngTuyen (@MaTT varchar)
as
begin
	SELECT * FROM dbo.DANG_KY_UNG_TUYEN WHERE MaDT = @MaTT
END
go
create or alter proc LuuDangKyUngTuyen (@MaHS VARCHAR, @DuDieuKien VARCHAR)
as
begin
	UPDATE dbo.DANG_KY_UNG_TUYEN SET TrangThai = @TrangThai WHERE MaHS = @MaHS
END
GO
create or alter proc LayThongTinUngVien (@CCCD VARCHAR)
as
begin
	SELECT * FROM dbo.DANG_KY_UNG_TUYEN WHERE CCCD = @CCCD
END