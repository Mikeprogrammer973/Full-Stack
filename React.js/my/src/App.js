import logo from './logo.svg';
import './App.css';
import components from './components/components';

function App() {
  return (
    <>
      <components.Btn text={"Start"}/>
      <hr></hr>
      <components.Container>
        <components.Task name={"Learn Node.js"} isDone={true}/>
        <components.Task name={"Learn JavaScript"} isDone={true}/>
        <components.Task name={"Learn TypeScript"} isDone={false}/>
        <components.Task name={"Learn React"} isDone={false}/>
        <components.Task name={"Learn C#"} isDone={true}/>
        <components.Task name={"Learn Saass"} isDone={false}/>
      </components.Container>
      <components.Container>
        <components.Gallery/>
      </components.Container>
      <components.Container>
        <components.Counter/>
      </components.Container>
    </>
  );
}

export default App;
