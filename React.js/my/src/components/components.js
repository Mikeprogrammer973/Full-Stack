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

function Task({name, isDone})
{
    return(
        <li className={isDone?"alert alert-success":"alert alert-warning"}>
            {name}
        </li>
    )
}

const components = {
    "Btn": Button,
    "Task": Task
}

export default components