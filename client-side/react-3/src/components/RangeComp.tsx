import { useState } from "react"


type Props = {}

const RangeComp = (props: Props) => {
    const [info,setInfo] = useState<number>(0);
  return (
    <>
        <input type="range" min={0} max={100} value={info}/>
        <p>{info}</p>
    </>
  )
}

export default RangeComp