-- MySQL dump 10.13  Distrib 8.0.15, for Win64 (x86_64)
--
-- Host: localhost    Database: db_blog
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_artigo`
--

DROP TABLE IF EXISTS `tbl_artigo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_artigo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `permalink` text NOT NULL,
  `texto` text NOT NULL,
  `titulo` varchar(255) NOT NULL,
  `subtitulo` varchar(255) DEFAULT NULL,
  `dtPublicacao` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `dtEdicao` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `autor` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_idUsuario_tblArtigo_idx` (`autor`),
  CONSTRAINT `fk_idUsuario_tblArtigo` FOREIGN KEY (`autor`) REFERENCES `tbl_usuario` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_artigo`
--

LOCK TABLES `tbl_artigo` WRITE;
/*!40000 ALTER TABLE `tbl_artigo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_artigo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_comentario`
--

DROP TABLE IF EXISTS `tbl_comentario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_comentario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `texto` text NOT NULL,
  `autor` int(11) NOT NULL,
  `artigo` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_idUsuario_tblComentario_idx` (`autor`),
  KEY `fk_permalink_tblComentario_idx` (`artigo`),
  CONSTRAINT `fk_idUsuario_tblComentario` FOREIGN KEY (`autor`) REFERENCES `tbl_usuario` (`id`),
  CONSTRAINT `fk_permalink_tblComentario` FOREIGN KEY (`artigo`) REFERENCES `tbl_artigo` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_comentario`
--

LOCK TABLES `tbl_comentario` WRITE;
/*!40000 ALTER TABLE `tbl_comentario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_comentario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_usuario`
--

DROP TABLE IF EXISTS `tbl_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_usuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(255) NOT NULL,
  `senha` varchar(255) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `desc` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_usuario`
--

LOCK TABLES `tbl_usuario` WRITE;
/*!40000 ALTER TABLE `tbl_usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'db_blog'
--

--
-- Dumping routines for database 'db_blog'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-08-06  1:28:31
