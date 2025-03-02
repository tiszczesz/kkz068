import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import First from './components/First'
import MyText from './components/MyText'
import PlayColors from './components/PlayColors'


function App() {
  return (
    <>
      <h1 >Hello first</h1>
      <div className='temp'>DSfsfdsf sdfdsf </div>
      <First accent={true} myColor="#114512" text="udało się" mySize={10} />
      <First myColor="Green" text="nieudało się" mySize={20} />
      <First myColor="blue" text="sdfsfsfę" mySize={30} />
      <First myColor="orange" text="--sad asdas---" accent={true} mySize={40} />
      <MyText content="sdfsdf" limit={20} />
      <MyText content="sdfsdf sadsa dsad sad a dadsad asda da" />
      <MyText content="asda da" />
      <hr />
      <PlayColors />
    </>
  )
}

export default App
