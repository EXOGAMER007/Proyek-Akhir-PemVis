CREATE SCHEMA ProyekAkhirPemVis;

USE ProyekAkhirPemVis;

Create table tbUsers (
	NomorHP bigint primary key,
    username  varchar(50),
    password varchar(50),
	KTP  varchar(300),
    statusPinjaman varchar(50) default "tidak ada pinjaman"
);

Create table Pinjaman (
	idPinjaman int primary key auto_increment,
    Nama varchar(50),
    Alamat varchar(100),
    Nominal int,
    cicilan varchar(50),
    tanggalACCEPT DATE DEFAULT '1000-01-01',
    status varchar(50) default "pending", 
    NomorHP_Pengguna bigint,
    FOREIGN KEY (NomorHP_Pengguna) REFERENCES tbUsers(NomorHP),
    AdminAccept varchar(50)
);

Create table Catatan (
	idCatatan INT AUTO_INCREMENT PRIMARY KEY,
    catatan varchar(50),
    ceklist boolean default false,
    nomorHP bigint,
    FOREIGN KEY (nomorHP) REFERENCES tbUsers(NomorHP)
);

select * from tbUsers;
select * from Pinjaman;
select * from Catatan;
SELECT idCatatan, catatan FROM Catatan WHERE nomorHP = 8310;

INSERT INTO tbUsers (NomorHP, username, password, KTP, statusPinjaman)
VALUES (6281234567890, 'budi123', 'rahasia123', '3578012345678901', 'tidak ada pinjaman');
