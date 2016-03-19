CREATE TABLE users(
	 user_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	 login VARCHAR(30) NOT NULL,
	 pass VARCHAR(30) NOT NULL,
	 email VARCHAR(30) NOT NULL,
	 date_of_birth DATE NOT NULL,
	 balance FLOAT NOT NULL,
	 paid BOOLEAN NOT NULL,
	 reg_date DATETIME NOT NULL,
	 camping_id INT NULL,
	 PRIMARY KEY(user_id));
	 

CREATE TABLE rfids (
	user_id INT NULL,
	bracelet_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	status VARCHAR(30) NULL,
	FOREIGN KEY (user_id) REFERENCES users(user_id)
	PRIMARY KEY(bracelet_id ));

CREATE TABLE camps (
	camping_id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	tent_nr INT NOT NULL,
	capacity INT NOT NULL,
	status VARCHAR(30) NOT NULL);

