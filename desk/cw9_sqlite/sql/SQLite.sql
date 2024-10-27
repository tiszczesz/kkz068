-- SQLite
CREATE TABLE Movies(
    id INTEGER PRIMARY KEY,
    title TEXT,
    director TEXT,
    year INTEGER,
    price decimal(10,2)
);

INSERT INTO Movies (id, title, director, year, price) VALUES
(1, 'Inception', 'Christopher Nolan', 2010, 9.99),
(2, 'The Matrix', 'Lana Wachowski, Lilly Wachowski', 1999, 7.99),
(3, 'Interstellar', 'Christopher Nolan', 2014, 12.99),
(4, 'The Godfather', 'Francis Ford Coppola', 1972, 14.99),
(5, 'Pulp Fiction', 'Quentin Tarantino', 1994, 8.99),
(6, 'The Dark Knight', 'Christopher Nolan', 2008, 10.99),
(7, 'Fight Club', 'David Fincher', 1999, 6.99),
(8, 'Forrest Gump', 'Robert Zemeckis', 1994, 7.49),
(9, 'The Shawshank Redemption', 'Frank Darabont', 1994, 11.99),
(10, 'The Lord of the Rings: The Return of the King', 'Peter Jackson', 2003, 13.99);