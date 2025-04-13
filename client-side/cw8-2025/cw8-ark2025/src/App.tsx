import 'bootstrap/dist/css/bootstrap.css'
import './App.css'
import { useState } from 'react';
import { items, type Item } from './data/data';

function App() {
  const [animalChecked, setAnimalChecked] = useState(true);
  const [flowersChecked, setFlowersChecked] = useState(true);
  const [carsChecked, setCarsChecked] = useState(true);
  const [itemsList, setItemsList] = useState<Item[]>(items);

  console.log(flowersChecked, animalChecked, carsChecked);

  
  function handleClick(id: number): void {
    const newList = itemsList.map((item) => (
      item.id === id ? { ...item, downloads: item.downloads + 1 } : item
    ))
    setItemsList(newList);
    console.log(newList);
  }


  return (
    <>
      <h1>Kategorie zdjęć</h1>
  
      <div style={{ display: "flex", gap: "10px" }}>
        <div className="form-check form-switch">
          <input onChange={() => setFlowersChecked(!flowersChecked)} className="form-check-input"
            type="checkbox" id="flowers" checked={flowersChecked} />
          <label className="form-check-label"
            htmlFor='flowers'>Kwiaty</label>
        </div>
        <div className="form-check form-switch">
          <input onChange={() => setAnimalChecked(!animalChecked)} className="form-check-input"
            type="checkbox" id="animals" checked={animalChecked} />
          <label className="form-check-label"
            htmlFor='animals'>Zwierzęta</label>
        </div>
        <div className="form-check form-switch">
          <input className="form-check-input"
            onChange={() => setCarsChecked(!carsChecked)}
            type="checkbox" id="cars" checked={carsChecked} />
          <label className="form-check-label"
            htmlFor='cars'>Samochody</label>
        </div>

      </div>
      <div className='list'>
        {
          itemsList.map((item, index) => (
            <section key={index}>
              <img src={`/assets/${item.filename}`} alt={item.alt} />
              <h4>Pobrań: {item.downloads}</h4>
              <button
                onClick={() => handleClick(item.id)}
                className='btn btn-success'>Pobierz</button>
            </section>
          ))
        }

      </div>

    </>
  )
}

export default App
