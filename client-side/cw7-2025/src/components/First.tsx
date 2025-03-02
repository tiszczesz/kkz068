

type Props = {
    myColor: string,
    text: string,
    accent?: boolean
    mySize: number
}

function First({ myColor, text, mySize, accent }: Props) {
    let myClass = ""
    if(accent) {
        myClass = "temp"
    }
   
    return (
        <div className={myClass} style={{ color: myColor, fontSize: mySize + "px" }}>{text}</div>
    )
}

export default First