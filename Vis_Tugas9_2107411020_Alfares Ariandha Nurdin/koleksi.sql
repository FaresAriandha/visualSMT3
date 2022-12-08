-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 01, 2022 at 05:00 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `perpustakaan`
--

-- --------------------------------------------------------

--
-- Table structure for table `koleksi`
--

CREATE TABLE `koleksi` (
  `id_koleksi` int(10) NOT NULL,
  `nama_koleksi` varchar(255) NOT NULL,
  `dir_gambar` text NOT NULL,
  `deskripsi` longtext NOT NULL,
  `penerbit` varchar(255) NOT NULL,
  `jenis_koleksi` varchar(255) NOT NULL,
  `tahun_terbit` year(4) NOT NULL,
  `lokasi` varchar(255) NOT NULL,
  `tanggal_masuk_koleksi` date NOT NULL,
  `stock` int(11) NOT NULL,
  `bahasa` varchar(50) NOT NULL,
  `kategori` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `koleksi`
--

INSERT INTO `koleksi` (`id_koleksi`, `nama_koleksi`, `dir_gambar`, `deskripsi`, `penerbit`, `jenis_koleksi`, `tahun_terbit`, `lokasi`, `tanggal_masuk_koleksi`, `stock`, `bahasa`, `kategori`) VALUES
(1, 'Koleksi A', 'C:/Users/hp/Pictures/Saved Pictures/1650940255807.jpg', 'Buku Bagus', 'Erlangga', 'History', 2019, 'A-170', '2022-12-01', 12, 'Bahasa Indonesia', 'Sains | Teknologi | Budaya | '),
(3, 'Koleksi B', 'C:/Users/hp/Pictures/Saved Pictures/1650940255762.jpg', 'Buku Bagus', 'KamuPunya', 'Mathematic', 2020, 'A-190', '2022-12-01', 5, 'Bahasa Indonesia', 'Sains | Sosial | '),
(4, 'Koleksi C', 'C:/Users/hp/Pictures/Saved Pictures/1650940255807.jpg', 'Buku Galang Dana', 'SiPaling', 'Fantasy', 2018, 'sdsd', '2022-12-01', 1, 'Bahasa Inggris', 'Sains | Sosial | Budaya | ');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `koleksi`
--
ALTER TABLE `koleksi`
  ADD PRIMARY KEY (`id_koleksi`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `koleksi`
--
ALTER TABLE `koleksi`
  MODIFY `id_koleksi` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
