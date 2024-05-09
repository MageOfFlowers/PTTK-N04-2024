SELECT *
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'THANH_TOAN'

go
create or alter trigger THANH_TOAN_insert_trig
on THANH_TOAN
after insert
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
end