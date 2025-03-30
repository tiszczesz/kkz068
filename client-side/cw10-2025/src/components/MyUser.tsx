import React from 'react'
import { UserType } from '../data/types'
type Props = {
    user: UserType
}

const MyUser = (props: Props) => {
  return (
    <div className='user' style={{
        backgroundColor: props.user.accept ? "green" : "red",
        color: "white",
    }}>
        <p>Imię: {props.user.firstname}</p>
        <p>Nazwisko: {props.user.lastname}</p>
        <p>Płeć: {props.user.gender}</p>
    </div>
  )
}

export default MyUser