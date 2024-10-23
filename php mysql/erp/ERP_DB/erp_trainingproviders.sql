CREATE TABLE `trainingproviders` (
  `TrainingID` int NOT NULL,
  `RegNo` varchar(30) DEFAULT NULL,
  `AccredationNo` varchar(30) DEFAULT NULL,
  `InstitutionName` varchar(30) DEFAULT NULL,
  `Address` varchar(30) DEFAULT NULL,
  `Courses` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`TrainingID`)
)