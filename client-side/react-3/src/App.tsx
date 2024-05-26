import './App.css'
import FirstComp from './components/FirstComp'
import RangeComp from './components/RangeComp';
import TextComp from './components/TextComp';

export type Person = {
  id: number;
  firstname: string;
  age: number;
}

function App() {
  const people: Person[] = [
    { id: 1, firstname: "Antoni", age: 33 },
    { id: 2, firstname: "Tomasz", age: 22 },
    { id: 3, firstname: "Monika", age: 56 },
  ]
  return (
    <div className='container'>
      <h1>Ćwiczenie 4</h1>
      <FirstComp myColor="red" person={people[0]} />
      <FirstComp myColor="yellow" />
      <FirstComp myColor="green" person={people[2]} />
      <FirstComp myColor='black'><p>Ffffff dddd</p></FirstComp>
      <hr />
      <TextComp />
      <hr />
      <RangeComp />
    </div>
  )
}

export default App
