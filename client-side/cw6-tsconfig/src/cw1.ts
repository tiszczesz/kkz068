import { User, UsersList } from "./data.js";

console.log(UsersList);

function GenerTab(data: User[]): HTMLTableElement {
    const table = document.createElement("table");
    table.className = "table table-striped";
    const thead = document.createElement("thead");
    const trhead = document.createElement("tr");
    trhead.innerHTML = "<th>Lp</th><th>Nazwa</th><th>Wiek</th><th>Data</th>";
    thead.appendChild(trhead);
    
    table.appendChild(thead);
    const tbody = document.createElement("tbody");
    data.forEach((v, i) => {
        const tr = document.createElement("tr");
        tr.innerHTML = `<td>${i + 1}</td>
            <td>${v.username}</td>
            <td>${v.age}</td>
            <td>${v.date?.toLocaleDateString()}</td>`;
        tbody.appendChild(tr);
    });
    table.appendChild(tbody);
    return table;
}
document.querySelector<HTMLDivElement>("#root")?.appendChild(GenerTab(UsersList));