-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 03, 2026 at 11:22 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_prakerin`
--

-- --------------------------------------------------------

--
-- Table structure for table `absensi`
--

CREATE TABLE `absensi` (
  `id_absensi` int(11) NOT NULL,
  `id_prakerin` int(11) NOT NULL,
  `tanggal` date DEFAULT NULL,
  `jam_masuk` time DEFAULT NULL,
  `jam_keluar` time DEFAULT NULL,
  `status` enum('hadir','izin','sakit','alpha') DEFAULT 'hadir'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `dokumentasi`
--

CREATE TABLE `dokumentasi` (
  `id_dokumentasi` int(11) NOT NULL,
  `id_prakerin` int(11) NOT NULL,
  `judul` varchar(150) DEFAULT NULL,
  `foto` varchar(255) DEFAULT NULL,
  `tanggal` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `guru`
--

CREATE TABLE `guru` (
  `id_guru` int(11) NOT NULL,
  `id_pengguna` int(11) NOT NULL,
  `nip` varchar(50) DEFAULT NULL,
  `nama` varchar(150) NOT NULL,
  `no_hp` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `guru`
--

INSERT INTO `guru` (`id_guru`, `id_pengguna`, `nip`, `nama`, `no_hp`, `email`) VALUES
(5, 29, '123456', 'Akmal Raditya', '096456789', 'amay@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `jurnal_harian`
--

CREATE TABLE `jurnal_harian` (
  `id_jurnal` int(11) NOT NULL,
  `id_prakerin` int(11) NOT NULL,
  `tanggal` date DEFAULT NULL,
  `kegiatan` text DEFAULT NULL,
  `kendala` text DEFAULT NULL,
  `solusi` text DEFAULT NULL,
  `status_verifikasi` enum('menunggu','diterima','ditolak') DEFAULT 'menunggu'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `jurusan`
--

CREATE TABLE `jurusan` (
  `id_jurusan` int(11) NOT NULL,
  `kode_jurusan` varchar(10) NOT NULL,
  `nama_jurusan` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `jurusan`
--

INSERT INTO `jurusan` (`id_jurusan`, `kode_jurusan`, `nama_jurusan`) VALUES
(3, 'RPL-001', 'Rekayasa Perangkat Lunak');

-- --------------------------------------------------------

--
-- Table structure for table `kelas`
--

CREATE TABLE `kelas` (
  `id_kelas` int(11) NOT NULL,
  `nama_kelas` varchar(50) NOT NULL,
  `tingkat` int(11) NOT NULL,
  `id_jurusan` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `kelas`
--

INSERT INTO `kelas` (`id_kelas`, `nama_kelas`, `tingkat`, `id_jurusan`) VALUES
(3, '12 RPL A', 12, 3);

-- --------------------------------------------------------

--
-- Table structure for table `monitoring`
--

CREATE TABLE `monitoring` (
  `id_monitoring` int(11) NOT NULL,
  `id_prakerin` int(11) NOT NULL,
  `id_guru` int(11) NOT NULL,
  `tanggal` date DEFAULT NULL,
  `catatan` text DEFAULT NULL,
  `foto` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `pembimbing`
--

CREATE TABLE `pembimbing` (
  `id_pembimbing` int(11) NOT NULL,
  `id_pengguna` int(11) NOT NULL,
  `id_perusahaan` int(11) NOT NULL,
  `nama` varchar(150) DEFAULT NULL,
  `jabatan` varchar(100) DEFAULT NULL,
  `no_hp` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pembimbing`
--

