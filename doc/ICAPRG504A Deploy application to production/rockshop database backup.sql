/*
SQLyog Community v10.41 
MySQL - 5.5.27 : Database - rockshop
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`rockshop` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `rockshop`;

/*Table structure for table `media` */

DROP TABLE IF EXISTS `media`;

CREATE TABLE `media` (
  `ProductNo` int(11) NOT NULL AUTO_INCREMENT,
  `ProductName` varchar(30) NOT NULL,
  `ProductType` int(11) NOT NULL,
  `FileType` varchar(3) NOT NULL,
  `URLSampler` varchar(50) NOT NULL,
  `URLMedia` varchar(50) NOT NULL,
  `UnitPrice` decimal(10,0) NOT NULL,
  `RoyaltyNo` int(11) NOT NULL,
  `UnitRoyalty` decimal(10,0) NOT NULL,
  `DateAdded` date NOT NULL,
  PRIMARY KEY (`ProductNo`)
) ENGINE=InnoDB AUTO_INCREMENT=106 DEFAULT CHARSET=latin1;

/*Data for the table `media` */

/*Table structure for table `royaltyowners` */

DROP TABLE IF EXISTS `royaltyowners`;

CREATE TABLE `royaltyowners` (
  `RoyaltyNo` int(11) NOT NULL AUTO_INCREMENT,
  `RoyaltyName` varchar(20) NOT NULL,
  `PostalAddress` varchar(50) NOT NULL,
  `MinimumRoyalties` decimal(10,0) NOT NULL,
  `CurrentPeriodSales` int(11) NOT NULL,
  `CurrentPeriodRoyalties` decimal(10,0) NOT NULL,
  `YearToDateSales` int(11) NOT NULL,
  `YearToDateRoyalties` decimal(10,0) NOT NULL,
  `TotalSales` int(11) NOT NULL,
  `TotalRoyalties` decimal(10,0) NOT NULL,
  `LastPaymentDate` date NOT NULL,
  PRIMARY KEY (`RoyaltyNo`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

/*Data for the table `royaltyowners` */

insert  into `royaltyowners`(`RoyaltyNo`,`RoyaltyName`,`PostalAddress`,`MinimumRoyalties`,`CurrentPeriodSales`,`CurrentPeriodRoyalties`,`YearToDateSales`,`YearToDateRoyalties`,`TotalSales`,`TotalRoyalties`,`LastPaymentDate`) values (1,'ROCK','100 ROCK RD NSW',2,20,23,33,2,222,2334,'2014-04-01'),(2,'ZERO MUCIS','1 ZERO STREET NSW',2,20,23,33,2,222,2334,'2014-04-01'),(3,'NEW LINE','20 NEWLINE RD NSW',2,20,23,33,2,222,23,'2014-04-01'),(4,'SUNNY DAY','2 ROCK RD NSW',2,20,23,33,2,222,23,'2014-04-01'),(5,'CLEAN MUSIC','12 LIVE RD NSW',2,20,23,33,2,222,23,'2014-04-01');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
