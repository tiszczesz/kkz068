
import { useState } from "react"
import { colors } from "../data/colors"

const PlayColors = () => {
    const [content, setContent] = useState('')
    const [myColor, setMyColor] = useState(colors[0])
    const changeColor = () => { 
        const color = colors[Math.floor(Math.random() * colors.length)]
        console.log(color)
        setMyColor(color)       
    }
    return (
        <div className="row">
            <input value={content} onChange={(event)=>setContent(event.target.value)} type="text" className="col-4 m-1" />
            <button onClick={changeColor}
                className="btn btn-primary col-2 m-1">
                Zmień kolor
            </button>
            <span style={{color:myColor}} className="col-4">{content}</span>
        </div>
    )
}

export default PlayColors


