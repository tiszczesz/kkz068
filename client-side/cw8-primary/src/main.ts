import './style.css'
import PrimalGenerator from './PrimalGenerator';

document.querySelector<HTMLDivElement>('#app')!.innerHTML = ``

const generator = new PrimalGenerator(10);
console.log(generator.isPrimal(152));
console.log(generator.getPrimals());
