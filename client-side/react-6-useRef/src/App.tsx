import 'bootstrap/dist/css/bootstrap.css';
import './App.css';
import { FormEvent, useRef, useState } from 'react';

function App() {
  const formElement = useRef<HTMLFormElement>(null);
  const [results, setResults] = useState<string>('Brak danych');
  function handleSubmit(event: FormEvent<HTMLFormElement>): void {
    event.preventDefault();
    if (formElement.current !== null) {
      const formData = new FormData(formElement.current);
      console.log(formData);
      console.log(formData.get('firstname'));
      setResults(
        'Dane z formularza: imię: ' +
          formData.get('firstname') +
          ' nazwisko ' +
          formData.get('lastname') +
          ' data urodzenia: ' +
          formData.get('mydate')
      );
    }
  }

  return (
    <div className="container">
      <form ref={formElement} onSubmit={(e) => handleSubmit(e)}>
        <input
          required
          className="m-2"
          type="text"
          name="firstname"
          placeholder="podaj imie"
        />
        <br />
        <input
          required
          className="m-2"
          type="text"
          name="lastname"
          placeholder="podaj nazwisko"
        />
        <br />
        <input required className="m-2" type="date" name="mydate" />{' '}
        <label>Data urodzenia</label>
        <br />
        <button className="m-2" type="submit">
          Zatwierdź
        </button>
      </form>
      <hr />
      <div
        style={{
          border: 'solid 1px black',
          padding: '20px',
          backgroundColor: 'lightgray',
          minHeight: '100px',
        }}
      >
        {results}
      </div>
    </div>
  );
}

export default App;
