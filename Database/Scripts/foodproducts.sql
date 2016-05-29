-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 
-- Версия на сървъра: 10.1.10-MariaDB
-- PHP Version: 5.6.19

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
-- Структура на таблица `foodproducts`
--

CREATE TABLE `foodproducts` (
  `PRODUCT_ID` int(11) NOT NULL,
  `NAME` varchar(20) NOT NULL,
  `PRICE` double NOT NULL,
  `QUANTITY` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Схема на данните от таблица `foodproducts`
--

INSERT INTO `foodproducts` (`PRODUCT_ID`, `NAME`, `PRICE`, `QUANTITY`) VALUES
(1, 'CocaCola', 2.5, 200000000),
(2, 'Fanta', 2.5, 50),
(3, 'Sprite', 2.5, 40),
(4, 'HotDog', 3, 40),
(5, 'Pizza', 3.5, 40),
(6, 'Burger', 4, 40),
(7, 'Fries', 3, 40),
(8, 'Beer', 3, 40),
(9, 'SexyLady', 2.5, 40);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `foodproducts`
--
ALTER TABLE `foodproducts`
  ADD PRIMARY KEY (`PRODUCT_ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
