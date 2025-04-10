CREATE TABLE `user` (
  `UserId` int NOT NULL AUTO_INCREMENT,
  `UserName` varchar(45) DEFAULT NULL,
  `Password` char(50) DEFAULT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Surname` varchar(50) DEFAULT NULL,
  `Role` varchar(40) DEFAULT NULL,
  `Position` varchar(40) DEFAULT NULL,
  `Department` varchar(45) DEFAULT NULL,
  `Category` varchar(20) DEFAULT NULL,
  `Account_Status` bit(1) DEFAULT NULL,
  `Last Logon` datetime DEFAULT NULL,
  PRIMARY KEY (`UserId`)
)