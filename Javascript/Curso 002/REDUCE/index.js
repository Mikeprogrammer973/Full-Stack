const p_array = document.querySelector("#array")
const btn = document.querySelector("#btnReduce")
const p_resultado = document.querySelector("#resultado")

const elements = [12, 4, 5, 8]
let aux = []

p_array.innerHTML = `[${elements}]` 

btn.addEventListener("click", () =>{
    p_resultado.innerHTML = elements.reduce((anterior, atual, index, arr) =>{
        aux.push(anterior, atual)
        return anterior + atual
    })
    p_resultado.innerHTML += `<br>${aux}`
})