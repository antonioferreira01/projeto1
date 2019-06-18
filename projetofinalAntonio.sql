-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mydb
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.33-MariaDB

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
-- Table structure for table `carrinho`
--

DROP TABLE IF EXISTS `carrinho`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `carrinho` (
  `idcarrinho` int(11) NOT NULL,
  `nome_produtos` varchar(20) NOT NULL,
  `preco_produtos` float NOT NULL,
  `informacao_utilizador_idinformacao_utilizador` int(11) NOT NULL,
  PRIMARY KEY (`idcarrinho`,`informacao_utilizador_idinformacao_utilizador`),
  KEY `fk_carrinho_informacao_utilizador1_idx` (`informacao_utilizador_idinformacao_utilizador`),
  CONSTRAINT `fk_carrinho_informacao_utilizador1` FOREIGN KEY (`informacao_utilizador_idinformacao_utilizador`) REFERENCES `informacao_utilizador` (`idinformacao_utilizador`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carrinho`
--

LOCK TABLES `carrinho` WRITE;
/*!40000 ALTER TABLE `carrinho` DISABLE KEYS */;
/*!40000 ALTER TABLE `carrinho` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compra`
--

DROP TABLE IF EXISTS `compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `compra` (
  `idcompra` int(11) NOT NULL,
  `nome_produto` varchar(45) NOT NULL,
  `preco_produtos` float NOT NULL,
  `carrinho_idcarrinho` int(11) NOT NULL,
  `promocoes_idpromocoes` int(11) NOT NULL,
  PRIMARY KEY (`idcompra`),
  KEY `fk_compra_carrinho1_idx` (`carrinho_idcarrinho`),
  KEY `fk_compra_promocoes1_idx` (`promocoes_idpromocoes`),
  CONSTRAINT `fk_compra_carrinho1` FOREIGN KEY (`carrinho_idcarrinho`) REFERENCES `carrinho` (`idcarrinho`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_compra_promocoes1` FOREIGN KEY (`promocoes_idpromocoes`) REFERENCES `promocoes` (`idpromocoes`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compra`
--

LOCK TABLES `compra` WRITE;
/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
/*!40000 ALTER TABLE `compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `informacao_utilizador`
--

DROP TABLE IF EXISTS `informacao_utilizador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `informacao_utilizador` (
  `idinformacao_utilizador` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`idinformacao_utilizador`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `informacao_utilizador`
--

LOCK TABLES `informacao_utilizador` WRITE;
/*!40000 ALTER TABLE `informacao_utilizador` DISABLE KEYS */;
INSERT INTO `informacao_utilizador` VALUES (1,'toni','123'),(2,'riki7g','1234'),(3,'asd','123'),(4,'',''),(5,'toni','123'),(6,'andre','123');
/*!40000 ALTER TABLE `informacao_utilizador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produtos` (
  `idprodutos` int(11) NOT NULL,
  `preco_produtos` float NOT NULL,
  `informacao_utilizador_idinformacao_utilizador` int(11) NOT NULL,
  `nome_produtos` varchar(45) NOT NULL,
  `carrinho_idcarrinho` int(11) NOT NULL,
  `promocoes_idpromocoes` int(11) NOT NULL,
  PRIMARY KEY (`idprodutos`,`informacao_utilizador_idinformacao_utilizador`,`carrinho_idcarrinho`,`promocoes_idpromocoes`),
  KEY `fk_produtos_informacao_utilizador_idx` (`informacao_utilizador_idinformacao_utilizador`),
  KEY `fk_produtos_carrinho1_idx` (`carrinho_idcarrinho`),
  KEY `fk_produtos_promocoes1_idx` (`promocoes_idpromocoes`),
  CONSTRAINT `fk_produtos_carrinho1` FOREIGN KEY (`carrinho_idcarrinho`) REFERENCES `carrinho` (`idcarrinho`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_produtos_informacao_utilizador` FOREIGN KEY (`informacao_utilizador_idinformacao_utilizador`) REFERENCES `informacao_utilizador` (`idinformacao_utilizador`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_produtos_promocoes1` FOREIGN KEY (`promocoes_idpromocoes`) REFERENCES `promocoes` (`idpromocoes`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produtos`
--

LOCK TABLES `produtos` WRITE;
/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `promocoes`
--

DROP TABLE IF EXISTS `promocoes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `promocoes` (
  `idpromocoes` int(11) NOT NULL,
  `nome_produto` varchar(45) NOT NULL,
  `preco_produto` float NOT NULL,
  `preco_desconto` float NOT NULL,
  PRIMARY KEY (`idpromocoes`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `promocoes`
--

LOCK TABLES `promocoes` WRITE;
/*!40000 ALTER TABLE `promocoes` DISABLE KEYS */;
/*!40000 ALTER TABLE `promocoes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'mydb'
--

--
-- Dumping routines for database 'mydb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-06-18 11:43:14
