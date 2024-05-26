
import { ReactNode } from "react";
import { Person } from "../App"
type Props = {
    myColor: string;
    person?: Person;
    children?:ReactNode
}

function FirstComp({ myColor, person,children }: Props) {
    return (
        <>
            <h3 style={{ color: myColor }}>Informacja o osobie</h3>
           {person && <div style={{ backgroundColor: "lightgreen" }}
            >
                Szczegóły: {person?.firstname} {person?.age}
            </div>}
            <div>{children}</div>
        </>
    )
}

export default FirstComp