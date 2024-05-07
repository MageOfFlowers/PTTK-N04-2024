use QL_HSUT

create or alter proc thanh_toan (@ma_qc varchar, @lan_tra int, @so_tien numeric, @ngay_thanh_toan date, @phuong_thuc varchar)
as
begin
	insert into THANH_TOAN values (@ma_qc, @lan_tra, @so_tien, @ngay_thanh_toan, @phuong_thuc)
end