-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: rental_appliances
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
-- Table structure for table `tbladmin`
--

DROP TABLE IF EXISTS `tbladmin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbladmin` (
  `adminName` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `adminPassword` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbladmin`
--

LOCK TABLES `tbladmin` WRITE;
/*!40000 ALTER TABLE `tbladmin` DISABLE KEYS */;
INSERT INTO `tbladmin` VALUES ('Admin','Admin123');
/*!40000 ALTER TABLE `tbladmin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblappliance`
--

DROP TABLE IF EXISTS `tblappliance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblappliance` (
  `brand` varchar(20) DEFAULT NULL,
  `type` varchar(20) DEFAULT NULL,
  `model` varchar(20) DEFAULT NULL,
  `dimensions` varchar(20) DEFAULT NULL,
  `colour` varchar(20) DEFAULT NULL,
  `energy_consumption` varchar(20) DEFAULT NULL,
  `monthly_fee` int DEFAULT NULL,
  `appliancesId` int NOT NULL,
  PRIMARY KEY (`appliancesId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblappliance`
--

LOCK TABLES `tblappliance` WRITE;
/*!40000 ALTER TABLE `tblappliance` DISABLE KEYS */;
INSERT INTO `tblappliance` VALUES (' Hitachi','Smart TV','55HL5W69','54 inches','Black','0.5kW',150,1),('Amazon Fire TVs','Smart TV','2-Series','32 inches','Black','0.8kW',100,2),('Hisense','Smart TV','32A4GS','32 inches','Black','0.7kW',120,3),('LG','Smart TV','LM56','32 inches','Black','0.6kW',150,4),('Panasonic','Smart TV','TX-43JS360B','43 inches','Black','0.5kW',180,5),('Philis','Smart TV','43PUL7672 ','43 inches','Black','0.3kW',130,6),('Samsung','Smart TV','43CUE70AK ','43 inches','PurColour','0.5kW',100,7),('Sony','Smart TV','XR-65A95L','55 inches','Black','0.5kW',150,8),('TCL','Smart TV','CLASS 4-SERIES','55 inches','Black','0.5kW',120,9),('Toshiba','Smart TV','32V35KP','32 inches','Black','0.5kW',120,10),('Samsung','Refrigerator','RT39C5531S8','3.5 Inches','Elegant','17kW',200,11),('LG','Refrigerator','LRFLC2706S','3.5 Inches','Black','18kW',200,12),('Hitachi','Refrigerator','RWX670KA','4 Inches','Crystal White','16.7kW',200,13),('GE','Refrigerator','PVD28BYNFS','4 Feet','Black','16.7kW',150,14),('Samsung','Refrigerator','RF28R7201SR','4 Feet','White','19kW',200,15),('Samsung','Refrigerator','RF27T5201SR','4 Feet','Grey','18kW',160,16),('Frigidaire','Refrigerator','FFTR1835VS','4 Feet','Black','17.5kW',170,17),('Magic Chef','Refrigerator','MCDR1000WE','4 Feet','Grey','16.7kW',150,18),('Whirlpool','Refrigerator','WRX735SDHZ','4 Feet','White','16.7kW',130,19),('Sub-Zero','Refrigerator','BI36RO','4 Feet','Grey','16.7kW',210,20),('Sub-Zero','Refrigerator','IT36CIID','4 Feet','Black','16.7kW',150,21),('Samsung','Washing Machine','WW60R20GLMA','3 Feet','Black','1.4kW',150,22),('Samsung','Washing Machine','WA70A4002GS','3 Feet','Grey','1.4kW',160,23),('LG','Washing Machine','T65SKSF4Z','3 Feet','White','1.5kW',210,24),('Bosch','Washing Machine','WAJ2416SIN','3 Feet','Grey','2kW',130,25),('Whirlpool','Washing Machine','WHITEMAGIC ','3 Feet','White','1.8kW',140,26),('Godrej','Washing Machine','WT EON 620 A GP GR','3 Feet','Black','1.6kW',180,27),('IFB','Washing Machine','NEO DIVA BXS 7010','3 Feet','White','1.4kW',230,28),('Havells','Washing Machine','LWMS75RA1 ','3 Feet','Grey','1.4kW',220,29),('panasonic','Washing Machine','NA-F60LF1HRB','3 Feet','Black','1.4kW',320,30),('Haier','Washing Machine','HWM65-187BO','3 Feet','Grey','1.4kW',150,31),('LG','Dishwasher','QuadWash','35 Inches','Black','1.3kW',60,32),('Bosch','Dishwasher','SMS66GI01I ','35 Inches','White','1.5kW',70,33),('IFB','Dishwasher','Neptune VX','35 Inches','White','1.25kW',90,34),('Voltas','Dishwasher','DF14W','35 Inches','Black','1.3kW',100,35),('LG','Dishwasher','DFB424FP ','35 Inches','Black','1.1kW',50,36),('Siemens','Dishwasher','SN256W01GI','35 Inches','Grey','1.2kW',80,37),('Faber','Dishwasher','12 Place','35 Inches','Grey','1.2kW',45,38),('Kaff','Dishwasher','VETRA ','35 Inches','Black','1.2kW',34,39),('Hindware','Dishwasher','Calico ','35 Inches','White','1.2kW',80,40),('Samsung','Dishwasher','13 Place','35 Inches','Grey','1.2kW',60,41),('IFB','Microwave','30 L','24 Inches','Black','500W',80,42),('Philips','Microwave','HD6975/00','24 Inches','Grey','400W',50,43),('Bajaj','Microwave','1702MT','24 Inches','White','550W',60,44),('Bajaj','Microwave','1702MT','24 Inches','Black','450W',45,45),('Morphy','Microwave','Richards 27L','24 Inches','White ','300W',70,46),('Morphy','Microwave','Richards 25L','24 Inches','Grey','250W',65,47),('Morphy','Microwave','Richards 20L','24 Inches','Grey','400W',55,48),('LG','Microwave','28 L','24 Inches','White','600W',90,49),('Samsung','Microwave','32L','24 Inches','Black','600W',60,50),('Panasonic ','Microwave','27L','24 Inches','White','600W',70,51),('Lifelong','Microwave','LLOT38','24 Inches','Black','350W',75,52);
/*!40000 ALTER TABLE `tblappliance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblusers`
--

DROP TABLE IF EXISTS `tblusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblusers` (
  `userName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `password` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `phone` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `address` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblusers`
--

LOCK TABLES `tblusers` WRITE;
/*!40000 ALTER TABLE `tblusers` DISABLE KEYS */;
INSERT INTO `tblusers` VALUES ('AyeAye','Aye12345','0326598742','Yangon'),('MyaMya','Mya12345','0978546632','Mandalay'),('SuSu','Su123456','0923569874','Yangon'),('User','User1234567','032569877445','Chin'),('User2','User23456','03265987125','England'),('David','David12345','0235789644125','New York'),('User3','User34567','0265897451','New York');
/*!40000 ALTER TABLE `tblusers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-10-30  0:49:58
