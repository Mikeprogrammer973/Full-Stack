const express = require('express')
const routers = express.Router()


let cursos_info = [
    {"curso": "Node", "info": "Curso de Node"},
    {"curso": "React", "info": "Curso de React"},
    {"curso": "TypeScript", "info": "Curso de TypeScript"},
    {"curso": "Laravel", "info": "Curso de Laravel"},
    {"curso": "Javascript", "info": "Curso de Javascript"}
]


routers.get("/", (req, res)=>{
    res.json({hello: "Seja bem-vindo(a)!"})
})

routers.get("/:cursoId", (req, res)=>{
    const curso = req.params.cursoId
    const curso_info = cursos_info.find(c => c.curso == curso)

    if(!curso_info){
        res.status(404).json({
            curso: "Curso não encontrado!",
            info: curso
        })
    }else{
        res.status(200).json(curso_info)
    }
})

module.exports = routers