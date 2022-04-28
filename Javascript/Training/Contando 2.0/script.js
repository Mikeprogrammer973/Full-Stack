function contar(){
    var txtinit = document.querySelector('#init')
    var init = Number(txtinit.value)
    var txtfim = document.querySelector('#fim')
    var fim = Number(txtfim.value)
    var txtpasso = document.querySelector('#passo')
    var passo = Number(txtpasso.value)
    var res = document.querySelector('#res')
    if((txtinit.value.length == 0 || txtfim.value.length == 0 || txtpasso.value.length == 0)){
        alert("[ERRO], por favor, verifica os dados!")
        res.innerHTML = "Impossível contar!"
    }else{
        if(passo <= 0){
            alert("Passo inválido, considera-se PASSO 1")
            passo = 1
        }
        res.innerHTML = `Contando:<br><br> `
        if(init < fim){//Contagem crescente
            for(var c = init; c <= fim; c += passo){
                res.innerHTML += `${c}  ➤  `
            }
           
        }else{//Contagem regressiva
            for(var c = init; c >= fim; c -= passo){
                res.innerHTML += `${c}  ➤  `
            }
        }  
    }
    res.innerHTML += ` 🎓` 
}
