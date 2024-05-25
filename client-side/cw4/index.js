console.log("Hello from cw4");
const root = document.querySelector("#root");
const h3 = document.createElement("h3");
h3.innerText = "Jestem z JS";
root.appendChild(h3);
//nowy h3 z napisem---> jestem z JS
document.querySelector("#run").addEventListener("click", () => {
    const number1 = parseInt(document.querySelector("#A").value);
    const number2 = parseInt(document.querySelector("#B").value);
    if(!isNaN(number1) && !isNaN(number2)){
        const result = NWDIter(number1,number2);
        document.querySelector("#result").innerHTML = `NWD(${number1},${number2})
           = ${result}`;
    }else{
        alert("Błędne dane!!!!");
        document.querySelector("#result").innerHTML = ``;
    }
    //console.log(typeof number1);
})

function NWDIter(a, b) {
    let temp = a;
    while (b !== 0) {
        temp = a;
        a = b;
        b = temp % b;
    }
    return a;
}
function NWDRek(a, b) {
    if (b === 0) return a;
    return NWDRek(b, a % b);
}