-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 26, 2016 at 01:46 PM
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

--
-- Dumping data for table `visitors`
--

INSERT INTO `visitors` (`USER_ID`, `SECCODE`, `PASSWORD`, `EMAIL`, `FNAME`, `LNAME`, `DOB`, `REGDATE`, `BALANCE`, `PAID`, `BRACELET_ID`, `CAMPING_ID`, `STATUS`, `ADDRESS`) VALUES
(1123, '4CU2', '123123', 'karl@karl.com', 'KARL', 'KARLSON', '1970-04-08', NULL, 45, 1, '5c005ca01e', 10001, 0, NULL),
(1124, 'FU4M', 'rarar', 'rar@rar.rar', 'Rar', 'Raaaar', '1923-05-12', NULL, 86.4, 0, '49001ebf55', 10001, 0, NULL),
(1125, 'KARL', 'abc', 'abc@abc.abc', 'Gertrude', 'Fury', '1907-07-07', NULL, 166.9, 1, '2800b8532e', 10001, 0, NULL),
(1126, 'GUGU', '123@ada', '123@ada', '123@ada', '123@ada', '2016-05-04', '2016-05-04', 0, 0, NULL, 10001, 0, NULL),
(1127, '', '123', 'gs@gs.ss', 'george', 'stevenson', '0000-00-00', '0000-00-00', 0, 0, NULL, NULL, 0, 'asdaaa'),
(1130, NULL, 'purpurpur@pa', 'purpurpur@pa', 'purpurpur@pa', 'purpurpur@pa', '2019-01-03', '2016-05-14', 0, 0, NULL, 11120, 0, 'purpurpur@pa,v,purpurpur@pa,purpurpur@pa'),
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
(1144, NULL, 'curry', 'curry@curry.curry', 'Alice', 'Curry', '1986-01-26', '2016-05-26', 196.5, 1, '7000822356', 11112, 0, NULL),
(1145, NULL, 'pepe', 'pepe@pe.pe', 'Penelopa', 'Pe', '1993-02-10', '2016-05-04', 5859.8, 1, '5c005e6a62', 11112, 0, NULL),
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

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
