CREATE DATABASE FPSakananeWash

Create Table member (
id_member smallint NOT NULL primary key identity (1,1),
nama_member varchar (100) not null,
no_hp varchar (20) not null,
email varchar (100) not null,
password varchar (20) not null
)

Create Table laundry (
id_laundry smallint NOT NULL primary key identity (1,1),
nama_laundry varchar (100) not null,
nama_pemilik varchar (100) not null,
email varchar (100) not null,
password varchar (20) not null,
alamat varchar (100),
no_hp varchar (20) not null,
harga smallint not null,
antar_jemput smallint not null,
)

Create Table penilaian (
kd_nilai smallint NOT NULL primary key identity (1,1),
rating smallint
check (rating IN (1, 2, 3, 4, 5)),
ulasan varchar (100) not null, 
id_laundry smallint 
foreign key references laundry (id_laundry),
id_member smallint 
foreign key references member (id_member)
)

Create Table chat (
kd_chat smallint NOT NULL primary key identity (1,1),
isi_chat varchar (100) not null,
id_laundry smallint 
foreign key references laundry (id_laundry),
id_member smallint
foreign key references member (id_member)
)

Create Table order_cucian (
kd_cucian smallint NOT NULL primary key identity (1,1),
berat_cucian smallint not null,
antar_jemput char (1) check (antar_jemput = 'Y' or antar_jemput = 'T'),
id_laundry smallint
foreign key references laundry (id_laundry)
on update cascade on delete no action,
id_member smallint
foreign key references member (id_member) 
on update cascade on delete no action
)

Create Table pembayaran (
kd_pembayaran smallint NOT NULL primary key identity (1,1),
total_pembayaran int not null,
jenis_pembayaran varchar (10) 
Check (jenis_pembayaran = 'Tunai' or jenis_pembayaran =  'E-Money'),
id_laundry smallint
foreign key references laundry (id_laundry),
id_member smallint
foreign key references member (id_member)
)


drop table pembayaran

drop table order_cucian

drop table chat

drop table penilaian

drop table laundry

drop table member


INSERT INTO member Values ('Danny', '0858', 'd@mail.com', '12345')

INSERT INTO laundry Values ('Laundry A', 'Nurakhmad', 'n@mail.com', '12345', 'Jln. Wates', '090909090909', 5000, 6000),
('Laundry B', 'Nur', 'nur@mail.com', '12345', 'Jln. Wonosari', '080808080808', 5500, 6500),
('Laundry C', 'Achmad', 'a@mail.com', '12345', 'Jln. Ahmad Yani', '070707070707', 6000, 7000),
('Laundry D', 'Agista', 'ag@mail.com', '12345', 'Jln. Gejayan', '060606060606', 6500, 7500),
('Laundry E', 'Daffa', 'df@mail.com', '12345', 'Jln. Monjali', '050505050505', 7000, 8000),
('Laundry F', 'Alansa', 'al@mail.com', '12345', 'Jln. Magelang', '040404040404', 7500, 8500)

INSERT INTO penilaian Values ('5', 'sangat baik', 1, 1)

INSERT INTO chat Values ('Halooo', 1, 1)

INSERT INTO pembayaran Values (30000, 'Tunai', 1, 1)

INSERT INTO order_cucian Values (5, 'Y', 1, 1)


select * from member

select * from laundry

select * from penilaian

select * from chat

select * from order_cucian

select * from pembayaran