//import logo from './logo.svg';
import './App.css';
import Components from './components/components';
import Page001 from './components/page001';
import Page002 from './components/page002';
import Page003 from './components/page003';
import { useState} from 'react';
//import {Routes, Route, Link} from 'react-router-dom'
import IMCCalc from './components/IMC';

const carros = [
  {categoria: "Esporte", preco: 154700, modelo: "Golg HIU"},
  {categoria: "Esporte", preco: 5874900, modelo: "Ferrari"},
  {categoria: "Casual", preco: 40000, modelo: "Honda"},
  {categoria: "SUV", preco: 584120, modelo: "Mercedes"},
  {categoria: "Casual", preco: 85000, modelo: "HRV"},
  {categoria: "SUV", preco: 96000, modelo: "T-Cross"},
  {categoria: "Casual", preco: 125400, modelo: "Ranger"},
  {categoria: "Esporte", preco: 258000, modelo: "Hilux Premium"},
  {categoria: "Esporte", preco: 548000, modelo: "Toyota"},
  {categoria: "SUV", preco: 58000, modelo: "Go"},
  {categoria: "Casual", preco: 63000, modelo: "Camaro"},
  {categoria: "Esporte", preco: 4967200, modelo: "Mercedes"}
]


function tableCars(cat)
{
  return (
    <table>
      <thead>
        <tr>
          <th>Categoria</th>
          <th>Preço</th>
          <th>Modelo</th>
        </tr>
      </thead>
      <tbody>
        {carros.map(car => {
          if(car.categoria == cat)
          {
            return (
              <tr>
                <td>{car.categoria}</td>
                <td>R$ {car.preco}</td>
                <td>{car.modelo}</td>
              </tr>
            )
          }
        })}
      </tbody>
    </table>
  )
}

function App()
{

  const [page, setPage] = useState(0)

  const [cat, setCat] = useState('Esporte')

  function handlePageChange(page)
  {
    setPage(page)
    getPage()
  }

  const getPage = ()=>{
    if(page == 0)
    {
      return(
        <>
          <input type='text' value={cat} placeholder='Categoria...' onChange={(e)=>setCat(e.target.value)} className='form-control' />
          <hr/>
          {tableCars(cat)}
        </>
      )
    }
    if(page == 1)
    {
      return <Page001/>
    }
    if(page == 2)
    {
      return <Page002/>
    }
    if(page == 3)
    {
      return <Page003/>
    }
    if(page == 4)
    {
      return <IMCCalc/>
    }
  }

  return(
    <>
      <Components.Container>
        {getPage()}
      </Components.Container>
      <Components.Container>
        <button className='Btn btn btn-success' onClick={()=>handlePageChange(0)}>Home</button>
        <button className='Btn btn btn-primary' onClick={()=>handlePageChange(1)}>Página 1</button>
        <button className='Btn btn btn-primary' onClick={()=>handlePageChange(2)}>Página 2</button>
        <button className='Btn btn btn-primary' onClick={()=>handlePageChange(3)}>Página 3</button>
        <button className='Btn btn btn-primary' onClick={()=>handlePageChange(4)}>Calcular IMC</button>
      </Components.Container>
    </>
  )
}

export default App;
