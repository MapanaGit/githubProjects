CREATE TABLE `jobapplications` (
  `Job_refNo` varchar(233) NOT NULL,
  `FullNames` varchar(200) DEFAULT NULL,
  `IDNumber` int DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `StreetName` varchar(100) DEFAULT NULL,
  `City` varchar(30) DEFAULT NULL,
  `Suburb` varchar(30) DEFAULT NULL,
  `Province` varchar(30) DEFAULT NULL,
  `HighestQualification` varchar(255) DEFAULT NULL,
  `OtherQualification` varchar(255) DEFAULT NULL,
  `OtherQualification2` varchar(255) DEFAULT NULL,
  `KeySkills` varchar(255) DEFAULT NULL,
  `YearsOfExperience` varchar(300) DEFAULT NULL,
  `CV` blob,
  `academic` blob,
  `certifications` blob
)