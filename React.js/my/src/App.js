//import logo from './logo.svg';
import './App.css';
import components from './components/components';
import { useState } from 'react';

function App() {

  const [nome, setNome] = useState('')

  return (
    <>
      <components.Btn text={"Start"}/>
      <components.Horloge/>
      <hr></hr>

      <components.Container>
        <form>
          <input 
            onChange={(e)=>{setNome(e.target.value)}} value={nome} className='form-control' type='text' placeholder='seu nome...' name='ipt-nome'></input>
          <p>Nome digitado: {nome}</p>
        </form>
      </components.Container>
    </>
  );
}

export default App;
