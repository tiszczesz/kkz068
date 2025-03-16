import { useState } from "react"
import { users, type User } from "../data/users"
import ItemList from "./ItemList"
function getMaxId(users: User[]): number {
    let max = 0
    users.forEach(u => {
        if (u.id > max) {
            max = u.id
        }
    })
    return max
}


const ComplexList = () => {
    const [usersList, setUsersList] = useState<User[]>(users)
    const maxId = getMaxId(usersList)
    function handleDelete(id: number): void {
        const newList = usersList.filter(u => u.id !== id)
        setUsersList(newList)
    }

    return (
        <div className="container">
            <h1>Lista użytkowników</h1>
            <div style={{
                display: "flex",
                gap: "10px",
                flexWrap: "wrap",
                minWidth: "400px"
            }}>
                {usersList.map((u, index) => (
                    <ItemList onDelete={handleDelete} key={u.id} user={u} />
                ))}
            </div>
        </div>
    )
}

export default ComplexList