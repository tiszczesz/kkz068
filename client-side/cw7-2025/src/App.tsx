import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import First from './components/First'

function App() {


  return (
    <>
      <h1 >Hello first</h1>
      <div className='temp'>DSfsfdsf sdfdsf </div>
      <First accent={true} myColor="#114512" text="udało się" mySize={10} />
      <First myColor="green" text="nieudało się" mySize={20} />
      <First myColor="blue" text="sdfsfsfę" mySize={30} />
      <First myColor="orange" text="--sad asdas---" accent={true} mySize={40} />
      {/* <MyText text="sdfsdf" limit={20}/>
      <MyText text="sdfsdf sadsa dsad sad a dadsad asda da" /> */}
    </>
  )
}

export default App
