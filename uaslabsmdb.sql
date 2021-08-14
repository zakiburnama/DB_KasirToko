-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 03, 2021 at 01:38 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `uaslabsmdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `databarang`
--

CREATE TABLE `databarang` (
  `ID` varchar(5) NOT NULL,
  `NAMA` varchar(30) NOT NULL,
  `HARGA` bigint(20) NOT NULL,
  `STOK` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `databarang`
--

INSERT INTO `databarang` (`ID`, `NAMA`, `HARGA`, `STOK`) VALUES
('1001', 'Pulpen Faber Castell', 1400, 200),
('1002', 'Pulpen Joyko', 1600, 300),
('2001', 'Kenko Penggaris Besi', 1700, 300),
('2002', 'Joyko Penggaris Plastik', 1500, 100),
('3001', 'Lakban Hitam', 5500, 250),
('3002', 'Lakban Putih', 5000, 300);

-- --------------------------------------------------------

--
-- Table structure for table `pengguna`
--

CREATE TABLE `pengguna` (
  `username` varchar(20) NOT NULL,
  `password` varchar(250) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `role` enum('Admin','Kasir','User') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pengguna`
--

INSERT INTO `pengguna` (`username`, `password`, `nama`, `alamat`, `role`) VALUES
('andi_p', '10713417811525552252225157107128782559063877117316423416247297319230822211831359175', 'Andi P.', 'Jakarta', 'User'),
('naafi_m', '891487126187117422521931298924620411618024517185152621889179202245169193115202207197', 'Naafi Mahendra', 'Medan', 'Admin'),
('zaki_h', '284622338167216131885075635106182202234601389918719120321515629222203188199592382', 'M. Zaki Harits Burnama', 'Lubuk Sikaping', 'Kasir');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `databarang`
--
ALTER TABLE `databarang`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `pengguna`
--
ALTER TABLE `pengguna`
  ADD PRIMARY KEY (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
