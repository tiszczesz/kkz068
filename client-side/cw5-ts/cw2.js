var colors = ["white", "green", "blue", "yellow", "red"];
var generSelect = function (data) {
    var select = document.createElement("select");
    select.id = "colors";
    for (var _i = 0, colors_1 = colors; _i < colors_1.length; _i++) {
        var color = colors_1[_i];
        var option = document.createElement("option");
        option.value = color;
        option.innerText = color;
        select.appendChild(option);
    }
    return select;
};
var root = document.querySelector("#root");
root === null || root === void 0 ? void 0 : root.appendChild(generSelect(colors));
var select = document.querySelector("#colors");
select === null || select === void 0 ? void 0 : select.addEventListener("change", function (e) {
    //document.body.style.backgroundColor = select.value;
    document.body.style.backgroundColor =
        e.target.value;
});
