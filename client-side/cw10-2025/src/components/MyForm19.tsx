import { useState } from "react";
import { UserType } from "../data/types";
import MyUser from "./MyUser";

function getGender(info: string): string {
    switch (info) {
        case "m":
            return "Mężczyzna";
        case "k":
            return "Kobieta";
        case "i":
            return "Inna";
        default:
            return "Nieznana płeć";
    }
}
function MyForm19() {
    const [formData, setFormData] = useState<UserType | null>(null);
    const [usersList, setUsersList] = useState<UserType[]>([]);
    function handleAction(e: FormData): void | Promise<void> {
        console.log(e);
        const user = {
            firstname: e.get("firstname") as string,
            lastname: e.get("lastname") as string,
            gender: getGender(e.get("gender") as string),
            accept: e.get("accept") as string === "on" ? true : false
        }
        setFormData(user);
        setUsersList([...usersList, user]);
    }


    return (
        <>
            <form action={handleAction}>
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
            <hr />
            {usersList.length > 0 && <div style={{
                display: "flex",
                flexWrap: "wrap",
                gap: "10px"
            }}>
                {usersList.map((elem, i) => (
                    <MyUser key={i} user={elem} />
                ))}
            </div>}
        </>
    )
}
export default MyForm19;
