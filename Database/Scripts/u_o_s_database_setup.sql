-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Sep 17, 2017 at 06:28 PM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 5.6.23

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
-- Table structure for table `activities`
--

CREATE TABLE `activities` (
  `ACTIVITY_ID` int(11) NOT NULL,
  `ACTIVITYNAME` varchar(120) NOT NULL,
  `DESCRIPTION` varchar(400) NOT NULL,
  `DATE` datetime NOT NULL,
  `TOTALPLACES` int(11) NOT NULL,
  `OPENPLACES` int(11) NOT NULL,
  `OPENPLACESTAKEN` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `activities`
--

INSERT INTO `activities` (`ACTIVITY_ID`, `ACTIVITYNAME`, `DESCRIPTION`, `DATE`, `TOTALPLACES`, `OPENPLACES`, `OPENPLACESTAKEN`) VALUES
(1, 'YOGA WITH SHANTAM KAUR', 'JOIN THE MORNING CLASSES AND MAKE YOUR BODY AND SOUL A PRESENT', '2016-05-20 09:30:30', 40, 0, 0),
(3, 'GUITAR LESSONS WITH DIMITAR MARKOV', 'LEARN TO PLAY THE BEST INSTRUMENT IN THE WORLD WITH THE BEST TEACHER IN THE WORLD. NO GIRL WILL BE ABLE TO STAND AGAINST YOUR LOVESONGS', '2016-05-20 14:00:00', 500, 0, 0),
(4, 'Play PIANO WITH KARL KARLOV', 'KARL KARLOV WILL KARL YOU TO KARL', '2016-05-21 15:10:21', 300, 0, 0),
(5, 'PERKS OF YODDELING WITH WITH WITHERSPOON', 'YODL', '2016-05-21 09:00:00', 150, 0, 0),
(6, 'THE WAY OF JAZZ', 'LEARN ALL YOU CAN ', '2016-05-22 16:00:00', 312, 0, 0),
(7, 'PUSH IT TO THE LIMIT', 'Walk along the razor''s edge\r\nBut don''t look down, just keep your head\r\nOr you''ll be finished\r\n\r\nOpen up the limit\r\nPast the point of no return\r\nYou''ve reached the top but still you gotta learn\r\nHow to keep it', '2016-05-20 06:24:15', 9001, 0, 0);

-- --------------------------------------------------------

--
-- Stand-in structure for view `activityplaces_view`
--
CREATE TABLE `activityplaces_view` (
`ACTIVITY_ID` int(11)
,`TOTALPLACES` int(11)
,`TORESPLCS` bigint(13)
,`RESERVEDPLACES` bigint(21)
);

-- --------------------------------------------------------

--
-- Table structure for table `activityreservations`
--

CREATE TABLE `activityreservations` (
  `ACTIVITY_ID` int(11) NOT NULL,
  `USER_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `camps`
--

CREATE TABLE `camps` (
  `CAMPING_ID` int(11) NOT NULL,
  `TENTNR` int(11) NOT NULL,
  `AVAILABLE` tinyint(1) NOT NULL DEFAULT '1',
  `TYPE` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `camps`
--

INSERT INTO `camps` (`CAMPING_ID`, `TENTNR`, `AVAILABLE`, `TYPE`) VALUES
(10001, 33, 0, 'TIPI'),
(11112, 34, 0, 'CARDBOARD BOX'),
(11113, 12, 0, 'CHAIR CASTLE'),
(11114, 13, 0, 'TREE HOUSE'),
(11115, 332, 0, 'Pineapple'),
(11116, 76, 0, 'House'),
(11117, 2, 0, 'Yard'),
(11118, 12, 0, 'Farm'),
(11119, 22, 0, 'Garbage'),
(11120, 22, 0, 'Toilet'),
(11121, 2, 0, 'Chalk Shaft'),
(11122, 4444, 0, 'blanket'),
(11123, 223, 0, 'Molden blanket'),
(11124, 1, 1, 'Shop');

-- --------------------------------------------------------

--
-- Table structure for table `foodproducts`
--

CREATE TABLE `foodproducts` (
  `PRODUCT_ID` int(11) NOT NULL,
  `NAME` varchar(15) NOT NULL,
  `PRICE` double NOT NULL,
  `STOCK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `foodproducts`
--

INSERT INTO `foodproducts` (`PRODUCT_ID`, `NAME`, `PRICE`, `STOCK`) VALUES
(1, 'Carrot Soup', 13.3, 155),
(2, 'Lamb Burger', 13.2, 123),
(3, 'Ulmodwich', 3.5, 30),
(4, 'Slurp', 2.2, 44),
(5, 'Yellow Cheese', 3.3, 12),
(6, 'Licorice ', 44.3, 20);

-- --------------------------------------------------------

--
-- Table structure for table `loanitems`
--

CREATE TABLE `loanitems` (
  `ARTICLE_ID` int(11) NOT NULL,
  `PRICEDAY` int(11) DEFAULT '0',
  `NAME` varchar(10) NOT NULL,
  `USER_ID` int(11) NOT NULL,
  `LoanStatus` tinyint(4) NOT NULL,
  `RETURNDATE` datetime NOT NULL,
  `DUEDATE` datetime NOT NULL,
  `STARTDATE` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `loanitems`
--

INSERT INTO `loanitems` (`ARTICLE_ID`, `PRICEDAY`, `NAME`, `USER_ID`, `LoanStatus`, `RETURNDATE`, `DUEDATE`, `STARTDATE`) VALUES
(1, 420, 'Bong', 234, 1, '2016-06-29 00:00:00', '2016-06-30 00:00:00', '2016-06-28 00:00:00'),
(2, 20, 'GUITAR', 1123, 0, '2016-08-19 00:00:00', '2016-03-15 00:00:00', '2016-08-19 00:00:00'),
(3, 34, 'DRUMS', 1123, 0, '2016-05-11 00:00:00', '2016-05-12 00:00:00', '2016-05-20 00:00:00'),
(4, 80, 'STONE', 1123, 0, '2016-05-22 00:00:00', '2016-05-03 00:00:00', '2016-05-28 00:00:00'),
(5, 80, 'STONE', 1124, 0, '2016-05-22 00:00:00', '2016-05-03 00:00:00', '2016-05-28 00:00:00'),
(6, 80, 'STONE', 1124, 0, '2016-05-22 00:00:00', '2016-05-03 00:00:00', '2016-05-28 00:00:00'),
(7, 420, 'Bong', 234, 1, '2016-06-29 00:00:00', '2016-06-30 00:00:00', '2016-06-28 00:00:00'),
(8, 45, 'Violin', 435, 0, '2016-06-29 00:00:00', '2016-06-30 00:00:00', '2016-06-28 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `location_history`
--

CREATE TABLE `location_history` (
  `VISITSTAMP_ID` int(11) NOT NULL,
  `USER_ID` int(11) NOT NULL,
  `ACTIVITY_ID` int(11) DEFAULT NULL,
  `CAMPING` int(11) DEFAULT NULL,
  `TIME_ENTRANCE` datetime NOT NULL,
  `TIME_EXIT` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `pincodes`
--

CREATE TABLE `pincodes` (
  `ID` int(11) NOT NULL,
  `CODE` varchar(4) NOT NULL,
  `TAKEN` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `productstorages`
--

CREATE TABLE `productstorages` (
  `INSTOREQUANTITY` int(11) NOT NULL,
  `PRODUCT_ID` int(11) NOT NULL,
  `STORE_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `rfids`
--

CREATE TABLE `rfids` (
  `BRACELET_ID` varchar(25) NOT NULL,
  `STATUS` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `salelines`
--

CREATE TABLE `salelines` (
  `PRODUCT_ID` int(11) NOT NULL,
  `QUANTITY` int(11) NOT NULL,
  `PAYMENT_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `serpayments`
--

CREATE TABLE `serpayments` (
  `PAYMENT_ID` int(11) NOT NULL,
  `USER_ID` int(11) NOT NULL,
  `DATE` datetime NOT NULL,
  `TYPE` varchar(1) NOT NULL,
  `PAYSUM` double NOT NULL,
  `DESCRIPTION` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `storepayment`
--

CREATE TABLE `storepayment` (
  `PAYMENT_ID` int(11) NOT NULL,
  `USER_ID` int(11) NOT NULL,
  `STORE_ID` int(11) NOT NULL,
  `TOTALPRICE` double NOT NULL,
  `PURCHASETIME` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `storeperfarchive`
--

CREATE TABLE `storeperfarchive` (
  `SAVE_ID` int(11) NOT NULL,
  `SLICETIME` datetime NOT NULL,
  `PRODNAME` varchar(15) NOT NULL,
  `PRODUCT_ID` int(11) NOT NULL,
  `STORE_ID` int(11) NOT NULL,
  `QUANTITY` int(11) NOT NULL,
  `NUMSALES` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `storeperfarchive`
--

INSERT INTO `storeperfarchive` (`SAVE_ID`, `SLICETIME`, `PRODNAME`, `PRODUCT_ID`, `STORE_ID`, `QUANTITY`, `NUMSALES`) VALUES
(23, '2016-06-13 21:10:00', 'Carrot Soup', 1, 1, 34, 2),
(24, '2016-06-13 21:10:00', 'Carrot Soup', 1, 2, 54, 1),
(25, '2016-06-13 21:10:00', 'Ulmodwich', 3, 2, 18, 15),
(26, '2016-06-13 21:10:00', 'Yellow Cheese', 5, 1, 31, 2),
(27, '2016-06-13 21:10:00', 'Yellow Cheese', 5, 2, 128, 3),
(28, '2016-06-13 22:10:00', 'Carrot Soup', 1, 1, 34, 2),
(29, '2016-06-13 22:10:00', 'Carrot Soup', 1, 2, 54, 1),
(30, '2016-06-13 22:10:00', 'Ulmodwich', 3, 2, 18, 15),
(31, '2016-06-13 22:10:00', 'Yellow Cheese', 5, 1, 31, 2),
(32, '2016-06-13 22:10:00', 'Yellow Cheese', 5, 2, 128, 3),
(35, '2016-06-13 23:10:00', 'Carrot Soup', 1, 1, 34, 2),
(36, '2016-06-13 23:10:00', 'Carrot Soup', 1, 2, 54, 1),
(37, '2016-06-13 23:10:00', 'Ulmodwich', 3, 2, 18, 15),
(38, '2016-06-13 23:10:00', 'Yellow Cheese', 5, 1, 31, 2),
(39, '2016-06-13 23:10:00', 'Yellow Cheese', 5, 2, 128, 3),
(42, '2016-06-14 00:10:00', 'Carrot Soup', 1, 1, 34, 2),
(43, '2016-06-14 00:10:00', 'Carrot Soup', 1, 2, 54, 1),
(44, '2016-06-14 00:10:00', 'Ulmodwich', 3, 2, 18, 15),
(45, '2016-06-14 00:10:00', 'Yellow Cheese', 5, 1, 31, 2),
(46, '2016-06-14 00:10:00', 'Yellow Cheese', 5, 2, 128, 3),
(49, '2016-06-14 01:10:00', 'Carrot Soup', 1, 1, 34, 2),
(50, '2016-06-14 01:10:00', 'Carrot Soup', 1, 2, 54, 1),
(51, '2016-06-14 01:10:00', 'Ulmodwich', 3, 2, 18, 15),
(52, '2016-06-14 01:10:00', 'Yellow Cheese', 5, 1, 31, 2),
(53, '2016-06-14 01:10:00', 'Yellow Cheese', 5, 2, 128, 3);

-- --------------------------------------------------------

--
-- Stand-in structure for view `storeprodinfo`
--
CREATE TABLE `storeprodinfo` (
`STORENAME` varchar(25)
,`PRODUCT_ID` int(11)
,`PRODNAME` varchar(15)
,`PRICE` double
,`QUANTITY` int(11)
);

-- --------------------------------------------------------

--
-- Table structure for table `stores`
--

CREATE TABLE `stores` (
  `STORE_ID` int(11) NOT NULL,
  `STORENAME` varchar(25) NOT NULL,
  `DESCRIPTION` varchar(400) DEFAULT NULL,
  `ACCESSCODE` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stores`
--

INSERT INTO `stores` (`STORE_ID`, `STORENAME`, `DESCRIPTION`, `ACCESSCODE`) VALUES
(1, 'Pho Phuck Ly', 'Don''t lieeee! It''s a pho phuc ly. Best food eva', 'PPL'),
(2, 'MOES', 'No Homers allowed', 'NOHOMERS!'),
(3, 'BravoPanCakes', 'Johnny Bravo''s pretty pancakes will make you go monkey with him', 'YeahWhatever'),
(4, 'Test', 'Testtest', 'tttest'),
(5, 'BobPlace', 'Pururu', 'Bob');

-- --------------------------------------------------------

--
-- Table structure for table `tentleaders`
--

CREATE TABLE `tentleaders` (
  `CAMPING_ID` int(11) NOT NULL,
  `USER_ID` int(11) NOT NULL,
  `ARRIVALDATE` date NOT NULL,
  `LEAVEDATE` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Stand-in structure for view `tentleadersextra_view`
--
CREATE TABLE `tentleadersextra_view` (
`USER_ID` int(11)
,`CAMPING_ID` int(11)
,`FNAME` varchar(25)
,`LNAME` varchar(25)
);

-- --------------------------------------------------------

--
-- Table structure for table `visitors`
--

CREATE TABLE `visitors` (
  `USER_ID` int(11) NOT NULL,
  `SECCODE` varchar(4) DEFAULT NULL,
  `PASSWORD` varchar(25) NOT NULL,
  `EMAIL` varchar(25) NOT NULL,
  `FNAME` varchar(25) NOT NULL,
  `LNAME` varchar(25) NOT NULL,
  `DOB` date NOT NULL,
  `REGDATE` date DEFAULT NULL,
  `BALANCE` double NOT NULL DEFAULT '0',
  `PAID` tinyint(1) NOT NULL DEFAULT '0',
  `BRACELET_ID` varchar(25) DEFAULT NULL,
  `CAMPING_ID` int(11) DEFAULT NULL,
  `STATUS` int(11) DEFAULT '0',
  `ADDRESS` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure for view `activityplaces_view`
--
DROP TABLE IF EXISTS `activityplaces_view`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `activityplaces_view`  AS  select `a`.`ACTIVITY_ID` AS `ACTIVITY_ID`,`a`.`TOTALPLACES` AS `TOTALPLACES`,floor((`a`.`TOTALPLACES` / 2)) AS `TORESPLCS`,count(`ar`.`USER_ID`) AS `RESERVEDPLACES` from (`activities` `a` join `activityreservations` `ar` on((`a`.`ACTIVITY_ID` = `ar`.`ACTIVITY_ID`))) group by `a`.`ACTIVITY_ID` ;

-- --------------------------------------------------------

--
-- Structure for view `storeprodinfo`
--
DROP TABLE IF EXISTS `storeprodinfo`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `storeprodinfo`  AS  select `st`.`STORENAME` AS `STORENAME`,`ps`.`PRODUCT_ID` AS `PRODUCT_ID`,`fp`.`NAME` AS `PRODNAME`,`fp`.`PRICE` AS `PRICE`,`ps`.`INSTOREQUANTITY` AS `QUANTITY` from ((`productstorages` `ps` join `foodproducts` `fp` on((`ps`.`PRODUCT_ID` = `fp`.`PRODUCT_ID`))) join `stores` `st` on((`st`.`STORE_ID` = `ps`.`STORE_ID`))) order by `fp`.`NAME` ;

-- --------------------------------------------------------

--
-- Structure for view `tentleadersextra_view`
--
DROP TABLE IF EXISTS `tentleadersextra_view`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `tentleadersextra_view`  AS  select `t`.`USER_ID` AS `USER_ID`,`t`.`CAMPING_ID` AS `CAMPING_ID`,`v`.`FNAME` AS `FNAME`,`v`.`LNAME` AS `LNAME` from (`tentleaders` `t` join `visitors` `v` on((`t`.`USER_ID` = `v`.`USER_ID`))) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `activities`
--
ALTER TABLE `activities`
  ADD PRIMARY KEY (`ACTIVITY_ID`);

--
-- Indexes for table `activityreservations`
--
ALTER TABLE `activityreservations`
  ADD PRIMARY KEY (`ACTIVITY_ID`,`USER_ID`),
  ADD KEY `USER_ID` (`USER_ID`);

--
-- Indexes for table `camps`
--
ALTER TABLE `camps`
  ADD PRIMARY KEY (`CAMPING_ID`);

--
-- Indexes for table `foodproducts`
--
ALTER TABLE `foodproducts`
  ADD PRIMARY KEY (`PRODUCT_ID`);

--
-- Indexes for table `loanitems`
--
ALTER TABLE `loanitems`
  ADD PRIMARY KEY (`ARTICLE_ID`);

--
-- Indexes for table `location_history`
--
ALTER TABLE `location_history`
  ADD PRIMARY KEY (`VISITSTAMP_ID`),
  ADD KEY `USER_ID` (`USER_ID`),
  ADD KEY `ACTIVITY_ID` (`ACTIVITY_ID`);

--
-- Indexes for table `pincodes`
--
ALTER TABLE `pincodes`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `productstorages`
--
ALTER TABLE `productstorages`
  ADD PRIMARY KEY (`STORE_ID`,`PRODUCT_ID`),
  ADD KEY `PRODUCT_ID` (`PRODUCT_ID`);

--
-- Indexes for table `rfids`
--
ALTER TABLE `rfids`
  ADD PRIMARY KEY (`BRACELET_ID`),
  ADD UNIQUE KEY `BRACELET_ID` (`BRACELET_ID`);

--
-- Indexes for table `salelines`
--
ALTER TABLE `salelines`
  ADD PRIMARY KEY (`PRODUCT_ID`,`PAYMENT_ID`),
  ADD KEY `PAYMENT_ID` (`PAYMENT_ID`);

--
-- Indexes for table `serpayments`
--
ALTER TABLE `serpayments`
  ADD PRIMARY KEY (`PAYMENT_ID`),
  ADD KEY `USER_ID` (`USER_ID`);

--
-- Indexes for table `storepayment`
--
ALTER TABLE `storepayment`
  ADD PRIMARY KEY (`PAYMENT_ID`),
  ADD UNIQUE KEY `PAYMENT_ID` (`PAYMENT_ID`),
  ADD KEY `USER_ID` (`USER_ID`),
  ADD KEY `STORE_ID` (`STORE_ID`);

--
-- Indexes for table `storeperfarchive`
--
ALTER TABLE `storeperfarchive`
  ADD PRIMARY KEY (`SAVE_ID`),
  ADD KEY `PRODUCT_ID` (`PRODUCT_ID`),
  ADD KEY `STORE_ID` (`STORE_ID`);

--
-- Indexes for table `stores`
--
ALTER TABLE `stores`
  ADD PRIMARY KEY (`STORE_ID`),
  ADD UNIQUE KEY `ACCESSCODE` (`ACCESSCODE`),
  ADD UNIQUE KEY `STORENAME` (`STORENAME`);

--
-- Indexes for table `tentleaders`
--
ALTER TABLE `tentleaders`
  ADD PRIMARY KEY (`CAMPING_ID`),
  ADD KEY `CAMPING_ID` (`CAMPING_ID`),
  ADD KEY `CAMPING_ID_2` (`CAMPING_ID`),
  ADD KEY `USER_ID` (`USER_ID`),
  ADD KEY `CAMPING_ID_3` (`CAMPING_ID`);

--
-- Indexes for table `visitors`
--
ALTER TABLE `visitors`
  ADD PRIMARY KEY (`USER_ID`),
  ADD UNIQUE KEY `E-MAIL` (`EMAIL`),
  ADD UNIQUE KEY `USER_ID` (`USER_ID`),
  ADD UNIQUE KEY `USER_ID_2` (`USER_ID`),
  ADD UNIQUE KEY `SECCODE` (`SECCODE`),
  ADD UNIQUE KEY `BRACELET_ID` (`BRACELET_ID`),
  ADD UNIQUE KEY `BRACELET_ID_2` (`BRACELET_ID`),
  ADD KEY `CAMPING_ID` (`CAMPING_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `activities`
--
ALTER TABLE `activities`
  MODIFY `ACTIVITY_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `camps`
--
ALTER TABLE `camps`
  MODIFY `CAMPING_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11125;
--
-- AUTO_INCREMENT for table `foodproducts`
--
ALTER TABLE `foodproducts`
  MODIFY `PRODUCT_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `loanitems`
--
ALTER TABLE `loanitems`
  MODIFY `ARTICLE_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `location_history`
--
ALTER TABLE `location_history`
  MODIFY `VISITSTAMP_ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pincodes`
--
ALTER TABLE `pincodes`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `serpayments`
--
ALTER TABLE `serpayments`
  MODIFY `PAYMENT_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;
--
-- AUTO_INCREMENT for table `storepayment`
--
ALTER TABLE `storepayment`
  MODIFY `PAYMENT_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT for table `storeperfarchive`
--
ALTER TABLE `storeperfarchive`
  MODIFY `SAVE_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;
--
-- AUTO_INCREMENT for table `stores`
--
ALTER TABLE `stores`
  MODIFY `STORE_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `visitors`
--
ALTER TABLE `visitors`
  MODIFY `USER_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1165;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `activityreservations`
--
ALTER TABLE `activityreservations`
  ADD CONSTRAINT `activityreservations_ibfk_1` FOREIGN KEY (`ACTIVITY_ID`) REFERENCES `activities` (`ACTIVITY_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `activityreservations_ibfk_2` FOREIGN KEY (`USER_ID`) REFERENCES `visitors` (`USER_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `location_history`
--
ALTER TABLE `location_history`
  ADD CONSTRAINT `location_history_ibfk_1` FOREIGN KEY (`USER_ID`) REFERENCES `visitors` (`USER_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `location_history_ibfk_2` FOREIGN KEY (`ACTIVITY_ID`) REFERENCES `activities` (`ACTIVITY_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `productstorages`
--
ALTER TABLE `productstorages`
  ADD CONSTRAINT `productstorages_ibfk_3` FOREIGN KEY (`PRODUCT_ID`) REFERENCES `foodproducts` (`PRODUCT_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `productstorages_ibfk_4` FOREIGN KEY (`STORE_ID`) REFERENCES `stores` (`STORE_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `salelines`
--
ALTER TABLE `salelines`
  ADD CONSTRAINT `salelines_ibfk_2` FOREIGN KEY (`PRODUCT_ID`) REFERENCES `productstorages` (`PRODUCT_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `salelines_ibfk_3` FOREIGN KEY (`PAYMENT_ID`) REFERENCES `storepayment` (`PAYMENT_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `serpayments`
--
ALTER TABLE `serpayments`
  ADD CONSTRAINT `serpayments_ibfk_1` FOREIGN KEY (`USER_ID`) REFERENCES `visitors` (`USER_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `storepayment`
--
ALTER TABLE `storepayment`
  ADD CONSTRAINT `storepayment_ibfk_1` FOREIGN KEY (`USER_ID`) REFERENCES `visitors` (`USER_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `storepayment_ibfk_2` FOREIGN KEY (`STORE_ID`) REFERENCES `stores` (`STORE_ID`);

--
-- Constraints for table `storeperfarchive`
--
ALTER TABLE `storeperfarchive`
  ADD CONSTRAINT `storeperfarchive_ibfk_1` FOREIGN KEY (`PRODUCT_ID`) REFERENCES `foodproducts` (`PRODUCT_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `storeperfarchive_ibfk_2` FOREIGN KEY (`STORE_ID`) REFERENCES `stores` (`STORE_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tentleaders`
--
ALTER TABLE `tentleaders`
  ADD CONSTRAINT `tentleaders_ibfk_1` FOREIGN KEY (`USER_ID`) REFERENCES `visitors` (`USER_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tentleaders_ibfk_2` FOREIGN KEY (`CAMPING_ID`) REFERENCES `camps` (`CAMPING_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `visitors`
--
ALTER TABLE `visitors`
  ADD CONSTRAINT `visitors_ibfk_1` FOREIGN KEY (`BRACELET_ID`) REFERENCES `rfids` (`BRACELET_ID`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `visitors_ibfk_2` FOREIGN KEY (`CAMPING_ID`) REFERENCES `camps` (`CAMPING_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

DELIMITER $$
--
-- Events
--
CREATE DEFINER=`root`@`localhost` EVENT `SALESSLICEREVENT` ON SCHEDULE EVERY 1 HOUR STARTS '2016-06-13 20:10:00' ENDS '2016-06-15 04:00:00' ON COMPLETION PRESERVE DISABLE COMMENT 'ARCHIVES INFO ABOUT THE SALES AND STORAGES PER STORE' DO INSERT INTO storeperfarchive (SLICETIME, PRODNAME, PRODUCT_ID, QUANTITY, NUMSALES, STORE_ID) 
	
     SELECT NOW(), fp.NAME, ps.PRODUCT_ID, ps.INSTOREQUANTITY, SUM(sl.QUANTITY) AS NUMSOLD, ps.STORE_ID 
     FROM foodproducts fp
     	join productstorages ps 
        	on fp.PRODUCT_ID = ps.PRODUCT_ID
     	left outer join storepayment sp 
        	on ps.STORE_ID=sp.STORE_ID 
     	join salelines sl 
     		on sp.PAYMENT_ID = sl.PAYMENT_ID and sl.PRODUCT_ID = ps.PRODUCT_ID 
     GROUP BY ps.PRODUCT_ID, ps.STORE_ID$$

DELIMITER ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
