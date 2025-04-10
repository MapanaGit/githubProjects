CREATE TABLE `benefits` (
  `BenefitID` int NOT NULL,
  `type` varchar(30) DEFAULT NULL,
  `Description` varchar(30) DEFAULT NULL,
  `BenefitAmount` varchar(30) DEFAULT NULL,
  `Deductions` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`BenefitID`)
)