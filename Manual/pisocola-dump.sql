-- MySQL dump 10.13  Distrib 5.5.62, for Win64 (AMD64)
--
-- Host: localhost    Database: pisocola
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.6-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customer` (
  `ID_CUSTOMER` int(11) NOT NULL AUTO_INCREMENT,
  `NM_CUSTOMER` varchar(100) NOT NULL,
  `NM_SOCIAL` varchar(100) NOT NULL,
  `NR_CPF_CNPJ` varchar(19) NOT NULL,
  `NR_INSC` varchar(10) NOT NULL,
  `DS_ADDRESS` varchar(100) NOT NULL,
  `NR_PHONE` varchar(100) DEFAULT NULL,
  `DT_INSERT` datetime DEFAULT NULL,
  PRIMARY KEY (`ID_CUSTOMER`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parameter`
--

DROP TABLE IF EXISTS `parameter`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `parameter` (
  `ID_PARAMETER` int(11) NOT NULL AUTO_INCREMENT,
  `ID_TOPIC` varchar(100) DEFAULT NULL,
  `NM_PARAMETER` varchar(100) DEFAULT NULL,
  `VL_VALUE` varchar(100) DEFAULT NULL,
  `DT_INSERT` datetime DEFAULT NULL,
  PRIMARY KEY (`ID_PARAMETER`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parameter`
--

LOCK TABLES `parameter` WRITE;
/*!40000 ALTER TABLE `parameter` DISABLE KEYS */;
INSERT INTO `parameter` VALUES (1,'CUSTOMER_IMPORT','IMPORT_PATH','K:\\GitHub\\Pisocola\\Pisocola\\Pisocola\\view\\ViewImportCustomer\\imports\\','2021-03-12 23:03:29'),(3,'CUSTOMER_IMPORT_ERROR','NUMBER_OF_COLUMNS_ERROR','O número de colunas está incorreto. O arquivo deve conter apenas 6 colunas','2021-03-15 02:13:52'),(4,'CUSTOMER_IMPORT_ERROR','NR_CPF_CNPJ_FORMAT_ERROR','A formatação do CPF/CNPJ está errada!','2021-03-15 02:13:53'),(5,'CUSTOMER_IMPORT_ERROR','NR_PHONE_FORMAT_ERROR','A formatação do Número de Telefone está errada!','2021-03-15 02:13:54'),(6,'CUSTOMER_IMPORT_ERROR','NR_INSC_FORMAT_ERROR','A formatação do Número de Inscrição está errada!','2021-03-15 02:13:55'),(7,'CUSTOMER_IMPORT_ERROR','NR_CPF_CNPJ_EXISTS_ERROR','O CPF/CNPJ já está cadastrado!','2021-03-15 18:19:29');
/*!40000 ALTER TABLE `parameter` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'pisocola'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-03-15 19:29:31
