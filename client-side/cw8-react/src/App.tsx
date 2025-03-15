import { useState } from 'react'
import { welcomeTexts } from './data'
import './App.css'

function App() {
  const [fontSize, setFontSize] = useState(16)
  const [welcomeText, setWelcomeText] =
        useState(welcomeTexts[0]);
  console.log("renderowanie komponentu App");
  

  return (
    <>
     <h1 className='header'>Właściwości czcionki</h1>
     <div>Rozmiar: {fontSize}</div>
     <input style={{width:"100%"}} type='range' 
     min={0} max={40} value={fontSize}
     onChange={(e)=>setFontSize(parseInt(e.target.value))} />
    </>
  )
}

export default App
