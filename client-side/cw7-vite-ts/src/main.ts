import './style.css';
import motyl from '/motyl.jpg';
import { Car, cars } from './data/cars';
// import typescriptLogo from './typescript.svg'
// import viteLogo from '/vite.svg'
// import { setupCounter } from './counter.ts'

console.log(cars);

const generTimer = (): HTMLDivElement => {
  const timer = document.createElement("div");
  timer.innerText = new Date().toLocaleTimeString();
  setInterval(() => UpdateTime(timer), 1000);
  return timer;
}

document.querySelector<HTMLDivElement>('#app')!.appendChild(generTimer());
// document.querySelector<HTMLDivElement>('#root')!.appendChild(GenerTab2(cars));
document.querySelector<HTMLDivElement>('#root')!.innerHTML = GenerTab1(cars);
//document.querySelector<HTMLDivElement>('#root')!.innerHTML = GenerTab1(cars);

function GenerTab2(data: Car[]): HTMLTableElement {
  return document.createElement("table");
}

function GenerTab1(data: Car[]): string {
  let html = "<table class='table'>";
  html += "<tr><th>Marka</th><th>przebieg</th><th>rok produkcji</th><th>cena</th></tr>";
  data.forEach((e) => {
    html += `<tr><td>${e.marka}</td><td>${e.przebieg}</td>
        <td>${e.rokProdukcji}</td><td>${e.cena}</td></tr>`;
  })
  return html + "</table>";
}
const img = document.createElement('img');
img.src = '/motyl.jpg';
//dodawanie obrazka
//document.querySelector<HTMLDivElement>('#root')!.appendChild(img);

function UpdateTime(elem: HTMLDivElement): void {
  elem.innerText = new Date().toLocaleTimeString();
}
