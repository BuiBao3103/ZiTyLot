CREATE TABLE `roles` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime
);

CREATE TABLE `functions` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime
);

CREATE TABLE `role_functions` (
  `role_id` integer,
  `function_id` integer,
  PRIMARY KEY (`role_id`, `function_id`)
);

CREATE TABLE `accounts` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `full_name` varchar(255),
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `role_id` integer
);

CREATE TABLE `bills` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `total_fee` double,
  `issue_quantity` int,
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `account_id` int,
  `resident_id` int
);

CREATE TABLE `residents` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `full_name` varchar(255),
  `phone` varchar(11),
  `email` varchar(255),
  `apartment_id` varchar(20),
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime
);

CREATE TABLE `parking_lots` (
  `id` varchar(20) PRIMARY KEY,
  `total_slot` integer,
  `type` ENUM ('TWO_WHEELER', 'FOUR_WHEELER'),
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime
);

CREATE TABLE `slots` (
  `id` varchar(20) PRIMARY KEY,
  `status` ENUM ('IN_USE', 'EMPTY', 'MAINTENANCE'),
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `parking_lot_id` varchar(20)
);

CREATE TABLE `issues` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `start_date` datetime NOT NULL,
  `end_date` datetime NOT NULL,
  `license_plate` varchar(255),
  `fee` double,
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `resident_card_id` integer,
  `bill_id` integer,
  `parking_lot_id` varchar(20),
  `slot_id` varchar(20)
);

CREATE TABLE `cards` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `rfid` varchar(255) UNIQUE NOT NULL,
  `status` ENUM ('EMPTY', 'ACTIVE', 'BLOCKED', 'LOST'),
  `type` ENUM ('RESIDENT', 'VISITOR'),
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `vehicle_type_id` integer
);

CREATE TABLE `resident_cards` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `due_date` datetime,
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `card_id` integer,
  `resident_id` integer
);

CREATE TABLE `lost_history` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `time_loss` datetime NOT NULL,
  `license_plate` varchar(255) NOT NULL,
  `owner_name` varchar(255),
  `owner_identification_card` varchar(20),
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `card_id` integer
);

CREATE TABLE `vehicle_types` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `name` varchar(20) UNIQUE NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime
);

CREATE TABLE `resident_fees` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `month` integer,
  `fee` double,
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `vehicle_type_id` int
);

CREATE TABLE `visitor_fees` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `fee_type` ENUM ('TURN', 'HOUR_PER_TURN', 'FIRST_N_AND_NEXT_M_HOUR'),
  `day_fee` double,
  `night_fee` double,
  `hours_per_turn` double,
  `n_hours` integer,
  `m_hours` integer,
  `first_n_hours_fee` double,
  `additional_m_hours_fee` double,
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `vehicle_type_id` integer
);

CREATE TABLE `sessions` (
  `id` integer PRIMARY KEY NOT NULL,
  `license_plate` varchar(20) NOT NULL,
  `checkin_time` datetime,
  `checkout_time` datetime,
  `fee` double,
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `card_id` integer
);

CREATE TABLE `images` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `url` varchar(255) UNIQUE,
  `image_type` ENUM ('FRONT', 'BACK'),
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `session_id` integer
);

ALTER TABLE `role_functions` ADD FOREIGN KEY (`role_id`) REFERENCES `roles` (`id`);

ALTER TABLE `role_functions` ADD FOREIGN KEY (`function_id`) REFERENCES `functions` (`id`);

ALTER TABLE `bills` ADD FOREIGN KEY (`resident_id`) REFERENCES `residents` (`id`);

ALTER TABLE `bills` ADD FOREIGN KEY (`account_id`) REFERENCES `accounts` (`id`);

ALTER TABLE `issues` ADD FOREIGN KEY (`bill_id`) REFERENCES `bills` (`id`);

ALTER TABLE `issues` ADD FOREIGN KEY (`slot_id`) REFERENCES `slots` (`id`);

ALTER TABLE `slots` ADD FOREIGN KEY (`parking_lot_id`) REFERENCES `parking_lots` (`id`);

ALTER TABLE `issues` ADD FOREIGN KEY (`parking_lot_id`) REFERENCES `parking_lots` (`id`);

ALTER TABLE `issues` ADD FOREIGN KEY (`resident_card_id`) REFERENCES `resident_cards` (`id`);

ALTER TABLE `cards` ADD FOREIGN KEY (`vehicle_type_id`) REFERENCES `vehicle_types` (`id`);

ALTER TABLE `resident_fees` ADD FOREIGN KEY (`vehicle_type_id`) REFERENCES `vehicle_types` (`id`);

ALTER TABLE `visitor_fees` ADD FOREIGN KEY (`vehicle_type_id`) REFERENCES `vehicle_types` (`id`);

ALTER TABLE `sessions` ADD FOREIGN KEY (`card_id`) REFERENCES `cards` (`id`);

ALTER TABLE `lost_history` ADD FOREIGN KEY (`card_id`) REFERENCES `cards` (`id`);

ALTER TABLE `images` ADD FOREIGN KEY (`session_id`) REFERENCES `sessions` (`id`);

ALTER TABLE `accounts` ADD FOREIGN KEY (`role_id`) REFERENCES `roles` (`id`);

ALTER TABLE `resident_cards` ADD FOREIGN KEY (`card_id`) REFERENCES `cards` (`id`);

ALTER TABLE `resident_cards` ADD FOREIGN KEY (`resident_id`) REFERENCES `residents` (`id`);
