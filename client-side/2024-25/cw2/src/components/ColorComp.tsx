import { useState } from "react";


export default function ColorComp() {
    const [color, setColor] = useState('red');
  return (
    <>
      <select value={color} onChange={(e)=>setColor(e.target.value)}>
        <option value="red">red</option>
        <option value="green">green</option>
        <option value="blue">blue</option>
        <option value="yellow">yellow</option>
      </select>
      <div
        style={{ width: '100px', height: '100px', 
            border: 'solid black 1px', backgroundColor: color }}
      ></div>
    </>
  );
}

