import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min';
import './App.css';
import ColorComp from './components/ColorComp';
import Color2Comp from './components/Color2Comp';

function App() {
  const myColors = ['red', 'green', 'blue', 'yellow', 'pink', '#1245ae'];

  return (
    <div className="container">
      <h1>Zrobiłem sam</h1>
      <ColorComp />
      <Color2Comp colors={myColors}>ala ma kota</Color2Comp>
      <Color2Comp colors={myColors}>
        <h4>Inne dziecko</h4>
      </Color2Comp>
      <Color2Comp colors={['black', '#675554', 'grey']} />
    </div>
  );
}

export default App;
