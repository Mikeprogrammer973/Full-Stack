function Button({text})
{
  function handleClick()
  {
    alert(text)
  }

  return(
    <button className="Btn btn btn-dark" onClick={handleClick}>{text}</button>
  )
}

function Container({children})
{
  return(
    <div className='container'> {children} </div>
  )
}

function Task({name, isDone})
{
    return(
        <li style={{fontSize: '1.4em'}} className={isDone?"alert alert-success":"alert alert-warning"}>
            {name}
        </li>
    )
}

const components = {
    "Btn": Button,
    "Task": Task,
    "Container": Container
}

export default components