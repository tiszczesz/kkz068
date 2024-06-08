import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.js';
import './App.css';
import MoviesList from './components/MoviesList';
import { Movie, movies } from './data/movies';
import { useState } from 'react';
import MovieForm from './components/MovieForm';

function App() {
  const [moviesList, setMoviesList] = useState<Movie[]>(movies);
  const [showForm, setShowForm] = useState<boolean>(false);
  function handleDelete(id: number): void {
    console.log(`usuwanie filmu o id ${id}`);
    setMoviesList(moviesList.filter((movie) => movie.id !== id));
  }

  function handleAdd(movie: Movie): void {
    console.log(`adding new movie ${movie}`);
    
  }

  return (
    <div className="container">
      <h1>React - 4 Listy</h1>
      <input
        type="button"
        className='btn btn-secondary w-50'
        value="Pokaż/Ukryj formularz"
        onClick={() => setShowForm(!showForm)}
      />
      {showForm && <MovieForm addMovie={(movie)=>handleAdd(movie)} />}
      <MoviesList list={moviesList} onDelete={(id) => handleDelete(id)} />
    </div>
  );
}

export default App;
