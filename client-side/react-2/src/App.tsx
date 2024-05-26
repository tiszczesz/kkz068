import './App.css';
import { Car, cars } from './data/cars';

function App() {

  console.log("Renderowanie App...");
  const currentTime = new Date();
  const numbers = [2, 3, 5, 7, 11, 13, 17];
  const colors = ["white", "red", "green", "blue"];
  // const colorsEffect = colors.map((e) => {
  //   return `<option>${e}</option>`
  // })
  console.log(colors);
  //console.log(colorsEffect);

  return (
    <>
      <h1>Hello from App Component</h1>
      <div style={
        { border: "solid blue 1px", padding: "10px" }
      }>{currentTime.toLocaleTimeString()}</div>
      <div>{numbers.join(' ')}</div>
      <select>
        {colors.map((e, k) => (<option key={k}>{e}</option>))}
      </select>
      <ul>
        {cars.map((e, k) => (
          <li key={k}>{e.marka} {e.przebieg} km {e.cena} zł</li>
        ))}
      </ul>

      <hr />
      <table>
        <tr>
          <th>Lp</th>
          <th>Marka</th>
          <th>przebieg</th>
          <th>cena</th>
        </tr>
        {cars.map((c, i) => (
          <tr key={i}>
            <td>{i + 1}</td>
            <td>{c.marka}</td>
            <td>{c.przebieg}</td>
            <td>{c.cena}</td>
          </tr>
        ))}
      </table>
    </>
  )
}

export default App
