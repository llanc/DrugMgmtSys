/*
Navicat MySQL Data Transfer

Source Server         : MySql5.7
Source Server Version : 50720
Source Host           : localhost:3306
Source Database       : drug_mgmt_sys

Target Server Type    : MYSQL
Target Server Version : 50720
File Encoding         : 65001

Date: 2018-03-22 21:26:16
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
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_drug
-- ----------------------------
INSERT INTO `tb_drug` VALUES ('52', '诺氟沙星', '1', '6粒/板', '山师德州名要县', '2014.2', '56.0', '4.50', '8.00');
INSERT INTO `tb_drug` VALUES ('53', '奥美拉挫穿甲片', '1', '4粒/板', '河北唐山', '2022.1', '74.0', '4.50', '13.00');
INSERT INTO `tb_drug` VALUES ('54', '阿莫西林克拉维酸钾片', '2', '3mg/片', '河南郑州', '2019.12', '135.0', '13.50', '20.52');
INSERT INTO `tb_drug` VALUES ('55', '感冒灵胶囊', '1', '6粒/板', '撒复健科困了就', '213.53', '219.0', '3.00', '5.00');
INSERT INTO `tb_drug` VALUES ('56', '甘草片', '2', '100片/瓶', '山东烟台', '2020.4', '123.0', '2.00', '4.00');
INSERT INTO `tb_drug` VALUES ('57', '咳特灵胶囊', '1', '9粒/板', '四川成都', '2019.1', '5.0', '4.00', '7.50');

-- ----------------------------
-- Table structure for tb_order
-- ----------------------------
DROP TABLE IF EXISTS `tb_order`;
CREATE TABLE `tb_order` (
  `o_id` int(10) NOT NULL AUTO_INCREMENT,
  `o_time` varchar(255) NOT NULL,
  `o_name` varchar(255) NOT NULL,
  `o_num` double(10,2) NOT NULL,
  `o_r_price` double(10,2) NOT NULL,
  `o_money` double(10,2) NOT NULL,
  PRIMARY KEY (`o_id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_order
-- ----------------------------
INSERT INTO `tb_order` VALUES ('1', '2018年3月22日 星期四', '阿莫西林克拉维酸钾片', '1.00', '34.00', '10.50');
INSERT INTO `tb_order` VALUES ('2', '2018年3月22日 星期四', '奥美拉挫穿甲片', '1.00', '11.00', '10.00');
INSERT INTO `tb_order` VALUES ('3', '2018年3月21日 星期三', '诺氟沙星', '1.00', '8.00', '3.50');
INSERT INTO `tb_order` VALUES ('4', '2018年3月21日 星期三', '奥美拉挫穿甲片', '3.00', '11.00', '30.00');
INSERT INTO `tb_order` VALUES ('5', '2018年3月22日 星期四', '诺氟沙星', '3.00', '8.00', '10.50');
INSERT INTO `tb_order` VALUES ('6', '2018年3月22日 星期四', '诺氟沙星', '1.00', '8.00', '3.50');
INSERT INTO `tb_order` VALUES ('7', '2018年3月21日 星期三', '阿莫西林克拉维酸钾片', '1.00', '34.00', '10.50');
INSERT INTO `tb_order` VALUES ('8', '2018年3月22日 星期四', '奥美拉挫穿甲片', '1.00', '11.00', '10.00');
INSERT INTO `tb_order` VALUES ('9', '2018年3月22日 星期四', '阿莫西林克拉维酸钾片', '2.00', '34.00', '21.00');
INSERT INTO `tb_order` VALUES ('10', '2018年3月22日 星期四', '感冒灵胶囊', '3.00', '5.00', '6.00');
INSERT INTO `tb_order` VALUES ('11', '2018年3月22日 星期四', '诺氟沙星', '1.00', '8.00', '3.50');
INSERT INTO `tb_order` VALUES ('12', '2018年3月22日 星期四', '阿莫西林克拉维酸钾片', '1.00', '34.00', '10.50');
INSERT INTO `tb_order` VALUES ('13', '2018年3月22日 星期四', '感冒灵胶囊', '1.00', '5.00', '2.00');
INSERT INTO `tb_order` VALUES ('14', '2018年3月22日 星期四', '感冒灵胶囊', '1.00', '5.00', '2.00');
INSERT INTO `tb_order` VALUES ('15', '2018年3月22日 星期四', '甘草片', '1.00', '4.00', '2.00');
INSERT INTO `tb_order` VALUES ('16', '2018年3月22日 星期四', '甘草片', '1.00', '4.00', '2.00');
INSERT INTO `tb_order` VALUES ('17', '2018年3月22日 星期四', '诺氟沙星', '1.00', '8.00', '3.50');
INSERT INTO `tb_order` VALUES ('18', '2018年3月22日 星期四', '诺氟沙星', '1.00', '8.00', '3.50');
INSERT INTO `tb_order` VALUES ('19', '2018年3月22日 星期四', '诺氟沙星', '1.00', '8.00', '3.50');
INSERT INTO `tb_order` VALUES ('20', '2018年3月22日 星期四', '咳特灵胶囊', '1.00', '7.50', '3.50');
INSERT INTO `tb_order` VALUES ('21', '2018年3月22日 星期四', '阿莫西林克拉维酸钾片', '1.00', '20.52', '7.02');
INSERT INTO `tb_order` VALUES ('22', '2018年3月22日 星期四', '奥美拉挫穿甲片', '1.00', '13.00', '8.50');

-- ----------------------------
-- Table structure for tb_pwd
-- ----------------------------
DROP TABLE IF EXISTS `tb_pwd`;
CREATE TABLE `tb_pwd` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `pwd` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_pwd
-- ----------------------------
INSERT INTO `tb_pwd` VALUES ('1', '123456');
INSERT INTO `tb_pwd` VALUES ('2', '12369874');

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
