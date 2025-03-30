import 'bootstrap/dist/css/bootstrap.css';
//import viteLogo from '/vite.svg'
import './App.css'
import MyForm19 from './components/MyForm19';
import MyForm from './components/MyForm';
import NWDForm from './components/NWDForm';

function App() {


  return (
    <div className='container'>
     <h1>Obsługa formularza react19</h1>
     {/* <MyForm19/> */}
     {/* <MyForm/> */}
     <NWDForm/>
     
    </div>
  )
}

export default App
