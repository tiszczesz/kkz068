console.log("Hello from TS");
var a = "23";
function isOK(age) {
    if (age >= 18)
        console.log("OK");
    else
        console.log("NO OK");
}
isOK(78);
var colors = ["red", "green", "blue", "white", 23];
colors.forEach(function (v, i) {
    if (typeof v === "string")
        console.log(v.toUpperCase());
});
