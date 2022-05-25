SELECT * FROM Person;

DELETE FROM Person WHERE Name = 'Greg';

ALTER TABLE Person DROP COLUMN Id;

ALTER TABLE Person ADD Id INT IDENTITY(1,1);

INSERT INTO Person (Age, Name, Company, Salary) VALUES (23, 'Wilgelm', 'Mercedes', 873.23);
INSERT INTO Person (Age, Name, Company, Salary) VALUES (33, 'Andrew', 'Airbus', 2573.74);
INSERT INTO Person (Age, Name, Company, Salary) VALUES (22, 'Kraige', 'Mercedes', 2022.03);
INSERT INTO Person (Age, Name, Company, Salary) VALUES (42, 'Fred', 'BMW', 990.99);
INSERT INTO Person (Age, Name, Company, Salary) VALUES (18, 'Sam', 'BMW', 1001.43);
INSERT INTO Person (Age, Name, Company, Salary) VALUES (37, 'Peter', 'Shop', 572.29);
INSERT INTO Person (Age, Name, Company, Salary) VALUES (51, 'Valdemar', 'Top-pop', 1093.99);

DROP TABLE Person;

CREATE TABLE Person (
	Id INT NOT NULL IDENTITY(1,1),
	Age INT,
	Name VARCHAR(80),
	Company VARCHAR(80),
	Salary DECIMAL(8, 2)
);