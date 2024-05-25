var _a;
import { UsersList } from "./data.js";
console.log(UsersList);
function GenerTab(data) {
    const table = document.createElement("table");
    table.className = "table table-striped";
    const thead = document.createElement("thead");
    const trhead = document.createElement("tr");
    trhead.innerHTML = "<th>Lp</th><th>Nazwa</th><th>Wiek</th><th>Data</th>";
    thead.appendChild(trhead);
    table.appendChild(thead);
    const tbody = document.createElement("tbody");
    data.forEach((v, i) => {
        var _a;
        const tr = document.createElement("tr");
        tr.innerHTML = `<td>${i + 1}</td>
            <td>${v.username}</td>
            <td>${v.age}</td>
            <td>${(_a = v.date) === null || _a === void 0 ? void 0 : _a.toLocaleDateString()}</td>`;
        tbody.appendChild(tr);
    });
    table.appendChild(tbody);
    return table;
}
(_a = document.querySelector("#root")) === null || _a === void 0 ? void 0 : _a.appendChild(GenerTab(UsersList));
