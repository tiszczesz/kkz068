import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import { todos } from './data/todos'

function App() {


  return (
    <div className='container'>
      <div className='row'>
        <input style={{
          border: "none",
          borderBottom: "2px black solid"
        }}
          className='col-5 m-2' type="text" placeholder='nowy element' />
        <button style={{
          backgroundColor: "#DC143C",
          padding: "5px",
          color: "white"
        }} className='col-3 m-2'>DODAJ</button>
      </div>
      <ul className='list-group'>
        {todos.map((item,index)=>(
          <li key={index} className='list-group-item'>{item}</li>
        ))}
      </ul>
    </div>
  )
}

export default App
