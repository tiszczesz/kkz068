
import { useState } from 'react'
import './App.css'

function App() {
  const [fontSize, setFontSize] = useState(16)

  return (
    <>
     <h1 className='header'>Właściwości czcionki</h1>
     <div>Rozmiar: {fontSize}</div>
    </>
  )
}

export default App
