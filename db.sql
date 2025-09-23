/*
SQLyog Job Agent v10.42 Copyright(c) Webyog Inc. All Rights Reserved.


MySQL - 8.3.0 : Database - drones
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`drones` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `drones`;

/*Table structure for table `tbl_aircraft` */

DROP TABLE IF EXISTS `tbl_aircraft`;

CREATE TABLE `tbl_aircraft` (
  `aircraft_id` int DEFAULT NULL,
  `aircraft_type` varchar(100) NOT NULL,
  `aircraft_number` varchar(100) NOT NULL,
  `aircraft_summary` text,
  `aircraft_maximum_flying_hours` int DEFAULT '0',
  `aircraft_is_active` tinyint unsigned DEFAULT '1',
  `id` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tbl_aircraft` */

insert  into `tbl_aircraft` values (1,'7887','979','556',100,1,2);

/*Table structure for table `tbl_aircrafts` */

DROP TABLE IF EXISTS `tbl_aircrafts`;

CREATE TABLE `tbl_aircrafts` (
  `aircraft_id` int NOT NULL AUTO_INCREMENT,
  `aircraft_name` varchar(100) NOT NULL,
  `aircraft_type` varchar(100) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`aircraft_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tbl_aircrafts` */

/*Table structure for table `tbl_commanders` */

DROP TABLE IF EXISTS `tbl_commanders`;

CREATE TABLE `tbl_commanders` (
  `commander_id` int NOT NULL AUTO_INCREMENT,
  `commander_name` varchar(150) NOT NULL,
  PRIMARY KEY (`commander_id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tbl_commanders` */

insert  into `tbl_commanders` values (1,'ali');

/*Table structure for table `tbl_fixing` */

DROP TABLE IF EXISTS `tbl_fixing`;

CREATE TABLE `tbl_fixing` (
  `fixing_id` int NOT NULL AUTO_INCREMENT,
  `aircraft_id` int DEFAULT NULL,
  `part_id` int DEFAULT NULL,
  `fixing_date` date DEFAULT NULL,
  `fixing_details` text,
  PRIMARY KEY (`fixing_id`),
  KEY `aircraft_id` (`aircraft_id`),
  KEY `part_id` (`part_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tbl_fixing` */

/*Table structure for table `tbl_flights` */

DROP TABLE IF EXISTS `tbl_flights`;

CREATE TABLE `tbl_flights` (
  `flight_id` int NOT NULL AUTO_INCREMENT,
  `flight_aircraft_type` varchar(100) DEFAULT NULL,
  `flight_aircraft_number` varchar(100) DEFAULT NULL,
  `flight_number` varchar(50) NOT NULL,
  `flight_commander` varchar(150) DEFAULT NULL,
  `flight_pilot` varchar(150) DEFAULT NULL,
  `flight_date` date DEFAULT NULL,
  `flight_depatrue_time` time DEFAULT NULL,
  `flight_arrival_time` time DEFAULT NULL,
  `flight_duration` varchar(50) DEFAULT NULL,
  `flight_frther_range` varchar(50) DEFAULT NULL,
  `flight_max_height` varchar(50) DEFAULT NULL,
  `flight_landing_no` varchar(50) DEFAULT NULL,
  `flight_location` varchar(150) DEFAULT NULL,
  `flight_temperature` varchar(50) DEFAULT NULL,
  `flight_wind_speed` varchar(50) DEFAULT NULL,
  `flight_preciptions` varchar(50) DEFAULT NULL,
  `flight_gps` varchar(50) DEFAULT NULL,
  `flight_humidity` varchar(50) DEFAULT NULL,
  `flight_m_b_v_b` varchar(50) DEFAULT NULL,
  `flight_m_b_v_a` varchar(50) DEFAULT NULL,
  `flight_b_v_r_l_b` varchar(50) DEFAULT NULL,
  `flight_b_v_r_l_a` varchar(50) DEFAULT NULL,
  `flight_e_b_v_b` varchar(50) DEFAULT NULL,
  `flight_e_b_v_a` varchar(50) DEFAULT NULL,
  `flight_f_b` varchar(50) DEFAULT NULL,
  `flight_f_a` varchar(50) DEFAULT NULL,
  `flight_aircraft_weight` varchar(50) DEFAULT NULL,
  `flight_emergency` varchar(50) DEFAULT NULL,
  `flight_emergency_description` text,
  PRIMARY KEY (`flight_id`),
  UNIQUE KEY `flight_number` (`flight_number`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tbl_flights` */

insert  into `tbl_flights` values (1,'7887','979','76','ali','me','2025-09-23','11:01:00','11:01:00','0','897','56','454','343','uy','554','334','34','67','1','1','65','65','98','878','87','9','977','',''),(2,'7887','979','1312','ali','dalton','2025-09-23','13:57:00','13:57:00','0','30000','10000','1','sdn','312','897','7879','987','8977','797','7897','8977','8797','7897','7897','789','21331','987','','');

/*Table structure for table `tbl_mission` */

DROP TABLE IF EXISTS `tbl_mission`;

CREATE TABLE `tbl_mission` (
  `mission_id` int NOT NULL AUTO_INCREMENT,
  `mission_name` varchar(100) NOT NULL,
  `mission_details` text,
  PRIMARY KEY (`mission_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tbl_mission` */

/*Table structure for table `tbl_parts` */

DROP TABLE IF EXISTS `tbl_parts`;

CREATE TABLE `tbl_parts` (
  `id` int NOT NULL AUTO_INCREMENT,
  `part_name` varchar(255) NOT NULL,
  `part_number` varchar(255) NOT NULL,
  `max_time` int DEFAULT NULL,
  `current_time` int DEFAULT NULL,
  `aircraft_id` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `aircraft_id` (`aircraft_id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tbl_parts` */

insert  into `tbl_parts` values (4,'21`','21`2',1000,0,'2'),(5,'Plugs','000000000032',1000,100,'2'),(6,'Battary','0000134',1000,100,'2');

/*Table structure for table `tbl_parts_log` */

DROP TABLE IF EXISTS `tbl_parts_log`;

CREATE TABLE `tbl_parts_log` (
  `log_id` int NOT NULL AUTO_INCREMENT,
  `part_name` varchar(100) DEFAULT NULL,
  `part_id` int DEFAULT NULL,
  `part_number` varchar(100) DEFAULT NULL,
  `using_time` double DEFAULT NULL,
  `aircraft_type` varchar(100) DEFAULT NULL,
  `aircraft_no` varchar(100) DEFAULT NULL,
  `aircraft_id` int DEFAULT NULL,
  `flight_date` date DEFAULT NULL,
  `flight_id` int DEFAULT NULL,
  PRIMARY KEY (`log_id`),
  KEY `part_id` (`part_id`),
  KEY `aircraft_id` (`aircraft_id`),
  KEY `flight_id` (`flight_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tbl_parts_log` */

/*Table structure for table `tbl_pilots` */

DROP TABLE IF EXISTS `tbl_pilots`;

CREATE TABLE `tbl_pilots` (
  `pilot_id` int NOT NULL AUTO_INCREMENT,
  `pilot_name` varchar(150) NOT NULL,
  PRIMARY KEY (`pilot_id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tbl_pilots` */

insert  into `tbl_pilots` values (1,'me'),(2,'dalton');

/*Table structure for table `tbl_user_trace` */

DROP TABLE IF EXISTS `tbl_user_trace`;

CREATE TABLE `tbl_user_trace` (
  `id` int NOT NULL AUTO_INCREMENT,
  `trace_time` time DEFAULT NULL,
  `trace_date` date DEFAULT NULL,
  `main_operation` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `user_id` int DEFAULT NULL,
  `user_name` varchar(120) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=174 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

/*Data for the table `tbl_user_trace` */

insert  into `tbl_user_trace` values (1,'14:37:17','2022-10-25','Login Successfuly  : UserName is :admin',1,'admin'),(2,'14:37:20','2022-10-25','Open POS | Direct Sells | Point Of Sales',1,'admin'),(3,'14:38:36','2022-10-25','Login Successfuly  : UserName is :admin',1,'admin'),(4,'14:38:39','2022-10-25','Open POS | Direct Sells | Point Of Sales',1,'admin'),(5,'14:39:30','2022-10-25','Login Successfuly  : UserName is :admin',1,'admin'),(6,'14:39:33','2022-10-25','Open POS | Direct Sells | Point Of Sales',1,'admin'),(7,'14:42:05','2022-10-25','Login Successfuly  : UserName is :admin',1,'admin'),(8,'14:42:07','2022-10-25','Open POS | Direct Sells | Point Of Sales',1,'admin'),(9,'14:42:55','2022-10-25','Login Successfuly  : UserName is :admin',1,'admin'),(10,'14:42:57','2022-10-25','Open POS | Direct Sells | Point Of Sales',1,'admin'),(11,'14:44:26','2022-10-25','Login Successfuly  : UserName is :admin',1,'admin'),(12,'14:44:30','2022-10-25','Open POS | Direct Sells | Point Of Sales',1,'admin'),(13,'14:45:48','2022-10-25','Login Successfuly  : UserName is :admin',1,'admin'),(14,'14:45:51','2022-10-25','Open POS | Direct Sells | Point Of Sales',1,'admin'),(15,'14:48:51','2022-10-25','Login Successfuly  : UserName is :admin',1,'admin'),(16,'14:48:53','2022-10-25','Open POS | Direct Sells | Point Of Sales',1,'admin'),(17,'14:51:43','2022-10-25','Login Successfuly  : UserName is :admin',1,'admin'),(18,'14:51:45','2022-10-25','Open POS | Direct Sells | Point Of Sales',1,'admin'),(19,'14:52:03','2022-10-25','New Invoice : [INV -PF0VA0V7-49-51-25-10-2022-1]Has Been Issued',1,'admin'),(20,'14:57:47','2022-10-25','Open Products Categoery',1,'admin'),(21,'14:58:00','2022-10-25','Open POS | Direct Sells | Point Of Sales',1,'admin'),(22,'14:58:12','2022-10-25','New Invoice : [INV -PF0VA0V7-02-58-25-10-2022-1]Has Been Issued',1,'admin'),(23,'14:58:31','2022-10-25','Open POS | Direct Sells | Point Of Sales',1,'admin'),(24,'14:58:41','2022-10-25','New Invoice : [INV -PF0VA0V7-34-58-25-10-2022-1]Has Been Issued',1,'admin'),(25,'14:58:50','2022-10-25','New Invoice : [INV -PF0VA0V7-43-58-25-10-2022-1]Has Been Issued',1,'admin'),(26,'15:07:08','2022-10-25','Open Store Settings - Update ',1,'admin'),(27,'15:07:43','2022-10-25','Open Store Settings window',1,'admin'),(28,'15:08:43','2022-10-25','Open POS | Direct Sells | Point Of Sales',1,'admin'),(29,'15:08:59','2022-10-25','New Invoice : [INV -PF0VA0V7-47-08-25-10-2022-1]Has Been Issued',1,'admin'),(30,'15:09:22','2022-10-25','Open Store Settings window',1,'admin'),(31,'15:12:39','2022-10-25','Login Successfuly  : UserName is :admin',1,'admin'),(32,'15:14:04','2022-10-25','Login Successfuly  : UserName is :admin',1,'admin'),(33,'15:15:53','2022-10-25','Login Successfuly  : UserName is :admin',1,'admin'),(34,'15:18:01','2022-10-25','Login Successfuly  : UserName is :admin',1,'admin'),(35,'15:18:49','2022-10-25','Login Successfuly  : UserName is :admin',1,'admin'),(36,'15:19:37','2022-10-25','Cashier Payment Successfuly ',1,'admin'),(37,'17:33:04','2022-10-25','Open Products Categoery',1,'admin'),(38,'17:33:08','2022-10-25','Open POS | Direct Sells | Point Of Sales',1,'admin'),(39,'11:49:43','2025-09-02','Login Successfuly  : UserName is :admin',1,'admin'),(40,'11:49:45','2025-09-02','Login Successfuly  : UserName is :admin',1,'admin'),(41,'11:49:48','2025-09-02','Open POS | Direct Sells | Point Of Sales',1,'admin'),(42,'11:50:06','2025-09-02','Open Store Settings window',1,'admin'),(43,'11:50:24','2025-09-02','Open Products Categoery',1,'admin'),(44,'11:50:26','2025-09-02','Open POS | Direct Sells | Point Of Sales',1,'admin'),(45,'11:51:34','2025-09-02','Open Products Categoery',1,'admin'),(46,'11:52:07','2025-09-02','Login Successfuly  : UserName is :admin',1,'admin'),(47,'11:52:49','2025-09-02','Login Successfuly  : UserName is :admin',1,'admin'),(48,'11:53:28','2025-09-02','Open Store Settings - Update ',1,'admin'),(49,'11:56:06','2025-09-02','Login Successfuly  : UserName is :admin',1,'admin'),(50,'11:57:04','2025-09-02','Open Store Settings window',1,'admin'),(51,'11:57:39','2025-09-02','Open POS | Direct Sells | Point Of Sales',1,'admin'),(52,'12:00:18','2025-09-02','Open Change Password Window',1,'admin'),(53,'12:04:16','2025-09-02','Login Successfuly  : UserName is :admin',1,'admin'),(54,'12:04:24','2025-09-02','Open POS | Direct Sells | Point Of Sales',1,'admin'),(55,'13:14:40','2025-09-02','Login Successfuly  : UserName is :admin',1,'admin'),(56,'13:14:48','2025-09-02','Login Successfuly  : UserName is :admin',1,'admin'),(57,'13:14:57','2025-09-02','Login Successfuly  : UserName is :admin',1,'admin'),(58,'13:16:37','2025-09-02','Open Products Categoery',1,'admin'),(59,'10:16:48','2025-09-04','Login Successfuly  : UserName is :admin',1,'admin'),(60,'10:17:00','2025-09-04','Open Store Settings window',1,'admin'),(61,'10:17:17','2025-09-04','Open POS | Direct Sells | Point Of Sales',1,'admin'),(62,'10:19:13','2025-09-04','Open Products',1,'admin'),(63,'10:19:43','2025-09-04','Login Successfuly  : UserName is :admin',1,'admin'),(64,'10:20:09','2025-09-04','Open Store Settings window',1,'admin'),(65,'10:20:40','2025-09-04','Open Store Settings window',1,'admin'),(66,'10:20:54','2025-09-04','Open Change Password Window',1,'admin'),(67,'10:21:06','2025-09-04','Open users Management window',1,'admin'),(68,'10:21:37','2025-09-04','Open Products Categoery',1,'admin'),(69,'10:21:46','2025-09-04','Open Products Categoery',1,'admin'),(70,'11:53:37','2025-09-21','Login Successfuly  : UserName is :admin',1,'admin'),(71,'11:53:40','2025-09-21','Open Air Crafts List  : Username is :admin',1,'admin'),(72,'11:53:52','2025-09-21','Login Successfuly  : UserName is :admin',1,'admin'),(73,'12:30:59','2025-09-21','Login Successfuly  : UserName is :admin',1,'admin'),(74,'12:31:01','2025-09-21','Open Air Crafts List  : Username is :admin',1,'admin'),(75,'12:31:27','2025-09-21','Login Successfuly  : UserName is :admin',1,'admin'),(76,'12:31:30','2025-09-21','Open users Management window',1,'admin'),(77,'12:31:34','2025-09-21','Open Change Password Window',1,'admin'),(78,'14:00:15','2025-09-22','Login Successfuly  : UserName is :admin',1,'admin'),(79,'14:19:15','2025-09-22','Login Successfuly  : UserName is :admin',1,'admin'),(80,'14:31:01','2025-09-22','Login Successfuly  : UserName is :admin',1,'admin'),(81,'14:48:24','2025-09-22','Login Successfuly  : UserName is :admin',1,'admin'),(82,'14:48:27','2025-09-22','Open Air Crafts List  : Username is :admin',1,'admin'),(83,'15:00:38','2025-09-22','Login Successfuly  : UserName is :admin',1,'admin'),(84,'15:00:43','2025-09-22','Open Air Crafts List  : Username is :admin',1,'admin'),(85,'16:00:00','2025-09-22','Login Successfuly  : UserName is :admin',1,'admin'),(86,'16:02:03','2025-09-22','Login Successfuly  : UserName is :admin',1,'admin'),(87,'16:02:06','2025-09-22','Open Air Crafts List  : Username is :admin',1,'admin'),(88,'16:02:27','2025-09-22','open parts Screen by : admin',1,'admin'),(89,'10:56:35','2025-09-23','Login Successfuly  : UserName is :admin',1,'admin'),(90,'10:56:41','2025-09-23','try Add New Flight  : Username is :admin',1,'admin'),(91,'10:56:42','2025-09-23','Close Flights Screen  : Username is :admin',1,'admin'),(92,'10:56:44','2025-09-23','Open users Management window',1,'admin'),(93,'10:56:52','2025-09-23','open parts Screen by : admin',1,'admin'),(94,'11:00:28','2025-09-23','Login Successfuly  : UserName is :admin',1,'admin'),(95,'11:00:33','2025-09-23','Open users Management window',1,'admin'),(96,'11:00:43','2025-09-23','Open Pilot Screen by :admin',1,'admin'),(97,'11:00:45','2025-09-23','Try Add new Pilot to list by :admin',1,'admin'),(98,'11:00:51','2025-09-23','Try To Save new Pilot by :admin',1,'admin'),(99,'11:00:53','2025-09-23','Try Add new Pilot to list by :admin',1,'admin'),(100,'11:01:00','2025-09-23','Try To Save new Pilot by :admin',1,'admin'),(101,'11:01:23','2025-09-23','try Add New Flight  : Username is :admin',1,'admin'),(102,'11:02:38','2025-09-23','try Add New Flight  : Username is :admin',1,'admin'),(103,'11:02:39','2025-09-23','Close Flights Screen  : Username is :admin',1,'admin'),(104,'11:03:43','2025-09-23','open parts Screen by : admin',1,'admin'),(105,'11:08:57','2025-09-23','Login Successfuly  : UserName is :admin',1,'admin'),(106,'11:09:01','2025-09-23','open parts Screen by : admin',1,'admin'),(107,'11:11:06','2025-09-23','Login Successfuly  : UserName is :admin',1,'admin'),(108,'11:11:21','2025-09-23','Close Flights Screen  : Username is :admin',1,'admin'),(109,'11:11:26','2025-09-23','Close Flights Screen  : Username is :admin',1,'admin'),(110,'11:11:28','2025-09-23','Open Air Crafts List  : Username is :admin',1,'admin'),(111,'11:11:42','2025-09-23','open parts Screen by : admin',1,'admin'),(112,'13:34:48','2025-09-23','Login Successfuly  : UserName is :admin',1,'admin'),(113,'13:34:51','2025-09-23','open parts Screen by : admin',1,'admin'),(114,'13:35:50','2025-09-23','Login Successfuly  : UserName is :admin',1,'admin'),(115,'13:35:53','2025-09-23','open parts Screen by : admin',1,'admin'),(116,'13:37:35','2025-09-23','Login Successfuly  : UserName is :admin',1,'admin'),(117,'13:37:40','2025-09-23','open parts Screen by : admin',1,'admin'),(118,'13:37:44','2025-09-23','try To add New Part byadmin',1,'admin'),(119,'13:37:51','2025-09-23','try to save new part by :admin',1,'admin'),(120,'13:37:54','2025-09-23','try to save new part by :admin',1,'admin'),(121,'13:38:05','2025-09-23','try to save new part by :admin',1,'admin'),(122,'13:38:31','2025-09-23','open parts Screen by : admin',1,'admin'),(123,'13:38:35','2025-09-23','try To add New Part byadmin',1,'admin'),(124,'13:38:40','2025-09-23','try to save new part by :admin',1,'admin'),(125,'13:39:19','2025-09-23','open parts Screen by : admin',1,'admin'),(126,'13:39:23','2025-09-23','try To add New Part byadmin',1,'admin'),(127,'13:39:27','2025-09-23','try to save new part by :admin',1,'admin'),(128,'13:42:10','2025-09-23','Login Successfuly  : UserName is :admin',1,'admin'),(129,'13:42:16','2025-09-23','open parts Screen by : admin',1,'admin'),(130,'13:42:18','2025-09-23','try To add New Part byadmin',1,'admin'),(131,'13:42:24','2025-09-23','try to save new part by :admin',1,'admin'),(132,'13:42:37','2025-09-23','try To add New Part byadmin',1,'admin'),(133,'13:51:55','2025-09-23','Login Successfuly  : UserName is :admin',1,'admin'),(134,'13:51:59','2025-09-23','Open users Management window',1,'admin'),(135,'13:55:15','2025-09-23','Login Successfuly  : UserName is :admin',1,'admin'),(136,'13:55:22','2025-09-23','Open users Management window',1,'admin'),(137,'13:55:31','2025-09-23','Start Edit Operation For User : sameersalih',1,'admin'),(138,'13:55:40','2025-09-23','Edit : username sameersalih Data Has Been Edited',1,'admin'),(139,'13:57:26','2025-09-23','Login Successfuly  : UserName is :admin',1,'admin'),(140,'13:57:34','2025-09-23','try Add New Flight  : Username is :admin',1,'admin'),(141,'13:57:38','2025-09-23','Close Flights Screen  : Username is :admin',1,'admin'),(142,'13:57:40','2025-09-23','Open Air Crafts List  : Username is :admin',1,'admin'),(143,'13:57:51','2025-09-23','try Add New Flight  : Username is :admin',1,'admin'),(144,'13:59:11','2025-09-23','Login Successfuly  : UserName is :admin',1,'admin'),(145,'14:00:04','2025-09-23','Login Successfuly  : UserName is :admin',1,'admin'),(146,'14:00:10','2025-09-23','Open Change Password Window',1,'admin'),(147,'14:00:40','2025-09-23','Login Successfuly  : UserName is :admin',1,'admin'),(148,'14:00:44','2025-09-23','Open Trace Report  : Username is :admin',1,'admin'),(149,'14:00:50','2025-09-23','Report Trace Users 2025-09-23 - 2025-09-23  admin',1,'admin'),(150,'14:06:47','2025-09-23','Login Successfuly  : UserName is :admin',1,'admin'),(151,'14:06:57','2025-09-23','Open users Management window',1,'admin'),(152,'14:07:02','2025-09-23','Open Change Password Window',1,'admin'),(153,'14:07:08','2025-09-23','try Add New Flight  : Username is :admin',1,'admin'),(154,'14:07:26','2025-09-23','Cancel Add New Flight  : Username is :admin',1,'admin'),(155,'14:07:29','2025-09-23','open parts Screen by : admin',1,'admin'),(156,'14:07:36','2025-09-23','open parts Screen by : admin',1,'admin'),(157,'14:07:39','2025-09-23','try To add New Part byadmin',1,'admin'),(158,'14:07:58','2025-09-23','try to save new part by :admin',1,'admin'),(159,'14:08:01','2025-09-23','try To add New Part byadmin',1,'admin'),(160,'14:08:11','2025-09-23','try to save new part by :admin',1,'admin'),(161,'14:10:50','2025-09-23','Login Successfuly  : UserName is :admin',1,'admin'),(162,'14:11:27','2025-09-23','Open Air Crafts List  : Username is :admin',1,'admin'),(163,'14:11:44','2025-09-23','open parts Screen by : admin',1,'admin'),(164,'14:12:00','2025-09-23','try Add New Flight  : Username is :admin',1,'admin'),(165,'14:12:29','2025-09-23','Cancel Add New Flight  : Username is :admin',1,'admin'),(166,'14:12:44','2025-09-23','Open users Management window',1,'admin'),(167,'14:12:59','2025-09-23','Open Change Password Window',1,'admin'),(168,'14:13:21','2025-09-23','Open Pilot Screen by :admin',1,'admin'),(169,'14:13:30','2025-09-23','Open Trace Report  : Username is :admin',1,'admin'),(170,'14:13:38','2025-09-23','Report Trace Users 2025-09-23 - 2025-09-23  admin',1,'admin'),(171,'14:13:51','2025-09-23','Open Flight Report : Username is :admin',1,'admin'),(172,'14:14:10','2025-09-23','try Add New Flight  : Username is :admin',1,'admin'),(173,'14:14:15','2025-09-23','try Add New Flight  : Username is :admin',1,'admin');

/*Table structure for table `tbl_users_data` */

DROP TABLE IF EXISTS `tbl_users_data`;

CREATE TABLE `tbl_users_data` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(32) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci NOT NULL,
  `name` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `password` varchar(32) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL COMMENT 'false',
  `enableded` enum('true','false') CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT 'false',
  `print_permission` enum('true','false') CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT 'false',
  `add_new_Permission` enum('true','false') CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT 'false',
  `delete_permission` enum('true','false') CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT 'false',
  `add_users_permission` enum('true','false') CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT 'false',
  `edit_permisson` enum('true','false') CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT 'false',
  `role` enum('Administrative','direct sales employee','cashier sales employee','accountant','sales revenue','HR Officer','store manager','Stock manager') CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`user_id`,`username`),
  UNIQUE KEY `username` (`username`)
) ENGINE=MyISAM AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

/*Data for the table `tbl_users_data` */

insert  into `tbl_users_data` values (1,'admin','sameer','C8837B23FF8AAA8A2DDE915473CE0991','true','false','true','true','true','true','Administrative'),(20,'sameer','sameersalih','C2113B03F6EA07C0E06EEB198BF667B1','true','true','true','true','true','true','direct sales employee'),(23,'sameersalih','sameeersalih','580DBCC1171B862FA28B309A7BDF735B','true','true','true','true','true','true','Administrative');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
