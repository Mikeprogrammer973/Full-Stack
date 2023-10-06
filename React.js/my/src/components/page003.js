import '../App.css';
import Classe from '../components/classe';
import Carro from '../components/carro';
import Globals from '../components/globals';

export default function Page003()
{
  return(
    <>
      <h1>Componentes de Classes</h1>
      <Classe canal={Globals.canal} curso={Globals.curso} />
      <Carro fator={Globals.ano} canal="Web Hacker" curso="Curso de Csharp"/>
    </>
  )
}
