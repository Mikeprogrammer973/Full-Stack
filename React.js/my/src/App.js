//import logo from './logo.svg';
import './App.css';
import components from './components/components';
import { useState } from 'react';

function App() {

  //const [nome, setNome] = useState('')
  const [form, setForm] = useState({"nome":"Maria", "curso":"Node", "ano":"2021"})

  function handleChange(e)
  {
    if(e.target.getAttribute('name') == 'nome') setForm({"nome":e.target.value, "curso":form.curso, "ano":form.ano})
    if(e.target.getAttribute('name') == 'curso') setForm({"nome":form.nome, "curso":e.target.value, "ano":form.ano})
    if(e.target.getAttribute('name') == 'ano') setForm({"nome":form.nome, "curso":form.curso, "ano":e.target.value})
  }

  return (
    <>
      <components.Btn text={"Start"}/>
      <components.Horloge/>
      <hr></hr>

      <components.Container>
        <form>
          <input onChange={(e)=>handleChange(e)} value={form.nome} className='form-control' type='text' placeholder='Nome...' name='nome'/>
          <input onChange={(e)=>handleChange(e)} value={form.curso} className='form-control' type='text' placeholder='Curso...' name='curso'/>
          <input onChange={(e)=>handleChange(e)} value={form.ano} className='form-control' type='number' placeholder='Ano...' name='ano'/>
          <p>Nome digitado: {form.nome}</p>
          <p>Curso digitado: {form.curso}</p>
          <p>Ano digitado: {form.ano}</p>
        </form>
      </components.Container>
    </>
  );
}

export default App;
