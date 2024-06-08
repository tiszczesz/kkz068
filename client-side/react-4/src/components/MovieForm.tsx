import { useState } from 'react';
import { Movie } from '../data/movies';

type Props = {
  addMovie: (movie: Movie) => void;
};

const MovieForm = (props: Props) => {
  const [title, setTitle] = useState<string>('');
  const [director, setDirector] = useState<string>('');
  const [date, setDate] = useState<string>('');
  const [price, setPrice] = useState<number>(0);
  return (
    <>
      <h3>Dodaj nowy film</h3>
      <form
        onSubmit={(event) => {
          event.preventDefault();
          props.addMovie({ id: -1, title, director, date, price });
          console.log({ id: -1, title, director, date, price });
        }}
      >
        <input
          className="form-control"
          type="text"
          placeholder="Tytuł"
          onChange={(event) => setTitle(event.target.value)}
        />
        <br />
        <input className="form-control" type="text" placeholder="Reżyser"
        onChange={(event) => setDirector(event.target.value)} />
        <br />
        <input className="form-control" type="number" placeholder="Rok" 
        onChange={(event) => setDate(event.target.value)}/>
        <br />
        <input
          className="form-control"
          type="number"
          placeholder="Cena"
          step={0.01}
          onChange={(event) => setPrice(parseFloat(event.target.value))}
        />
        <br />
        <button className="btn btn-primary" type="submit">
          Dodaj
        </button>
      </form>
    </>
  );
};

export default MovieForm;
