CREATE TABLE users (
	id_number INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(50) NOT NULL UNIQUE,
	email VARCHAR(100) NOT NULL UNIQUE,
	password_hash VARCHAR(255) NOT NULL,
	profile_picture VARCHAR(255),
	role VARCHAR(20) NOT NULL,
	birthdate DATE NULL,
	phone_number VARCHAR(15) NOT NULL UNIQUE,
	registration_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
);
SELECT * FROM users;
INSERT INTO users(id_number, username,email, password_hash, profile_picture, role, birthdate, phone_number, registration_date) 
VALUES  ('00001','admin','admin@email.pt', 'admin123','', 'Administrador','21-05-2002', '924228972',  '2-06-2025');