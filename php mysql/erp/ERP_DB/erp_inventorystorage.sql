CREATE TABLE `inventorystorage` (
  `Store_id` int NOT NULL,
  `AssetTypeID` int NOT NULL,
  `Branch_id` int DEFAULT NULL,
  `Qty` int DEFAULT NULL,
  `Status` varchar(45) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Store_id`),
  KEY `bn_idx` (`Branch_id`),
  CONSTRAINT `bn` FOREIGN KEY (`Branch_id`) REFERENCES `branches` (`Branch_id`) ON DELETE CASCADE ON UPDATE CASCADE
)