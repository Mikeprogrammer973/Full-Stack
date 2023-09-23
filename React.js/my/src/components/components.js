
import { useState } from 'react';
import { sculptureList } from '../utils/data';


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

function Counter()
{
  const [score, setScore] = useState(0)

  function increment()
  {
    setScore(s => s + 1)
  }

  return(
    <>
      <button className="Btn btn btn-warning" onClick={()=>increment()}>
        +1
      </button>
      <button className="Btn btn btn-warning" onClick={
        function(){
          for(let i = 0; i < 7; i++)
          {
            increment()
          }
        }
      }>
        +7
      </button>
      <h4>Score: {score}</h4>
    </>
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
  let taskContent = name
  if(isDone)
  {
    taskContent = (<del>{name}</del>)
  }
    return(
        <li style={{fontSize: '1.4em'}} className={isDone?"alert alert-success":"alert alert-warning"}>
            {taskContent}
        </li>
    )
}

function Gallery() {
  const [index, setIndex] = useState(0);
  const [showMore, setShowMore] = useState(false);
  const hasNext = index < sculptureList.length - 1;

  function handleNextClick() {
    if (hasNext) {
      setIndex(index + 1);
    } else {
      setIndex(0);
    }
  }

  function handleMoreClick() {
    setShowMore(!showMore);
  }

  let sculpture = sculptureList[index];
  return (
    <>
      <button className='btn btn-success' onClick={handleNextClick}>
        Next
      </button>
      <h2>
        <i>{sculpture.name} </i>
        by {sculpture.artist}
      </h2>
      <h3>
        ({index + 1} of {sculptureList.length})
      </h3>
      <button className='btn btn-primary' style={{display:"block", marginBottom:"10px"}} onClick={handleMoreClick}>
        {showMore ? 'Hide' : 'Show'} details
      </button>
      {showMore && <p>{sculpture.description}</p>}
      <img
        src={sculpture.url}
        alt={sculpture.alt}
      />
    </>
  )
}

const components = {
    "Btn": Button,
    "Task": Task,
    "Container": Container,
    "Gallery": Gallery,
    "Counter": Counter
}

export default components