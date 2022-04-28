var agora = new Date() //Pegando hora diretamente do sistema
var hora = agora.getHours()

if(hora < 12 && hora > 5){
    console.log(`Agora são exatamente ${hora} horas da manhã.`)
    console.log("Bom dia!")
}else if(hora > 12 && hora <= 18){
    console.log(`Agora são exatamente ${hora} horas da tarde.`)
    console.log("Boa tarde!")
}else{
    if(hora >= 18 && hora < 24){
        console.log(`Agora são exatamente ${hora} horas da noite.`)
        console.log("Boa noite!")
    }else{
        console.log(`Agora são exatamente ${hora} horas da madrugada.`)
        console.log("Boa madrugada!")
    }
}