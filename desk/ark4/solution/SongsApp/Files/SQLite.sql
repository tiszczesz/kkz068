-- SQLite
CREATE TABLE songs(
    id INTEGER PRIMARY KEY,
    artist TEXT,
    album TEXT,
    songNumber INTEGER,
    year INTEGER,
    downloadNumber INTEGER
);

INSERT INTO Songs (artist, album, songNumber, year, downloadNumber) VALUES
('Gorillaz', 'The Now Now', 11, 2018, 11000102),
('My Chemical Romance', 'The Black Parade', 14, 2006, 304666444),
('Wilki', 'wilki', 16, 1992, 4000230),
('30 Seconds To Mars', 'A Beautiful Lie', 13, 2009, 300120222),
('30 Seconds To Mars', 'This Is War', 15, 2009, 22000000),
('Melanie Martinez', 'Cry Baby', 16, 2015, 400345042),
('The Rasmus', 'Dead Letters', 10, 2003, 253453),
('Metallica', 'Metallica', 12, 1991, 1506404300),
('Meskie Granie Orkiestra 2022', 'Meskie Granie 2022', 30, 2022, 243085),
('Krzysztof Zalewski', 'Zloto', 11, 2016, 4586200),
('The Cure', 'Disintegration', 11, 1989, 130000560),
('Pink Floyd', 'The Division Bell', 11, 1994, 24332190),
('Depeche Mode', 'Spirit', 17, 2017, 24300453),
('Faith No More', 'Angel Dust', 14, 1992, 55384200);