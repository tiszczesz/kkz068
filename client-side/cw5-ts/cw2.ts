const colors = ["white", "green", "blue", "yellow", "red"];
const generSelect = (data: string[]): HTMLSelectElement => {
    const select = document.createElement("select");
    select.id = "colors";
    for (const color of colors) {
        const option = document.createElement("option");
        option.value = color;
        option.innerText = color;
        select.appendChild(option);
    }
    return select;
}
const root = document.querySelector<HTMLDivElement>("#root");
root?.appendChild(generSelect(colors));

const select = document.querySelector<HTMLSelectElement>("#colors");

select?.addEventListener("change", (e) => {
    //document.body.style.backgroundColor = select.value;
    document.body.style.backgroundColor =
        (e.target as HTMLSelectElement).value;
});

