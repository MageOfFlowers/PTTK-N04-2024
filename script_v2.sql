﻿USE MASTER
go

IF DB_ID('QL_HSUT') IS NOT NULL
	DROP DATABASE QL_HSUT
go

create database QL_HSUT
go

/*
drop table BANG_CAP
drop table DANG_KY_UNG_TUYEN
drop table UNG_VIEN
drop table CT_HINH_THUC
drop table TT_DANG_TUYEN
drop table HINH_THUC
drop table THANH_TOAN
drop table TT_QUANG_CAO
drop table DOANH_NGHIEP
drop table UU_DAI
*/

use QL_HSUT

create table UU_DAI (
	MaUD varchar(10) primary key,
	ChiTietUD varchar(20)
)

create table DOANH_NGHIEP (
	MaSoThue varchar(10) primary key,
	TenCongTy varchar(20) not null,
	DiaChi varchar(50) not null,
	Email varchar(30) not null,
	NguoiDaiDien varchar(20) not null,
	TrangThai varchar(20),
	UuDai varchar(10),
	constraint FK_DN_UD
	foreign key (UuDai)
	references UU_DAI(MaUD)
)

create table TT_QUANG_CAO (
	MaQC varchar(10) primary key,
	TongSoTien numeric not null,
	TrangThaiThanhToan bit,
	TrangThaiDangTuyen bit
)

create table THANH_TOAN (
	MaQC varchar(10),
	LanTra int check(LanTra in (1, 2, 3, 4)),
	SoTien numeric not null,
	NgayThanhToan date,
	PhuongThucTT varchar(20),
	primary key (MaQC, LanTra),
	constraint FK_TT_QC
	foreign key (MaQC)
	references TT_QUANG_CAO(MaQC)
)

create table HINH_THUC (
	MaHinhThuc varchar(10) primary key,
	TenHinhThuc varchar(20) not null,
	ChiTietHinhThuc varchar(50)
)

create table TT_DANG_TUYEN (
	MaDT varchar(10) not null primary key,
	ViTriTuyen varchar(20) not null,
	SoLuongTuyen int not null,
	BatDauTuyen date not null,
	KetThucTuyen date not null,
	YeuCau varchar(50)
)

create table CT_HINH_THUC (
	MaDT varchar(10),
	MaHinhThuc varchar(10),
	primary key (MaDT, MaHinhThuc),
	constraint FK_CTHT_DT
	foreign key (MaDT)
	references TT_DANG_TUYEN(MaDT),
	constraint FK_CTHT_HT
	foreign key (MaHinhThuc)
	references HINH_THUC(MaHinhThuc)
)

create table UNG_VIEN (
	CCCD varchar(10) primary key,
	HoTen varchar(20) not null,
	SDT varchar(10) not null,
	DiaChi varchar(50) not null
)

create table DANG_KY_UNG_TUYEN (
	MaHS varchar(10) primary key,
	CCCD varchar(10),
	NgayNop date not null,
	TrangThai varchar(20),
	NgayGui date,
	PhanHoi varchar(50),
	DoUuTien int,
	constraint FK_DK_UV
	foreign key (CCCD)
	references UNG_VIEN(CCCD)
)

create table BANG_CAP (
	MaHS varchar(10),
	TenBangCap varchar(20),
	LoaiBangCap varchar(20) not null,
	ChiTietBangCap varchar(30),
	primary key (MaHS, TenBangCap),
	constraint FK_BC_HS
	foreign key (MaHS)
	references DANG_KY_UNG_TUYEN(MaHS)
)