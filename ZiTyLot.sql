-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th10 07, 2024 lúc 07:26 AM
-- Phiên bản máy phục vụ: 10.4.32-MariaDB
-- Phiên bản PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `zitylot`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `accounts`
--

CREATE TABLE `accounts` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `full_name` varchar(255) DEFAULT NULL,
  `gender` enum('MALE','FEMALE') DEFAULT NULL,
  `national_id` varchar(20) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL,
  `role_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `accounts`
--

INSERT INTO `accounts` (`id`, `username`, `password`, `full_name`, `gender`, `national_id`, `email`, `phone`, `created_at`, `updated_at`, `deleted_at`, `role_id`) VALUES
(1, 'admin', 'admin123', 'Nguyễn Văn A', 'MALE', '123456789', 'nguyenvana@example.com', '0912345678', '2024-10-05 08:00:00', NULL, NULL, 1),
(2, 'tranthib', 'password123', 'Trần Thị B', 'FEMALE', '234567890', 'tranthib@example.com', '0987654321', '2024-10-05 09:00:00', NULL, NULL, 2),
(3, 'levanc', 'password123', 'Lê Văn C', 'MALE', '345678901', 'levanc@example.com', '0356789123', '2024-10-05 10:00:00', NULL, NULL, 2),
(4, 'phamthid', 'password123', 'Phạm Thị D', 'FEMALE', '456789012', 'phamthid@example.com', '0865432198', '2024-10-05 11:00:00', NULL, NULL, 2),
(5, 'vuvane', 'password123', 'Vũ Văn E', 'MALE', '567890123', 'vuvane@example.com', '0978563412', '2024-10-05 12:00:00', NULL, NULL, 2),
(6, 'dinhthif', 'password123', 'Đinh Thị F', 'FEMALE', '678901234', 'dinhthif@example.com', '0367891234', '2024-10-05 13:00:00', NULL, NULL, 2),
(7, 'buivang', 'password123', 'Bùi Văn G', 'MALE', '789012345', 'buivang@example.com', '0887654321', '2024-10-05 14:00:00', NULL, NULL, 2),
(8, 'maithih', 'password123', 'Mai Thị H', 'FEMALE', '890123456', 'maithih@example.com', '0934567890', '2024-10-05 15:00:00', NULL, NULL, 2),
(9, 'tranvani', 'password123', 'Trần Văn I', 'MALE', '901234567', 'tranvani@example.com', '0834567123', '2024-10-05 16:00:00', NULL, NULL, 2),
(10, 'nguyenthik', 'password123', 'Nguyễn Thị K', 'FEMALE', '012345678', 'nguyenthik@example.com', '0945612378', '2024-10-05 17:00:00', NULL, NULL, 2);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `bills`
--

CREATE TABLE `bills` (
  `id` int(11) NOT NULL,
  `total_fee` double DEFAULT NULL,
  `issue_quantity` int(11) DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL,
  `account_id` int(11) DEFAULT NULL,
  `resident_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `bills`
--

INSERT INTO `bills` (`id`, `total_fee`, `issue_quantity`, `created_at`, `updated_at`, `deleted_at`, `account_id`, `resident_id`) VALUES
(1, 50.75, 1, '2024-10-05 08:00:00', NULL, NULL, 1, 1),
(2, 75.25, 2, '2024-10-05 09:00:00', NULL, NULL, 2, 2),
(3, 100, 1, '2024-10-05 10:00:00', NULL, NULL, 3, 3),
(4, 120.5, 3, '2024-10-05 11:00:00', NULL, NULL, 4, 4),
(5, 80, 1, '2024-10-05 12:00:00', NULL, NULL, 5, 5),
(6, 95.75, 2, '2024-10-05 13:00:00', NULL, NULL, 6, 6),
(7, 110.25, 1, '2024-10-05 14:00:00', NULL, NULL, 7, 7),
(8, 65.5, 3, '2024-10-05 15:00:00', NULL, NULL, 8, 8),
(9, 85, 1, '2024-10-05 16:00:00', NULL, NULL, 9, 9),
(10, 70.25, 2, '2024-10-05 17:00:00', NULL, NULL, 10, 10);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `cards`
--

