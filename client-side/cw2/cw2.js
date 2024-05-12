const colors = ["white", "red", "green", "blue", "yellow"];
//wygeneroewać w root select i option z kolorami
console.log(typeof colors);
//zwykla for
console.log("===============zwykłe for z indeksem===============");
for (let i = 0; i < colors.length; i++) {
    console.log(colors[i]);
}
console.log("==============for of===================");
for (let color of colors) {
    console.log(color);
}
console.log("=============forEach===============");
colors.forEach((v, i) => {
    console.log(`${i} => ${v}`);
})

const select = document.createElement("select");
select.id = "idColors";
colors.forEach((v) => {
    const option = document.createElement("option");
    option.value = v;
    option.innerText = v;
    select.appendChild(option);
});
document.querySelector("#root").appendChild(select);