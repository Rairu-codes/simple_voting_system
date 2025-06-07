DROP TABLE Account_Table;

CREATE TABLE Account_Table(
Student_Number varchar(255) NOT NULL PRIMARY KEY,
Password varchar(255),
First_Name varchar(255),
Last_Name varchar(255),
Section varchar(255)
);

CREATE TABLE Vote_Table(
Vote_ID int not null PRIMARY KEY IDENTITY(1,1),
Student_Number varchar(255),
President_Vote varchar(255),
VicePresident_Vote varchar(255),
Secretary_Vote varchar(255)
);

TRUNCATE TABLE Vote_Table;

SELECT * FROM Account_Table;
SELECT * FROM Vote_Table;

SELECT COUNT(*) AS 'James Votes' FROM Vote_Table WHERE President_Vote='James';

SELECT MAX(President_Vote)AS 'Candidate Name',COUNT(President_Vote) AS 'No. of Votes' FROM Vote_Table;


INSERT INTO Account_Table(Student_Number,Password)
VALUES ('admin','admin');