CREATE TABLE `cards` (
  `id` int(11) NOT NULL,
  `rfid` varchar(255) NOT NULL,
  `status` enum('EMPTY','ACTIVE','BLOCKED','LOST') DEFAULT NULL,
  `type` enum('RESIDENT','VISITOR') DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL,
  `vehicle_type_id` int(11) DEFAULT NULL,
  `resident_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `cards`
--

INSERT INTO `cards` (`id`, `rfid`, `status`, `type`, `created_at`, `updated_at`, `deleted_at`, `vehicle_type_id`, `resident_id`) VALUES
(1, 'RFID001', 'ACTIVE', 'RESIDENT', '2024-10-05 08:00:00', NULL, NULL, NULL, 1),
(2, 'RFID002', 'ACTIVE', 'RESIDENT', '2024-10-05 09:00:00', NULL, NULL, NULL, 2),
(3, 'RFID003', 'ACTIVE', 'RESIDENT', '2024-10-05 10:00:00', NULL, NULL, NULL, 3),
(4, 'RFID004', 'ACTIVE', 'RESIDENT', '2024-10-05 11:00:00', NULL, NULL, NULL, 4),
(5, 'RFID005', 'ACTIVE', 'RESIDENT', '2024-10-05 12:00:00', NULL, NULL, NULL, 5),
(6, 'RFID006', 'ACTIVE', 'RESIDENT', '2024-10-05 13:00:00', NULL, NULL, NULL, 6),
(7, 'RFID007', 'ACTIVE', 'RESIDENT', '2024-10-05 14:00:00', NULL, NULL, NULL, 7),
(8, 'RFID008', 'ACTIVE', 'RESIDENT', '2024-10-05 15:00:00', NULL, NULL, NULL, 8),
(9, 'RFID009', 'ACTIVE', 'RESIDENT', '2024-10-05 16:00:00', NULL, NULL, NULL, 9),
(10, 'RFID010', 'ACTIVE', 'RESIDENT', '2024-10-05 17:00:00', NULL, NULL, NULL, 10),
(11, 'RFID011', 'ACTIVE', 'RESIDENT', '2024-10-05 18:00:00', NULL, NULL, NULL, 11),
(12, 'RFID012', 'ACTIVE', 'RESIDENT', '2024-10-05 19:00:00', NULL, NULL, NULL, 12),
(13, 'RFID013', 'ACTIVE', 'RESIDENT', '2024-10-05 20:00:00', NULL, NULL, NULL, 13),
(14, 'RFID014', 'ACTIVE', 'RESIDENT', '2024-10-05 21:00:00', NULL, NULL, NULL, 14),
(15, 'RFID015', 'ACTIVE', 'RESIDENT', '2024-10-05 22:00:00', NULL, NULL, NULL, 15),
(16, 'RFID016', 'ACTIVE', 'RESIDENT', '2024-10-05 23:00:00', NULL, NULL, NULL, 16),
(17, 'RFID017', 'ACTIVE', 'RESIDENT', '2024-10-06 00:00:00', NULL, NULL, NULL, 17),
(18, 'RFID018', 'ACTIVE', 'RESIDENT', '2024-10-06 01:00:00', NULL, NULL, NULL, 18),
(19, 'RFID019', 'ACTIVE', 'RESIDENT', '2024-10-06 02:00:00', NULL, NULL, NULL, 19),
(20, 'RFID020', 'ACTIVE', 'RESIDENT', '2024-10-06 03:00:00', NULL, NULL, NULL, 20);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `functions`
--

CREATE TABLE `functions` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `icon` varchar(255) DEFAULT NULL,
  `active_icon` varchar(255) DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `functions`
--

INSERT INTO `functions` (`id`, `name`, `icon`, `active_icon`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, 'Add', 'add_icon.png', 'add_icon_active.png', '2024-10-05 08:00:00', NULL, NULL),
(2, 'Edit', 'edit_icon.png', 'edit_icon_active.png', '2024-10-05 09:00:00', NULL, NULL),
(3, 'Delete', 'delete_icon.png', 'delete_icon_active.png', '2024-10-05 10:00:00', NULL, NULL),
(4, 'Read', 'read_icon.png', 'read_icon_active.png', '2024-10-05 11:00:00', NULL, NULL),
(5, 'Statistics', 'stats_icon.png', 'stats_icon_active.png', '2024-10-05 12:00:00', NULL, NULL);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `images`
--

CREATE TABLE `images` (
  `id` int(11) NOT NULL,
  `url` varchar(255) DEFAULT NULL,
  `type` enum('BEFORE_CHECKIN','AFTER_CHECKIN','LICENSE_PLATE_CHECKIN','BEFORE_CHECKOUT','AFTER_CHECKOUT','LICENSE_PLATE_CHECKOUT') DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL,
  `session_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `images`
--

INSERT INTO `images` (`id`, `url`, `type`, `created_at`, `updated_at`, `deleted_at`, `session_id`) VALUES
(2, 'https://example.com/image1.jpg', 'BEFORE_CHECKIN', '2024-10-05 08:00:00', NULL, NULL, 1),
(3, 'https://example.com/image2.jpg', 'AFTER_CHECKIN', '2024-10-05 09:00:00', NULL, NULL, 2),
(4, 'https://example.com/image3.jpg', 'LICENSE_PLATE_CHECKIN', '2024-10-05 10:00:00', NULL, NULL, 3),
(5, 'https://example.com/image4.jpg', 'BEFORE_CHECKOUT', '2024-10-05 11:00:00', NULL, NULL, 4),
(6, 'https://example.com/image5.jpg', 'AFTER_CHECKOUT', '2024-10-05 12:00:00', NULL, NULL, 5),
(7, 'https://example.com/image6.jpg', 'LICENSE_PLATE_CHECKOUT', '2024-10-05 13:00:00', NULL, NULL, 6),
(8, 'https://example.com/image7.jpg', 'BEFORE_CHECKIN', '2024-10-05 14:00:00', NULL, NULL, 7),
(9, 'https://example.com/image8.jpg', 'AFTER_CHECKIN', '2024-10-05 15:00:00', NULL, NULL, 8),
(10, 'https://example.com/image9.jpg', 'LICENSE_PLATE_CHECKIN', '2024-10-05 16:00:00', NULL, NULL, 9),
(11, 'https://example.com/image10.jpg', 'BEFORE_CHECKOUT', '2024-10-05 17:00:00', NULL, NULL, 10),
(12, 'https://example.com/image11.jpg', 'AFTER_CHECKOUT', '2024-10-05 18:00:00', NULL, NULL, 11),
(13, 'https://example.com/image12.jpg', 'LICENSE_PLATE_CHECKOUT', '2024-10-05 19:00:00', NULL, NULL, 12),
(14, 'https://example.com/image13.jpg', 'BEFORE_CHECKIN', '2024-10-05 20:00:00', NULL, NULL, 13),
(15, 'https://example.com/image14.jpg', 'AFTER_CHECKIN', '2024-10-05 21:00:00', NULL, NULL, 14),
(16, 'https://example.com/image15.jpg', 'LICENSE_PLATE_CHECKIN', '2024-10-05 22:00:00', NULL, NULL, 15),
(17, 'https://example.com/image16.jpg', 'BEFORE_CHECKOUT', '2024-10-05 23:00:00', NULL, NULL, 16),
(18, 'https://example.com/image17.jpg', 'AFTER_CHECKOUT', '2024-10-06 00:00:00', NULL, NULL, 17),
(19, 'https://example.com/image18.jpg', 'LICENSE_PLATE_CHECKOUT', '2024-10-06 01:00:00', NULL, NULL, 18),
(20, 'https://example.com/image19.jpg', 'BEFORE_CHECKIN', '2024-10-06 02:00:00', NULL, NULL, 19),
(21, 'https://example.com/image20.jpg', 'AFTER_CHECKIN', '2024-10-06 03:00:00', NULL, NULL, 20);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `issues`
--

CREATE TABLE `issues` (
  `id` int(11) NOT NULL,
  `start_date` datetime NOT NULL,
  `end_date` datetime NOT NULL,
  `license_plate` varchar(255) DEFAULT NULL,
  `fee` double DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL,
  `bill_id` int(11) DEFAULT NULL,
  `vehicle_type_id` int(11) DEFAULT NULL,
  `parking_lot_id` varchar(20) DEFAULT NULL,
  `slot_id` varchar(20) DEFAULT NULL,
  `card_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `issues`
--

INSERT INTO `issues` (`id`, `start_date`, `end_date`, `license_plate`, `fee`, `created_at`, `updated_at`, `deleted_at`, `bill_id`, `vehicle_type_id`, `parking_lot_id`, `slot_id`, `card_id`) VALUES
(112, '2024-10-01 08:00:00', '2024-11-01 08:00:00', '29A-12345', 200000, '2024-10-01 08:00:00', NULL, NULL, 1, 2, 'RL2W-A1', 'S01-RL2W-A1', 1),
(113, '2024-10-02 09:00:00', '2024-12-02 09:00:00', '51C-67890', 550000, '2024-10-02 09:00:00', NULL, NULL, 2, 2, 'RL2W-A1', 'S02-RL2W-A1', 2),
(114, '2024-10-03 10:00:00', '2025-03-03 10:00:00', '43H-24680', 1000000, '2024-10-03 10:00:00', NULL, NULL, 3, 2, 'RL2W-A1', 'S03-RL2W-A1', 3),
(115, '2024-10-04 11:00:00', '2024-11-04 11:00:00', '92P-86420', 100000, '2024-10-04 11:00:00', NULL, NULL, 4, 3, 'RL2W-A1', 'S04-RL2W-A1', 4),
(116, '2024-10-05 12:00:00', '2024-12-05 12:00:00', '14A-97531', 250000, '2024-10-05 12:00:00', NULL, NULL, 5, 3, 'RL2W-A1', 'S05-RL4W-A1', 5),
(122, '2024-10-06 13:00:00', '2025-03-06 13:00:00', '56B-73201', 450000, '2024-10-06 13:00:00', NULL, NULL, 6, 3, 'RL2W-A2', 'S01-RL2W-A1', 6),
(123, '2024-10-07 14:00:00', '2025-03-07 14:00:00', '78C-10923', 1000000, '2024-10-07 14:00:00', NULL, NULL, 7, 1, 'RL2W-A2', 'S02-RL4W-A1', 7),
(124, '2024-10-08 15:00:00', '2024-12-08 15:00:00', '39H-56214', 2700000, '2024-10-08 15:00:00', NULL, NULL, 8, 1, 'RL4W-A1', 'S01-RL4W-A1', 8),
(125, '2024-10-09 16:00:00', '2025-03-09 16:00:00', '87P-32451', 5000000, '2024-10-09 16:00:00', NULL, NULL, 9, 1, 'RL4W-A1', 'S02-RL4W-A1', 9),
(126, '2024-10-09 17:00:00', '2025-03-09 17:00:00', '57P-32451', 5000000, '2024-10-09 16:00:00', NULL, NULL, 10, 1, 'RL4W-A1', 'S03-RL4W-A1', 10);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `lost_history`
--

CREATE TABLE `lost_history` (
  `id` int(11) NOT NULL,
  `time_loss` datetime NOT NULL,
  `license_plate` varchar(255) NOT NULL,
  `owner_name` varchar(255) DEFAULT NULL,
  `owner_identification_card` varchar(20) DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL,
  `card_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `lost_history`
--

INSERT INTO `lost_history` (`id`, `time_loss`, `license_plate`, `owner_name`, `owner_identification_card`, `created_at`, `updated_at`, `deleted_at`, `card_id`) VALUES
(1, '2024-10-01 10:00:00', '29A-12345', 'John Doe', '1234567890', '2024-10-01 10:00:00', '2024-10-01 10:00:00', NULL, 1),
(2, '2024-10-02 12:00:00', '51C-67890', 'Jane Smith', '0987654321', '2024-10-02 12:00:00', '2024-10-02 12:00:00', NULL, 2),
(3, '2024-10-03 14:00:00', '43H-24680', 'Alice Johnson', '1357924680', '2024-10-03 14:00:00', '2024-10-03 14:00:00', NULL, 3),
(4, '2024-10-04 16:00:00', '92P-86420', 'Bob Brown', '2468013579', '2024-10-04 16:00:00', '2024-10-04 16:00:00', NULL, 4),
(5, '2024-10-05 18:00:00', '14A-97531', 'Eve Wilson', '9876543210', '2024-10-05 18:00:00', '2024-10-05 18:00:00', NULL, 5);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `parking_lots`
--

CREATE TABLE `parking_lots` (
  `id` varchar(20) NOT NULL,
  `total_slot` int(11) DEFAULT NULL,
  `parking_lot_type` enum('TWO_WHEELER','FOUR_WHEELER') DEFAULT NULL,
  `user_type` enum('RESIDENT','VISITOR') DEFAULT NULL,
  `status` enum('FULL','AVAILABLE','CLOSED','UNDER_MAINTENANCE') DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `parking_lots`
--

INSERT INTO `parking_lots` (`id`, `total_slot`, `parking_lot_type`, `user_type`, `status`, `created_at`, `updated_at`, `deleted_at`) VALUES
('RL2W-A1', 50, 'TWO_WHEELER', 'RESIDENT', 'AVAILABLE', '2024-10-05 08:00:00', NULL, NULL),
('RL2W-A2', 50, 'TWO_WHEELER', 'RESIDENT', 'AVAILABLE', '2024-10-05 12:00:00', NULL, NULL),
('RL2W-A3', 40, 'TWO_WHEELER', 'RESIDENT', 'AVAILABLE', '2024-10-05 16:00:00', NULL, NULL),
('RL2W-A4', 45, 'TWO_WHEELER', 'RESIDENT', 'AVAILABLE', '2024-10-05 20:00:00', NULL, NULL),
('RL2W-A5', 55, 'TWO_WHEELER', 'RESIDENT', 'AVAILABLE', '2024-10-06 00:00:00', NULL, NULL),
('RL4W-A1', 50, 'FOUR_WHEELER', 'RESIDENT', 'AVAILABLE', '2024-10-05 09:00:00', NULL, NULL),
('RL4W-A2', 50, 'FOUR_WHEELER', 'RESIDENT', 'AVAILABLE', '2024-10-05 13:00:00', NULL, NULL),
('RL4W-A3', 20, 'FOUR_WHEELER', 'RESIDENT', 'AVAILABLE', '2024-10-05 17:00:00', NULL, NULL),
('RL4W-A4', 15, 'FOUR_WHEELER', 'RESIDENT', 'AVAILABLE', '2024-10-05 21:00:00', NULL, NULL),
('RL4W-A5', 10, 'FOUR_WHEELER', 'RESIDENT', 'AVAILABLE', '2024-10-06 01:00:00', NULL, NULL),
('VL2W-A1', 50, 'TWO_WHEELER', 'VISITOR', 'AVAILABLE', '2024-10-05 10:00:00', NULL, NULL),
('VL2W-A2', 50, 'TWO_WHEELER', 'VISITOR', 'AVAILABLE', '2024-10-05 14:00:00', NULL, NULL),
('VL2W-A3', 25, 'TWO_WHEELER', 'VISITOR', 'AVAILABLE', '2024-10-05 18:00:00', NULL, NULL),
('VL2W-A4', 22, 'TWO_WHEELER', 'VISITOR', 'AVAILABLE', '2024-10-05 22:00:00', NULL, NULL),
('VL2W-A5', 30, 'TWO_WHEELER', 'VISITOR', 'AVAILABLE', '2024-10-06 02:00:00', NULL, NULL),
('VL4W-A1', 50, 'FOUR_WHEELER', 'VISITOR', 'AVAILABLE', '2024-10-05 11:00:00', NULL, NULL),
('VL4W-A2', 50, 'FOUR_WHEELER', 'VISITOR', 'AVAILABLE', '2024-10-05 15:00:00', NULL, NULL),
('VL4W-A3', 10, 'FOUR_WHEELER', 'VISITOR', 'AVAILABLE', '2024-10-05 19:00:00', NULL, NULL),
('VL4W-A4', 8, 'FOUR_WHEELER', 'VISITOR', 'AVAILABLE', '2024-10-05 23:00:00', NULL, NULL),
('VL4W-A5', 5, 'FOUR_WHEELER', 'VISITOR', 'AVAILABLE', '2024-10-06 03:00:00', NULL, NULL);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `residents`
--

CREATE TABLE `residents` (
  `id` int(11) NOT NULL,
  `full_name` varchar(255) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `apartment_id` varchar(20) DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `residents`
--

INSERT INTO `residents` (`id`, `full_name`, `phone`, `email`, `apartment_id`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, 'Nguyễn Văn A', '0912345678', 'nguyenvana@example.com', 'A101', '2024-10-05 08:00:00', NULL, NULL),
(2, 'Trần Thị B', '0987654321', 'tranthib@example.com', 'B202', '2024-10-05 09:00:00', NULL, NULL),
(3, 'Lê Văn C', '0356789123', 'levanc@example.com', 'C303', '2024-10-05 10:00:00', NULL, NULL),
(4, 'Phạm Thị D', '0865432198', 'phamthid@example.com', 'D404', '2024-10-05 11:00:00', NULL, NULL),
(5, 'Vũ Văn E', '0978563412', 'vuvane@example.com', 'E505', '2024-10-05 12:00:00', NULL, NULL),
(6, 'Đinh Thị F', '0367891234', 'dinhthif@example.com', 'F606', '2024-10-05 13:00:00', NULL, NULL),
(7, 'Bùi Văn G', '0887654321', 'buivang@example.com', 'G707', '2024-10-05 14:00:00', NULL, NULL),
(8, 'Mai Thị H', '0934567890', 'maithih@example.com', 'H808', '2024-10-05 15:00:00', NULL, NULL),
(9, 'Trần Văn I', '0834567123', 'tranvani@example.com', 'I909', '2024-10-05 16:00:00', NULL, NULL),
(10, 'Nguyễn Thị K', '0945612378', 'nguyenthik@example.com', 'K1010', '2024-10-05 17:00:00', NULL, NULL),
(11, 'Hoàng Văn L', '0901234567', 'hoangvanl@example.com', 'L1111', '2024-10-05 18:00:00', NULL, NULL),
(12, 'Phan Thị M', '0898765432', 'phanthim@example.com', 'M1212', '2024-10-05 19:00:00', NULL, NULL),
(13, 'Vũ Văn N', '0378912345', 'vuvann@example.com', 'N1313', '2024-10-05 20:00:00', NULL, NULL),
(14, 'Đinh Thị P', '0854321987', 'dinhthip@example.com', 'P1414', '2024-10-05 21:00:00', NULL, NULL),
(15, 'Nguyễn Văn Q', '0965341209', 'nguyenvanq@example.com', 'Q1515', '2024-10-05 22:00:00', NULL, NULL),
(16, 'Trần Thị R', '0389123456', 'tranthir@example.com', 'R1616', '2024-10-05 23:00:00', NULL, NULL),
(17, 'Lê Văn S', '0876543210', 'levans@example.com', 'S1717', '2024-10-06 00:00:00', NULL, NULL),
(18, 'Hoàng Thị T', '0956789123', 'hoangthit@example.com', 'T1818', '2024-10-06 01:00:00', NULL, NULL),
(19, 'Vũ Văn U', '0843219876', 'vuvanu@example.com', 'U1919', '2024-10-06 02:00:00', NULL, NULL),
(20, 'Phạm Thị V', '0998765432', 'phamthiv@example.com', 'V2020', '2024-10-06 03:00:00', NULL, NULL);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `resident_fees`
--

CREATE TABLE `resident_fees` (
  `id` int(11) NOT NULL,
  `month` int(11) DEFAULT NULL,
  `fee` double DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL,
  `vehicle_type_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `resident_fees`
--

INSERT INTO `resident_fees` (`id`, `month`, `fee`, `created_at`, `updated_at`, `deleted_at`, `vehicle_type_id`) VALUES
(1, 1, 200000, '2024-10-05 08:00:00', NULL, NULL, 2),
(2, 3, 550000, '2024-10-05 08:00:00', NULL, NULL, 2),
(3, 6, 1000000, '2024-10-05 08:00:00', NULL, NULL, 2),
(4, 1, 100000, '2024-10-05 08:00:00', NULL, NULL, 3),
(5, 3, 250000, '2024-10-05 08:00:00', NULL, NULL, 3),
(6, 6, 450000, '2024-10-05 08:00:00', NULL, NULL, 3),
(7, 1, 1000000, '2024-10-05 08:00:00', NULL, NULL, 1),
(8, 3, 2700000, '2024-10-05 08:00:00', NULL, NULL, 1),
(9, 6, 5000000, '2024-10-05 08:00:00', NULL, NULL, 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `roles`
--

CREATE TABLE `roles` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `roles`
--

INSERT INTO `roles` (`id`, `name`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, 'admin', '2024-10-05 08:00:00', NULL, NULL),
(2, 'users', '2024-10-05 09:00:00', NULL, NULL);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `role_functions`
--

CREATE TABLE `role_functions` (
  `role_id` int(11) NOT NULL,
  `function_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `role_functions`
--

INSERT INTO `role_functions` (`role_id`, `function_id`) VALUES
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(2, 2);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sessions`
--

CREATE TABLE `sessions` (
  `id` int(11) NOT NULL,
  `license_plate` varchar(20) NOT NULL,
  `checkin_time` datetime DEFAULT NULL,
  `checkout_time` datetime DEFAULT NULL,
  `fee` double DEFAULT NULL,
  `type` enum('RESIDENT','VISITOR') DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL,
  `card_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `sessions`
--

INSERT INTO `sessions` (`id`, `license_plate`, `checkin_time`, `checkout_time`, `fee`, `type`, `created_at`, `updated_at`, `deleted_at`, `card_id`) VALUES
(1, '29A-12345', '2024-10-05 08:00:00', '2024-10-05 10:00:00', 5, 'RESIDENT', '2024-10-05 08:00:00', NULL, NULL, 1),
(2, '51C-67890', '2024-10-05 09:00:00', '2024-10-05 11:00:00', 7.5, 'VISITOR', '2024-10-05 09:00:00', NULL, NULL, 2),
(3, '72B-45678', '2024-10-05 10:00:00', '2024-10-05 12:00:00', 6, 'RESIDENT', '2024-10-05 10:00:00', NULL, NULL, 3),
(4, '18H-24680', '2024-10-05 11:00:00', '2024-10-05 13:00:00', 8, 'VISITOR', '2024-10-05 11:00:00', NULL, NULL, 4),
(5, '94L-13579', '2024-10-05 12:00:00', '2024-10-05 14:00:00', 7, 'RESIDENT', '2024-10-05 12:00:00', NULL, NULL, 5),
(6, '67C-78901', '2024-10-05 13:00:00', '2024-10-05 15:00:00', 9.5, 'VISITOR', '2024-10-05 13:00:00', NULL, NULL, 6),
(7, '29R-35789', '2024-10-05 14:00:00', '2024-10-05 16:00:00', 6.5, 'RESIDENT', '2024-10-05 14:00:00', NULL, NULL, 7),
(8, '51T-24680', '2024-10-05 15:00:00', '2024-10-05 17:00:00', 8.5, 'VISITOR', '2024-10-05 15:00:00', NULL, NULL, 8),
(9, '72V-15937', '2024-10-05 16:00:00', '2024-10-05 18:00:00', 7.5, 'RESIDENT', '2024-10-05 16:00:00', NULL, NULL, 9),
(10, '18Y-45678', '2024-10-05 17:00:00', '2024-10-05 19:00:00', 10, 'VISITOR', '2024-10-05 17:00:00', NULL, NULL, 10),
(11, '94B-78901', '2024-10-05 18:00:00', '2024-10-05 20:00:00', 8, 'RESIDENT', '2024-10-05 18:00:00', NULL, NULL, 11),
(12, '67E-35789', '2024-10-05 19:00:00', '2024-10-05 21:00:00', 12, 'VISITOR', '2024-10-05 19:00:00', NULL, NULL, 12),
(13, '29H-24680', '2024-10-05 20:00:00', '2024-10-05 22:00:00', 9, 'RESIDENT', '2024-10-05 20:00:00', NULL, NULL, 13),
(14, '51M-15937', '2024-10-05 21:00:00', '2024-10-05 23:00:00', 13.5, 'VISITOR', '2024-10-05 21:00:00', NULL, NULL, 14),
(15, '72P-45678', '2024-10-05 22:00:00', '2024-10-06 00:00:00', 10.5, 'RESIDENT', '2024-10-05 22:00:00', NULL, NULL, 15),
(16, '18Q-78901', '2024-10-05 23:00:00', '2024-10-06 01:00:00', 15, 'VISITOR', '2024-10-05 23:00:00', NULL, NULL, 16),
(17, '94T-35789', '2024-10-06 00:00:00', '2024-10-06 02:00:00', 11, 'RESIDENT', '2024-10-06 00:00:00', NULL, NULL, 17),
(18, '67W-24680', '2024-10-06 01:00:00', '2024-10-06 03:00:00', 17.5, 'VISITOR', '2024-10-06 01:00:00', NULL, NULL, 18),
(19, '29X-15937', '2024-10-06 02:00:00', '2024-10-06 04:00:00', 12.5, 'RESIDENT', '2024-10-06 02:00:00', NULL, NULL, 19),
(20, '51Z-45678', '2024-10-06 03:00:00', '2024-10-06 05:00:00', 20, 'VISITOR', '2024-10-06 03:00:00', NULL, NULL, 20);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `slots`
--

CREATE TABLE `slots` (
  `id` varchar(20) NOT NULL,
  `status` enum('IN_USE','EMPTY','MAINTENANCE') DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL,
  `parking_lot_id` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `slots`
--

INSERT INTO `slots` (`id`, `status`, `created_at`, `updated_at`, `deleted_at`, `parking_lot_id`) VALUES
('S01-RL2W-A1', 'EMPTY', '2024-10-05 09:00:00', NULL, NULL, 'RL2W-A1'),
('S01-RL4W-A1', 'EMPTY', '2024-10-05 15:00:00', NULL, NULL, 'RL4W-A1'),
('S01-VL2W-A1', 'EMPTY', '2024-10-05 08:00:00', NULL, NULL, 'VL2W-A1'),
('S01-VL4W-A1', 'EMPTY', '2024-10-05 19:00:00', NULL, NULL, 'VL4W-A1'),
('S02-RL2W-A1', 'EMPTY', '2024-10-05 14:00:00', NULL, NULL, 'RL2W-A1'),
('S02-RL4W-A1', 'EMPTY', '2024-10-05 18:00:00', NULL, NULL, 'RL4W-A1'),
('S02-VL2W-A1', 'EMPTY', '2024-10-05 08:00:00', NULL, NULL, 'VL2W-A1'),
('S02-VL4W-A1', 'EMPTY', '2024-10-05 19:00:00', NULL, NULL, 'VL4W-A1'),
('S03-RL2W-A1', 'EMPTY', '2024-10-05 14:00:00', NULL, NULL, 'RL2W-A1'),
('S03-RL4W-A1', 'EMPTY', '2024-10-05 18:00:00', NULL, NULL, 'RL4W-A1'),
('S03-VL2W-A1', 'EMPTY', '2024-10-05 08:00:00', NULL, NULL, 'VL2W-A1'),
('S03-VL4W-A1', 'EMPTY', '2024-10-05 22:00:00', NULL, NULL, 'VL4W-A1'),
('S04-RL2W-A1', 'EMPTY', '2024-10-05 14:00:00', NULL, NULL, 'RL2W-A1'),
('S04-RL4W-A1', 'EMPTY', '2024-10-05 18:00:00', NULL, NULL, 'RL4W-A1'),
('S04-VL2W-A1', 'EMPTY', '2024-10-05 09:00:00', NULL, NULL, 'VL2W-A1'),
('S04-VL4W-A1', 'EMPTY', '2024-10-05 22:00:00', NULL, NULL, 'VL4W-A1'),
('S05-RL2W-A1', 'EMPTY', '2024-10-05 15:00:00', NULL, NULL, 'RL2W-A1'),
('S05-RL4W-A1', 'EMPTY', '2024-10-05 19:00:00', NULL, NULL, 'RL4W-A1'),
('S05-VL2W-A1', 'EMPTY', '2024-10-05 09:00:00', NULL, NULL, 'VL2W-A1'),
('S05-VL4W-A1', 'EMPTY', '2024-10-05 22:00:00', NULL, NULL, 'VL4W-A1'),
('S06-RL2W-A1', 'EMPTY', '2024-10-05 15:00:00', NULL, NULL, 'RL2W-A1');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `vehicle_types`
--

CREATE TABLE `vehicle_types` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `has_slot` tinyint(1) DEFAULT NULL,
  `has_vehicle_plate` tinyint(1) DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `vehicle_types`
--

INSERT INTO `vehicle_types` (`id`, `name`, `has_slot`, `has_vehicle_plate`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, 'Car', 1, 1, '2024-10-05 08:00:00', NULL, NULL),
(2, 'Motorbike', 1, 1, '2024-10-05 09:00:00', NULL, NULL),
(3, 'Bicycle', 0, 0, '2024-10-05 10:00:00', NULL, NULL);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `visitor_fees`
--

CREATE TABLE `visitor_fees` (
  `id` int(11) NOT NULL,
  `fee_type` enum('TURN','HOUR_PER_TURN','FIRST_N_AND_NEXT_M_HOUR') DEFAULT NULL,
  `day_fee` double DEFAULT NULL,
  `night_fee` double DEFAULT NULL,
  `hours_per_turn` double DEFAULT NULL,
  `n_hours` int(11) DEFAULT NULL,
  `m_hours` int(11) DEFAULT NULL,
  `first_n_hours_fee` double DEFAULT NULL,
  `additional_m_hours_fee` double DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL,
  `vehicle_type_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `visitor_fees`
--

INSERT INTO `visitor_fees` (`id`, `fee_type`, `day_fee`, `night_fee`, `hours_per_turn`, `n_hours`, `m_hours`, `first_n_hours_fee`, `additional_m_hours_fee`, `created_at`, `updated_at`, `deleted_at`, `vehicle_type_id`) VALUES
(1, 'TURN', 2000, 4000, NULL, NULL, NULL, NULL, NULL, '2024-10-05 08:00:00', NULL, NULL, 3),
(2, 'TURN', 6000, 9000, 4, NULL, NULL, NULL, NULL, '2024-10-05 08:00:00', NULL, NULL, 2),
(3, 'FIRST_N_AND_NEXT_M_HOUR', NULL, NULL, NULL, 2, 1, 35000, 20000, '2024-10-05 08:00:00', NULL, NULL, 1);

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`id`),
  ADD KEY `role_id` (`role_id`);

--
-- Chỉ mục cho bảng `bills`
--
ALTER TABLE `bills`
  ADD PRIMARY KEY (`id`),
  ADD KEY `resident_id` (`resident_id`),
  ADD KEY `account_id` (`account_id`);

--
-- Chỉ mục cho bảng `cards`
--
ALTER TABLE `cards`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `rfid` (`rfid`),
  ADD KEY `vehicle_type_id` (`vehicle_type_id`),
  ADD KEY `resident_id` (`resident_id`);

--
-- Chỉ mục cho bảng `functions`
--
ALTER TABLE `functions`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `images`
--
ALTER TABLE `images`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `url` (`url`),
  ADD KEY `session_id` (`session_id`);

--
-- Chỉ mục cho bảng `issues`
--
ALTER TABLE `issues`
  ADD PRIMARY KEY (`id`),
  ADD KEY `bill_id` (`bill_id`),
  ADD KEY `slot_id` (`slot_id`),
  ADD KEY `parking_lot_id` (`parking_lot_id`),
  ADD KEY `card_id` (`card_id`),
  ADD KEY `vehicle_type_id` (`vehicle_type_id`);

--
-- Chỉ mục cho bảng `lost_history`
--
ALTER TABLE `lost_history`
  ADD PRIMARY KEY (`id`),
  ADD KEY `card_id` (`card_id`);

--
-- Chỉ mục cho bảng `parking_lots`
--
ALTER TABLE `parking_lots`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `residents`
--
ALTER TABLE `residents`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `resident_fees`
--
ALTER TABLE `resident_fees`
  ADD PRIMARY KEY (`id`),
  ADD KEY `vehicle_type_id` (`vehicle_type_id`);

--
-- Chỉ mục cho bảng `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `role_functions`
--
ALTER TABLE `role_functions`
  ADD PRIMARY KEY (`role_id`,`function_id`),
  ADD KEY `function_id` (`function_id`);

--
-- Chỉ mục cho bảng `sessions`
--
ALTER TABLE `sessions`
  ADD PRIMARY KEY (`id`),
  ADD KEY `card_id` (`card_id`);

--
-- Chỉ mục cho bảng `slots`
--
ALTER TABLE `slots`
  ADD PRIMARY KEY (`id`),
  ADD KEY `parking_lot_id` (`parking_lot_id`);

--
-- Chỉ mục cho bảng `vehicle_types`
--
ALTER TABLE `vehicle_types`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Chỉ mục cho bảng `visitor_fees`
--
ALTER TABLE `visitor_fees`
  ADD PRIMARY KEY (`id`),
  ADD KEY `vehicle_type_id` (`vehicle_type_id`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `accounts`
--
ALTER TABLE `accounts`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `bills`
--
ALTER TABLE `bills`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT cho bảng `cards`
--
ALTER TABLE `cards`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT cho bảng `functions`
--
ALTER TABLE `functions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT cho bảng `images`
--
ALTER TABLE `images`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT cho bảng `issues`
--
ALTER TABLE `issues`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=127;

--
-- AUTO_INCREMENT cho bảng `lost_history`
--
ALTER TABLE `lost_history`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT cho bảng `residents`
--
ALTER TABLE `residents`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT cho bảng `resident_fees`
--
ALTER TABLE `resident_fees`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT cho bảng `roles`
--
ALTER TABLE `roles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT cho bảng `vehicle_types`
--
ALTER TABLE `vehicle_types`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `visitor_fees`
--
ALTER TABLE `visitor_fees`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `accounts`
--
ALTER TABLE `accounts`
  ADD CONSTRAINT `accounts_ibfk_1` FOREIGN KEY (`role_id`) REFERENCES `roles` (`id`);

--
-- Các ràng buộc cho bảng `bills`
--
ALTER TABLE `bills`
  ADD CONSTRAINT `bills_ibfk_1` FOREIGN KEY (`resident_id`) REFERENCES `residents` (`id`),
  ADD CONSTRAINT `bills_ibfk_2` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`id`);

--
-- Các ràng buộc cho bảng `cards`
--
ALTER TABLE `cards`
  ADD CONSTRAINT `cards_ibfk_1` FOREIGN KEY (`vehicle_type_id`) REFERENCES `vehicle_types` (`id`),
  ADD CONSTRAINT `cards_ibfk_2` FOREIGN KEY (`resident_id`) REFERENCES `residents` (`id`);

--
-- Các ràng buộc cho bảng `images`
--
ALTER TABLE `images`
  ADD CONSTRAINT `images_ibfk_1` FOREIGN KEY (`session_id`) REFERENCES `sessions` (`id`);

--
-- Các ràng buộc cho bảng `issues`
--
ALTER TABLE `issues`
  ADD CONSTRAINT `issues_ibfk_1` FOREIGN KEY (`bill_id`) REFERENCES `bills` (`id`),
  ADD CONSTRAINT `issues_ibfk_2` FOREIGN KEY (`slot_id`) REFERENCES `slots` (`id`),
  ADD CONSTRAINT `issues_ibfk_3` FOREIGN KEY (`parking_lot_id`) REFERENCES `parking_lots` (`id`),
  ADD CONSTRAINT `issues_ibfk_4` FOREIGN KEY (`card_id`) REFERENCES `cards` (`id`),
  ADD CONSTRAINT `issues_ibfk_5` FOREIGN KEY (`vehicle_type_id`) REFERENCES `vehicle_types` (`id`);

--
-- Các ràng buộc cho bảng `lost_history`
--
ALTER TABLE `lost_history`
  ADD CONSTRAINT `lost_history_ibfk_1` FOREIGN KEY (`card_id`) REFERENCES `cards` (`id`);

--
-- Các ràng buộc cho bảng `resident_fees`
--
ALTER TABLE `resident_fees`
  ADD CONSTRAINT `resident_fees_ibfk_1` FOREIGN KEY (`vehicle_type_id`) REFERENCES `vehicle_types` (`id`);

--
-- Các ràng buộc cho bảng `role_functions`
--
ALTER TABLE `role_functions`
  ADD CONSTRAINT `role_functions_ibfk_1` FOREIGN KEY (`role_id`) REFERENCES `roles` (`id`),
  ADD CONSTRAINT `role_functions_ibfk_2` FOREIGN KEY (`function_id`) REFERENCES `functions` (`id`);

--
-- Các ràng buộc cho bảng `sessions`
--
ALTER TABLE `sessions`
  ADD CONSTRAINT `sessions_ibfk_1` FOREIGN KEY (`card_id`) REFERENCES `cards` (`id`);

--
-- Các ràng buộc cho bảng `slots`
--
ALTER TABLE `slots`
  ADD CONSTRAINT `slots_ibfk_1` FOREIGN KEY (`parking_lot_id`) REFERENCES `parking_lots` (`id`);

--
-- Các ràng buộc cho bảng `visitor_fees`
--
ALTER TABLE `visitor_fees`
  ADD CONSTRAINT `visitor_fees_ibfk_1` FOREIGN KEY (`vehicle_type_id`) REFERENCES `vehicle_types` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
