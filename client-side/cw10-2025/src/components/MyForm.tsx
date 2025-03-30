import React from 'react'

type Props = {}

const MyForm = (props: Props) => {
    function handleSubmit(e: any): void {
        throw new Error('Function not implemented.')
    }

  return (
    <form onSubmit={(e)=>handleSubmit(e)}></form>
  )
}

export default MyForm