import React, { FormEvent } from 'react'

type Props = {}

const MyForm = (props: Props) => {
  
    console.log("renderuje formularz");
    
    function handleSubmit(e: FormEvent<HTMLFormElement>): void {
        e.preventDefault(); // zapobiega przeładowaniu strony
        const formData = new FormData(e.currentTarget); // pobiera dane z formularza      
        console.log(formData);  
    }

  return (
    <form onSubmit={handleSubmit}>
    <div className="row m-2">
        <input placeholder="podaj imię" name="firstname"
            type="text" className="col-6" />
    </div>
    <div className="row m-2">
        <input placeholder="podaj nazwisko"
            name="lastname"
            type="text" className="col-6" />
    </div>
    <div className="row m-2">
        <select className="col-6" name="gender">
            <option value="m">Mężczyzna</option>
            <option value="k">Kobieta</option>
            <option value="i">Inna</option>
        </select>
    </div>
    <div className="row m-2">
        <input className="col-1" type="checkbox" name="accept" />    <label className="col-5">Akceptuję regulamin</label>
    </div>
    <button className="btn btn-secondary col-6">
        Zatwierdź
    </button>
</form>
  )
}

export default MyForm