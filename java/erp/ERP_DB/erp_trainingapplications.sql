CREATE TABLE `trainingapplications` (
  `ApplicationID` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(30) DEFAULT NULL,
  `LastName` varchar(30) DEFAULT NULL,
  `employeeNumber` int DEFAULT NULL,
  `TrainingID` int DEFAULT NULL,
  `CourseName` varchar(30) DEFAULT NULL,
  `Cost` decimal(10,0) DEFAULT NULL,
  `StartDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `CourseDuration` varchar(30) DEFAULT NULL,
  `Cost_RefNo` varchar(56) NOT NULL,
  PRIMARY KEY (`ApplicationID`),
  KEY `kj_idx` (`TrainingID`),
  KEY `emplN_idx` (`employeeNumber`),
  CONSTRAINT `emplN` FOREIGN KEY (`employeeNumber`) REFERENCES `employees` (`employeeNumber`),
  CONSTRAINT `kj` FOREIGN KEY (`TrainingID`) REFERENCES `trainingproviders` (`TrainingID`)
)