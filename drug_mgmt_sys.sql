/*
Navicat MySQL Data Transfer

Source Server         : MySql5.7
Source Server Version : 50720
Source Host           : localhost:3306
Source Database       : drug_mgmt_sys

Target Server Type    : MYSQL
Target Server Version : 50720
File Encoding         : 65001

Date: 2018-03-15 19:39:47
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for tb_drug
-- ----------------------------
DROP TABLE IF EXISTS `tb_drug`;
CREATE TABLE `tb_drug` (
  `d_id` int(10) NOT NULL AUTO_INCREMENT,
  `d_name` varchar(255) NOT NULL,
  `d_unit` int(10) NOT NULL,
  `d_spec` varchar(255) DEFAULT NULL,
  `d_origin` varchar(255) DEFAULT NULL,
  `d_lot_num` varchar(255) DEFAULT NULL,
  `d_reserve` double(10,1) NOT NULL,
  `d_w_price` double(10,2) NOT NULL,
  `d_r_price` double(10,2) NOT NULL,
  PRIMARY KEY (`d_id`),
  KEY `d_unit` (`d_unit`),
  CONSTRAINT `tb_drug_ibfk_1` FOREIGN KEY (`d_unit`) REFERENCES `tb_unit` (`u_id`)
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_drug
-- ----------------------------
INSERT INTO `tb_drug` VALUES ('2', '测试2', '2', '10mg/瓶', '山东泰安', 'SDta83191', '83.0', '1.25', '3.50');
INSERT INTO `tb_drug` VALUES ('3', '测试3', '2', '10g/瓶', '山东新泰', 'SDxt23924', '126.0', '2.60', '3.00');
INSERT INTO `tb_drug` VALUES ('36', 'CS01', '2', '2g/片', '山东德州', 'SDdz78392', '51.0', '2.50', '3.50');
INSERT INTO `tb_drug` VALUES ('37', 'CS02', '1', '0.5g/片', '山东日照', 'SDrz90321', '70.0', '2.50', '3.00');
INSERT INTO `tb_drug` VALUES ('38', 'CS03', '1', '2片/板', '山东泰安', 'SDta83921', '40.0', '1.50', '2.50');

-- ----------------------------
-- Table structure for tb_unit
-- ----------------------------
DROP TABLE IF EXISTS `tb_unit`;
CREATE TABLE `tb_unit` (
  `u_id` int(10) NOT NULL AUTO_INCREMENT,
  `u_name` varchar(255) NOT NULL,
  PRIMARY KEY (`u_id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_unit
-- ----------------------------
INSERT INTO `tb_unit` VALUES ('1', '盒');
INSERT INTO `tb_unit` VALUES ('2', '瓶');
INSERT INTO `tb_unit` VALUES ('3', '包');
INSERT INTO `tb_unit` VALUES ('4', '板');
INSERT INTO `tb_unit` VALUES ('5', '片');
INSERT INTO `tb_unit` VALUES ('6', '支');
INSERT INTO `tb_unit` VALUES ('7', '箱');
INSERT INTO `tb_unit` VALUES ('8', '桶');
INSERT INTO `tb_unit` VALUES ('9', '个');
INSERT INTO `tb_unit` VALUES ('10', '克');
INSERT INTO `tb_unit` VALUES ('11', '千克');
INSERT INTO `tb_unit` VALUES ('12', '两');
INSERT INTO `tb_unit` VALUES ('13', '斤');
INSERT INTO `tb_unit` VALUES ('14', '米');
SET FOREIGN_KEY_CHECKS=1;
