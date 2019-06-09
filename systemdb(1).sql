/*
 Navicat Premium Data Transfer

 Source Server         : GYL
 Source Server Type    : MySQL
 Source Server Version : 50726
 Source Host           : 47.110.249.55:3306
 Source Schema         : systemdb

 Target Server Type    : MySQL
 Target Server Version : 50726
 File Encoding         : 65001

 Date: 09/06/2019 11:47:06
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for Adjust00
-- ----------------------------
DROP TABLE IF EXISTS `Adjust00`;
CREATE TABLE `Adjust00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `AD_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STATUS` int(11) NOT NULL,
  `INPUT_DATE` datetime(0) NULL,
  `ADJUST_TYPE` int(11) NOT NULL,
  `STOCK_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_DATETIME` datetime(0) NULL DEFAULT NULL,
  `RELATE_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LOCKED` tinyint(4) NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `Trans_STATUS` tinyint(4) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for Adjust01
-- ----------------------------
DROP TABLE IF EXISTS `Adjust01`;
CREATE TABLE `Adjust01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `AD_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SNo` int(11) NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUANTITY` decimal(19, 6) NOT NULL,
  `STD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STD_CONVERT` int(11) NOT NULL,
  `STD_QUAN` decimal(19, 6) NOT NULL,
  `STD_PRICE` decimal(19, 6) NOT NULL,
  `COST` decimal(19, 6) NOT NULL,
  `QUAN1` decimal(19, 6) NOT NULL,
  `QUAN2` decimal(19, 6) NOT NULL,
  `REASON_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MEMO` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `BAT_NO` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Exp_DateTime` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for Branch
-- ----------------------------
DROP TABLE IF EXISTS `Branch`;
CREATE TABLE `Branch`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Code` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `Name` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `Level` tinyint(4) NOT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for BranchMenuControlInfo
-- ----------------------------
DROP TABLE IF EXISTS `BranchMenuControlInfo`;
CREATE TABLE `BranchMenuControlInfo`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `BranchMenuID` int(11) NOT NULL,
  `MenuControlID` int(11) NOT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for BranchMenuInfo
-- ----------------------------
DROP TABLE IF EXISTS `BranchMenuInfo`;
CREATE TABLE `BranchMenuInfo`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `BranchID` int(11) NOT NULL,
  `MenuID` int(11) NOT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for COL_ORDER01
-- ----------------------------
DROP TABLE IF EXISTS `COL_ORDER01`;
CREATE TABLE `COL_ORDER01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `COL_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SNo` int(11) NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUANTITY` decimal(19, 6) NOT NULL,
  `COST_PRICE` decimal(19, 6) NOT NULL,
  `STD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STD_CONVERT` int(11) NOT NULL,
  `STD_QUAN` decimal(19, 6) NOT NULL,
  `STD_PRICE` decimal(19, 6) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for COL_ORDER02
-- ----------------------------
DROP TABLE IF EXISTS `COL_ORDER02`;
CREATE TABLE `COL_ORDER02`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `COL_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SNo` int(11) NOT NULL,
  `Import_Shop` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `OUT_QUAN` float NOT NULL,
  `SUP_QUAN` float NOT NULL,
  `STD_QUAN` float NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for COMPONENT00
-- ----------------------------
DROP TABLE IF EXISTS `COMPONENT00`;
CREATE TABLE `COMPONENT00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `COM_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `Num` int(11) NOT NULL,
  `WEIGHT` decimal(19, 6) NOT NULL,
  `DefaultCOM` tinyint(4) NOT NULL,
  `QUAN1` int(11) NOT NULL,
  `QUAN2` int(11) NOT NULL,
  `DefQuan` int(11) NOT NULL,
  `BOM_Cost` decimal(19, 6) NOT NULL,
  `ExpDateTime` datetime(0) NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for COMPONENT01
-- ----------------------------
DROP TABLE IF EXISTS `COMPONENT01`;
CREATE TABLE `COMPONENT01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `COM_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `DETAIL_ID` int(11) NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUANTITY` decimal(19, 6) NOT NULL,
  `LQUANTITY` decimal(19, 6) NOT NULL,
  `New_PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `IsScales` tinyint(4) NOT NULL,
  `PrtTag` tinyint(4) NOT NULL,
  `IsFlag` tinyint(4) NOT NULL,
  `Memo` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for CONTRACT01
-- ----------------------------
DROP TABLE IF EXISTS `CONTRACT01`;
CREATE TABLE `CONTRACT01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `CONTRACT_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PROD_ID` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `CONTRACT_PRICE` decimal(19, 6) NOT NULL,
  `CONTRACT_PRICE1` decimal(19, 6) NOT NULL,
  `CONTRACT_PRICE2` decimal(19, 6) NOT NULL,
  `USABLE` tinyint(4) NOT NULL,
  `Meno` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `CRT_DATETIME` datetime(0) NULL DEFAULT NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL DEFAULT NULL,
  `STATUS` tinyint(4) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for Col_Order00
-- ----------------------------
DROP TABLE IF EXISTS `Col_Order00`;
CREATE TABLE `Col_Order00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `COL_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `INPUT_DATE` datetime(0) NULL,
  `ORD_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `EXPECT_DATE` datetime(0) NULL,
  `STATUS` int(11) NOT NULL,
  `PROD_TYPE` int(11) NOT NULL,
  `ORD_TYPE` int(11) NULL DEFAULT NULL,
  `ORD_DEP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `COL_BeginDate` datetime(0) NULL,
  `COL_EndDate` datetime(0) NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_DATE` datetime(0) NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LOCKED` tinyint(4) NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `Trans_STATUS` tinyint(4) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for DIVISION
-- ----------------------------
DROP TABLE IF EXISTS `DIVISION`;
CREATE TABLE `DIVISION`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `DIV_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `DIV_NAME` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `DIV_TYPE` int(11) NOT NULL,
  `STOCK_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `DIV_MEMO` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL DEFAULT NULL,
  `STATUS` tinyint(4) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for DUE00
-- ----------------------------
DROP TABLE IF EXISTS `DUE00`;
CREATE TABLE `DUE00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `TAKEIN_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `STATUS` int(11) NULL DEFAULT NULL,
  `INPUT_DATE` datetime(0) NULL DEFAULT NULL,
  `SUP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_DATETIME` datetime(0) NULL DEFAULT NULL,
  `TOT_AMOUNT` decimal(19, 6) NULL DEFAULT NULL,
  `TOT_TAX` decimal(19, 6) NULL DEFAULT NULL,
  `TOT_QTY` decimal(19, 6) NULL DEFAULT NULL,
  `PRE_PAY` decimal(19, 6) NULL DEFAULT NULL,
  `PRE_PAY_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `RELATE_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `INVOICE_ID` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `TAKEIN_TYPE` int(11) NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL DEFAULT NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for DUE01
-- ----------------------------
DROP TABLE IF EXISTS `DUE01`;
CREATE TABLE `DUE01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `TAKEIN_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SNO` int(11) NULL DEFAULT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `STD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `STD_QUAN` decimal(19, 6) NULL DEFAULT NULL,
  `STD_PRICE` decimal(19, 6) NULL DEFAULT NULL,
  `TAX` decimal(19, 6) NULL DEFAULT NULL,
  `QUAN1` decimal(19, 6) NULL DEFAULT NULL,
  `QUAN2` decimal(19, 6) NULL DEFAULT NULL,
  `ITEM_DISC_AMT` decimal(19, 6) NULL DEFAULT NULL,
  `MEMO` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `BAT_NO` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `COST` decimal(19, 6) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for Dispose00
-- ----------------------------
DROP TABLE IF EXISTS `Dispose00`;
CREATE TABLE `Dispose00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `DP_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STATUS` int(11) NOT NULL,
  `INPUT_DATE` datetime(0) NULL,
  `DP_TYPE` int(11) NOT NULL,
  `STOCK_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_DATETIME` datetime(0) NULL DEFAULT NULL,
  `RELATE_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LOCKED` tinyint(4) NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `Trans_STATUS` tinyint(4) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for EMPLOYEE
-- ----------------------------
DROP TABLE IF EXISTS `EMPLOYEE`;
CREATE TABLE `EMPLOYEE`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `EMP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `EMP_NAME` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `EMP_Birthday` datetime(0) NULL,
  `EMP_ADD` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EMP_TEL` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EMP_ZIP` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EMP_EMAIL` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EMP_MOBILE` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EMP_MEMO` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EMP_ENABLE` int(11) NOT NULL,
  `EMP_SEX` int(11) NOT NULL,
  `EMP_CodeID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EMP_LEVEL` int(11) NOT NULL,
  `EMP_PASSWORD` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `EMP_BDATE` datetime(0) NULL,
  `EMP_EDATE` datetime(0) NULL DEFAULT NULL,
  `EMP_WAGE` decimal(19, 2) NULL DEFAULT NULL,
  `EMP_Education` int(11) NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL DEFAULT NULL,
  `STATUS` tinyint(4) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for GROUPAREA
-- ----------------------------
DROP TABLE IF EXISTS `GROUPAREA`;
CREATE TABLE `GROUPAREA`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `AREA_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `AREA_NAME` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `AREA_ADD` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `AREA_TEL` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `AREA_EMAIL` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `AREA_CONTECT` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `AREA_MEMO` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `AREA_STATUS` tinyint(4) NOT NULL,
  `CRT_DATETIME` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL DEFAULT NULL,
  `STATUS` tinyint(4) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for HEAD_SHOP_ACCOUNT
-- ----------------------------
DROP TABLE IF EXISTS `HEAD_SHOP_ACCOUNT`;
CREATE TABLE `HEAD_SHOP_ACCOUNT`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SUP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `AMOUNT` decimal(18, 6) NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL DEFAULT NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for HEAD_SHOP_BILL
-- ----------------------------
DROP TABLE IF EXISTS `HEAD_SHOP_BILL`;
CREATE TABLE `HEAD_SHOP_BILL`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SU_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `BILL_AMOUNT` decimal(19, 6) NULL DEFAULT NULL,
  `PAY_AMOUNT` decimal(19, 6) NULL DEFAULT NULL,
  `PAY_METHOD` tinyint(4) NULL DEFAULT NULL,
  `BILL_DATE` datetime(0) NULL DEFAULT NULL,
  `PAY_DATE` datetime(0) NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL DEFAULT NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for HEAD_SHOP_PAY_HISTORY
-- ----------------------------
DROP TABLE IF EXISTS `HEAD_SHOP_PAY_HISTORY`;
CREATE TABLE `HEAD_SHOP_PAY_HISTORY`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `BILL_AMOUNT` decimal(19, 6) NULL DEFAULT NULL,
  `SUP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `BILL_ID` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `PAY_AMOUNT` decimal(19, 6) NULL DEFAULT NULL,
  `PAY_METHOD` tinyint(4) NULL DEFAULT NULL,
  `BILL_DATE` datetime(0) NULL DEFAULT NULL,
  `PAY_DATE` datetime(0) NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL DEFAULT NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for IN00
-- ----------------------------
DROP TABLE IF EXISTS `IN00`;
CREATE TABLE `IN00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `IN_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STATUS` int(11) NOT NULL,
  `INPUT_DATE` datetime(0) NULL,
  `OUT_SHOP` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STOCK_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_DATETIME` datetime(0) NULL DEFAULT NULL,
  `RELATE_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LOCKED` tinyint(4) NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `Trans_STATUS` tinyint(4) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for IN01
-- ----------------------------
DROP TABLE IF EXISTS `IN01`;
CREATE TABLE `IN01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `IN_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SNo` int(11) NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUANTITY` decimal(19, 6) NOT NULL,
  `STD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STD_CONVERT` int(11) NOT NULL,
  `STD_QUAN` decimal(19, 6) NOT NULL,
  `STD_PRICE` decimal(19, 6) NOT NULL,
  `COST` decimal(19, 6) NOT NULL,
  `QUAN1` decimal(19, 6) NOT NULL,
  `QUAN2` decimal(19, 6) NOT NULL,
  `MEMO` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `BAT_NO` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Exp_DateTime` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for IN_BACK00
-- ----------------------------
DROP TABLE IF EXISTS `IN_BACK00`;
CREATE TABLE `IN_BACK00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `IB_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STATUS` int(11) NOT NULL,
  `INPUT_DATE` datetime(0) NULL,
  `OUT_SHOP` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STOCK_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_DATETIME` datetime(0) NULL DEFAULT NULL,
  `RELATE_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LOCKED` tinyint(4) NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `Trans_STATUS` tinyint(4) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for IN_BACK01
-- ----------------------------
DROP TABLE IF EXISTS `IN_BACK01`;
CREATE TABLE `IN_BACK01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `IB_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SNo` int(11) NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUANTITY` decimal(19, 6) NOT NULL,
  `STD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STD_CONVERT` int(11) NOT NULL,
  `STD_QUAN` decimal(19, 6) NOT NULL,
  `STD_PRICE` decimal(19, 6) NOT NULL,
  `COST` decimal(19, 6) NOT NULL,
  `QUAN1` decimal(19, 6) NOT NULL,
  `QUAN2` decimal(19, 6) NOT NULL,
  `REASON_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `MEMO` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `BAT_NO` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Exp_DateTime` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for Inventory00
-- ----------------------------
DROP TABLE IF EXISTS `Inventory00`;
CREATE TABLE `Inventory00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `INV_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STATUS` int(11) NOT NULL,
  `INPUT_DATE` datetime(0) NULL,
  `INV_TYPE` int(11) NOT NULL,
  `STOCK_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_DATETIME` datetime(0) NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LOCKED` tinyint(4) NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `Trans_STATUS` tinyint(4) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for Inventory01
-- ----------------------------
DROP TABLE IF EXISTS `Inventory01`;
CREATE TABLE `Inventory01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `INV_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SNo` int(11) NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUANTITY` float NOT NULL,
  `QUAN` float NULL DEFAULT NULL,
  `QUAN1` float NULL DEFAULT NULL,
  `QUAN2` float NULL DEFAULT NULL,
  `QUAN_B` float NULL DEFAULT NULL,
  `MEMO` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Hidden` int(11) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for Inventory_STOCKBAK
-- ----------------------------
DROP TABLE IF EXISTS `Inventory_STOCKBAK`;
CREATE TABLE `Inventory_STOCKBAK`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `INV_ID` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PROD_ID` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STOCK_ID` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SHOP_ID` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUAN1` decimal(19, 6) NOT NULL,
  `QUAN2` decimal(19, 6) NOT NULL,
  `QUAN3` decimal(19, 6) NOT NULL,
  `CREATETIME` datetime(0) NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for Manager
-- ----------------------------
DROP TABLE IF EXISTS `Manager`;
CREATE TABLE `Manager`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `LoginName` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LoginPassword` varchar(32) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LoginTime` varchar(23) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `BranchID` int(11) NOT NULL,
  `BranchType` int(11) NOT NULL,
  `SHOP_ID` int(11) NOT NULL,
  `DIVISION_ID` int(11) NOT NULL,
  `IsEnable` int(11) NOT NULL,
  `EMP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `EMP_NAME` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `EMP_Birthday` varchar(23) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `EMP_ADD` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EMP_TEL` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EMP_ZIP` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EMP_EMAIL` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EMP_MOBILE` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EMP_MEMO` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EMP_ENABLE` int(11) NOT NULL,
  `EMP_SEX` int(11) NOT NULL,
  `EMP_CodeID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EMP_LEVEL` int(11) NOT NULL,
  `EMP_BDATE` varchar(23) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `EMP_EDATE` varchar(23) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EMP_WAGE` decimal(19, 6) NULL DEFAULT NULL,
  `EMP_Education` int(11) NULL DEFAULT NULL,
  `CRT_DATETIME` varchar(23) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` varchar(23) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` varchar(23) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `STATUS` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for Material00
-- ----------------------------
DROP TABLE IF EXISTS `Material00`;
CREATE TABLE `Material00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MA_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STATUS` int(11) NOT NULL,
  `INPUT_DATE` datetime(0) NULL,
  `DIV_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `MAT_TYPE` int(11) NOT NULL,
  `STOCK_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_DATETIME` datetime(0) NULL DEFAULT NULL,
  `RELATE_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LOCKED` tinyint(4) NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `Trans_STATUS` tinyint(4) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for Material01
-- ----------------------------
DROP TABLE IF EXISTS `Material01`;
CREATE TABLE `Material01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MA_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SNo` int(11) NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUANTITY` decimal(19, 6) NOT NULL,
  `STD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STD_CONVERT` int(11) NOT NULL,
  `STD_QUAN` decimal(19, 6) NOT NULL,
  `STD_PRICE` decimal(19, 6) NOT NULL,
  `COST` decimal(19, 6) NOT NULL,
  `QUAN1` decimal(19, 6) NOT NULL,
  `QUAN2` decimal(19, 6) NOT NULL,
  `MEMO` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `BAT_NO` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Exp_DateTime` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for MenuControlInfo
-- ----------------------------
DROP TABLE IF EXISTS `MenuControlInfo`;
CREATE TABLE `MenuControlInfo`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CName` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `EName` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MenuID` int(11) NOT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for MenuInfo
-- ----------------------------
DROP TABLE IF EXISTS `MenuInfo`;
CREATE TABLE `MenuInfo`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `Url` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `ParentID` int(11) NOT NULL,
  `Sort` int(11) NOT NULL,
  `Depth` int(11) NOT NULL,
  `IsDisplay` tinyint(4) NOT NULL,
  `IsMenu` tinyint(4) NOT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for ORDER00
-- ----------------------------
DROP TABLE IF EXISTS `ORDER00`;
CREATE TABLE `ORDER00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `ORDER_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `INPUT_DATE` datetime(0) NULL,
  `ORD_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `EXPECT_DATE` datetime(0) NULL,
  `STATUS` int(11) NOT NULL,
  `ORD_TYPE` int(11) NOT NULL,
  `OUT_SHOP` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `EXPORTED_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `EXPORTED` tinyint(4) NOT NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `APP_DATE` datetime(0) NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LOCKED` tinyint(4) NOT NULL,
  `ORD_DEP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `Trans_STATUS` tinyint(4) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for ORDER01
-- ----------------------------
DROP TABLE IF EXISTS `ORDER01`;
CREATE TABLE `ORDER01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `ORDER_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SNo` int(11) NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUANTITY` decimal(19, 6) NOT NULL,
  `ON_QUAN` decimal(19, 6) NOT NULL,
  `QUAN1` decimal(19, 6) NOT NULL,
  `QUAN2` decimal(19, 6) NOT NULL,
  `COST_PRICE` decimal(19, 6) NOT NULL,
  `STD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STD_CONVERT` int(11) NOT NULL,
  `STD_QUAN` decimal(19, 6) NOT NULL,
  `STD_PRICE` decimal(19, 6) NOT NULL,
  `Memo` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for ORDER_DEP00
-- ----------------------------
DROP TABLE IF EXISTS `ORDER_DEP00`;
CREATE TABLE `ORDER_DEP00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ORDDEP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `ORDDEP_NAME` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `ORDER_WEEK` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `USABLE` tinyint(4) NOT NULL,
  `Meno` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL DEFAULT NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL DEFAULT NULL,
  `STATUS` tinyint(4) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for ORDER_DEP01
-- ----------------------------
DROP TABLE IF EXISTS `ORDER_DEP01`;
CREATE TABLE `ORDER_DEP01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ORDDEP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SHOP_ID` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `USABLE` tinyint(4) NOT NULL,
  `Meno` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL DEFAULT NULL,
  `STATUS` tinyint(4) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for ORDER_DEP02
-- ----------------------------
DROP TABLE IF EXISTS `ORDER_DEP02`;
CREATE TABLE `ORDER_DEP02`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ORDDEP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `DEP_ID` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `USABLE` tinyint(4) NOT NULL,
  `Meno` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL DEFAULT NULL,
  `STATUS` tinyint(4) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for OUT00
-- ----------------------------
DROP TABLE IF EXISTS `OUT00`;
CREATE TABLE `OUT00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `OUT_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STATUS` int(11) NOT NULL,
  `INPUT_DATE` datetime(0) NULL,
  `IN_SHOP` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STOCK_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_DATETIME` datetime(0) NULL DEFAULT NULL,
  `EXPECT_DATE` datetime(0) NULL,
  `Exported` tinyint(4) NOT NULL,
  `Exported_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `RELATE_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LOCKED` tinyint(4) NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `Trans_STATUS` tinyint(4) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for OUT01
-- ----------------------------
DROP TABLE IF EXISTS `OUT01`;
CREATE TABLE `OUT01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `OUT_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SNo` int(11) NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUANTITY` decimal(19, 6) NOT NULL,
  `STD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STD_CONVERT` int(11) NOT NULL,
  `STD_QUAN` decimal(19, 6) NOT NULL,
  `STD_PRICE` decimal(19, 6) NOT NULL,
  `COST` decimal(19, 6) NOT NULL,
  `QUAN1` decimal(19, 6) NOT NULL,
  `QUAN2` decimal(19, 6) NOT NULL,
  `MEMO` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `BAT_NO` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Exp_DateTime` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for OUT_BACK00
-- ----------------------------
DROP TABLE IF EXISTS `OUT_BACK00`;
CREATE TABLE `OUT_BACK00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `BK_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STATUS` int(11) NOT NULL,
  `INPUT_DATE` datetime(0) NULL,
  `IN_SHOP` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STOCK_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_DATETIME` datetime(0) NULL DEFAULT NULL,
  `RELATE_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Exported` tinyint(4) NOT NULL,
  `Exported_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LOCKED` tinyint(4) NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `Trans_STATUS` tinyint(4) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for OUT_BACK01
-- ----------------------------
DROP TABLE IF EXISTS `OUT_BACK01`;
CREATE TABLE `OUT_BACK01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `BK_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SNo` int(11) NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUANTITY` float NOT NULL,
  `STD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STD_CONVERT` int(11) NOT NULL,
  `STD_QUAN` decimal(19, 6) NOT NULL,
  `STD_PRICE` decimal(19, 6) NOT NULL,
  `COST` decimal(19, 6) NOT NULL,
  `QUAN1` decimal(19, 6) NOT NULL,
  `QUAN2` decimal(19, 6) NOT NULL,
  `REASON_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `MEMO` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `BAT_NO` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Exp_DateTime` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for PLAN00
-- ----------------------------
DROP TABLE IF EXISTS `PLAN00`;
CREATE TABLE `PLAN00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PLAN_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STATUS` int(11) NOT NULL,
  `INPUT_DATE` datetime(0) NULL,
  `USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_DATETIME` datetime(0) NULL DEFAULT NULL,
  `EXPECT_DATE` datetime(0) NULL,
  `PREPARE_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EXPORTED` tinyint(4) NOT NULL,
  `EXPORTED_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `DIV_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `STOCK_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LOCKED` tinyint(4) NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `Trans_STATUS` tinyint(4) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for PLAN01
-- ----------------------------
DROP TABLE IF EXISTS `PLAN01`;
CREATE TABLE `PLAN01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PLAN_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SNo` int(11) NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUANTITY` decimal(19, 6) NOT NULL,
  `STD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STD_CONVERT` int(11) NOT NULL,
  `STD_QUAN` decimal(19, 6) NOT NULL,
  `STD_PRICE` decimal(19, 6) NOT NULL,
  `ACT_QUAN` decimal(19, 6) NOT NULL,
  `Dispose_QUAN` decimal(19, 6) NOT NULL,
  `QUAN` decimal(19, 6) NOT NULL,
  `BATCH1` decimal(19, 6) NOT NULL,
  `BATCH2` int(11) NOT NULL,
  `QUAN1` decimal(19, 6) NULL DEFAULT NULL,
  `QUAN2` decimal(19, 6) NULL DEFAULT NULL,
  `COM_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Memo` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for PLAN02
-- ----------------------------
DROP TABLE IF EXISTS `PLAN02`;
CREATE TABLE `PLAN02`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PLAN_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `BATCH_SNo` int(11) NOT NULL,
  `SNo` int(11) NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUANTITY` decimal(19, 6) NOT NULL,
  `STD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STD_CONVERT` int(11) NOT NULL,
  `STD_QUAN` decimal(19, 6) NOT NULL,
  `STD_PRICE` decimal(19, 6) NOT NULL,
  `Memo` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for PREPARE00
-- ----------------------------
DROP TABLE IF EXISTS `PREPARE00`;
CREATE TABLE `PREPARE00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PREPAR_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STATUS` int(11) NOT NULL,
  `INPUT_DATE` datetime(0) NULL,
  `PRE_TYPE` int(11) NOT NULL,
  `STOCK_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_DATETIME` datetime(0) NULL DEFAULT NULL,
  `RELATE_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LOCKED` bit(1) NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `Trans_STATUS` bit(1) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for PREPARE01
-- ----------------------------
DROP TABLE IF EXISTS `PREPARE01`;
CREATE TABLE `PREPARE01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PREPARE_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SNo` int(11) NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUANTITY` decimal(19, 6) NOT NULL,
  `STD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STD_CONVERT` int(11) NOT NULL,
  `STD_QUAN` decimal(19, 6) NOT NULL,
  `STD_PRICE` decimal(19, 6) NOT NULL,
  `COST` decimal(19, 6) NOT NULL,
  `QUAN1` decimal(19, 6) NOT NULL,
  `QUAN2` decimal(19, 6) NOT NULL,
  `sProd_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `BAT_NO` int(11) NULL DEFAULT NULL,
  `IsScales` tinyint(4) NULL DEFAULT NULL,
  `IsFlag` tinyint(4) NULL DEFAULT NULL,
  `Scales_User` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Scale_Date` datetime(0) NULL DEFAULT NULL,
  `MEMO` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Exported_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for PRODUCT00
-- ----------------------------
DROP TABLE IF EXISTS `PRODUCT00`;
CREATE TABLE `PRODUCT00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PROD_NAME1` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PROD_NAME2` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `PROD_KIND` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PROD_DEP` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PROD_CATE` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `DIV_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `PROD_TYPE` tinyint(4) NOT NULL,
  `PROD_Source` int(11) NOT NULL,
  `INV_TYPE` int(11) NOT NULL,
  `STOCK_TYPE` int(11) NOT NULL,
  `BOM_TYPE` int(11) NOT NULL,
  `MarginControl` int(11) NOT NULL,
  `PROD_RangTYPE` int(11) NOT NULL,
  `PROD_iRang` int(11) NOT NULL,
  `PROD_SPEC` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PROD_Margin` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `PROD_BARCODE` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `PROD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PROD_UNIT1` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PROD_CONVERT1` int(11) NOT NULL,
  `PROD_UNIT2` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PROD_CONVERT2` int(11) NOT NULL,
  `Report_UNIT` int(11) NOT NULL,
  `IsBool1` tinyint(4) NULL DEFAULT NULL,
  `IsBool2` tinyint(4) NULL DEFAULT NULL,
  `IsBool3` bit(1) NULL DEFAULT NULL,
  `PROD_MEMO` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL DEFAULT NULL,
  `STATUS` tinyint(4) NULL DEFAULT NULL,
  `PROD_NAME1_SPELLING` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for PRODUCT01
-- ----------------------------
DROP TABLE IF EXISTS `PRODUCT01`;
CREATE TABLE `PRODUCT01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `PRCAREA_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SUP_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SEND_TYPE` tinyint(4) NOT NULL,
  `TAX_TYPE` tinyint(4) NOT NULL,
  `Tax` int(11) NOT NULL,
  `SUP_COST` decimal(19, 6) NOT NULL,
  `SUP_COST1` decimal(19, 6) NOT NULL,
  `SUP_COST2` decimal(19, 6) NOT NULL,
  `SUP_Return` decimal(19, 6) NOT NULL,
  `SUP_Return1` decimal(19, 6) NOT NULL,
  `SUP_Return2` decimal(19, 6) NOT NULL,
  `U_Cost` decimal(19, 6) NOT NULL,
  `U_Cost1` decimal(19, 6) NOT NULL,
  `U_Cost2` decimal(19, 6) NOT NULL,
  `U_Ret_COST` decimal(19, 6) NOT NULL,
  `U_Ret_COST1` decimal(19, 6) NOT NULL,
  `U_Ret_COST2` decimal(19, 6) NOT NULL,
  `T_COST` decimal(19, 6) NOT NULL,
  `T_COST1` decimal(19, 6) NOT NULL,
  `T_COST2` decimal(19, 6) NOT NULL,
  `T_Ret_COST` decimal(19, 6) NOT NULL,
  `T_Ret_COST1` decimal(19, 6) NOT NULL,
  `T_Ret_COST2` decimal(19, 6) NOT NULL,
  `COST` decimal(19, 6) NOT NULL,
  `COST1` decimal(19, 6) NOT NULL,
  `COST2` decimal(19, 6) NOT NULL,
  `ENABLE` tinyint(4) NOT NULL,
  `VISIBLE` tinyint(4) NOT NULL,
  `BOM_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `STATUS` tinyint(4) NULL DEFAULT NULL,
  `ORDER_UNIT` int(11) NOT NULL,
  `ORDER_QUAN` int(11) NOT NULL,
  `Purchase_UNIT` int(11) NOT NULL,
  `Purchase_QUAN` int(11) NOT NULL,
  `SAFE_QUAN` int(11) NOT NULL,
  `PROD_PRICE` decimal(19, 2) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for PROD_Cate
-- ----------------------------
DROP TABLE IF EXISTS `PROD_Cate`;
CREATE TABLE `PROD_Cate`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `CATE_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `CATE_NAME` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `ENABLE` tinyint(4) NOT NULL,
  `DEP_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `IsBool1` tinyint(4) NULL DEFAULT NULL,
  `IsBool2` tinyint(4) NULL DEFAULT NULL,
  `IsBool3` tinyint(4) NULL DEFAULT NULL,
  `CATE_MEMO` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL DEFAULT NULL,
  `STATUS` bit(1) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for PROD_DEP
-- ----------------------------
DROP TABLE IF EXISTS `PROD_DEP`;
CREATE TABLE `PROD_DEP`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `DEP_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `DEP_NAME` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `ENABLE` tinyint(4) NOT NULL,
  `KIND_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `IsBool1` tinyint(4) NULL DEFAULT NULL,
  `IsBool2` tinyint(4) NULL DEFAULT NULL,
  `IsBool3` tinyint(4) NULL DEFAULT NULL,
  `DEP_MEMO` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL DEFAULT NULL,
  `STATUS` tinyint(4) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for PROD_KIND
-- ----------------------------
DROP TABLE IF EXISTS `PROD_KIND`;
CREATE TABLE `PROD_KIND`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `KIND_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `KIND_NAME` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `ENABLE` tinyint(4) NOT NULL,
  `ISBOM` tinyint(4) NOT NULL,
  `IsBool` tinyint(4) NULL DEFAULT NULL,
  `KIND_MEMO` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL DEFAULT NULL,
  `STATUS` tinyint(4) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for PROD_UNIT
-- ----------------------------
DROP TABLE IF EXISTS `PROD_UNIT`;
CREATE TABLE `PROD_UNIT`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UNIT_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `UNIT_NAME` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `UNIT_MEMO` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL DEFAULT NULL,
  `STATUS` tinyint(4) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for Purchase00
-- ----------------------------
DROP TABLE IF EXISTS `Purchase00`;
CREATE TABLE `Purchase00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `Purchase_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STATUS` int(11) NOT NULL,
  `PAY_STATUS` int(11) NOT NULL,
  `INPUT_DATE` datetime(0) NULL,
  `SUP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `EXPECT_DATE` datetime(0) NULL,
  `USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_DATETIME` datetime(0) NULL DEFAULT NULL,
  `TOT_AMOUNT` decimal(19, 6) NOT NULL,
  `TOT_TAX` decimal(19, 6) NOT NULL,
  `TOT_QTY` decimal(19, 6) NOT NULL,
  `PRE_PAY` decimal(19, 6) NOT NULL,
  `PRE_PAY_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `EXPORTED` tinyint(4) NOT NULL,
  `EXPORTED_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LOCKED` tinyint(4) NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `Trans_STATUS` tinyint(4) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for Purchase01
-- ----------------------------
DROP TABLE IF EXISTS `Purchase01`;
CREATE TABLE `Purchase01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `Purchase_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SNo` int(11) NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUANTITY` decimal(19, 6) NOT NULL,
  `STD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STD_CONVERT` int(11) NOT NULL,
  `STD_QUAN` decimal(19, 6) NOT NULL,
  `STD_PRICE` decimal(19, 6) NOT NULL,
  `Tax` decimal(19, 6) NOT NULL,
  `QUAN1` decimal(19, 6) NOT NULL,
  `QUAN2` decimal(19, 6) NOT NULL,
  `Item_DISC_Amt` decimal(19, 6) NOT NULL,
  `MEMO` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for RECEIVABLES00
-- ----------------------------
DROP TABLE IF EXISTS `RECEIVABLES00`;
CREATE TABLE `RECEIVABLES00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `BILL_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STATUS` int(11) NOT NULL,
  `INPUT_DATE` datetime(0) NULL,
  `IN_SHOP` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_DATETIME` datetime(0) NULL DEFAULT NULL,
  `MEMO` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL DEFAULT NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` datetime(0) NULL DEFAULT NULL,
  `BILL_AMOUNT` decimal(19, 6) NULL DEFAULT NULL,
  `BILL_COST` decimal(19, 6) NULL DEFAULT NULL,
  `BILL_TYPE` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for RECEIVABLES01
-- ----------------------------
DROP TABLE IF EXISTS `RECEIVABLES01`;
CREATE TABLE `RECEIVABLES01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `OUT_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SNo` int(11) NULL DEFAULT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `STD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `STD_QUAN` decimal(19, 6) NULL DEFAULT NULL,
  `STD_PRICE` decimal(19, 6) NULL DEFAULT NULL,
  `COST` decimal(19, 6) NULL DEFAULT NULL,
  `QUAN1` decimal(19, 6) NULL DEFAULT NULL,
  `QUAN2` decimal(19, 6) NULL DEFAULT NULL,
  `MEMO` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `BAT_NO` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for SHOP00
-- ----------------------------
DROP TABLE IF EXISTS `SHOP00`;
CREATE TABLE `SHOP00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SHOP_NAME1` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SHOP_NAME2` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SHOP_KIND` int(11) NOT NULL,
  `SHOP_Area_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SHOP_Price_Area` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SHOP_ADD` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SHOP_TEL` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SHOP_EMAIL` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SHOP_CONTECT` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SHOP_MEMO` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SHOP_STATUS` tinyint(4) NOT NULL,
  `SHOP_Limited` int(11) NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL DEFAULT NULL,
  `STATUS` tinyint(4) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for SHOP_ACCOUNT
-- ----------------------------
DROP TABLE IF EXISTS `SHOP_ACCOUNT`;
CREATE TABLE `SHOP_ACCOUNT`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `HEAD_SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `USED_AMOUNT` decimal(19, 6) NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL DEFAULT NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  `CREDIT_AMOUNT` decimal(19, 6) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for SHOP_BILL
-- ----------------------------
DROP TABLE IF EXISTS `SHOP_BILL`;
CREATE TABLE `SHOP_BILL`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `HEAD_SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `BILL_AMOUNT` decimal(19, 6) NULL DEFAULT NULL,
  `PAY_METHOD` int(11) NULL DEFAULT NULL,
  `BILL_DATE` datetime(0) NULL DEFAULT NULL,
  `PAY_DATE` datetime(0) NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL DEFAULT NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for SHOP_PAY_HISOTRY
-- ----------------------------
DROP TABLE IF EXISTS `SHOP_PAY_HISOTRY`;
CREATE TABLE `SHOP_PAY_HISOTRY`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Head_SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `BILL_ID` bigint(20) NULL DEFAULT NULL,
  `AMOUNT` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `PAY_DATE` datetime(0) NULL DEFAULT NULL,
  `PAYER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL DEFAULT NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for SHOP_PRICE_AREA
-- ----------------------------
DROP TABLE IF EXISTS `SHOP_PRICE_AREA`;
CREATE TABLE `SHOP_PRICE_AREA`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `PRCAREA_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PRCAREA_NAME` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `ENABLE` tinyint(4) NOT NULL,
  `PRCAREA_MEMO` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL DEFAULT NULL,
  `STATUS` tinyint(4) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for SHOP_SUPPLIER_RELATION
-- ----------------------------
DROP TABLE IF EXISTS `SHOP_SUPPLIER_RELATION`;
CREATE TABLE `SHOP_SUPPLIER_RELATION`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SUP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SUP_NAME` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `MEMO` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for STOCK
-- ----------------------------
DROP TABLE IF EXISTS `STOCK`;
CREATE TABLE `STOCK`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STOCK_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STOCK_NAME` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `IsDefBill` tinyint(4) NOT NULL,
  `IsBool` tinyint(4) NULL DEFAULT NULL,
  `Memo` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `Stock_Kind` int(11) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for STOCK01
-- ----------------------------
DROP TABLE IF EXISTS `STOCK01`;
CREATE TABLE `STOCK01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `STOCK_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STOCK_UNIT_QUAN` decimal(19, 6) NOT NULL,
  `STOCK_UNIT1_QUAN` decimal(19, 6) NOT NULL,
  `STOCK_UNIT2_QUAN` decimal(19, 6) NOT NULL,
  `USABLE` tinyint(4) NOT NULL,
  `Meno` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `SHOP_ID` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `COST` decimal(19, 6) NOT NULL,
  `COST1` decimal(19, 6) NOT NULL,
  `COST2` decimal(19, 6) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for STOCK02
-- ----------------------------
DROP TABLE IF EXISTS `STOCK02`;
CREATE TABLE `STOCK02`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `STOCK_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `USABLE` tinyint(4) NOT NULL,
  `Meno` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for SUPPLIERS
-- ----------------------------
DROP TABLE IF EXISTS `SUPPLIERS`;
CREATE TABLE `SUPPLIERS`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SUP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SUP_NAME` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SUP_NICKNAME` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SUP_TYPE` int(11) NOT NULL,
  `SUP_ADD` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SUP_TEL` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SUP_Email` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SUP_ZIP` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SUP_Contact` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SUP_Mobile` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SUP_CODE_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SUP_BankName` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SUP_BankID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SUP_PASSWORD` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `Send_DAY` int(11) NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for SYS_PARAMATERS
-- ----------------------------
DROP TABLE IF EXISTS `SYS_PARAMATERS`;
CREATE TABLE `SYS_PARAMATERS`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Code` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `VALUE` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `KEY_CN` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `MEMO` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Area_Id` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for TABLE_SEED
-- ----------------------------
DROP TABLE IF EXISTS `TABLE_SEED`;
CREATE TABLE `TABLE_SEED`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `TABLE_NAME` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SEED_DATETIME` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `SEED_ID` int(11) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for TAKEIN00
-- ----------------------------
DROP TABLE IF EXISTS `TAKEIN00`;
CREATE TABLE `TAKEIN00`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `TAKEIN_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STATUS` int(11) NOT NULL,
  `INPUT_DATE` datetime(0) NULL,
  `STOCK_ID` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `APP_DATETIME` datetime(0) NULL DEFAULT NULL,
  `RELATE_ID` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Memo` tinyint(4) NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `Trans_STATUS` tinyint(4) NOT NULL,
  `TAKEIN_TYPE` tinyint(4) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for TAKEIN01
-- ----------------------------
DROP TABLE IF EXISTS `TAKEIN01`;
CREATE TABLE `TAKEIN01`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `TAKEIN_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SNo` int(11) NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUANTITY` decimal(19, 6) NOT NULL,
  `STD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STD_CONVERT` int(11) NOT NULL,
  `STD_QUAN` decimal(19, 6) NOT NULL,
  `STD_PRICE` decimal(19, 6) NOT NULL,
  `COST` decimal(19, 6) NOT NULL,
  `PLAN_QUAN` decimal(19, 6) NOT NULL,
  `IsDispose` tinyint(4) NOT NULL,
  `QUAN1` decimal(19, 6) NULL DEFAULT NULL,
  `QUAN2` decimal(19, 6) NULL DEFAULT NULL,
  `RELATE_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `COM_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `BAT_NO` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Exp_DateTime` datetime(0) NULL DEFAULT NULL,
  `Memo` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for TAKEIN10
-- ----------------------------
DROP TABLE IF EXISTS `TAKEIN10`;
CREATE TABLE `TAKEIN10`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `TAKEIN_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STATUS` int(11) NOT NULL,
  `STOCK_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `INPUT_DATE` datetime(0) NULL,
  `SUP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `APP_USER` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `APP_DATETIME` datetime(0) NULL DEFAULT NULL,
  `TOT_AMOUNT` decimal(19, 6) NOT NULL,
  `TOT_TAX` decimal(19, 6) NOT NULL,
  `TOT_QTY` decimal(19, 6) NOT NULL,
  `PRE_PAY` decimal(19, 6) NOT NULL,
  `PRE_PAY_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `RELATE_ID` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `INVOICE_ID` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `TAKEIN_TYPE` int(11) NOT NULL,
  `Memo` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LOCKED` tinyint(4) NOT NULL,
  `CRT_DATETIME` datetime(0) NULL,
  `CRT_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `MOD_DATETIME` datetime(0) NULL DEFAULT NULL,
  `MOD_USER_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `LAST_UPDATE` datetime(0) NULL,
  `Trans_STATUS` tinyint(4) NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for TAKEIN11
-- ----------------------------
DROP TABLE IF EXISTS `TAKEIN11`;
CREATE TABLE `TAKEIN11`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SHOP_ID` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `TAKEIN_ID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `SNo` int(11) NOT NULL,
  `PROD_ID` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `QUANTITY` decimal(19, 6) NOT NULL,
  `STD_UNIT` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `STD_CONVERT` int(11) NOT NULL,
  `STD_QUAN` decimal(19, 6) NOT NULL,
  `STD_PRICE` decimal(19, 6) NOT NULL,
  `Tax` decimal(19, 6) NOT NULL,
  `QUAN1` decimal(19, 6) NOT NULL,
  `QUAN2` decimal(19, 6) NOT NULL,
  `Item_DISC_Amt` decimal(19, 6) NOT NULL,
  `MEMO` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `BAT_NO` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Exp_DateTime` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for UploadConfig
-- ----------------------------
DROP TABLE IF EXISTS `UploadConfig`;
CREATE TABLE `UploadConfig`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `JoinName` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `UserType` tinyint(4) NOT NULL,
  `UploadType_TypeKey` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PicSize` int(11) NOT NULL,
  `FileSize` int(11) NOT NULL,
  `SaveDir` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `IsPost` tinyint(4) NOT NULL,
  `IsChkSrcPost` tinyint(4) NOT NULL,
  `IsEditor` tinyint(4) NOT NULL,
  `IsSwf` tinyint(4) NOT NULL,
  `CutType` int(11) NOT NULL,
  `IsFixPic` tinyint(4) NOT NULL,
  `PicWidth` int(11) NOT NULL,
  `PicHeight` int(11) NOT NULL,
  `PicQuality` int(11) NOT NULL,
  `IsBigPic` tinyint(4) NOT NULL,
  `BigWidth` int(11) NOT NULL,
  `BigHeight` int(11) NOT NULL,
  `BigQuality` int(11) NOT NULL,
  `IsMidPic` tinyint(4) NOT NULL,
  `MidWidth` int(11) NOT NULL,
  `MidHeight` int(11) NOT NULL,
  `MidQuality` int(11) NOT NULL,
  `IsMinPic` tinyint(4) NOT NULL,
  `MinWidth` int(11) NOT NULL,
  `MinHeight` int(11) NOT NULL,
  `MinQuality` int(11) NOT NULL,
  `IsHotPic` tinyint(4) NOT NULL,
  `HotWidth` int(11) NOT NULL,
  `HotHeight` int(11) NOT NULL,
  `HotQuality` int(11) NOT NULL,
  `IsWaterPic` tinyint(4) NOT NULL,
  `Manager_Id` int(11) NOT NULL,
  `Manager_CName` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `UpdateDate` datetime(0) NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for WebLog
-- ----------------------------
DROP TABLE IF EXISTS `WebLog`;
CREATE TABLE `WebLog`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ManagerID` int(11) NOT NULL,
  `CName` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `AddTime` varchar(23) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `Notes` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for loginlog
-- ----------------------------
DROP TABLE IF EXISTS `loginlog`;
CREATE TABLE `loginlog`  (
  `Id` int(11) NOT NULL,
  `UserId` int(11) NULL DEFAULT NULL,
  `LoginTime` datetime(0) NULL DEFAULT NULL,
  `LoginIp` varchar(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Email` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Password` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Status` int(11) NULL DEFAULT NULL,
  `IsDelete` int(11) NULL DEFAULT NULL,
  `RegisterTime` datetime(0) NULL DEFAULT NULL,
  `IsAdmin` int(11) NULL DEFAULT NULL,
  `AuthToken` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
