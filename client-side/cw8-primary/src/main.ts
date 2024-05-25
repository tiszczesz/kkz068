import './style.css'
import PrimalGenerator from './PrimalGenerator';

document.querySelector<HTMLDivElement>('#app')!.innerHTML = ``
document.querySelector("#run")?.addEventListener("click", () => {
  const input = document.querySelector<HTMLInputElement>("#limit")?.value;
  if (input !== undefined) {
    const limit = parseInt(input);
    if (isNaN(limit)) {
      alert("Brak danych");
      return;
    }
    const generator = new PrimalGenerator(limit);
    const numbers = generator.getPrimals();
    const result = document.querySelector<HTMLDivElement>("#result")
    if (result !== null)
      result.innerHTML = numbers.join(' ')
  }
});





