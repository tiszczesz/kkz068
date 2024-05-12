fetch("https://jsonplaceholder.typicode.com/posts")
    .then((resp) => resp.json())
    .then((data) => generCards(data));


//def funkcji przy użyciu arrow function
const generCards = (data) => {
    data.forEach((v) => {
        const card = document.createElement("div");
        card.className = "card m-2";
        card.style = "width: 18rem;";
        const h5 = document.createElement("h5");
        h5.className = "card-title";
        h5.innerText = v.title;
        const cardBody = document.createElement("div");
        cardBody.className = "card-body"
        const cardText = document.createElement("p");
        cardText.innerText = v.body;
        cardText.className = "card-text";
        cardBody.appendChild(h5);
        cardBody.appendChild(cardText);
        card.appendChild(cardBody)
        document.querySelector("#root").appendChild(card);
    });
}