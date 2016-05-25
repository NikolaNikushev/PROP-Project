-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 25, 2016 at 03:39 PM
-- Server version: 10.1.9-MariaDB
-- PHP Version: 5.6.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `propdbtest`
--

-- --------------------------------------------------------

--
-- Table structure for table `tentleaders`
--

CREATE TABLE `tentleaders` (
  `CAMPING_ID` int(11) NOT NULL,
  `USER_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tentleaders`
--

INSERT INTO `tentleaders` (`CAMPING_ID`, `USER_ID`) VALUES
(11114, 1127);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tentleaders`
--
ALTER TABLE `tentleaders`
  ADD PRIMARY KEY (`CAMPING_ID`,`USER_ID`),
  ADD KEY `USER_ID` (`USER_ID`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tentleaders`
--
ALTER TABLE `tentleaders`
  ADD CONSTRAINT `tentleaders_ibfk_1` FOREIGN KEY (`USER_ID`) REFERENCES `visitors` (`USER_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tentleaders_ibfk_2` FOREIGN KEY (`CAMPING_ID`) REFERENCES `camps` (`CAMPING_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
