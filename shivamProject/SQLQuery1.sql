create database findHope;

use findHope;

CREATE TABLE CreatePost (
    id INT IDENTITY(1,1) PRIMARY KEY,
    image VARCHAR(45) UNIQUE,
    message TEXT,
    longitude DECIMAL(9,6), 
    latitude DECIMAL(8,6)  
);


CREATE TABLE volunteerDetails (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(45) NOT NULL,
    email VARCHAR(256) NOT NULL UNIQUE,
    password VARCHAR(45) NOT NULL UNIQUE,
    aadharNo VARCHAR(15) NOT NULL UNIQUE,
    occupation VARCHAR(45),
    dob VARCHAR(45),
    gender CHAR(1),
    address VARCHAR(255),
	image VARCHAR(255),
    motivation TEXT
);

select * from CreatePost;
drop table CreatePost;

select * from volunteerDetails;

delete from volunteerDetails where id = 6;
