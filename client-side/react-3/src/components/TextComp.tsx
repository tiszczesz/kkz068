import { useState } from "react";

type Props = {}

const TextComp = (props: Props) => {
    const [info,setInfo] = useState("");
    console.log("renderowanie TextComp");
    
    return (
        <>
            <input type="text" onChange={(e) => {
                console.log(e.target.value);
                setInfo(e.target.value)
                console.log(`info = ${info}`);
            }
            }  value={info}/>
            <p>{info.toUpperCase()}</p>
        </>
    )
}

export default TextComp