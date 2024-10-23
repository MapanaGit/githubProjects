CREATE TABLE `leaveapplication` (
  `LeaveID` int NOT NULL AUTO_INCREMENT,
  `employeeNumber` int DEFAULT NULL,
  `FirstName` varchar(30) DEFAULT NULL,
  `LastName` varchar(30) DEFAULT NULL,
  `LeaveType` varchar(45) DEFAULT NULL,
  `StartDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `LeaveBalance` decimal(10,0) DEFAULT NULL,
  `FileAttachment` blob,
  PRIMARY KEY (`LeaveID`),
  KEY `LeEmpl_idx` (`employeeNumber`),
  CONSTRAINT `LeEmpl` FOREIGN KEY (`employeeNumber`) REFERENCES `employees` (`employeeNumber`)
)