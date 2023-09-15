import logo from './logo.svg';
import './App.css';
import components from './components/components';

function App() {
  return (
    <>
      <components.Btn text={"Start"}/>
      <hr></hr>
      <components.Task name={"Learn Node.js"} isDone={true}/>
      <components.Task name={"Learn JavaScript"} isDone={true}/>
      <components.Task name={"Learn TypeScript"} isDone={false}/>
      <components.Task name={"Learn React"} isDone={false}/>
      <components.Task name={"Learn C#"} isDone={true}/>
      <components.Task name={"Learn Saass"} isDone={false}/>
    </>
  );
}

export default App;
