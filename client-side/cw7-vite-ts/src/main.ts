import './style.css'
// import typescriptLogo from './typescript.svg'
// import viteLogo from '/vite.svg'
// import { setupCounter } from './counter.ts'

const generTimer = (): HTMLDivElement => {
  const timer = document.createElement("div");
  timer.innerText = new Date().toLocaleTimeString();
  setInterval(() => UpdateTime(timer), 1000);
  return timer;
}
document.querySelector<HTMLDivElement>('#app')!.appendChild(generTimer());


function UpdateTime(elem: HTMLDivElement): void {
  elem.innerText = new Date().toLocaleTimeString();
}
