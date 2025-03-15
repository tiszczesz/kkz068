import { useState } from 'react'
import { welcomeTexts } from './data'
import './App.css'

function App() {
  const [fontSize, setFontSize] = useState(16)
  const [welcomeIndex, setWelcomeIndex] =
    useState(0);
  console.log("renderowanie komponentu App");


  return (
    <>
      <h1 className='header'>Właściwości czcionki</h1>
      <div>Rozmiar: {fontSize}</div>
      <input style={{ width: "100%" }} type='range'
        min={0} max={40} value={fontSize}
        onChange={(e) => setFontSize(parseInt(e.target.value))} />
      <div style={{ fontSize: `${fontSize}px` }}>
        {welcomeTexts[welcomeIndex]}
      </div>
      <div style={{ textAlign: "center" }}>
        <button style={{
          padding: "10px",
          backgroundColor: "green",
          color: "white"
        }}
        onClick={()=>{
          setWelcomeIndex((welcomeIndex+1)%welcomeTexts.length)
        }}
        >&gt;&gt;</button>
      </div>
    </>
  )
}

export default App
