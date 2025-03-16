import { useState } from "react"
import { users,type User } from "../data/users"
import ItemList from "./ItemList"



const ComplexList = () => {
    const [usersList, setUsersList] = useState<User[]>(users)
  return (
    <div className="container">
        <h1>Lista użytkowników</h1>
        <div style={{display:"flex",gap:"10px"}}>
            {users.map((u,index)=>(
                <ItemList key={u.id} user={u}/>
            ))}
        </div>
    </div>
  )
}

export default ComplexList