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
  `id` integer NOT NULL AUTO_INCREMENT,
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `role_id` integer,
  `function_id` integer,
  PRIMARY KEY (`id`, `role_id`, `function_id`)
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
  `total_price` double,
  `issue_quatity` int,
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
  `parking_lot_type` ENUM ('TWO_WHEELER', 'FOUR_WHEELER'),
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime
);

CREATE TABLE `slots` (
  `id` varchar(20) PRIMARY KEY,
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `parking_lot_id` varchar(20)
);

CREATE TABLE `issues` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `start_date` datetime NOT NULL,
  `end_date` datetime NOT NULL,
  `vehicle_plate` varchar(255),
  `price` double,
  `card_id` integer,
  `parking_lot_id` varchar(20),
  `slot_id` varchar(20),
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `bill_id` integer
);

CREATE TABLE `cards` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `rfid` varchar(255) UNIQUE NOT NULL,
  `status` ENUM ('EMPTY'),
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `vehicle_type_id` integer
);

CREATE TABLE `lost_history` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `time_loss` datetime NOT NULL,
  `vehicle_plate` varchar(255) NOT NULL,
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

CREATE TABLE `resident_prices` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `month` integer,
  `price` double,
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `vehicle_type_id` int
);

CREATE TABLE `visitor_prices` (
  `id` integer PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `parking_lot_fees` double,
  `isday` bool,
  `hours_per_visit` double,
  `first_n_hours` double,
  `additional_hours` double,
  `created_at` datetime NOT NULL,
  `updated_at` datetime,
  `deleted_at` datetime,
  `vehicle_type_id` integer
);

CREATE TABLE `sessions` (
  `id` integer PRIMARY KEY NOT NULL,
  `vehicle_plate` varchar(20) NOT NULL,
  `checkin_time` datetime,
  `checkout_time` datetime,
  `price` double,
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

ALTER TABLE `issues` ADD FOREIGN KEY (`card_id`) REFERENCES `cards` (`id`);

ALTER TABLE `cards` ADD FOREIGN KEY (`vehicle_type_id`) REFERENCES `vehicle_types` (`id`);

ALTER TABLE `resident_prices` ADD FOREIGN KEY (`vehicle_type_id`) REFERENCES `vehicle_types` (`id`);

ALTER TABLE `visitor_prices` ADD FOREIGN KEY (`vehicle_type_id`) REFERENCES `vehicle_types` (`id`);

ALTER TABLE `sessions` ADD FOREIGN KEY (`card_id`) REFERENCES `cards` (`id`);

ALTER TABLE `lost_history` ADD FOREIGN KEY (`card_id`) REFERENCES `cards` (`id`);

ALTER TABLE `images` ADD FOREIGN KEY (`session_id`) REFERENCES `sessions` (`id`);

ALTER TABLE `accounts` ADD FOREIGN KEY (`role_id`) REFERENCES `roles` (`id`);
