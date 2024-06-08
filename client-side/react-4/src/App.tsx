import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.js';
import './App.css';
import MoviesList from './components/MoviesList';
import { Movie, movies } from './data/movies';
import  { useState } from 'react';

function App() {
  const [moviesList, setMoviesList] = useState<Movie[]>(movies);
  function handleDelete(id: number): void {
    console.log(`usuwanie filmu o id ${id}`);   
    setMoviesList(moviesList.filter((movie) => movie.id!== id));
  }

  return (
    <div className="container">
      <h1>React - 4 Listy</h1>
      <MoviesList list={moviesList} onDelete={(id)=>handleDelete(id)} />
    </div>
  );
}

export default App;
