import  { useState } from 'react'
import { todos } from '../data/todos'

type Props = {}

const MonolitList = (props: Props) => {
    const [list, setList] = useState(todos)
    const [newItem, setNewItem] = useState('')
  
    function handleAddItem(): void {
      // alert("gfgfgfgf")
      if (newItem === '') return;
      setList([...list, newItem])//tworzymy nową tablicę z tym co było + nowym elementem
      // console.log(list);    
      setNewItem('')
    }
  
    function handleDeleteItem(index: number): void {
      console.log(`usuwanie elementu  z tablicy ${list[index]}`);
      const newList = list.filter((item, i) => i !== index)
      setList(newList)
    }
  
    return (
      <div className='container'>
        {newItem}
        <div className='row'>
          <input
            onChange={(e) => { setNewItem(e.target.value) }}
            value={newItem}
            style={{
              border: "none",
              borderBottom: "2px black solid"
            }}
            className='col-5 m-2' type="text" placeholder='nowy element' />
          <button
            onClick={() => handleAddItem()}
            style={{
              backgroundColor: "#DC143C",
              padding: "5px",
              color: "white"
            }} className='col-3 m-2'>DODAJ</button>
        </div>
        <ul className='list-group'>
          {list.map((item, index) => (
            <li key={index}
              className='list-group-item d-flex justify-content-between'>{item}
              <input
                onClick={() => handleDeleteItem(index)}
                className='btn btn-outline-danger'
                type="button"
                value="x" />
            </li>
          ))}
        </ul>
      </div>
    )
  
}

export default MonolitList