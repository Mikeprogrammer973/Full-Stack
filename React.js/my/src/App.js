//import logo from './logo.svg';
import './App.css';
import components from './components/components';
import Classe from './components/classe';
import { useState, useEffect } from 'react';

/*
  function App() {

    useEffect(()=>{
      console.log(`${document.title} reloaded...`)
    })

    const [form, setForm] = useState({"nome":"Maria", "curso":"Node", "ano":"2021"})

    function handleChange(e)
    {
      if(e.target.getAttribute('name') == 'nome') setForm({"nome":e.target.value, "curso":form.curso, "ano":form.ano})
      if(e.target.getAttribute('name') == 'curso') setForm({"nome":form.nome, "curso":e.target.value, "ano":form.ano})
      if(e.target.getAttribute('name') == 'ano') setForm({"nome":form.nome, "curso":form.curso, "ano":e.target.value})
    }

    const [notas, setNotas] = useState({"nota1": 0, "nota2": 0, "nota3": 0, "nota4": 0})
    function handleSetNotas(e)
    {
      if(e.target.getAttribute('num') == 1) setNotas({"nota1": e.target.value, "nota2": notas.nota2, "nota3": notas.nota3, "nota4": notas.nota4})
      if(e.target.getAttribute('num') == 2) setNotas({"nota1": 0, "nota2": e.target.value, "nota3": notas.nota3, "nota4": notas.nota4})
      if(e.target.getAttribute('num') == 3) setNotas({"nota1": notas.nota1, "nota2": notas.nota2, "nota3": e.target.value, "nota4": notas.nota4})
      if(e.target.getAttribute('num') == 4) setNotas({"nota1": notas.nota1 ,"nota2": notas.nota2, "nota3": notas.nota3, "nota4": e.target.value})
    }

    return (
      <>
        <components.Btn text={"Start"}/>
        <components.Horloge/>
        <hr></hr>

        <components.Container>
          <components.Pronote.NovaNota nota={notas.nota1} handleSetNotas={handleSetNotas} num={1}/>
          <components.Pronote.NovaNota nota={notas.nota2} handleSetNotas={handleSetNotas} num={2}/>
          <components.Pronote.NovaNota nota={notas.nota3} handleSetNotas={handleSetNotas} num={3}/>
          <components.Pronote.NovaNota nota={notas.nota4} handleSetNotas={handleSetNotas} num={4}/>
          <components.Pronote.SomaNotaFinal notas={[notas.nota1, notas.nota2, notas.nota3, notas.nota4]}/>
        </components.Container>

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
*/

function App()
{
  return(
    <>
      <h1>Componentes de Classes</h1>
      <Classe canal="Cine Movies"/>
    </>
  )
}

export default App;
