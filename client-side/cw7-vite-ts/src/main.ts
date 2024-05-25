import './style.css';
import { Car,cars } from './data/cars';
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
// document.querySelector<HTMLDivElement>('#root')!.innerHTML = GenerTab1(cars);

function GenerTab2(data:Car[]):HTMLTableElement {
  return document.createElement("table");
}

function GenerTab1(data:Car[]):string {
  return "<table></table>";
}


function UpdateTime(elem: HTMLDivElement): void {
  elem.innerText = new Date().toLocaleTimeString();
}
