const iaddes = [12, 18, 21, 25, 17]
const maiores = iaddes.filter(function(valor, indice, array){
    if(valor >= 18){
        return valor
    }
})

const menores  = iaddes.filter(function(valor, indice, array){
    if(valor < 18)
    {
        return valor
    }
})

console.log(iaddes)
console.log(maiores)
console.log(menores)