CREATE TABLE Books (
	Id INT(10) AUTO_INCREMENT PRIMARY KEY,
	Author longtext,
	LaunchDate datetime(6) not null,
	Price decimal(65,2) not null,
	Title longtext
)
ENGINE=InnoDB DEFAULT CHARSET=latin1;