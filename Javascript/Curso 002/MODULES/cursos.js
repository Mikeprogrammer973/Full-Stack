
export default class Cursos{
    static cursos = ["Javascript", "PHP", "CSS", "C#", "HTML", "Node.js", "Typescript"]

    static get_all(){
        return this.cursos
    }

    static get_curso(curso){
        if(isNaN(curso) || curso < 0 || curso >= this.cursos.length) return new Error("Invalid index!")
        return this.cursos[curso]
    }

    static delete_curso(curso){
        if(isNaN(curso) || curso < 0 || curso >= this.cursos.length) return new Error("Invalid index!")
        return this.cursos.splice(curso, 1)
    }

    static add_curso(curso){
        if(curso == "") return new Error("Invalid name!")
        return this.cursos.push(curso)
    }
}

