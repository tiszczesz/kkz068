// fetch("https://jsonplaceholder.typicode.com/users")
//     .then((res) => res.json())
//     .then((data) => console.log(data));
// console.log("ala ma kota");
fetch("https://jsonplaceholder.typicode.com/users")
    .then((res) => res.json())
    .then((data) => GetFromJSON(data));
function GetFromJSON(data) {
    const list = document.createElement("ul");
    list.className = "list-group";
    data.forEach((v) => {
        const li = document.createElement("li");
        li.innerText = `id: ${v.id} username: ${v.username}`;
        li.className = "list-group-item"
        list.appendChild(li);
    })
    document.querySelector("#root").appendChild(list);
}