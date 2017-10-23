-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 23, 2017 at 11:09 AM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pemilu`
--

-- --------------------------------------------------------

--
-- Table structure for table `administrator`
--

CREATE TABLE `administrator` (
  `NoKTP` bigint(20) NOT NULL,
  `NoID` int(11) NOT NULL,
  `Password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `administrator`
--

INSERT INTO `administrator` (`NoKTP`, `NoID`, `Password`) VALUES
(155150200111185, 85, '85'),
(155150200111183, 83, '83');

-- --------------------------------------------------------

--
-- Table structure for table `candidate`
--

CREATE TABLE `candidate` (
  `NoKTP` bigint(20) NOT NULL,
  `NoUrut` int(11) NOT NULL,
  `Jabatan` enum('Ketua','Wakil') NOT NULL,
  `Quote` text NOT NULL,
  `Percentage` int(11) NOT NULL,
  `Persen` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `candidate`
--

INSERT INTO `candidate` (`NoKTP`, `NoUrut`, `Jabatan`, `Quote`, `Percentage`, `Persen`) VALUES
(155150200111179, 1, 'Ketua', 'Selalu Ada', 0, 0),
(155150200111180, 2, 'Wakil', 'Tidak ada', 0, 0),
(155150200111181, 2, 'Ketua', 'Mundur tapi maju', 0, 0),
(155150200111182, 1, 'Wakil', 'Memang terpercaya', 0, 0),
(155150200111186, 8, 'Ketua', '8 hebat', 0, 0),
(155150200111187, 8, 'Wakil', 'qwerty 8 atas', 0, 0),
(155150200111188, 9, 'Ketua', '9 September', 0, 0),
(155150200111189, 9, 'Wakil', '9 Helicopter', 0, 0),
(155150200111190, 3, 'Ketua', '3 terbaik', 0, 0),
(155150200111192, 6, 'Ketua', '6 forwarding table', 0, 0),
(155150200111193, 6, 'Wakil', 'Jeri 6 go go', 0, 0),
(155150200111195, 4, 'Wakil', 'Keli 4 maju', 0, 0),
(155150200111196, 4, 'Ketua', '4 terbaik', 0, 0),
(155150200111197, 5, 'Wakil', 'Few 5 wow', 0, 0),
(155150200111198, 5, 'Ketua', '5 baiklah', 0, 0),
(155150200111199, 7, 'Ketua', '7 is the food', 0, 0),
(155150200111200, 7, 'Wakil', 'Setia 7 nyawa', 0, 0),
(155150200111201, 3, 'Wakil', 'Jli 3 maju', 0, 0),
(155150200111202, 10, 'Wakil', 'Helliiiccooppttaa', 0, 0),
(155150200111203, 10, 'Ketua', 'Gale Ri 10', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `society`
--

CREATE TABLE `society` (
  `NoKTP` bigint(20) NOT NULL,
  `Nama` varchar(64) NOT NULL,
  `Alamat` text NOT NULL,
  `Kependudukan` enum('WNI','WNA') NOT NULL,
  `Voted` enum('false','true') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `society`
--

INSERT INTO `society` (`NoKTP`, `Nama`, `Alamat`, `Kependudukan`, `Voted`) VALUES
(155150200111179, 'Agus Adyandana', 'Jl. AA', 'WNI', 'false'),
(155150200111180, 'Sisco Jupiyandi', 'Jl. AM', 'WNA', 'false'),
(155150200111181, 'Hanif Irfan S', 'Jl. MJ', 'WNI', 'false'),
(155150200111182, 'Boy Simanjuntak', 'Jl. BR', 'WNA', 'false'),
(155150200111183, 'Darmadani Kyat', 'Jl. RT', 'WNI', 'false'),
(155150200111184, 'Wahyu PAP', 'Jl. GH', 'WNA', 'false'),
(155150200111185, 'Non Relate', 'Jl. NR', 'WNA', 'false'),
(155150200111186, 'Tim Watiro', 'Jl. TWR', 'WNI', 'false'),
(155150200111187, 'Qwety Unique', 'Jl. QU', 'WNA', 'false'),
(155150200111188, 'Terra Fault', 'Jl. TF', 'WNA', 'false'),
(155150200111189, 'Heli Peter', 'Jl. HP', 'WNA', 'false'),
(155150200111190, 'Yeri Wati', 'Jl. YW', 'WNI', 'false'),
(155150200111191, 'Ber Teni', 'Jl. BT', 'WNI', 'false'),
(155150200111192, 'Nona Nano', 'Jl. NN', 'WNA', 'false'),
(155150200111193, 'Jeri Man', 'Jl. JM', 'WNI', 'false'),
(155150200111194, 'Kelo Pora', 'Jl. KP', 'WNI', 'false'),
(155150200111195, 'Keli Meta', 'Jl. KM', 'WNI', 'false'),
(155150200111196, 'Eri Mew', 'Jl. EM', 'WNI', 'false'),
(155150200111197, 'Few Nom', 'Jl. FN', 'WNA', 'false'),
(155150200111198, 'Pono Pori', 'Jl. PP', 'WNI', 'false'),
(155150200111199, 'Lolo Lili', 'Jl. LL', 'WNA', 'false'),
(155150200111200, 'Setia Pem', 'Jl. SP', 'WNI', 'false'),
(155150200111201, 'Jla Jli', 'Jl. JJ', 'WNA', 'false'),
(155150200111202, 'Heli Copta', 'Jl. HC', 'WNA', 'false'),
(155150200111203, 'Ger Ri', 'Jl. GL', 'WNI', 'false');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `administrator`
--
ALTER TABLE `administrator`
  ADD KEY `NoKTP` (`NoKTP`);

--
-- Indexes for table `candidate`
--
ALTER TABLE `candidate`
  ADD PRIMARY KEY (`NoKTP`);

--
-- Indexes for table `society`
--
ALTER TABLE `society`
  ADD PRIMARY KEY (`NoKTP`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `administrator`
--
ALTER TABLE `administrator`
  ADD CONSTRAINT `administrator_ibfk_1` FOREIGN KEY (`NoKTP`) REFERENCES `society` (`NoKTP`);

--
-- Constraints for table `candidate`
--
ALTER TABLE `candidate`
  ADD CONSTRAINT `candidate_ibfk_1` FOREIGN KEY (`NoKTP`) REFERENCES `society` (`NoKTP`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
