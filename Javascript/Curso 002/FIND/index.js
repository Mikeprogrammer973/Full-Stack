const p_array = document.querySelector("#array")
const input_p = document.querySelector("#txt_pesquisar")
const btn_pesquisar = document.querySelector("#btnPesquisar")
const p_resultado = document.querySelector("#resultado")

const elements = [12, 34, 56, 78, 90, 101, 11]

p_array.innerHTML = `[${elements}]`

btn_pesquisar.addEventListener("click", () =>{
    p_resultado.innerHTML = "Valor não encontrado!"
    elements.find((element, i) => {
        if(element == input_p.value){
            p_resultado.innerHTML = `Valor ${input_p.value} encontrado na posição ${i+1}`
        }
    })
})