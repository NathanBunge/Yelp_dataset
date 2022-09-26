CREATE TABLE Users (
	user_id char(22),
	average_stars FLOAT not NULL,
	cool INTEGER not NULL,
	funny INTEGER not NULL,
	useful INTEGER not NULL,
	yelping_since DATE not NULL,
	name VARCHAR not NULL,
	fans INTEGER not NULL,
	tipCount INTEGER not NULL,
	totalLikes INTEGER not NULL,
	PRIMARY KEY (user_id)
);    

CREATE TABLE Has_friends (
	user_id char(22),
	friend_id varchar(22),
	PRIMARY KEY (user_id,friend_id),
	FOREIGN KEY (user_id) REFERENCES users(user_id)
);

CREATE TABLE Business (
	business_id char(22),
	business_name varchar(100) NOT NULL,
	business_city varchar(25) NOT NULL,
	business_state varchar(25) NOT NULL,
	postal_code integer NOT NULL,
	latitude float NOT NULL,
	longitude float NOT NULL,
	business_address varchar(100) NOT NULL,
	numTips float NOT NULL,
	numCheckins INTEGER NOT NULL,
	is_open bool NOT NULL,
	stars float NOT NULL,
	PRIMARY KEY (business_id)
);

CREATE TABLE Tip (
	tipDate TIMESTAMP,
	user_id char(22),
	business_id char(22),
	tipText VARCHAR not NULL,
	likes INTEGER not NULL,
	PRIMARY KEY(user_id, business_id, tipDate, tipText),
	FOREIGN KEY (business_id) REFERENCES Business(business_id),
	FOREIGN KEY (user_id) REFERENCES Users(user_id)
);

CREATE TABLE BelongsTo (
	user_id char(22),
	business_id char(22),
	PRIMARY KEY (user_id, business_id),
	FOREIGN KEY (user_id) REFERENCES Users(user_id),
	FOREIGN KEY (business_id) REFERENCES Business(business_id)

);

CREATE TABLE Categories (
	category_name VARCHAR,
	business_id char(22),
	PRIMARY KEY (business_id, category_name),
	FOREIGN KEY (business_id) REFERENCES Business(business_id)
);

CREATE TABLE Attributes (
	business_id char(22),
	attr_name char(50),
	attribute_value char(20),
	PRIMARY KEY (business_id, attr_name),
	FOREIGN KEY (business_id) REFERENCES Business(business_id)
);

CREATE TABLE Hours (
	business_id char(22),
	dayofweek char(10),
	hours_close TIME not NULL,
	hours_open TIME not NULL,
	PRIMARY KEY (business_id, dayofweek),
	FOREIGN KEY (business_id) REFERENCES Business(business_id)
);

CREATE TABLE Checkins (
	business_id char(22),
	checkin_year INTEGER,
	checkin_month INTEGER,
	checkin_day INTEGER,
	checkin_time TIME,
	PRIMARY KEY (business_id, checkin_year, checkin_month, checkin_day, checkin_time),
	FOREIGN KEY (business_id) REFERENCES Business(business_id)
);
