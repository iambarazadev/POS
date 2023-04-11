-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bar
-- ------------------------------------------------------
-- Server version	8.0.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20221119122622_initial Db','7.0.0');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `barcodes`
--

DROP TABLE IF EXISTS `barcodes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `barcodes` (
  `BarcodeId` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`BarcodeId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `barcodes`
--

LOCK TABLES `barcodes` WRITE;
/*!40000 ALTER TABLE `barcodes` DISABLE KEYS */;
INSERT INTO `barcodes` VALUES (1),(2),(3);
/*!40000 ALTER TABLE `barcodes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bills`
--

DROP TABLE IF EXISTS `bills`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bills` (
  `BillId` int NOT NULL AUTO_INCREMENT,
  `BillCode` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `BillDateCreated` datetime(6) NOT NULL,
  `UserId` int DEFAULT NULL,
  `LogId` int DEFAULT NULL,
  PRIMARY KEY (`BillId`),
  KEY `IX_bills_LogId` (`LogId`),
  KEY `IX_bills_UserId` (`UserId`),
  CONSTRAINT `FK_bills_logs_LogId` FOREIGN KEY (`LogId`) REFERENCES `logs` (`LogId`),
  CONSTRAINT `FK_bills_users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bills`
--

LOCK TABLES `bills` WRITE;
/*!40000 ALTER TABLE `bills` DISABLE KEYS */;
INSERT INTO `bills` VALUES (3,'BID','2022-11-19 15:46:05.907020',1,NULL),(4,'BID','2022-11-19 15:46:37.430706',1,NULL);
/*!40000 ALTER TABLE `bills` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `brands`
--

DROP TABLE IF EXISTS `brands`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `brands` (
  `BrandId` int NOT NULL AUTO_INCREMENT,
  `BrandCode` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `BrandCaption` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `BrandDescription` varchar(600) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `BrandDateCreated` datetime(6) NOT NULL,
  `UserId` int DEFAULT NULL,
  `LogId` int DEFAULT NULL,
  PRIMARY KEY (`BrandId`),
  KEY `IX_brands_LogId` (`LogId`),
  KEY `IX_brands_UserId` (`UserId`),
  CONSTRAINT `FK_brands_logs_LogId` FOREIGN KEY (`LogId`) REFERENCES `logs` (`LogId`),
  CONSTRAINT `FK_brands_users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `brands`
--

LOCK TABLES `brands` WRITE;
/*!40000 ALTER TABLE `brands` DISABLE KEYS */;
INSERT INTO `brands` VALUES (1,'BID','safari','All safari beers','2022-11-19 15:33:51.227933',NULL,NULL),(2,'BID','Serengeti','all serengeti beers','2022-11-19 15:34:02.674219',NULL,NULL),(3,'BID','K-Vant','all kvant spirits','2022-11-19 15:36:38.096942',NULL,NULL);
/*!40000 ALTER TABLE `brands` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories` (
  `CategoryId` int NOT NULL AUTO_INCREMENT,
  `CategoryCode` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `CategoryCaption` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CategoryDescription` varchar(600) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CategoryDateCreated` datetime(6) NOT NULL,
  `UserId` int DEFAULT NULL,
  `LogId` int DEFAULT NULL,
  PRIMARY KEY (`CategoryId`),
  KEY `IX_categories_LogId` (`LogId`),
  KEY `IX_categories_UserId` (`UserId`),
  CONSTRAINT `FK_categories_logs_LogId` FOREIGN KEY (`LogId`) REFERENCES `logs` (`LogId`),
  CONSTRAINT `FK_categories_users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,'CID','Xl Beer','all 500 Ml Beer','2022-11-19 15:35:00.676084',NULL,NULL),(2,'CID','Mini Beer','All Minil Beer','2022-11-19 15:37:26.473120',NULL,NULL),(3,'CID','Light Beer','All Light Beer','2022-11-19 15:37:46.801156',NULL,NULL),(4,'CID','Spirits','All Spirits drinks','2022-11-19 15:38:02.423532',NULL,NULL);
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grns`
--

DROP TABLE IF EXISTS `grns`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grns` (
  `GrnId` int NOT NULL AUTO_INCREMENT,
  `GrnCode` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `GrnDateCreated` datetime(6) NOT NULL,
  `GrnReceiptCode` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `GrnReceiptDateCreated` datetime(6) NOT NULL,
  `SupplierId` int DEFAULT NULL,
  `UserId` int DEFAULT NULL,
  `LogId` int DEFAULT NULL,
  PRIMARY KEY (`GrnId`),
  KEY `IX_grns_LogId` (`LogId`),
  KEY `IX_grns_SupplierId` (`SupplierId`),
  KEY `IX_grns_UserId` (`UserId`),
  CONSTRAINT `FK_grns_logs_LogId` FOREIGN KEY (`LogId`) REFERENCES `logs` (`LogId`),
  CONSTRAINT `FK_grns_suppliers_SupplierId` FOREIGN KEY (`SupplierId`) REFERENCES `suppliers` (`SupplierId`),
  CONSTRAINT `FK_grns_users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grns`
--

LOCK TABLES `grns` WRITE;
/*!40000 ALTER TABLE `grns` DISABLE KEYS */;
INSERT INTO `grns` VALUES (1,'GID','2022-11-19 15:42:04.424228','343453','2022-11-19 15:42:04.424228',1,1,NULL);
/*!40000 ALTER TABLE `grns` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `holds`
--

DROP TABLE IF EXISTS `holds`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `holds` (
  `HoldId` int NOT NULL AUTO_INCREMENT,
  `HoldCode` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `HoldDateCreated` datetime(6) NOT NULL,
  `UserId` int DEFAULT NULL,
  `LogId` int DEFAULT NULL,
  PRIMARY KEY (`HoldId`),
  KEY `IX_holds_LogId` (`LogId`),
  KEY `IX_holds_UserId` (`UserId`),
  CONSTRAINT `FK_holds_logs_LogId` FOREIGN KEY (`LogId`) REFERENCES `logs` (`LogId`),
  CONSTRAINT `FK_holds_users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `holds`
--

LOCK TABLES `holds` WRITE;
/*!40000 ALTER TABLE `holds` DISABLE KEYS */;
/*!40000 ALTER TABLE `holds` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `logs`
--

DROP TABLE IF EXISTS `logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `logs` (
  `LogId` int NOT NULL AUTO_INCREMENT,
  `LogCode` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `UserId` int DEFAULT NULL,
  `LogDateTimeIn` datetime(6) NOT NULL,
  `LogDateTimeOut` datetime(6) NOT NULL,
  `LogDateCreated` datetime(6) NOT NULL,
  PRIMARY KEY (`LogId`),
  KEY `IX_logs_UserId` (`UserId`),
  CONSTRAINT `FK_logs_users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `logs`
--

LOCK TABLES `logs` WRITE;
/*!40000 ALTER TABLE `logs` DISABLE KEYS */;
/*!40000 ALTER TABLE `logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `opens`
--

DROP TABLE IF EXISTS `opens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `opens` (
  `OpenId` int NOT NULL AUTO_INCREMENT,
  `OpenCode` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `OpenDateCreated` datetime(6) NOT NULL,
  `UserId` int DEFAULT NULL,
  `LogId` int DEFAULT NULL,
  PRIMARY KEY (`OpenId`),
  KEY `IX_opens_LogId` (`LogId`),
  KEY `IX_opens_UserId` (`UserId`),
  CONSTRAINT `FK_opens_logs_LogId` FOREIGN KEY (`LogId`) REFERENCES `logs` (`LogId`),
  CONSTRAINT `FK_opens_users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `opens`
--

LOCK TABLES `opens` WRITE;
/*!40000 ALTER TABLE `opens` DISABLE KEYS */;
/*!40000 ALTER TABLE `opens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prices`
--

DROP TABLE IF EXISTS `prices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prices` (
  `PriceId` int NOT NULL AUTO_INCREMENT,
  `PriceCode` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `DateOfIssue` datetime(6) NOT NULL,
  `PriceReason` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `UserId` int DEFAULT NULL,
  `LogId` int DEFAULT NULL,
  `PricePurpose` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`PriceId`),
  KEY `IX_prices_LogId` (`LogId`),
  KEY `IX_prices_UserId` (`UserId`),
  CONSTRAINT `FK_prices_logs_LogId` FOREIGN KEY (`LogId`) REFERENCES `logs` (`LogId`),
  CONSTRAINT `FK_prices_users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prices`
--

LOCK TABLES `prices` WRITE;
/*!40000 ALTER TABLE `prices` DISABLE KEYS */;
INSERT INTO `prices` VALUES (1,'PRC','2022-11-19 15:42:04.424228','GRN',1,NULL,'GRN');
/*!40000 ALTER TABLE `prices` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productbarcodes`
--

DROP TABLE IF EXISTS `productbarcodes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productbarcodes` (
  `ProductId` int NOT NULL,
  `BarcodeId` int NOT NULL,
  `BarcodeNumber` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`ProductId`,`BarcodeId`),
  KEY `IX_productbarcodes_BarcodeId` (`BarcodeId`),
  CONSTRAINT `FK_productbarcodes_barcodes_BarcodeId` FOREIGN KEY (`BarcodeId`) REFERENCES `barcodes` (`BarcodeId`) ON DELETE CASCADE,
  CONSTRAINT `FK_productbarcodes_products_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `products` (`ProductId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productbarcodes`
--

LOCK TABLES `productbarcodes` WRITE;
/*!40000 ALTER TABLE `productbarcodes` DISABLE KEYS */;
INSERT INTO `productbarcodes` VALUES (1,1,'453543'),(2,2,'567567'),(3,3,'324523425');
/*!40000 ALTER TABLE `productbarcodes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productbills`
--

DROP TABLE IF EXISTS `productbills`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productbills` (
  `ProductId` int NOT NULL,
  `BillId` int NOT NULL,
  `QtyPurchased` int NOT NULL,
  `BillItemPrice` double NOT NULL,
  PRIMARY KEY (`ProductId`,`BillId`),
  KEY `IX_productbills_BillId` (`BillId`),
  CONSTRAINT `FK_productbills_bills_BillId` FOREIGN KEY (`BillId`) REFERENCES `bills` (`BillId`) ON DELETE CASCADE,
  CONSTRAINT `FK_productbills_products_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `products` (`ProductId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productbills`
--

LOCK TABLES `productbills` WRITE;
/*!40000 ALTER TABLE `productbills` DISABLE KEYS */;
INSERT INTO `productbills` VALUES (1,4,2,2000),(2,4,1,2500),(3,3,2,5000);
/*!40000 ALTER TABLE `productbills` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productgrns`
--

DROP TABLE IF EXISTS `productgrns`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productgrns` (
  `GrnId` int NOT NULL,
  `ProductId` int NOT NULL,
  `StockAtPurchaseTime` int NOT NULL,
  `ProductItemQty` int DEFAULT NULL,
  `ProductItemCost` double DEFAULT NULL,
  PRIMARY KEY (`ProductId`,`GrnId`),
  KEY `IX_productgrns_GrnId` (`GrnId`),
  CONSTRAINT `FK_productgrns_grns_GrnId` FOREIGN KEY (`GrnId`) REFERENCES `grns` (`GrnId`) ON DELETE CASCADE,
  CONSTRAINT `FK_productgrns_products_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `products` (`ProductId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productgrns`
--

LOCK TABLES `productgrns` WRITE;
/*!40000 ALTER TABLE `productgrns` DISABLE KEYS */;
INSERT INTO `productgrns` VALUES (1,1,0,10,1200),(1,2,0,30,1500),(1,3,0,20,3000);
/*!40000 ALTER TABLE `productgrns` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productholds`
--

DROP TABLE IF EXISTS `productholds`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productholds` (
  `ProductId` int NOT NULL,
  `HoldId` int NOT NULL,
  `QtyPurchased` int NOT NULL,
  `HoldItemPrice` double NOT NULL,
  PRIMARY KEY (`ProductId`,`HoldId`),
  KEY `IX_productholds_HoldId` (`HoldId`),
  CONSTRAINT `FK_productholds_holds_HoldId` FOREIGN KEY (`HoldId`) REFERENCES `holds` (`HoldId`) ON DELETE CASCADE,
  CONSTRAINT `FK_productholds_products_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `products` (`ProductId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productholds`
--

LOCK TABLES `productholds` WRITE;
/*!40000 ALTER TABLE `productholds` DISABLE KEYS */;
/*!40000 ALTER TABLE `productholds` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productopens`
--

DROP TABLE IF EXISTS `productopens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productopens` (
  `OpenId` int NOT NULL,
  `ProductId` int NOT NULL,
  `ProductItemCost` double DEFAULT NULL,
  `ProductItemQty` int DEFAULT NULL,
  PRIMARY KEY (`ProductId`,`OpenId`),
  KEY `IX_productopens_OpenId` (`OpenId`),
  CONSTRAINT `FK_productopens_opens_OpenId` FOREIGN KEY (`OpenId`) REFERENCES `opens` (`OpenId`) ON DELETE CASCADE,
  CONSTRAINT `FK_productopens_products_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `products` (`ProductId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productopens`
--

LOCK TABLES `productopens` WRITE;
/*!40000 ALTER TABLE `productopens` DISABLE KEYS */;
/*!40000 ALTER TABLE `productopens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productprices`
--

DROP TABLE IF EXISTS `productprices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productprices` (
  `ProductId` int NOT NULL,
  `PriceId` int NOT NULL,
  `OldPrice` double NOT NULL,
  `LatestPrice` double NOT NULL,
  `AtThisAverageCost` double NOT NULL,
  `AtStock` int NOT NULL,
  `Status` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`ProductId`,`PriceId`),
  KEY `IX_productprices_PriceId` (`PriceId`),
  CONSTRAINT `FK_productprices_prices_PriceId` FOREIGN KEY (`PriceId`) REFERENCES `prices` (`PriceId`) ON DELETE CASCADE,
  CONSTRAINT `FK_productprices_products_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `products` (`ProductId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productprices`
--

LOCK TABLES `productprices` WRITE;
/*!40000 ALTER TABLE `productprices` DISABLE KEYS */;
INSERT INTO `productprices` VALUES (1,1,0,2000,1200,0,'GID'),(2,1,0,2500,1500,0,'GID'),(3,1,0,5000,3000,0,'GID');
/*!40000 ALTER TABLE `productprices` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `ProductId` int NOT NULL AUTO_INCREMENT,
  `ProductCode` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `ProductCaption` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductDateCreated` datetime(6) NOT NULL,
  `CategoryId` int DEFAULT NULL,
  `BrandId` int DEFAULT NULL,
  `TaxId` int DEFAULT NULL,
  `UserId` int DEFAULT NULL,
  `LogId` int DEFAULT NULL,
  PRIMARY KEY (`ProductId`),
  KEY `IX_products_BrandId` (`BrandId`),
  KEY `IX_products_CategoryId` (`CategoryId`),
  KEY `IX_products_LogId` (`LogId`),
  KEY `IX_products_TaxId` (`TaxId`),
  KEY `IX_products_UserId` (`UserId`),
  CONSTRAINT `FK_products_brands_BrandId` FOREIGN KEY (`BrandId`) REFERENCES `brands` (`BrandId`),
  CONSTRAINT `FK_products_categories_CategoryId` FOREIGN KEY (`CategoryId`) REFERENCES `categories` (`CategoryId`),
  CONSTRAINT `FK_products_logs_LogId` FOREIGN KEY (`LogId`) REFERENCES `logs` (`LogId`),
  CONSTRAINT `FK_products_taxes_TaxId` FOREIGN KEY (`TaxId`) REFERENCES `taxes` (`TaxId`),
  CONSTRAINT `FK_products_users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'PID','Safari Kubwa','2022-11-19 15:39:48.214927',1,1,1,1,NULL),(2,'PID','safari ndogo','2022-11-19 15:40:09.901039',1,1,1,1,NULL),(3,'PID','Mini K-Vant','2022-11-19 15:40:43.203982',4,3,1,1,NULL);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `specs`
--

DROP TABLE IF EXISTS `specs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `specs` (
  `SpecsId` int NOT NULL AUTO_INCREMENT,
  `SpecsCode` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Ram` int DEFAULT NULL,
  `Processor` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `StorageSize` int DEFAULT NULL,
  `StorageType` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `SimCardSlots` int DEFAULT NULL,
  `DisplayTypeSize` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Bluetooth` tinyint(1) NOT NULL,
  `WiFi` tinyint(1) NOT NULL,
  `MemoryCard` tinyint(1) NOT NULL,
  `CableType` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `CableLength` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Os` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `SpecsDescription` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `ProductId` int NOT NULL,
  PRIMARY KEY (`SpecsId`),
  UNIQUE KEY `IX_specs_ProductId` (`ProductId`),
  CONSTRAINT `FK_specs_products_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `products` (`ProductId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `specs`
--

LOCK TABLES `specs` WRITE;
/*!40000 ALTER TABLE `specs` DISABLE KEYS */;
INSERT INTO `specs` VALUES (1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,0,0,NULL,NULL,NULL,'safari kubwa',1),(2,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,0,0,NULL,NULL,NULL,'mini safari',2),(3,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,0,0,NULL,NULL,NULL,'350 mlkvant',3);
/*!40000 ALTER TABLE `specs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stockadjustmentproducts`
--

DROP TABLE IF EXISTS `stockadjustmentproducts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stockadjustmentproducts` (
  `StockAdjustmentId` int NOT NULL,
  `ProductId` int NOT NULL,
  `StockAtAdjustmentTime` int NOT NULL,
  `QtyAdjusted` int NOT NULL,
  `CostAtAdjustmentTime` double NOT NULL,
  `RetailAtAdjustmentTime` double NOT NULL,
  PRIMARY KEY (`StockAdjustmentId`,`ProductId`),
  KEY `IX_stockadjustmentproducts_ProductId` (`ProductId`),
  CONSTRAINT `FK_stockadjustmentproducts_products_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `products` (`ProductId`) ON DELETE CASCADE,
  CONSTRAINT `FK_stockadjustmentproducts_stockadjustments_StockAdjustmentId` FOREIGN KEY (`StockAdjustmentId`) REFERENCES `stockadjustments` (`StockAdjustmentId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stockadjustmentproducts`
--

LOCK TABLES `stockadjustmentproducts` WRITE;
/*!40000 ALTER TABLE `stockadjustmentproducts` DISABLE KEYS */;
/*!40000 ALTER TABLE `stockadjustmentproducts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stockadjustments`
--

DROP TABLE IF EXISTS `stockadjustments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stockadjustments` (
  `StockAdjustmentId` int NOT NULL AUTO_INCREMENT,
  `StockAdjustmentCode` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `StockAdjustmentsReasons` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `DateOfIssue` datetime(6) NOT NULL,
  `UserId` int DEFAULT NULL,
  `LogId` int DEFAULT NULL,
  PRIMARY KEY (`StockAdjustmentId`),
  KEY `IX_stockadjustments_LogId` (`LogId`),
  KEY `IX_stockadjustments_UserId` (`UserId`),
  CONSTRAINT `FK_stockadjustments_logs_LogId` FOREIGN KEY (`LogId`) REFERENCES `logs` (`LogId`),
  CONSTRAINT `FK_stockadjustments_users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stockadjustments`
--

LOCK TABLES `stockadjustments` WRITE;
/*!40000 ALTER TABLE `stockadjustments` DISABLE KEYS */;
/*!40000 ALTER TABLE `stockadjustments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suppliers` (
  `SupplierId` int NOT NULL AUTO_INCREMENT,
  `SupplierCode` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `SupplierName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `SupplierEmail` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `SupplierPhone` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `SupplierTIN` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `SupplierAddress` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `SupplierDescription` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `SupplierDateCreated` datetime(6) NOT NULL,
  `UserId` int DEFAULT NULL,
  `LogId` int DEFAULT NULL,
  PRIMARY KEY (`SupplierId`),
  KEY `IX_suppliers_LogId` (`LogId`),
  KEY `IX_suppliers_UserId` (`UserId`),
  CONSTRAINT `FK_suppliers_logs_LogId` FOREIGN KEY (`LogId`) REFERENCES `logs` (`LogId`),
  CONSTRAINT `FK_suppliers_users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` VALUES (1,'SUP','Dar supplier','info@dar.tz','0742014101','111-2222-333','ilala, dar e salaam','universal supplier','2022-11-19 15:39:07.142114',1,NULL);
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `taxes`
--

DROP TABLE IF EXISTS `taxes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `taxes` (
  `TaxId` int NOT NULL AUTO_INCREMENT,
  `TaxCode` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `TaxCaption` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `TaxValue` double DEFAULT NULL,
  `TaxDescription` varchar(600) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `TaxDateCreated` datetime(6) NOT NULL,
  `UserId` int DEFAULT NULL,
  `LogId` int DEFAULT NULL,
  PRIMARY KEY (`TaxId`),
  KEY `IX_taxes_LogId` (`LogId`),
  KEY `IX_taxes_UserId` (`UserId`),
  CONSTRAINT `FK_taxes_logs_LogId` FOREIGN KEY (`LogId`) REFERENCES `logs` (`LogId`),
  CONSTRAINT `FK_taxes_users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `taxes`
--

LOCK TABLES `taxes` WRITE;
/*!40000 ALTER TABLE `taxes` DISABLE KEYS */;
INSERT INTO `taxes` VALUES (1,'TXID','V.A.T',18,'Universal Tax','2022-11-19 15:34:30.849330',NULL,NULL);
/*!40000 ALTER TABLE `taxes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `UserId` int NOT NULL AUTO_INCREMENT,
  `UserCode` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `UserEmail` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UserPhone` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `UserFirstName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UserLastName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UserAccessLevel` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UserDateCreated` datetime(6) NOT NULL,
  `UserPassword` varchar(18) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UserAddress` varchar(600) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UserStatus` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'USR001','kai@gmaill.com','0742014101','kai','baraza','administrator','2022-11-19 15:29:53.000000','123456789','Kibaha Dar es salaam','active');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'bar'
--

--
-- Dumping routines for database 'bar'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-24 11:47:44
