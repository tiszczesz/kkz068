import { useState } from "react";


const NWDForm = () => {
    //definicja stanu aby było renderowanie
    const [result, setResult] = useState<string>("");
    const handleAction = (formData:FormData)=>{
        console.log(formData);
        const a = parseInt(formData.get("a") as string);
        const b = parseInt(formData.get("b") as string);
        const choice = formData.get("choice") as string;
        if(choice === "rec"){
            console.log("NWD rekurencyjnie: ", nwdRec(a,b));
            setResult(`NWD(${a},${b}) rekurencyjnie: ${nwdRec(a,b)}`);
        }else{
            console.log("NWD iteracyjnie: ", nwdIter(a,b));
            setResult(`NWD(${a},${b}) iteracyjnie: ${nwdIter(a,b)}`);
        }
    }
    return (<>

        <form
            action={handleAction}
        // onSubmit={handleSubmit}
        >
            <div className="row m-2">
                <label htmlFor="a" className="col-3 text-end">Podaj a:</label>
                <input type="number" name="a" id="a" className="col-6" />
            </div>
            <div className="row m-2">
                <label htmlFor="b" className="col-3 text-end">Podaj a:</label>
                <input type="number" name="b" id="b" className="col-6" />
            </div>
            <div className="row m-2">
                <label htmlFor="choice" className="col-3 text-end">Wybierz metodę:</label>
                <select name="choice" id="choice" className="col-6" >
                    <option value="rec">NWD rekurencyjnie</option>
                    <option value="iter">NWD iteracyjnie </option>
                </select>
            </div>
            <div className="row m-2">
                <button className="btn btn-secondary offset-3 col-6">Oblicz</button>
            </div>
        </form>
         <hr />
            {result && <h3>{result}</h3>}
        
    </>
    )
}

export default NWDForm

function nwdRec(a: number, b: number): any {
    throw new Error("Function not implemented.");
}
function nwdIter(a: number, b: number): any {
    throw new Error("Function not implemented.");
}

