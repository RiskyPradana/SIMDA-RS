-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 20, 2016 at 10:57 AM
-- Server version: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `simda_rs`
--

-- --------------------------------------------------------

--
-- Table structure for table `data_login`
--

CREATE TABLE IF NOT EXISTS `data_login` (
  `username` varchar(40) DEFAULT NULL,
  `password` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `data_login`
--

INSERT INTO `data_login` (`username`, `password`) VALUES
('admin', '21232f297a57a5a743894a0e4a801fc3');

-- --------------------------------------------------------

--
-- Table structure for table `master_golongan`
--

CREATE TABLE IF NOT EXISTS `master_golongan` (
  `golongan` varchar(40) NOT NULL,
  `jenjang` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `master_golongan`
--

INSERT INTO `master_golongan` (`golongan`, `jenjang`) VALUES
('II / C', 'Pengatur '),
('III/ D', 'PENATA TK I'),
('III/B', 'Penata Muda Tkt.I'),
('IV/B', 'Pembina Tkt. I');

-- --------------------------------------------------------

--
-- Table structure for table `master_jabatan`
--

CREATE TABLE IF NOT EXISTS `master_jabatan` (
  `id_jabatan` varchar(25) NOT NULL,
  `jabatan` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `master_jabatan`
--

INSERT INTO `master_jabatan` (`id_jabatan`, `jabatan`) VALUES
('1', 'DIREKTUR'),
('10', 'KASIE PENGEMBANGAN MUTU KEPERAWATAN DAN '),
('11', 'KASIE KEPERAWATAN'),
('2', 'KABID PELAYANAN DAN PENUNJANG MEDIS'),
('3', 'KEPALA TATA USAHA'),
('4', 'KABID KEPERAWATAN'),
('5', 'KASIE PENUNJANG MEDIS'),
('6', 'KASIE PELAYANAN MEDIS'),
('7', 'KASUBAG INFORMASI PERENCANAAN DAN REKAM '),
('8', 'KASUBAG UMUM KEPEGAWAIAN DAN PERLENGKAPA'),
('9', 'KASUBAG KEUANGAN');

-- --------------------------------------------------------

--
-- Table structure for table `master_pegawai`
--

CREATE TABLE IF NOT EXISTS `master_pegawai` (
  `nip` int(30) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `tempat_lahir` varchar(50) DEFAULT NULL,
  `tgl_lahir` date DEFAULT NULL,
  `jenis_kelamin` varchar(10) DEFAULT NULL,
  `agama` varchar(30) DEFAULT NULL,
  `status_nikah` varchar(30) DEFAULT NULL,
  `pendidikan` varchar(35) DEFAULT NULL,
  `status_pegawai` varchar(30) DEFAULT NULL,
  `no_tlp` int(13) DEFAULT NULL,
  `alamat` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `master_pegawai`
--

INSERT INTO `master_pegawai` (`nip`, `nama`, `tempat_lahir`, `tgl_lahir`, `jenis_kelamin`, `agama`, `status_nikah`, `pendidikan`, `status_pegawai`, `no_tlp`, `alamat`) VALUES
(2147483647, 'dr. Tito E.M Bastiaan, M.Kes (MMR)', ' ', '2016-05-14', 'Laki-laki', 'Islam', 'Kawin', '  ', 'PNS', 2147483647, ' ');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi_mutasi_jabatan`
--

CREATE TABLE IF NOT EXISTS `transaksi_mutasi_jabatan` (
  `id_mutasi` varchar(25) NOT NULL,
  `nip` int(30) DEFAULT NULL,
  `tgl_mutasi` date DEFAULT NULL,
  `id_jabatan` varchar(25) DEFAULT NULL,
  `no_sk` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `transaksi_mutasi_pegawai`
--

CREATE TABLE IF NOT EXISTS `transaksi_mutasi_pegawai` (
  `id_mutasi` varchar(25) NOT NULL,
  `nip` int(30) DEFAULT NULL,
  `tgl_mutasi` date DEFAULT NULL,
  `instansi_baru` varchar(60) DEFAULT NULL,
  `no_sk` varchar(45) DEFAULT NULL,
  `ket` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `transaksi_pangkat`
--

CREATE TABLE IF NOT EXISTS `transaksi_pangkat` (
  `id_pangkat` varchar(25) NOT NULL,
  `nip` int(30) DEFAULT NULL,
  `golongan` varchar(40) DEFAULT NULL,
  `jabatan` varchar(40) DEFAULT NULL,
  `no_sk` varchar(45) DEFAULT NULL,
  `tgl_angkat` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `transaksi_pensiun`
--

CREATE TABLE IF NOT EXISTS `transaksi_pensiun` (
  `id_pensiun` varchar(25) NOT NULL,
  `nip` int(30) DEFAULT NULL,
  `tgl_pensiun` date DEFAULT NULL,
  `no_sk` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `master_golongan`
--
ALTER TABLE `master_golongan`
 ADD PRIMARY KEY (`golongan`);

--
-- Indexes for table `master_jabatan`
--
ALTER TABLE `master_jabatan`
 ADD PRIMARY KEY (`id_jabatan`);

--
-- Indexes for table `master_pegawai`
--
ALTER TABLE `master_pegawai`
 ADD PRIMARY KEY (`nip`);

--
-- Indexes for table `transaksi_mutasi_jabatan`
--
ALTER TABLE `transaksi_mutasi_jabatan`
 ADD PRIMARY KEY (`id_mutasi`), ADD KEY `nip2` (`nip`), ADD KEY `golongan2` (`id_jabatan`);

--
-- Indexes for table `transaksi_mutasi_pegawai`
--
ALTER TABLE `transaksi_mutasi_pegawai`
 ADD PRIMARY KEY (`id_mutasi`), ADD KEY `nip3` (`nip`);

--
-- Indexes for table `transaksi_pangkat`
--
ALTER TABLE `transaksi_pangkat`
 ADD PRIMARY KEY (`id_pangkat`), ADD KEY `nip` (`nip`), ADD KEY `jabatan` (`jabatan`), ADD KEY `golongan` (`golongan`);

--
-- Indexes for table `transaksi_pensiun`
--
ALTER TABLE `transaksi_pensiun`
 ADD PRIMARY KEY (`id_pensiun`), ADD KEY `nip4` (`nip`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `transaksi_mutasi_jabatan`
--
ALTER TABLE `transaksi_mutasi_jabatan`
ADD CONSTRAINT `golongan2` FOREIGN KEY (`id_jabatan`) REFERENCES `master_jabatan` (`id_jabatan`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `nip2` FOREIGN KEY (`nip`) REFERENCES `master_pegawai` (`nip`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `transaksi_mutasi_pegawai`
--
ALTER TABLE `transaksi_mutasi_pegawai`
ADD CONSTRAINT `nip3` FOREIGN KEY (`nip`) REFERENCES `master_pegawai` (`nip`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `transaksi_pangkat`
--
ALTER TABLE `transaksi_pangkat`
ADD CONSTRAINT `golongan` FOREIGN KEY (`golongan`) REFERENCES `master_golongan` (`golongan`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `jabatan` FOREIGN KEY (`jabatan`) REFERENCES `master_jabatan` (`id_jabatan`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `nip` FOREIGN KEY (`nip`) REFERENCES `master_pegawai` (`nip`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `transaksi_pensiun`
--
ALTER TABLE `transaksi_pensiun`
ADD CONSTRAINT `nip4` FOREIGN KEY (`nip`) REFERENCES `master_pegawai` (`nip`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
