//import logo from './logo.svg';
import './App.css';
import Components from './components/components';
import Page001 from './components/page001';
import Page002 from './components/page002';
import Page003 from './components/page003';
import { useState, useEffect } from 'react';

function App()
{

  const [page, setPage] = useState(0)

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
          <h1>---Welcome HOME---</h1>
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
      </Components.Container>
    </>
  )
}

export default App;
