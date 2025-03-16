
import { useState } from 'react';
import { User } from '../data/users'

type Props = {
    user: User,
    onDelete: (id: number) => void
}

const ItemList = (props: Props) => {
    console.log("renderuję ItemList");
    const [isLogged, setIsLogged] = useState(props.user.isLogged)
    
    function handleLogged(): void {
        setIsLogged(!isLogged)
        props.user.isLogged = !props.user.isLogged
        console.log(props.user);
        
    }

    return (
        <div className='user' style={{
            backgroundColor: props.user.isLogged ? 'lightgreen' : 'lightcoral',
        }}
            onClick={()=>handleLogged()}
        >
            <h3>nazwa użytkownika: {props.user.name}</h3>
            <h5>email: {props.user.email}</h5>
            <div>telefon: {props.user.phone}</div>
            <button
                className='btn btn-danger'
                onClick={() => props.onDelete(props.user.id)}
            >Usuń</button>
        </div>
    )
}

export default ItemList