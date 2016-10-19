CREATE DATABASE  IF NOT EXISTS `laboratorio` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `laboratorio`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: laboratorio
-- ------------------------------------------------------
-- Server version	5.7.11-log

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
-- Table structure for table `alumno`
--

DROP TABLE IF EXISTS `alumno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alumno` (
  `NumeroControl` varchar(8) NOT NULL,
  `Nombres` varchar(50) NOT NULL,
  `ApellidoPaterno` varchar(40) NOT NULL,
  `ApellidoMaterno` varchar(40) NOT NULL,
  `CarreraId` int(11) NOT NULL,
  PRIMARY KEY (`NumeroControl`),
  KEY `Alumno_Carrera_idx` (`CarreraId`),
  CONSTRAINT `Alumno_Carrera` FOREIGN KEY (`CarreraId`) REFERENCES `carrera` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alumno`
--

LOCK TABLES `alumno` WRITE;
/*!40000 ALTER TABLE `alumno` DISABLE KEYS */;
INSERT INTO `alumno` VALUES ('125T0522','Rocío Izamar','Coronado','Vázquez',1),('135T0664','Andrés','De León','Ortiz',1),('135T0670','Daniel Eduardo','González','Coronado',1),('135T0671','Luis Gerardo','Guajardo','González',1),('135T0672','Juan Alberto','Hernández ','López',1),('145T0076','María Julissa','Aguilar','Quezada',1),('145T0081','Sofía Patricia','Garduño','Pérez',1),('145T0083','Martha Alicia','Herrera','Alonso',1),('145T0145','Jorge','Cervantes','Rosales',1);
/*!40000 ALTER TABLE `alumno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `carrera`
--

DROP TABLE IF EXISTS `carrera`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `carrera` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(80) NOT NULL,
  `NombreCorto` varchar(40) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carrera`
--

LOCK TABLES `carrera` WRITE;
/*!40000 ALTER TABLE `carrera` DISABLE KEYS */;
INSERT INTO `carrera` VALUES (1,'Ingeniería en Tecnologías de la Información y Comunicaciones','Ing. en TICs'),(2,'Ingeniería en Gestión Empresarial','Ing. en Gestión'),(3,'Ingeniería Ambiental','Ing. Ambiental'),(4,'Ingeniería Hidrológica','Ing. Hidrológica');
/*!40000 ALTER TABLE `carrera` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Descripcion` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `docente`
--

DROP TABLE IF EXISTS `docente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `docente` (
  `NumeroEmpleado` int(11) NOT NULL,
  `Nombres` varchar(50) NOT NULL,
  `ApellidoPaterno` varchar(40) NOT NULL,
  `ApellidoMaterno` varchar(40) NOT NULL,
  PRIMARY KEY (`NumeroEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `docente`
--

LOCK TABLES `docente` WRITE;
/*!40000 ALTER TABLE `docente` DISABLE KEYS */;
/*!40000 ALTER TABLE `docente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estadomaterial`
--

DROP TABLE IF EXISTS `estadomaterial`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estadomaterial` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(25) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estadomaterial`
--

LOCK TABLES `estadomaterial` WRITE;
/*!40000 ALTER TABLE `estadomaterial` DISABLE KEYS */;
/*!40000 ALTER TABLE `estadomaterial` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estadoprestamo`
--

DROP TABLE IF EXISTS `estadoprestamo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estadoprestamo` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(25) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estadoprestamo`
--

LOCK TABLES `estadoprestamo` WRITE;
/*!40000 ALTER TABLE `estadoprestamo` DISABLE KEYS */;
/*!40000 ALTER TABLE `estadoprestamo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `material`
--

DROP TABLE IF EXISTS `material`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `material` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Descripcion` varchar(100) DEFAULT NULL,
  `CategoriaId` int(11) NOT NULL,
  `Imagen` blob,
  PRIMARY KEY (`Id`),
  KEY `Material_Categoria_idx` (`CategoriaId`),
  CONSTRAINT `Material_Categoria` FOREIGN KEY (`CategoriaId`) REFERENCES `categoria` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `material`
--

LOCK TABLES `material` WRITE;
/*!40000 ALTER TABLE `material` DISABLE KEYS */;
/*!40000 ALTER TABLE `material` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prestamo`
--

DROP TABLE IF EXISTS `prestamo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prestamo` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` datetime NOT NULL,
  `AlumnoId` varchar(8) DEFAULT NULL,
  `DocenteId` int(11) DEFAULT NULL,
  `EstadoPrestamoId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `Prestamo_Alumno_idx` (`AlumnoId`),
  KEY `Prestamo_Docente_idx` (`DocenteId`),
  KEY `Prestamo_EstadoPrestamo_idx` (`EstadoPrestamoId`),
  CONSTRAINT `Prestamo_Alumno` FOREIGN KEY (`AlumnoId`) REFERENCES `alumno` (`NumeroControl`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Prestamo_Docente` FOREIGN KEY (`DocenteId`) REFERENCES `docente` (`NumeroEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Prestamo_EstadoPrestamo` FOREIGN KEY (`EstadoPrestamoId`) REFERENCES `estadoprestamo` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prestamo`
--

LOCK TABLES `prestamo` WRITE;
/*!40000 ALTER TABLE `prestamo` DISABLE KEYS */;
/*!40000 ALTER TABLE `prestamo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prestamomaterial`
--

DROP TABLE IF EXISTS `prestamomaterial`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prestamomaterial` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `FechaEntrega` datetime NOT NULL,
  `EstadoMaterialPrestamoId` int(11) NOT NULL,
  `EstadoMaterialEntregaId` int(11) NOT NULL,
  `MaterialId` int(11) NOT NULL,
  `Observaciones` text,
  `PrestamoId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Prestamo_Material_idx` (`MaterialId`),
  KEY `Prestamo_EstadoEntrega_idx` (`EstadoMaterialEntregaId`),
  KEY `Prestamo_EstadoPrestamoId_idx` (`EstadoMaterialPrestamoId`),
  KEY `Prestamo_idx` (`PrestamoId`),
  CONSTRAINT `Prestamo` FOREIGN KEY (`PrestamoId`) REFERENCES `prestamo` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Prestamo_EstadoEntrega` FOREIGN KEY (`EstadoMaterialEntregaId`) REFERENCES `estadomaterial` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Prestamo_EstadoPrestamoId` FOREIGN KEY (`EstadoMaterialPrestamoId`) REFERENCES `estadomaterial` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Prestamo_Material` FOREIGN KEY (`MaterialId`) REFERENCES `material` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prestamomaterial`
--

LOCK TABLES `prestamomaterial` WRITE;
/*!40000 ALTER TABLE `prestamomaterial` DISABLE KEYS */;
/*!40000 ALTER TABLE `prestamomaterial` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-10-19  8:54:59
