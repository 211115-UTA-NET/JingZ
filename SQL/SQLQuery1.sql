-- create a book table

CREATE TABLE Books
(
    Title VARCHAR(256) PRIMARY KEY,
    Author VARCHAR(256) NOT NULL,
    Pages INT NOT NULL,
    Thickness VARCHAR(32) NOT NULL,
    GenreID INT NOT NULL,
    PublisherID INT NOT NULL
);

-- create a author table

CREATE TABLE Author
(
    Author VARCHAR(256) PRIMARY KEY,
    AuthorNationality VARCHAR(32) NOT NULL
);
-- create a format table table

CREATE TABLE FormatPrice(
	Title VARCHAR(256) NOT NULL,
	PrintFormat VARCHAR(32) NOT NULL,
	Price Money not null,
	Primary key (Title, PrintFormat)
);


-- create a genre table

CREATE TABLE Genre
(
    GenreID INT PRIMARY KEY,
    GenreName VARCHAR(32) NOT NULL
);

-- change table name 'Author' to 'Athors'
EXEC sp_rename 'Custumer','Customer';

-- create a foreign key as a alteration to another table
ALTER TABLE Books ADD FOREIGN KEY (Author) REFERENCES Authors(Author);
ALTER TABLE Books ADD FOREIGN KEY (GenreID) REFERENCES Genre(GenreID);
ALTER TABLE FormatPrice ADD FOREIGN KEY (Title) REFERENCES Books(Title);

-- insert Authors table
INSERT Authors (Author, AuthorNationality) VALUES ('Chad Russell','American'), ('E.F.Codd','British');
SELECT * FROM Authors;

-- insert Genre table
INSERT Genre(GenreID, GenreName) VALUES (1,'Tutorial'), (2,'Popular science');
SELECT * FROM Genre;

-- delete content of table Genre
TRUNCATE TABLE Genre;  -- ERROR cuz there's foreign key reference to genre table

-- insert Books table
-- MUST add data to the Foreign Key reference table first, then add data to the foreign key
INSERT Books (Title, Author, Pages, Thickness, GenreID, PublisherID) 
VALUES ('Beginning MySQL Database Design and Optimization','Chad Russell', 520, 'Thick', 1, 1), 
('The Relational Model for Database Management: Version 2','E.F.Codd', 538, 'Thick', 2, 2),
('Chads New Book','Chad Russell', 20, 'Thin', 2, 1);
SELECT * FROM Books;
SELECT * FROM Books WHERE Author='Chad Russell';
SELECT * FROM Books WHERE Author!='Chad Russell';

-- insert FormatPrice table
INSERT FormatPrice(Title, PrintFormat, Price) 
VALUES ('Beginning MySQL Database Design and Optimization','Hardcover', 49.99), 
('Beginning MySQL Database Design and Optimization','E-book', 22.34), 
('The Relational Model for Database Management: Version 2','E-book', 13.88),
('The Relational Model for Database Management: Version 2','Paperback', 39.99);
SELECT * FROM FormatPrice;

-- Update data in table Genre
UPDATE Genre set GenreName='Horror' where GenreID=1;
SELECT * FROM Genre;
UPDATE Genre set GenreName='Tutorial' where GenreID=1;
SELECT * FROM Genre;

-- Testing table
CREATE TABLE Test (
    ID INT PRIMARY KEY,
    TestName VARCHAR(32) NOT NULL
);

INSERT Test(ID, TestName) VALUES (1,'A'), (2, 'B'), (3, 'C');
SELECT * FROM Test;

-- DELETE specific table content
DELETE FROM Test WHERE ID=1;
SELECT * FROM Test;
INSERT Test(ID, TestName) VALUES (1,'im back!');
SELECT * FROM Test;
-- TRUNCATE table
TRUNCATE TABLE Test;  -- DELETE ALL table contents
SELECT * FROM Test;
-- DELETE table
DROP TABLE Test;   -- DELETE table

-- RIGHT JOIN example
CREATE TABLE Custumer (
    ID INT PRIMARY KEY,
    FirstName VARCHAR(32) NOT NULL,
    Age INT NOT NULL,
    Salary MONEY NOT NULL
);
INSERT Custumer VALUES (1,'ARYAN', 51, 56000), (2, 'AROHI', 21, 25000), (3, 'VINEET', 24, 31000);
SELECT * FROM Custumer;

CREATE TABLE Orders (
    OrderDate DATE NOT NULL,
    OrderID INT PRIMARY KEY,
    CustumerID INT NOT NULL,
    Amount INT NOT NULL
);
INSERT Orders VALUES 
('01/20/2012', 1, 2, 3000), 
('01/12/2012', 2, 2, 2000), 
('03/22/2012', 3, 3, 4000), 
('04/20/2012', 4, 4, 5000);
-- right join
SELECT * FROM Custumer;
SELECT * FROM Orders;

SELECT ID, FirstName, Amount, OrderDate  
FROM Custumer  
RIGHT JOIN Orders  
ON Custumer.ID = Orders.CustumerID;
-- inner join
SELECT * FROM Custumer;
SELECT * FROM Orders;

SELECT ID, FirstName, Amount, OrderDate  
FROM Custumer  
JOIN Orders  
ON Custumer.ID = Orders.CustumerID;
-- left join
SELECT * FROM Custumer;
SELECT * FROM Orders;

SELECT ID, FirstName, Amount, OrderDate  
FROM Custumer  
LEFT JOIN Orders  
ON Custumer.ID = Orders.CustumerID;
-- full join
SELECT * FROM Custumer;
SELECT * FROM Orders;

SELECT ID, FirstName, Amount, OrderDate  
FROM Custumer  
FULL JOIN Orders  
ON Custumer.ID = Orders.CustumerID;
-- self join
SELECT * FROM Custumer;
SELECT * FROM Orders;

SELECT ID, FirstName, Amount, OrderDate 
FROM Customer, Orders
WHERE Customer.ID = Orders.CustumerID;

-- ORDER BY
SELECT * FROM Books ORDER BY Title;

