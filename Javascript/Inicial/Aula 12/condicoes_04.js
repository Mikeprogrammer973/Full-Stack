var idade = 68
console.log(`Você tem ${idade} anos`)
if(idade >= 18 && idade < 67){
    console.log("Voto obrigatório!")
}else{
    if(idade >= 16 || idade >= 67){
        console.log("Voto opcional")
    }else{
        console.log("Não vota!")
    }
    
}