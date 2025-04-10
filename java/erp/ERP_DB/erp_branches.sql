CREATE TABLE `branches` (
  `Branch_id` int NOT NULL,
  `BranchName` varchar(20) DEFAULT NULL,
  `BranchLocation` varchar(45) DEFAULT NULL,
  `BranchManager` varchar(45) DEFAULT NULL,
  `contactEmail` varchar(45) DEFAULT NULL,
  `stockref` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Branch_id`)
)