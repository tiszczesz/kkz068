
import './App.css';

function App() {
  const info = "To jest informacja z kodu TS";
  
  return (
    <>
    <h1 className='main'>To jest nagłówek</h1>
      <div>Hello</div>
      <ul>
        <li>Aaaa</li>
        <li>Aaaa</li>
        <li>Aaaa</li>
        <li>Aaaa</li>
      </ul>
      <select >
        <option value="red">czerwony</option>
        <option value="green">zielony</option>
        <option value="blue">niebieski</option>
        <option value="yellow">żółty</option>
      </select>
      <div style={{color:"red",textAlign:"right"}}>{info}</div>
      <hr />
      <h1>GGGG</h1>
    </>

  );
}

export default App;
