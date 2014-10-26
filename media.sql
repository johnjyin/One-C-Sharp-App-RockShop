
CREATE DATABASE [IF NOT EXISTS] `rockshop`


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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1



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
  PRIMARY KEY (`ProductNo`),
  KEY `royalty_no_refs` (`RoyaltyNo`),
  CONSTRAINT `royalty_no_refs` FOREIGN KEY (`RoyaltyNo`) REFERENCES `royaltyowners` (`RoyaltyNo`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1



ALTER TABLE `books` ADD CONSTRAINT author_id_refs FOREIGN KEY (`author_id`) REFERENCES `author` (`id`);

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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1

