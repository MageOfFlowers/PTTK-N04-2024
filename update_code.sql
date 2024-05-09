SELECT *
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'TT_QUANG_CAO'

ALTER TABLE DOANH_NGHIEP
DROP COLUMN TrangThai
ALTER TABLE DOANH_NGHIEP
drop constraint FK_DN_UD
ALTER TABLE DOANH_NGHIEP
DROP COLUMN UuDai

update TT_DANG_TUYEN
set KetThucTuyen = dateAdd(year, 1, BatDauTuyen)
alter table TT_DANG_TUYEN
add TrangThai char(2)
alter table TT_DANG_TUYEN
add UuDai varchar(10)
alter table TT_DANG_TUYEN
add constraint FK_DT_UD
foreign key (UuDai)
references UU_DAI(MaUD)
update TT_DANG_TUYEN
set TrangThai = -1
where datediff(day, KetThucTuyen, getdate()) > 3
update TT_DANG_TUYEN
set TrangThai = 1
where datediff(day, getdate(), KetThucTuyen) <= 3 and datediff(day, getdate(), KetThucTuyen) >= 0

alter table HINH_THUC
alter column ChiTietHinhThuc varchar(100)
insert into HINH_THUC values ('BG', 'Bao giay', 'Dang tuyen dung len trang bia cua bao giay')
insert into HINH_THUC values ('BN', 'Banner quang cao', 'Dang tuyen dung len cac banner quang cao dan tren pho hoac toa nha')
insert into HINH_THUC values ('TM', 'Trang mang', 'Dang tuyen dung len cac trang web thong tin cua cong ty')

update DANG_KY_UNG_TUYEN
set NgayGui = dateAdd(day, 25, NgayNop)
update DANG_KY_UNG_TUYEN
set NgayGui = null, PhanHoi = null
where TrangThai = 'HetHan' or TrangThai = 'ChoGui' or TrangThai = 'ChoXetDuyet' or TrangThai = 'ChoBoSung'

update TT_QUANG_CAO
set TrangThaiThanhToan = 0
update TT_QUANG_CAO
set TrangThaiDangTuyen = 0
where TrangThaiDangTuyen is null
alter table TT_QUANG_CAO
alter column TrangThaiDangTuyen bit not null

