import '../App.css';
import components from '../components/components';
import { useState, useEffect } from 'react';

export default function Page001() {

useEffect(()=>{
    console.log(`${document.title} reloaded...`)
})

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
    </>
);
}
