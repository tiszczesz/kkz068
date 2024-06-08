import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import { useState } from 'react';

function App() {
  const [names, setNames] = useState<string[]>(['Anna', 'Monika', 'Roman']);
  const [firstname, setFirstname] = useState<string>('');
  console.log(firstname);
  
  function handleDelete(index: number): void {
    setNames(names.filter((name, i) => i!== index));
  }

  return (
    <div className="container mt-3">
      <div className="row">
        <input
          value={firstname}
          onChange={(e) => setFirstname(e.target.value)}
          type="text"
          className="col-3"
          placeholder="podaj imię zanajomego"
        />
        <input type="button" className="col-3" value="Dodaj nowego" 
        onClick={()=>setNames([...names,firstname])}/>
      </div>
      <h1>Lista zanajomych</h1>
      <ul className="list-group">
        {names.map((name, index) => (
          <li className="list-group-item" key={index}>
            {name} <button onClick={()=>handleDelete(index)}>x</button>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
