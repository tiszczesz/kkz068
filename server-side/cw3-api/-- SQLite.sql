-- SQLite
CREATE TABLE Books(
    id INTEGER PRIMARY KEY,
    title TEXT,
    author TEXT,
    price REAL
);
INSERT INTO Books(title,author,price)
VALUES("ABC c++","Roman Polański",34.89);
INSERT INTO Books(title,author,price)
VALUES("JS od podsta","Adam Nowak",44.77);
INSERT INTO Books(title,author,price)
VALUES("React coś tam","Tomasz Gryk",66.89);
INSERT INTO Books(title,author,price)
VALUES("Jakaś bez tytułu","Roman Polański",45.89);

DELETE FROM Books WHERE id>5;

SELECT * FROM Books WHERE title LIKE "A%" 
or 
author like "A%" ;
--selekcja wybor rekordow wierszy
--projekcja wybor pol w rekordzie (kolumn)
SELECT * FROM Books WHERE id={id}
