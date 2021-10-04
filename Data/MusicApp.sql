-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: prolab
-- ------------------------------------------------------
-- Server version	8.0.23

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
-- Table structure for table `album`
--

DROP TABLE IF EXISTS `album`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `album` (
  `albumidd` varchar(45) NOT NULL,
  `albumad` varchar(45) DEFAULT NULL,
  `sanatciad` varchar(45) DEFAULT NULL,
  `tarih` varchar(45) DEFAULT NULL,
  `tur` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`albumidd`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `album`
--

LOCK TABLES `album` WRITE;
/*!40000 ALTER TABLE `album` DISABLE KEYS */;
INSERT INTO `album` VALUES ('1','Rapstar','Ceza','2004.07.12','Pop'),('10','19','Kahraman Deniz ','2018.06.29','Jazz'),('2','Darmaduman','Duman','2013.05.28','Pop'),('3','Biraz Ayrılık','Gökhan Türkmen','2013.12.04','Classic'),('4','Seni Kendime Sakladım','Duman','2012.01.26','Pop'),('5','Güneşi Beklerken','Mor ve Ötesi','2014.03.04','Jazz'),('6','Yaramızda Kalsın','Onur Can Özcan','2016.09.20','Classic'),('7','Bela','Elanur','2019.07.21','Pop'),('8','The Best of MFÖ','MFÖ','2016.02.02','Jazz'),('9','Beni Kendinden Kurtar','Perdenin Ardındakiler','2019.10.04','Classic');
/*!40000 ALTER TABLE `album` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fk1`
--

DROP TABLE IF EXISTS `fk1`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fk1` (
  `albumid` varchar(45) NOT NULL,
  `sarkiid` varchar(45) NOT NULL,
  `sanatciid` varchar(45) NOT NULL,
  PRIMARY KEY (`albumid`,`sarkiid`,`sanatciid`),
  KEY `sarkiid` (`sarkiid`),
  KEY `sanatciid` (`sanatciid`),
  CONSTRAINT `fk1_ibfk_1` FOREIGN KEY (`albumid`) REFERENCES `album` (`albumidd`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fk1`
--

LOCK TABLES `fk1` WRITE;
/*!40000 ALTER TABLE `fk1` DISABLE KEYS */;
/*!40000 ALTER TABLE `fk1` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fk2`
--

DROP TABLE IF EXISTS `fk2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fk2` (
  `sarkiid` varchar(45) NOT NULL,
  `sanatciad` varchar(45) NOT NULL,
  PRIMARY KEY (`sarkiid`,`sanatciad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fk2`
--

LOCK TABLES `fk2` WRITE;
/*!40000 ALTER TABLE `fk2` DISABLE KEYS */;
/*!40000 ALTER TABLE `fk2` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fktakip`
--

DROP TABLE IF EXISTS `fktakip`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fktakip` (
  `C1` text,
  `C2` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fktakip`
--

LOCK TABLES `fktakip` WRITE;
/*!40000 ALTER TABLE `fktakip` DISABLE KEYS */;
INSERT INTO `fktakip` VALUES ('-- MySQL dump 10.13  Distrib 8.0.23',' for Win64 (x86_64)'),('/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS',' UNIQUE_CHECKS=0 */;'),('/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS',' FOREIGN_KEY_CHECKS=0 */;'),('/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE',' SQL_MODE=\'NO_AUTO_VALUE_ON_ZERO\' */;'),('/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES',' SQL_NOTES=0 */;'),('  `id` int NOT NULL',NULL),('  `takipciad` varchar(45) NOT NULL',NULL);
/*!40000 ALTER TABLE `fktakip` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fktakip2`
--

DROP TABLE IF EXISTS `fktakip2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fktakip2` (
  `C1` text,
  `C2` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fktakip2`
--

LOCK TABLES `fktakip2` WRITE;
/*!40000 ALTER TABLE `fktakip2` DISABLE KEYS */;
INSERT INTO `fktakip2` VALUES ('-- MySQL dump 10.13  Distrib 8.0.23',' for Win64 (x86_64)'),('/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS',' UNIQUE_CHECKS=0 */;'),('/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS',' FOREIGN_KEY_CHECKS=0 */;'),('/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE',' SQL_MODE=\'NO_AUTO_VALUE_ON_ZERO\' */;'),('/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES',' SQL_NOTES=0 */;'),('  `id` int NOT NULL',NULL),('  `takipedilen_ad` varchar(45) NOT NULL',NULL);
/*!40000 ALTER TABLE `fktakip2` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kullanicilar`
--

DROP TABLE IF EXISTS `kullanicilar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kullanicilar` (
  `kullaniciId` int NOT NULL AUTO_INCREMENT,
  `kullaniciAdi` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `sifre` varchar(45) NOT NULL,
  `abonelik` varchar(45) NOT NULL,
  `ulke` varchar(45) NOT NULL,
  `odendi` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`kullaniciId`),
  UNIQUE KEY `kullanicilar_email_uindex` (`email`),
  UNIQUE KEY `kullanicilar_kullaniciAdi_uindex` (`kullaniciAdi`),
  UNIQUE KEY `kullanicilar_kullaniciId_uindex` (`kullaniciId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kullanicilar`
--

LOCK TABLES `kullanicilar` WRITE;
/*!40000 ALTER TABLE `kullanicilar` DISABLE KEYS */;
INSERT INTO `kullanicilar` VALUES (1,'Berkay','berkay@gmail.com','1234','normal','Türkiye',0),(2,'Rakibe','rakibe@gmail.com','321','premium','Türkiye',1),(3,'Ferhat','ferhat@gmail.com','456','premium','Türkiye',1);
/*!40000 ALTER TABLE `kullanicilar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `playlistdata`
--

DROP TABLE IF EXISTS `playlistdata`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `playlistdata` (
  `dataid` int NOT NULL AUTO_INCREMENT,
  `kullaniciId` int NOT NULL,
  `sarkiid` int NOT NULL,
  `tur` varchar(45) NOT NULL,
  PRIMARY KEY (`dataid`),
  KEY `playlistdata_kullanicilar_kullaniciId_fk` (`kullaniciId`),
  KEY `playlistdata_sarki_sarkiid_fk` (`sarkiid`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `playlistdata`
--

LOCK TABLES `playlistdata` WRITE;
/*!40000 ALTER TABLE `playlistdata` DISABLE KEYS */;
INSERT INTO `playlistdata` VALUES (1,1,1,'Pop'),(2,1,2,'Pop'),(3,1,3,'Classic'),(4,1,4,'Classic'),(5,1,6,'Jazz'),(6,1,7,'Classic'),(7,1,8,'Jazz'),(8,1,9,'Jazz'),(9,2,5,'Pop'),(10,2,10,'Pop'),(11,2,11,'Jazz'),(12,2,3,'Classic'),(13,2,7,'Classic'),(14,2,9,'Jazz'),(15,2,1,'Pop'),(16,2,4,'Classic'),(17,3,4,'Classic'),(18,3,5,'Pop'),(19,3,6,'Jazz'),(20,3,7,'Classic'),(21,3,8,'Jazz'),(22,3,9,'Jazz'),(23,3,2,'Pop'),(24,3,10,'Pop');
/*!40000 ALTER TABLE `playlistdata` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `playlistrecords`
--

DROP TABLE IF EXISTS `playlistrecords`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `playlistrecords` (
  `id` int NOT NULL AUTO_INCREMENT,
  `playlistid` int NOT NULL,
  `sarkiid` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `playlistrecords_id_uindex` (`id`),
  KEY `playlistrecords_playlists_playlistid_fk` (`playlistid`),
  KEY `playlistrecords_sarki_sarkiid_fk` (`sarkiid`),
  CONSTRAINT `playlistrecords_playlists_playlistid_fk` FOREIGN KEY (`playlistid`) REFERENCES `playlists` (`playlistid`),
  CONSTRAINT `playlistrecords_sarki_sarkiid_fk` FOREIGN KEY (`sarkiid`) REFERENCES `sarki` (`sarkiid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `playlistrecords`
--

LOCK TABLES `playlistrecords` WRITE;
/*!40000 ALTER TABLE `playlistrecords` DISABLE KEYS */;
/*!40000 ALTER TABLE `playlistrecords` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `playlists`
--

DROP TABLE IF EXISTS `playlists`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `playlists` (
  `playlistid` int NOT NULL AUTO_INCREMENT,
  `playlistname` varchar(100) NOT NULL,
  `kullaniciId` int NOT NULL,
  `tur` varchar(30) NOT NULL,
  PRIMARY KEY (`playlistid`),
  UNIQUE KEY `playlists_playlistid_uindex` (`playlistid`),
  KEY `playlists_kullanicilar_kullaniciId_fk` (`kullaniciId`),
  CONSTRAINT `playlists_kullanicilar_kullaniciId_fk` FOREIGN KEY (`kullaniciId`) REFERENCES `kullanicilar` (`kullaniciId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `playlists`
--

LOCK TABLES `playlists` WRITE;
/*!40000 ALTER TABLE `playlists` DISABLE KEYS */;
/*!40000 ALTER TABLE `playlists` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sanatci`
--

DROP TABLE IF EXISTS `sanatci`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sanatci` (
  `sanatciid` int NOT NULL,
  `sanatciad` varchar(45) DEFAULT NULL,
  `ulke` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`sanatciid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sanatci`
--

LOCK TABLES `sanatci` WRITE;
/*!40000 ALTER TABLE `sanatci` DISABLE KEYS */;
INSERT INTO `sanatci` VALUES (1,'Ceza','Türkiye'),(2,'Duman','Türkiye'),(3,'Gökhan Türkmen','Türkiye'),(4,'Onur Can Özcan','Türkiye'),(5,'Elanur','Yunanistan'),(6,'MFÖ','Türkiye'),(7,'Kahraman Deniz ','Türkiye'),(8,'Mor ve Ötesi','Türkiye'),(9,'Perdenin Ardındakiler','Türkiye');
/*!40000 ALTER TABLE `sanatci` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sarki`
--

DROP TABLE IF EXISTS `sarki`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sarki` (
  `sarkiid` varchar(45) NOT NULL,
  `sarkiad` varchar(45) DEFAULT NULL,
  `tarih` varchar(45) DEFAULT NULL,
  `sanatciid` varchar(45) NOT NULL,
  `albumad` varchar(45) DEFAULT NULL,
  `tur` varchar(45) DEFAULT NULL,
  `sure` varchar(45) DEFAULT NULL,
  `dinlenmesayisi` int DEFAULT NULL,
  PRIMARY KEY (`sarkiid`,`sanatciid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sarki`
--

LOCK TABLES `sarki` WRITE;
/*!40000 ALTER TABLE `sarki` DISABLE KEYS */;
INSERT INTO `sarki` VALUES ('1','Rapstar','2004.07.12','1','Rapstar','Pop','01:45',5),('10','Aman Aman','2012.01.26','2','Seni Kendime Sakladım','Pop','04:05',42),('11','Oyunbozan','2014.03.04','8','Güneşi Beklerken','Jazz','04:37',22),('12','Rakibenin Cocugu','2021.05.31','1','Rakibe','Pop','04:04',99),('2','Eyvallah','2013.05.28','2','Darmaduman','Pop','04:49',4),('3','Yüreğim','2013.12.04','3','Biraz Ayrılık','Classic','05:08',12),('4','İntihaşk','2016.09.20','4','Yaramızda Kalsın','Classic','03:12',16),('5','Bela','2019.07.21','5','Bela','Pop','02:07',47),('6','Ele Güne Karşı Yapayalnız','2016.02.02','6','The Best of MFÖ','Jazz','03:09',3),('7','Beni Kendinden Kurtar','2019.10.04','9','Beni Kendinden Kurtar','Classic','03:26',22),('8','Suç Mahalli ','2018.06.29','7','19','Jazz','04:16',47),('9','Böyle Sever','2018.06.29','7','19','Jazz','04:07',70);
/*!40000 ALTER TABLE `sarki` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `takip`
--

DROP TABLE IF EXISTS `takip`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `takip` (
  `C1` text,
  `C2` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `takip`
--

LOCK TABLES `takip` WRITE;
/*!40000 ALTER TABLE `takip` DISABLE KEYS */;
INSERT INTO `takip` VALUES ('-- MySQL dump 10.13  Distrib 8.0.23',' for Win64 (x86_64)'),('/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS',' UNIQUE_CHECKS=0 */;'),('/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS',' FOREIGN_KEY_CHECKS=0 */;'),('/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE',' SQL_MODE=\'NO_AUTO_VALUE_ON_ZERO\' */;'),('/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES',' SQL_NOTES=0 */;'),('  `id` int NOT NULL AUTO_INCREMENT',NULL),('  `takip_eden_id` int NOT NULL',NULL),('  `takip_edilen_id` int NOT NULL',NULL);
/*!40000 ALTER TABLE `takip` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-07  0:39:58
