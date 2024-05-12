const colors = ["white", "red", "green", "blue", "yellow"];
const sizes = [10, 15, 18, 20, 24, 28, 32];
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
select.addEventListener("change", (e) => {
    document.querySelector(".scene").style.backgroundColor = e.target.value;
});
for (let s of sizes) {
    const radio = document.createElement("input");
    radio.type = "radio";
    radio.value = s;
    radio.name = "size";
    const label = document.createElement("label");
    label.innerText = s + "px";
    const br = document.createElement("br");
    document.querySelector("#root2").appendChild(radio);
    document.querySelector("#root2").appendChild(label);
    document.querySelector("#root2").appendChild(br);
    //todo 
    radio.addEventListener("click", (e) => {
        console.log(`kliknięto: ${e.target.value}px`);
        document.querySelector(".scene2").style.fontSize = e.target.value+"px";
    });
}