const cursos = ["HTML", "CSS", "JavaScript", "React", "Node.js"]

cursos.map((el, i)=>{
    console.log(`Curso: ${el} Pos: ${i}`)
})

let dobrar = e=>e*2

let nums = [4,5,6,7,8,9].map(dobrar)

console.log(nums)