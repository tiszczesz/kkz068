import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.js';
import './App.css';
import MoviesList from './components/MoviesList';
import { movies } from './data/movies';

function App() {
  return (
    <div className="container">
      <h1>React - 4 Listy</h1>
      <MoviesList list={movies} />
    </div>
  );
}

export default App;
