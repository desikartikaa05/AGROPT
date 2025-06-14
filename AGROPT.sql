CREATE TABLE akun (
    id SERIAL PRIMARY KEY,
    nama TEXT NOT NULL,
    username TEXT NOT NULL,
    password TEXT NOT NULL,
    role TEXT NOT NULL
);

CREATE TABLE lahan (
    id SERIAL PRIMARY KEY,
    id_lahan VARCHAR(20),
    nama_lahan VARCHAR(100),
    lokasi TEXT,
    deskripsi TEXT,
    status BOOLEAN,
    tanggal_upload DATE,
    no_hp VARCHAR(20),
    id_akun INTEGER
);

ALTER TABLE lahan
ADD CONSTRAINT fk_akun_lahan 
    FOREIGN KEY (id_akun) REFERENCES akun(id);

ALTER TABLE lahan
ADD CONSTRAINT unique_id_lahan UNIQUE (id_lahan);


CREATE TABLE perkembangan_lahan (
    id SERIAL PRIMARY KEY,
    id_lahan VARCHAR(20),
    nama_lahan TEXT,
    keterangan TEXT,
    progress_panen TEXT,
    id_akun INTEGER
);

ALTER TABLE perkembangan_lahan
    ADD CONSTRAINT fk_lahan_perkembangan FOREIGN KEY (id_lahan) REFERENCES lahan(id_lahan),
    ADD CONSTRAINT fk_akun_perkembangan FOREIGN KEY (id_akun) REFERENCES akun(id);

CREATE TABLE pembayaran (
    id SERIAL PRIMARY KEY,
    id_lahan TEXT,
    nama_lahan TEXT,
    lokasi TEXT,
    kode_pembayaran TEXT,
    nama_pembeli TEXT,
    alamat_pembeli TEXT,
    status BOOLEAN,
    id_akun INTEGER
);


ALTER TABLE pembayaran
ADD CONSTRAINT fk_id_lahan 
    FOREIGN KEY (id_lahan) REFERENCES lahan(id_lahan);
	
ALTER TABLE pembayaran
ADD CONSTRAINT fk_id_akun 
    FOREIGN KEY (id_akun) REFERENCES akun(id);

select * from akun
select * from lahan
select * from perkembangan_lahan
select * from pembayaran 


INSERT INTO akun (id, nama, username, password, role) VALUES
(11, 'Vivian', 'Vian', '12345', 'Petani'),
(12, 'Ririn', 'Riri', '1234', 'Customer'),
(13, 'Admint', 'Admin', '123', 'Admin'),
(14, 'Rian', 'Ruru', '12345', 'Customer');

INSERT INTO lahan (id, id_lahan, nama_lahan, lokasi, deskripsi, status, tanggal_upload, no_hp, id_akun) VALUES
(23, 'L004', 'Lahan Sawi', 'Kaliwates', 'tinggal panen', true, '2025-06-13', NULL, NULL),
(24, 'L005', 'Lahan Timun', 'Kalisat', 'dekat sungai', true, '2025-06-13', '081245678098', NULL),
(25, 'L006', 'Kopi', 'Probolinggo', 'Mendekati panen', true, '2025-06-13', '0881266121634611', NULL),
(19, 'L001', 'Lahan Jagung', 'Jember', 'Jagung manis', false, '2025-06-13', '0987654567', NULL),
(26, 'L008', 'Lahan Cabai', 'Jember', 'Tanah subur', true, '2025-06-13', '09876543432', NULL),
(20, 'L002', 'Lahan Kelapa', 'Jember', 'Kelapa muda', true, '2025-06-13', '12456587', NULL);


INSERT INTO perkembangan_lahan (id, id_lahan, nama_lahan, keterangan, progress_panen, id_akun) VALUES
(1, 'L001', 'Lahan Jagung', 'sudah disiram', '30%', NULL),
(2, 'L002', 'Lahan Kelapa', 'mulai keliatan tua buahnya', '80%', NULL),
(3, 'L001', 'Lahan Jagung', NULL, NULL, NULL),
(4, 'L002', 'Lahan Kelapa', 'proses panen', '90%', NULL),
(5, 'L002', 'Lahan Kelapa', 'proses panen', '90%', NULL),
(6, 'L002', 'Lahan Kelapa', 'Sedang Pemupukan', '60%', NULL);

INSERT INTO pembayaran (id, id_lahan, nama_lahan, lokasi, kode_pembayaran, nama_pembeli, alamat_pembeli, status, id_akun) VALUES
(2, 'L004', 'Lahan Sawi', 'Kaliwates', '0C0754FF', 'Riri', 'Jember', true, NULL),
(5, 'L001', 'Lahan Jagung', 'Jember', 'D4BC163F', 'Rii', 'Sumbersari', true, NULL),
(6, 'L001', 'Lahan Jagung', 'Jember', '1184236B', 'rii', 'jember', true, NULL),
(7, 'L001', 'Lahan Jagung', 'Jember', '9D671BFD', 'rii', 'sumbersari', true, NULL),
(8, 'L002', 'Lahan Kelapa', 'Jember', '7B4DECCA', 'Ria', 'Sumbersari', true, NULL),
(9, 'L002', 'Lahan Kelapa', 'Jember', 'E22B1BD9', 'Rian', 'Sumbersari', true, NULL);


