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
-- Структура на таблица `activities`
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
-- Схема на данните от таблица `activities`
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
-- Структура на таблица `activityreservations`
--

CREATE TABLE `activityreservations` (
  `ACTIVITY_ID` int(11) NOT NULL,
  `USER_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Схема на данните от таблица `activityreservations`
--

INSERT INTO `activityreservations` (`ACTIVITY_ID`, `USER_ID`) VALUES
(1, 1137),
(1, 1142),
(3, 1123),
(3, 1139),
(4, 1123),
(4, 1125),
(4, 1139),
(4, 1140),
(4, 1142),
(5, 1123),
(5, 1125),
(5, 1136),
(5, 1139),
(5, 1142),
(6, 1136),
(6, 1140),
(7, 1123),
(7, 1136),
(7, 1140);

-- --------------------------------------------------------

--
-- Структура на таблица `camps`
--

CREATE TABLE `camps` (
  `CAMPING_ID` int(11) NOT NULL,
  `TENTNR` int(11) NOT NULL,
  `AVAILABLE` tinyint(1) NOT NULL DEFAULT '1',
  `TYPE` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Схема на данните от таблица `camps`
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
(11123, 223, 1, 'Molden blanket'),
(11124, 1, 1, 'Shop');

-- --------------------------------------------------------

--
-- Структура на таблица `foodproducts`
--

CREATE TABLE `foodproducts` (
  `PRODUCT_ID` int(11) NOT NULL,
  `NAME` varchar(20) COLLATE latin1_bin NOT NULL,
  `PRICE` double NOT NULL,
  `QUANTITY` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_bin;

-- --------------------------------------------------------

--
-- Структура на таблица `loanitems`
--

CREATE TABLE `loanitems` (
  `ARTICLE_ID` int(11) NOT NULL,
  `PRICEDAY` int(11) DEFAULT '0',
  `NAME` varchar(10) NOT NULL,
  `LoanStatus` tinyint(1) NOT NULL,
  `USER_ID` int(11) NOT NULL,
  `RETURNDATE` date NOT NULL,
  `DUEDATE` date NOT NULL,
  `STARTDATE` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Схема на данните от таблица `loanitems`
--

INSERT INTO `loanitems` (`ARTICLE_ID`, `PRICEDAY`, `NAME`, `LoanStatus`, `USER_ID`, `RETURNDATE`, `DUEDATE`, `STARTDATE`) VALUES
(0, 420, 'Bong', 1, 234, '2016-06-29', '2016-06-30', '2016-06-28'),
(1, 20, 'GUITAR', 0, 1123, '2016-08-19', '2016-03-15', '2016-08-19'),
(2, 34, 'DRUMS', 0, 1123, '2016-05-11', '2016-05-12', '2016-05-20'),
(3, 80, 'STONE', 0, 1123, '2016-05-22', '2016-05-03', '2016-05-28'),
(4, 80, 'STONE', 0, 1124, '2016-05-22', '2016-05-03', '2016-05-28'),
(5, 80, 'STONE', 0, 1124, '2016-05-22', '2016-05-03', '2016-05-28'),
(9, 420, 'Bong', 1, 234, '2016-06-29', '2016-06-30', '2016-06-28'),
(23, 45, 'Violin', 0, 435, '2016-06-29', '2016-06-30', '2016-06-28');

-- --------------------------------------------------------

--
-- Структура на таблица `location_history`
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
-- Структура на таблица `pincodes`
--

CREATE TABLE `pincodes` (
  `ID` int(11) NOT NULL,
  `CODE` varchar(4) NOT NULL,
  `TAKEN` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Структура на таблица `productstorages`
--

CREATE TABLE `productstorages` (
  `INSTOREQUANTITY` int(11) NOT NULL,
  `PRODUCT_ID` int(11) NOT NULL,
  `STORE_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Структура на таблица `rfids`
--

CREATE TABLE `rfids` (
  `BRACELET_ID` varchar(25) NOT NULL,
  `STATUS` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Схема на данните от таблица `rfids`
--

INSERT INTO `rfids` (`BRACELET_ID`, `STATUS`) VALUES
('2800b8532e', 'DEACTIVATED'),
('49001ebf55', 'STAND_BY'),
('5c005ca01e', 'DEACTIVATED'),
('5c005e6a62', 'DEACTIVATED'),
('7000822356', 'DEACTIVATED');

-- --------------------------------------------------------

--
-- Структура на таблица `salelines`
--

CREATE TABLE `salelines` (
  `PRODUCT_ID` int(11) NOT NULL,
  `QUANTITY` int(11) NOT NULL,
  `PAYMENT_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Структура на таблица `serpayments`
--

CREATE TABLE `serpayments` (
  `PAYMENT_ID` int(11) NOT NULL,
  `USER_ID` int(11) NOT NULL,
  `DATE` datetime NOT NULL,
  `TYPE` varchar(1) NOT NULL,
  `PAYSUM` double NOT NULL,
  `DESCRIPTION` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Схема на данните от таблица `serpayments`
--

INSERT INTO `serpayments` (`PAYMENT_ID`, `USER_ID`, `DATE`, `TYPE`, `PAYSUM`, `DESCRIPTION`) VALUES
(14, 1123, '2016-05-22 16:00:00', '-', 25, 'Tent Reservation Payment. Group of 4'),
(15, 1144, '2016-05-26 07:31:51', '', 50, 'Tent Reservation Payment. Group of 2 .'),
(16, 1147, '2016-05-26 07:48:30', '', 50, 'Tent Reservation Payment. Group of 2 .'),
(17, 1148, '2016-05-26 07:51:22', '', 25, 'Tent Reservation Payment. Group of 1 .'),
(18, 1148, '2016-05-26 07:53:40', '', 25, 'Tent Reservation Payment. Group of 1 .'),
(19, 1151, '2016-05-26 07:56:54', '', 15, 'Tent Reservation Payment. Group of 1 .'),
(20, 1152, '2016-05-26 08:02:55', '', 25, 'Tent Reservation Payment. Group of 1 .'),
(21, 1136, '2016-05-26 08:06:34', '', 25, 'Tent Reservation Payment. Group of 1 .'),
(22, 1153, '2016-05-26 11:13:48', '', 50, 'Tent Reservation Payment. Group of 2 .'),
(23, 1130, '2016-05-26 11:15:36', '', 25, 'Tent Reservation Payment. Group of 1 .'),
(24, 1140, '2016-05-26 11:16:20', '', 15, 'Tent Reservation Payment. Group of 1 .'),
(28, 1125, '2016-05-28 12:52:30', '-', 55, 'Ticket Payment'),
(29, 1123, '2016-05-28 12:53:56', '-', 55, 'Ticket Payment'),
(30, 1159, '2016-05-28 02:08:21', '-', 55, 'Ticket Payment'),
(31, 1136, '2016-05-28 02:16:54', '-', 125, 'Ticket Payment'),
(32, 1158, '2016-05-28 07:53:07', '-', 55, 'Ticket Payment'),
(33, 1158, '2016-05-28 23:53:07', '-', 50, 'Tent Reservation Payment. Group of 2 .');

-- --------------------------------------------------------

--
-- Структура на таблица `storepayment`
--

CREATE TABLE `storepayment` (
  `USER_ID` int(11) NOT NULL,
  `PAYMENT_ID` int(11) NOT NULL,
  `TOTALPRICE` double NOT NULL,
  `PURCHASETIME` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Структура на таблица `stores`
--

CREATE TABLE `stores` (
  `STORE_ID` int(11) NOT NULL,
  `STORENAME` varchar(25) NOT NULL,
  `DESCRIPTION` varchar(400) DEFAULT NULL,
  `ACCESSCODE` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Структура на таблица `tentleaders`
--

CREATE TABLE `tentleaders` (
  `CAMPING_ID` int(11) NOT NULL,
  `USER_ID` int(11) NOT NULL,
  `ARRIVALDATE` int(11) NOT NULL,
  `LEAVEDATE` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Схема на данните от таблица `tentleaders`
--

INSERT INTO `tentleaders` (`CAMPING_ID`, `USER_ID`, `ARRIVALDATE`, `LEAVEDATE`) VALUES
(10001, 1123, 0, 0),
(11112, 1144, 0, 0),
(11113, 1147, 0, 0),
(11114, 1148, 0, 0),
(11115, 1148, 0, 0),
(11116, 1151, 0, 0),
(11117, 1152, 0, 0),
(11118, 1136, 0, 0),
(11119, 1153, 0, 0),
(11120, 1130, 0, 0),
(11121, 1140, 0, 0),
(11122, 1158, 28, 0);

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
-- Структура на таблица `visitors`
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

--
-- Схема на данните от таблица `visitors`
--

INSERT INTO `visitors` (`USER_ID`, `SECCODE`, `PASSWORD`, `EMAIL`, `FNAME`, `LNAME`, `DOB`, `REGDATE`, `BALANCE`, `PAID`, `BRACELET_ID`, `CAMPING_ID`, `STATUS`, `ADDRESS`) VALUES
(1123, '4CU2', '123123', 'karl@karl.com', 'KARL', 'KARLSON', '1970-04-08', NULL, 45, 1, NULL, 10001, 0, NULL),
(1124, 'FU4M', 'rarar', 'rar@rar.rar', 'Rar', 'Raaaar', '1923-05-12', NULL, 45555040, 1, '49001ebf55', 10001, 0, NULL),
(1125, 'KARL', 'abc', 'abc@abc.abc', 'Gertrude', 'Fury', '1907-07-07', NULL, 345, 1, '2800b8532e', 10001, 0, NULL),
(1126, 'GUGU', '123@ada', '123@ada', '123@ada', '123@ada', '2016-05-04', '2016-05-04', 0, 0, NULL, 10001, 0, NULL),
(1127, '', '123', 'gs@gs.ss', 'george', 'stevenson', '0000-00-00', '0000-00-00', 0, 0, NULL, NULL, 0, 'asdaaa'),
(1130, NULL, 'purpurpur@pa', 'purpurpur@pa', 'purpurpur@pa', 'purpurpur@pa', '2019-01-03', '2016-05-14', 420, 1, '5c005e6a62', 11120, 0, 'purpurpur@pa,v,purpurpur@pa,purpurpur@pa'),
(1131, NULL, 'sjdasklfall@a', 'sjdasklfall@a', 'sjdasklfall@a', 'sjdasklfall@a', '2018-01-30', '2016-05-14', 0, 0, NULL, NULL, 0, 'Novogireevskaya ul.,Moscow,Netherlands,111394'),
(1132, NULL, 'sjdasklfall!12@asda', 'sjdasklfall!12@asda', 'v', 'sjdasklfall!12@asda', '0000-00-00', '2016-05-14', 0, 0, NULL, NULL, 0, 'sjdasklfall!12@asda,sjdasklfall!12@asda12,1,123'),
(1133, NULL, 'qqq@qq', 'qqq@qq', 'qqq@qq', 'qqq@qq', '2016-01-01', '2016-05-14', 0, 0, NULL, NULL, 0, 'qqq@qq,qqq@qq,qqq@qq,qqq@qq'),
(1134, NULL, 'sjdasklfall@sad', 'sjdasklfall@sad', 'sjdasklfall@sad', 'sjdasklfall@sad', '2016-02-01', '2016-05-14', 0, 0, NULL, NULL, 0, 'sjdasklfall@sad,sjdasklfall@sad,sjdasklfall@sad,sjdasklfall@sad'),
(1135, NULL, 'sjdasklfall@qqq', 'sjdasklfall@qqq', 'sjdasklfall@qqq', 'sjdasklfall@qqq', '0123-12-21', '2016-05-14', 0, 0, NULL, NULL, 0, 'sjdasklfall@qqqq,sjdasklfall@qqq,sjdasklfall@qqq,sjdasklfall@qqq'),
(1136, NULL, 'caca@caca', 'caca@caca', 'caca@caca', 'caca@caca', '2016-05-02', '2016-05-15', 0, 1, NULL, 11118, 0, 'caca@caca,caca@caca,caca@caca,caca@caca'),
(1137, NULL, 'cacaasda@caca', 'cacaasda@caca', 'cacaasda@caca', 'cacaasda@caca', '2016-05-24', '2016-05-15', 0, 0, NULL, NULL, 0, 'cacaasda@caca,cacaasda@caca,cacaasda@caca,cacaasda@caca'),
(1138, NULL, 'asda@adad', 'asda@adad', 'asda@adad', 'asda@adad', '2016-05-25', '2016-05-16', 0, 0, NULL, 11122, 0, 'asda@adad,asda@adad,asda@adad,asda@adad'),
(1139, NULL, 'caaasdaca@caca', 'caaasdaca@caca', 'caaasdaca@caca', 'caaasdaca@caca', '2016-01-06', '2016-05-16', 0, 0, NULL, NULL, 0, 'caaasdaca@caca,caaasdaca@caca,caaasdaca@caca,caaasdaca@caca'),
(1140, NULL, 'aaa', 'aaaa@aaaaa.aa', 'Aaa Aaovich', 'Aaaovsky', '1969-01-08', '2016-05-16', 0, 0, NULL, 11121, 0, 'Astreet,2,3a,Atown,Acountry,Azip'),
(1141, NULL, '', '', '', '', '0000-00-00', '2016-05-16', 0, 0, NULL, NULL, 0, ',,,'),
(1142, NULL, 'asda@adadASDASDSA', 'asda@adadASDASDSA', 'BOB', 'PETERS', '2014-06-13', '2016-05-17', 0, 0, NULL, NULL, 0, 'fAR STREEETT,AS,ADS,AD'),
(1143, NULL, '123', 'asdd@dd', 'asf', 'asf', '2016-05-17', '2016-05-24', 0, 0, NULL, NULL, 0, 'a,s,x,z'),
(1144, NULL, 'curry', 'curry@curry.curry', 'Alice', 'Curry', '1986-01-26', '2016-05-26', 200, 0, NULL, 11112, 0, NULL),
(1145, NULL, 'pepe', 'pepe@pe.pe', 'Penelopa', 'Pe', '1993-02-10', '2016-05-04', 5975, 0, NULL, 11112, 0, NULL),
(1146, 'RTYE', '123', 'fred@dead.com', 'Fred', 'Dead', '1816-02-02', '2016-05-26', 0, 0, NULL, 11113, 0, NULL),
(1147, 'Deac', '123', 'jo@jo.jo', 'Josaphine', 'Joplin', '2016-05-11', NULL, 73, 0, NULL, 11113, 0, NULL),
(1148, 'assd', 'issd', 'issd@issd.is', 'IS', 'SD', '2016-02-24', NULL, 197, 0, NULL, 11115, 0, NULL),
(1151, NULL, 'nic', 'cb@cb.fr', 'Carla', 'Bruni', '1967-12-23', NULL, 985, 0, NULL, 11116, 0, NULL),
(1152, '2222', 'sos', 'sos@sos.sos', 'Soso', 'Sosov', '2016-05-11', NULL, 5, 0, NULL, 11117, 0, NULL),
(1153, 'NICO', 'nico', 'nico@nico', 'Nicolas', 'Sarkozy', '1958-01-28', '2016-05-04', 20, 0, NULL, 11119, 0, NULL),
(1154, '4tfa', '123', 'car@car.com', 'Mad', 'Max', '1968-12-02', '2016-05-03', 5000, 0, NULL, 11119, 0, NULL),
(1157, NULL, '123', 'b.vangestel@asdasdasda.nl', 'Bert', 'van Gestel', '2016-05-11', '2016-05-27', 0, 0, NULL, NULL, 0, '76,Eindhoven,Netherlands,5612 JD'),
(1158, NULL, '123', 'sd@ds', 'sd', 'ds', '2016-05-11', '2016-05-28', 145, 1, NULL, 11122, 0, 's,s,s,s'),
(1159, NULL, '123', 'rita@rt.com', 'Rita Drita', 'Van Dida', '2016-05-12', '2016-05-28', 345, 1, NULL, NULL, 0, 'Sdada,Vzsaa,JBVA,LLK'),
(1160, NULL, 'asd', 'bear@boar.com', 'Bear', 'Boar', '2016-05-04', '2016-05-29', 0, 0, NULL, NULL, 0, 'B,B,B,B');

-- --------------------------------------------------------

--
-- Structure for view `activityplaces_view`
--
DROP TABLE IF EXISTS `activityplaces_view`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `activityplaces_view`  AS  select `a`.`ACTIVITY_ID` AS `ACTIVITY_ID`,`a`.`TOTALPLACES` AS `TOTALPLACES`,floor((`a`.`TOTALPLACES` / 2)) AS `TORESPLCS`,count(`ar`.`USER_ID`) AS `RESERVEDPLACES` from (`activities` `a` join `activityreservations` `ar` on((`a`.`ACTIVITY_ID` = `ar`.`ACTIVITY_ID`))) group by `a`.`ACTIVITY_ID` ;

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
  ADD PRIMARY KEY (`PURCHASETIME`,`USER_ID`),
  ADD UNIQUE KEY `PAYMENT_ID` (`PAYMENT_ID`),
  ADD KEY `USER_ID` (`USER_ID`);

--
-- Indexes for table `stores`
--
ALTER TABLE `stores`
  ADD PRIMARY KEY (`STORE_ID`),
  ADD UNIQUE KEY `ACCESSCODE` (`ACCESSCODE`);

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
  MODIFY `PAYMENT_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;
--
-- AUTO_INCREMENT for table `visitors`
--
ALTER TABLE `visitors`
  MODIFY `USER_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1161;
--
-- Ограничения за дъмпнати таблици
--

--
-- Ограничения за таблица `activityreservations`
--
ALTER TABLE `activityreservations`
  ADD CONSTRAINT `activityreservations_ibfk_1` FOREIGN KEY (`ACTIVITY_ID`) REFERENCES `activities` (`ACTIVITY_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `activityreservations_ibfk_2` FOREIGN KEY (`USER_ID`) REFERENCES `visitors` (`USER_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения за таблица `location_history`
--
ALTER TABLE `location_history`
  ADD CONSTRAINT `location_history_ibfk_1` FOREIGN KEY (`USER_ID`) REFERENCES `visitors` (`USER_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `location_history_ibfk_2` FOREIGN KEY (`ACTIVITY_ID`) REFERENCES `activities` (`ACTIVITY_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения за таблица `productstorages`
--
ALTER TABLE `productstorages`
  ADD CONSTRAINT `productstorages_ibfk_1` FOREIGN KEY (`PRODUCT_ID`) REFERENCES `foodproducts` (`PRODUCT_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `productstorages_ibfk_2` FOREIGN KEY (`STORE_ID`) REFERENCES `stores` (`STORE_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения за таблица `salelines`
--
ALTER TABLE `salelines`
  ADD CONSTRAINT `salelines_ibfk_1` FOREIGN KEY (`PAYMENT_ID`) REFERENCES `storepayment` (`PAYMENT_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `salelines_ibfk_2` FOREIGN KEY (`PRODUCT_ID`) REFERENCES `productstorages` (`PRODUCT_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения за таблица `serpayments`
--
ALTER TABLE `serpayments`
  ADD CONSTRAINT `serpayments_ibfk_1` FOREIGN KEY (`USER_ID`) REFERENCES `visitors` (`USER_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения за таблица `storepayment`
--
ALTER TABLE `storepayment`
  ADD CONSTRAINT `storepayment_ibfk_1` FOREIGN KEY (`USER_ID`) REFERENCES `visitors` (`USER_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения за таблица `tentleaders`
--
ALTER TABLE `tentleaders`
  ADD CONSTRAINT `tentleaders_ibfk_1` FOREIGN KEY (`USER_ID`) REFERENCES `visitors` (`USER_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tentleaders_ibfk_2` FOREIGN KEY (`CAMPING_ID`) REFERENCES `camps` (`CAMPING_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения за таблица `visitors`
--
ALTER TABLE `visitors`
  ADD CONSTRAINT `visitors_ibfk_1` FOREIGN KEY (`BRACELET_ID`) REFERENCES `rfids` (`BRACELET_ID`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `visitors_ibfk_2` FOREIGN KEY (`CAMPING_ID`) REFERENCES `camps` (`CAMPING_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;