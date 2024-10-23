CREATE TABLE `assetmaintenance` (
  `MaintenanceID` int NOT NULL,
  `Asset_Id` int DEFAULT NULL,
  `Priority` varchar(10) DEFAULT NULL,
  `PersonResponsible` varchar(45) DEFAULT NULL,
  `Duration` varchar(10) DEFAULT NULL,
  `StartDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `ServiceProvider` varchar(20) DEFAULT NULL,
  `Comments` varchar(57) DEFAULT NULL,
  `Status` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`MaintenanceID`),
  KEY `Asset_Id_idx` (`Asset_Id`),
  CONSTRAINT `Asset_Id` FOREIGN KEY (`Asset_Id`) REFERENCES `assets` (`Asset_Id`) ON DELETE CASCADE ON UPDATE CASCADE
)