INSERT INTO `pembimbing` (`id_pembimbing`, `id_pengguna`, `id_perusahaan`, `nama`, `jabatan`, `no_hp`, `email`) VALUES
(7, 28, 3, 'Aditya Akmal', 'Manajer', '00987654', 'aditya@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `pengguna`
--

CREATE TABLE `pengguna` (
  `id_pengguna` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` varchar(150) NOT NULL,
  `status` enum('Aktif','Nonaktif') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pengguna`
--

INSERT INTO `pengguna` (`id_pengguna`, `username`, `password`, `role`, `status`) VALUES
(26, 'nazran', '202cb962ac59075b964b07152d234b70', 'Super Admin', 'Aktif'),
(27, 'adelia', '202cb962ac59075b964b07152d234b70', 'Siswa', 'Aktif'),
(28, 'aditya', '202cb962ac59075b964b07152d234b70', 'Pembimbing', 'Aktif'),
(29, 'amay', '202cb962ac59075b964b07152d234b70', 'Guru', 'Aktif'),
(30, 'admin01', '202cb962ac59075b964b07152d234b70', 'Super Admin', 'Aktif');

-- --------------------------------------------------------

--
-- Table structure for table `penilaian`
--

CREATE TABLE `penilaian` (
  `id_penilaian` int(11) NOT NULL,
  `id_prakerin` int(11) NOT NULL,
  `disiplin` int(11) DEFAULT NULL,
  `kerjasama` int(11) DEFAULT NULL,
  `tanggung_jawab` int(11) DEFAULT NULL,
  `inisiatif` int(11) DEFAULT NULL,
  `keahlian` int(11) DEFAULT NULL,
  `nilai_akhir` decimal(5,2) DEFAULT NULL,
  `catatan` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `perusahaan`
--

CREATE TABLE `perusahaan` (
  `id_perusahaan` int(11) NOT NULL,
  `nama` varchar(150) NOT NULL,
  `alamat` text DEFAULT NULL,
  `no_telp` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `bidang_usaha` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `perusahaan`
--

INSERT INTO `perusahaan` (`id_perusahaan`, `nama`, `alamat`, `no_telp`, `email`, `bidang_usaha`) VALUES
(3, 'PT Antariksa', 'Jl Haji Usep', '098765432', 'antariksa@gmail.com', 'Tekstil');

-- --------------------------------------------------------

--
-- Table structure for table `prakerin`
--

CREATE TABLE `prakerin` (
  `id_prakerin` int(11) NOT NULL,
  `id_siswa` int(11) NOT NULL,
  `id_guru` int(11) NOT NULL,
  `id_perusahaan` int(11) NOT NULL,
  `id_pembimbing` int(11) NOT NULL,
  `tanggal_mulai` date DEFAULT NULL,
  `tanggal_selesai` date DEFAULT NULL,
  `status` enum('menunggu','berlangsung','selesai') DEFAULT 'menunggu'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `prakerin`
--

INSERT INTO `prakerin` (`id_prakerin`, `id_siswa`, `id_guru`, `id_perusahaan`, `id_pembimbing`, `tanggal_mulai`, `tanggal_selesai`, `status`) VALUES
(4, 6, 5, 3, 7, '2026-08-29', '2026-09-04', 'menunggu');

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `id_role` int(11) NOT NULL,
  `nama_role` varchar(50) NOT NULL,
  `keterangan` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`id_role`, `nama_role`, `keterangan`) VALUES
(1, 'Super Admin', 'admin ini'),
(10, 'Siswa', ''),
(11, 'Guru', ''),
(12, 'Pembimbing', '');

-- --------------------------------------------------------

--
-- Table structure for table `siswa`
--

CREATE TABLE `siswa` (
  `id_siswa` int(11) NOT NULL,
  `id_pengguna` int(11) NOT NULL,
  `foto` text DEFAULT NULL,
  `nis` varchar(50) DEFAULT NULL,
  `nama` varchar(150) NOT NULL,
  `kelas` varchar(50) DEFAULT NULL,
  `jurusan` varchar(100) DEFAULT NULL,
  `jenis_kelamin` enum('L','P') DEFAULT NULL,
  `alamat` text DEFAULT NULL,
  `no_hp` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `siswa`
--

INSERT INTO `siswa` (`id_siswa`, `id_pengguna`, `foto`, `nis`, `nama`, `kelas`, `jurusan`, `jenis_kelamin`, `alamat`, `no_hp`) VALUES
(6, 27, '22638905_1948370858717070_8390453517382320128_n.jpg', '3456782345', 'Adelia Putri Ramadhi', '12 RPL A', 'Rekayasa Perangkat Lunak', 'P', 'Jl Bandung', '098765345');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `absensi`
--
ALTER TABLE `absensi`
  ADD PRIMARY KEY (`id_absensi`),
  ADD KEY `id_prakerin` (`id_prakerin`);

--
-- Indexes for table `dokumentasi`
--
ALTER TABLE `dokumentasi`
  ADD PRIMARY KEY (`id_dokumentasi`),
  ADD KEY `id_prakerin` (`id_prakerin`);

--
-- Indexes for table `guru`
--
ALTER TABLE `guru`
  ADD PRIMARY KEY (`id_guru`),
  ADD UNIQUE KEY `nip` (`nip`),
  ADD KEY `guru_ibfk_1` (`id_pengguna`);

--
-- Indexes for table `jurnal_harian`
--
ALTER TABLE `jurnal_harian`
  ADD PRIMARY KEY (`id_jurnal`),
  ADD KEY `id_prakerin` (`id_prakerin`);

--
-- Indexes for table `jurusan`
--
ALTER TABLE `jurusan`
  ADD PRIMARY KEY (`id_jurusan`),
  ADD UNIQUE KEY `kode_jurusan` (`kode_jurusan`);

--
-- Indexes for table `kelas`
--
ALTER TABLE `kelas`
  ADD PRIMARY KEY (`id_kelas`),
  ADD KEY `fk_kelas_jurusan` (`id_jurusan`);

--
-- Indexes for table `monitoring`
--
ALTER TABLE `monitoring`
  ADD PRIMARY KEY (`id_monitoring`),
  ADD KEY `id_prakerin` (`id_prakerin`),
  ADD KEY `id_guru` (`id_guru`);

--
-- Indexes for table `pembimbing`
--
ALTER TABLE `pembimbing`
  ADD PRIMARY KEY (`id_pembimbing`),
  ADD KEY `id_pengguna` (`id_pengguna`),
  ADD KEY `id_perusahaan` (`id_perusahaan`);

--
-- Indexes for table `pengguna`
--
ALTER TABLE `pengguna`
  ADD PRIMARY KEY (`id_pengguna`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `penilaian`
--
ALTER TABLE `penilaian`
  ADD PRIMARY KEY (`id_penilaian`),
  ADD KEY `id_prakerin` (`id_prakerin`);

--
-- Indexes for table `perusahaan`
--
ALTER TABLE `perusahaan`
  ADD PRIMARY KEY (`id_perusahaan`);

--
-- Indexes for table `prakerin`
--
ALTER TABLE `prakerin`
  ADD PRIMARY KEY (`id_prakerin`),
  ADD KEY `id_siswa` (`id_siswa`),
  ADD KEY `id_guru` (`id_guru`),
  ADD KEY `id_perusahaan` (`id_perusahaan`),
  ADD KEY `id_pembimbing` (`id_pembimbing`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`id_role`),
  ADD UNIQUE KEY `nama_role` (`nama_role`);

--
-- Indexes for table `siswa`
--
ALTER TABLE `siswa`
  ADD PRIMARY KEY (`id_siswa`),
  ADD UNIQUE KEY `nis` (`nis`),
  ADD KEY `id_pengguna` (`id_pengguna`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `absensi`
--
ALTER TABLE `absensi`
  MODIFY `id_absensi` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `dokumentasi`
--
ALTER TABLE `dokumentasi`
  MODIFY `id_dokumentasi` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `guru`
--
ALTER TABLE `guru`
  MODIFY `id_guru` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `jurnal_harian`
--
ALTER TABLE `jurnal_harian`
  MODIFY `id_jurnal` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `jurusan`
--
ALTER TABLE `jurusan`
  MODIFY `id_jurusan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `kelas`
--
ALTER TABLE `kelas`
  MODIFY `id_kelas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `monitoring`
--
ALTER TABLE `monitoring`
  MODIFY `id_monitoring` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pembimbing`
--
ALTER TABLE `pembimbing`
  MODIFY `id_pembimbing` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `pengguna`
--
ALTER TABLE `pengguna`
  MODIFY `id_pengguna` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `penilaian`
--
ALTER TABLE `penilaian`
  MODIFY `id_penilaian` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `perusahaan`
--
ALTER TABLE `perusahaan`
  MODIFY `id_perusahaan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `prakerin`
--
ALTER TABLE `prakerin`
  MODIFY `id_prakerin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `role`
--
ALTER TABLE `role`
  MODIFY `id_role` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `siswa`
--
ALTER TABLE `siswa`
  MODIFY `id_siswa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `absensi`
--
ALTER TABLE `absensi`
  ADD CONSTRAINT `absensi_ibfk_1` FOREIGN KEY (`id_prakerin`) REFERENCES `prakerin` (`id_prakerin`) ON DELETE CASCADE;

--
-- Constraints for table `dokumentasi`
--
ALTER TABLE `dokumentasi`
  ADD CONSTRAINT `dokumentasi_ibfk_1` FOREIGN KEY (`id_prakerin`) REFERENCES `prakerin` (`id_prakerin`) ON DELETE CASCADE;

--
-- Constraints for table `guru`
--
ALTER TABLE `guru`
  ADD CONSTRAINT `guru_ibfk_1` FOREIGN KEY (`id_pengguna`) REFERENCES `pengguna` (`id_pengguna`);

--
-- Constraints for table `jurnal_harian`
--
ALTER TABLE `jurnal_harian`
  ADD CONSTRAINT `jurnal_harian_ibfk_1` FOREIGN KEY (`id_prakerin`) REFERENCES `prakerin` (`id_prakerin`) ON DELETE CASCADE;

--
-- Constraints for table `kelas`
--
ALTER TABLE `kelas`
  ADD CONSTRAINT `fk_kelas_jurusan` FOREIGN KEY (`id_jurusan`) REFERENCES `jurusan` (`id_jurusan`) ON UPDATE CASCADE;

--
-- Constraints for table `monitoring`
--
ALTER TABLE `monitoring`
  ADD CONSTRAINT `monitoring_ibfk_1` FOREIGN KEY (`id_prakerin`) REFERENCES `prakerin` (`id_prakerin`) ON DELETE CASCADE,
  ADD CONSTRAINT `monitoring_ibfk_2` FOREIGN KEY (`id_guru`) REFERENCES `guru` (`id_guru`) ON DELETE CASCADE;

--
-- Constraints for table `pembimbing`
--
ALTER TABLE `pembimbing`
  ADD CONSTRAINT `pembimbing_ibfk_1` FOREIGN KEY (`id_pengguna`) REFERENCES `pengguna` (`id_pengguna`) ON DELETE CASCADE,
  ADD CONSTRAINT `pembimbing_ibfk_2` FOREIGN KEY (`id_perusahaan`) REFERENCES `perusahaan` (`id_perusahaan`) ON DELETE CASCADE;

--
-- Constraints for table `penilaian`
--
ALTER TABLE `penilaian`
  ADD CONSTRAINT `penilaian_ibfk_1` FOREIGN KEY (`id_prakerin`) REFERENCES `prakerin` (`id_prakerin`) ON DELETE CASCADE;

--
-- Constraints for table `prakerin`
--
ALTER TABLE `prakerin`
  ADD CONSTRAINT `prakerin_ibfk_1` FOREIGN KEY (`id_siswa`) REFERENCES `siswa` (`id_siswa`),
  ADD CONSTRAINT `prakerin_ibfk_2` FOREIGN KEY (`id_guru`) REFERENCES `guru` (`id_guru`),
  ADD CONSTRAINT `prakerin_ibfk_3` FOREIGN KEY (`id_perusahaan`) REFERENCES `perusahaan` (`id_perusahaan`),
  ADD CONSTRAINT `prakerin_ibfk_4` FOREIGN KEY (`id_pembimbing`) REFERENCES `pembimbing` (`id_pembimbing`);

--
-- Constraints for table `siswa`
--
ALTER TABLE `siswa`
  ADD CONSTRAINT `siswa_ibfk_1` FOREIGN KEY (`id_pengguna`) REFERENCES `pengguna` (`id_pengguna`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
