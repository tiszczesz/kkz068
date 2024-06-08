import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.js'
import './App.css'
import MoviesList from './components/MoviesList';


function App() {  
  const movies:Movie[] = myList
  return (
    <div className='container'>
      <h1>React - 4 Listy</h1>
      <MoviesList />
    </div>
  )
}

export default App
