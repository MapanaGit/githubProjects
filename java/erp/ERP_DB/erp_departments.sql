CREATE TABLE `departments` (
  `DepId` int NOT NULL,
  `departmentName` varchar(30) DEFAULT NULL,
  `Description` varchar(30) DEFAULT NULL,
  `BranchID` int NOT NULL,
  PRIMARY KEY (`DepId`),
  KEY `op_idx` (`BranchID`),
  CONSTRAINT `op` FOREIGN KEY (`BranchID`) REFERENCES `branches` (`Branch_id`) ON DELETE CASCADE ON UPDATE CASCADE
)