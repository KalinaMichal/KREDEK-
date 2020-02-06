
--Tworzymy bazê danych na Laboratorium 3
CREATE DATABASE Test;

USE		Test;

--Tworzymy potrzebne tabele, studentów, kursów i wpisów w indeksie
CREATE TABLE Students (
	 ID int IDENTITY(1,1) PRIMARY KEY,
	 FirstName nvarchar(255),
	 LastName nvarchar(255),
	 Address nvarchar(255),
	 StudentIdent numeric(6,0)
);

CREATE TABLE Books (
	ID int IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(63),
	Autor nvarchar(255),
	Book numeric(3,0)
);

CREATE TABLE Movies (
	ID int IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(63),
	Autor nvarchar(255),
	Movie numeric(3,0)
);
CREATE TABLE Songs (
	ID int IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(63),
	Autor nvarchar(255),
	Song numeric(3,0)
);





CREATE TABLE RentIndex (
	ID int IDENTITY(1,1) PRIMARY KEY,
	StudentID int,
	BookID int,
	MovieID int,
	SongID int,
);


--Wprowadzamy przyk³adowe dane do tabel
INSERT INTO Students(FirstName, LastName, Address, StudentIdent)
	VALUES ('Jan','Kowalski','ul.Polna 1, Wroclaw 50-100', 123332),
			('Marek','Nowak','Nowakowskiego 322, Wroclaw 51-222', 226705),
			('Staœ','Burczymucha','Padewskiego 1/3, Wroc³aw 51-200',20000);

INSERT INTO Books(Name, Autor,Book) 
	VALUES ('Alicja w krainie czarów 2','Wert',123);
		
INSERT INTO Movies(Name, Autor,Movie) 
	VALUES ('Szybcy i wœciekli','Paul Walker',222),
	('Australia 2','Tonny Abbot',111);
		
INSERT INTO Songs(Name, Autor, Song) 
	VALUES ('Polish Danse Hits 89','Czadoman',333);

--Usuwamy studentow
DELETE FROM Students 
	WHERE StudentIdent=7567;

DELETE FROM Books
	WHERE ID=4;


--Dodajemy klucze g³ówne na tabeli RentIndex
ALTER TABLE RentIndex 
	ADD FOREIGN KEY (StudentID) REFERENCES Students(ID);

ALTER TABLE RentIndex 
	ADD FOREIGN KEY (BookID) REFERENCES Books(ID);

ALTER TABLE RentIndex 
	ADD FOREIGN KEY (MovieID) REFERENCES Movies(ID);

ALTER TABLE RentIndex 
	ADD FOREIGN KEY (SongID) REFERENCES Song(ID);

--Dodajemy wypozyczenia
INSERT INTO RentIndex(StudentID, BookID, MovieID,SongID)
	VALUES (1,1,1,1);

		

--Wyci¹gamy sobie dane
SELECT * FROM Students;
SELECT * FROM Rentindex;
SELECT * FROM Books;
SELECT * FROM Songs;

--Dodajemy wypozyczenia
INSERT INTO IndexPosition(StudentID, BookID)
	VALUES (1,1);
	
INSERT INTO IndexPosition(StudentID,MovieID)
	VALUES (1,1);
	
	INSERT INTO IndexPosition(StudentID, SongID)
	VALUES (1,1);
		
SELECT * FROM IndexPosition;

--Tworzymy widok do przegl¹dania wypozyczen
CREATE VIEW BooksView 
AS
SELECT c.Name, s.StudentIdent, i.SongID
  FROM IndexPosition i
    JOIN Books c on i.BookID = c.ID
    JOIN Students s on i.StudentID = s.ID;

	CREATE VIEW MoviesView 
AS
SELECT c.Name, s.StudentIdent, i.SongID
  FROM IndexPosition i
    JOIN Books c on i.BookID = c.ID
    JOIN Students s on i.StudentID = s.ID;

	CREATE VIEW SongtsView 
AS
SELECT c.Name, s.StudentIdent, i.SongID
  FROM IndexPosition i
    JOIN Books c on i.BookID = c.ID
    JOIN Students s on i.StudentID = s.ID;



	
--Usuwamy nasz¹ bazê danych
USE master;

DROP DATABASE Test;