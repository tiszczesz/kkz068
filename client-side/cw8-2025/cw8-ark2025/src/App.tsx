import 'bootstrap/dist/css/bootstrap.css'
import './App.css'
import { useState } from 'react';

function App() {
  const [animalChecked, setAnimalChecked] = useState(true);
  const [flowersChecked, setFlowersChecked] = useState(true);
  const [carsChecked, setCarsChecked] = useState(true);

  return (
    <>
      <h1>Kategorie zdjęć</h1>
      <div style={{ display: "flex", gap: "10px" }}>
        <div className="form-check form-switch">
          <input onClick={() => setFlowersChecked(!flowersChecked)} className="form-check-input"
            type="checkbox" id="flowers" checked={flowersChecked} />
          <label className="form-check-label"
            htmlFor='flowers'>Kwiaty</label>
        </div>
        <div className="form-check form-switch">
          <input onClick={() => setAnimalChecked(!animalChecked)} className="form-check-input"
            type="checkbox" id="animals" checked={animalChecked} />
          <label className="form-check-label"
            htmlFor='animals'>Zwierzęta</label>
        </div>
        <div className="form-check form-switch">
          <input className="form-check-input"
            onClick={() => setCarsChecked(!carsChecked)}
            type="checkbox" id="cars" checked={carsChecked} />
          <label className="form-check-label"
            htmlFor='cars'>Samochody</label>
        </div>

      </div>
     
    </>
  )
}

export default App
