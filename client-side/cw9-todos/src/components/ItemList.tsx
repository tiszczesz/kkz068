
import { User } from '../data/users'

type Props = {
    user: User
}

const ItemList = (props: Props) => {
  return (
    <div className='user'>
            <h3>nazwa użytkownika: {props.user.name}</h3>
            <h5>email: {props.user.email}</h5>
            <div>telefon: {props.user.phone}</div>
            <button className='btn btn-danger'>Usuń</button>
    </div>
  )
}

export default ItemList