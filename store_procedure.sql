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
create or alter proc DangKyUngVien(@CCCD varchar(10),@HoTen varchar(20),@SDT varchar(10),@DiaChi varchar(50))
as
begin
	insert into UNG_VIEN values(@CCCD,@HoTen,@SDT,@DiaChi)
end
go