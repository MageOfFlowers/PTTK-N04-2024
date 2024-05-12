SELECT *
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'THANH_TOAN'

GO
CREATE OR ALTER TRIGGER THANH_TOAN_insert_trig
ON THANH_TOAN
AFTER insert
as
begin
	declare @maqc varchar(10), @sotien numeric, @tongtien numeric
	set @maqc = (select MaQC from inserted)
	set @sotien = (select SoTien from inserted)
	set @tongtien = (select TongSoTien from TT_QUANG_CAO where MaQC = @maqc)

	if (@sotien <= @tongtien * 30 / 100)
	begin
		if ((select sum(SoTien) from THANH_TOAN where MaQC = @maqc) < @tongtien)
		begin
			update TT_QUANG_CAO
			set TrangThaiThanhToan = 0
			where MaQC = @maqc
			return
		end
	end
	update TT_QUANG_CAO
	set TrangThaiThanhToan = 1
	where MaQC = @maqc
end

go
create or alter trigger THANH_TOAN_delete_trig
on THANH_TOAN
after delete
as
begin
	declare @maqc varchar(10), @tongtien numeric
	set @maqc = (select MaQC from deleted)
	set @tongtien = (select TongSoTien from TT_QUANG_CAO where MaQC = @maqc)

	if ((select sum(SoTien) from THANH_TOAN where MaQC = @maqc) < @tongtien)
	begin
		update TT_QUANG_CAO
		set TrangThaiThanhToan = 0
		where MaQC = @maqc
	end
END

CREATE OR ALTER   TRIGGER [dbo].[tk_check] ON [dbo].[TaiKhoan] 
AFTER INSERT AS 
BEGIN
    IF EXISTS (SELECT 1 FROM Inserted JOIN dbo.DOANH_NGHIEP ON Inserted.TenDangNhap = DOANH_NGHIEP.MaSoThue WHERE Inserted.VaiTro = 'DN')
    BEGIN
        DELETE dbo.TaiKhoan FROM TaiKhoan JOIN Inserted ON TaiKhoan.TenDangNhap = Inserted.TenDangNhap
    END
    ELSE IF EXISTS (SELECT 1 FROM Inserted JOIN dbo.UNG_VIEN ON Inserted.TenDangNhap = UNG_VIEN.CCCD WHERE Inserted.VaiTro = 'UV')
    BEGIN
        DELETE dbo.TaiKhoan FROM TaiKhoan JOIN Inserted ON TaiKhoan.TenDangNhap = Inserted.TenDangNhap
    END
END