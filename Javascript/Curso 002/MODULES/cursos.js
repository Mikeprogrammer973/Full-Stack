const cursos = ["Javascript", "PHP", "CSS", "C#", "HTML"]

export default function get_all(){
    return cursos
}

function get_curso(indice){
    return cursos[indice]
}

export {cursos, get_curso}

//export default get_all