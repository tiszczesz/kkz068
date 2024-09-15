import { FormEvent, useState } from 'react';

const Calc = () => {
  const [a, setA] = useState<number>(0);
  const [b, setB] = useState<number>(0);
  const [op, setOp] = useState<string>('+');
  const [result, setResult] = useState<string>('wwwWynik obliczeń');
  function handleSubmit(e: FormEvent<HTMLFormElement>): void {
    e.preventDefault();
    console.log('submit');
    console.log(a, b, op);
    const error = 'BRAK WYNIKU';
    switch (op) {
      case '+':
        setResult(`${a} + ${b} = ${a + b}`);
        break;
      case '-':
        setResult(`${a} - ${b} = ${a - b}`);
        break;
      case '*':
        setResult(`${a} * ${b} = ${a * b}`);
        break;
      case '/':
        setResult(`${a} / ${b} = ${b != 0 ? a / b : error}`);
        break;
      default:
        setResult('Błąd');
        break;
    }
  }

  return (
    <>
      <form onSubmit={(e) => handleSubmit(e)}>
        <div className="row m-2">
          <input
            className="col-6"
            type="number"
            value={a}
            onChange={(e) => setA(Number(e.target.value))}
          />
          <span className="col-3 error"></span>
        </div>
        <div className="row m-2">
          <input
            className="col-6"
            type="number"
            value={b}
            onChange={(e) => setB(Number(e.target.value))}
          />
          <span className="col-3 error"></span>
        </div>
        <div className="row m-2">
          <select
            className="offset-3 col-3"
            value={op}
            onChange={(e) => setOp(e.target.value)}
          >
            <option value="+">+</option>
            <option value="-">-</option>
            <option value="*">*</option>
            <option value="/">/</option>
          </select>
        </div>
        <div className="row m-2">
          <input
            className="col-6 btn btn-primary"
            type="submit"
            value="Oblicz"
          />
        </div>
      </form>
      <div
        className="col-6"
        style={{
          border: 'solid 1px black',
          padding: '10px',
          backgroundColor: 'lightgreen',
        }}
      >
        {result}
      </div>
    </>
  );
};

export default Calc;
