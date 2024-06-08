export interface Movie {
    id:number;
    title: string;
    director: string;
    date: string;
    price: number;
}

export const movies: Movie[] = [
    {
        id: 1,
        title: "Incepcja",
        director: "Christopher Nolan",
        date: "2010",
        price: 12.99,
       
    },
    {
        id: 2,
        title: "Matrix",
        director: "Lana Wachowski, Lilly Wachowski",
        date: "1999",
        price: 9.99,
    },
    {
        id: 3,
        title: "Pulp Fiction",
        director: "Quentin Tarantino",
        date: "1994",
        price: 11.49,
    },
    {
        id: 4,
        title: "Forrest Gump",
        director: "Robert Zemeckis",
        date: "1994",
        price: 8.99,
    },
    {
        id: 5,
        title: "Fight Club",
        director: "David Fincher",
        date: "1999",
        price: 10.79,
    },
    {
        id: 6,
        title: "The Dark Knight",
        director: "Christopher Nolan",
        date: "2008",
        price: 14.99,
    },
    {
        id: 7,
        title: "Gladiator",
        director: "Ridley Scott",
        date: "2000",
        price: 7.99,
    },
    {
        id: 8,
        title: "The Shawshank Redemption",
        director: "Frank Darabont",
        date: "1994",
        price: 9.49,
    },
    {
        id: 9,
        title: "The Godfather",
        director: "Francis Ford Coppola",
        date: "1972",
        price: 13.29,
    },
    {
        id: 10,
        title: "Schindler's List",
        director: "Steven Spielberg",
        date: "1993",
        price: 10.99,
    },
];

console.log(movies); // Wyświetl tablicę filmów w konsoli
