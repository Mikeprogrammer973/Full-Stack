
function carregar(){
var msg = document.querySelector('#msg')
var img = document.querySelector('#image')
var data = new Date()
var hora = data.getHours()

msg.innerHTML = `Agora são ${hora} horas`
if(hora >= 0 && hora < 12){
    //BOM DIA!
    img.src="./Imagens/manhã.jpg"
    document.body.style.backgroundColor='#fcdc75'
}else if(hora >= 12 && hora <= 18){
    //BOA TARDE!
    img.src="./Imagens/tarde.jpg"
    document.body.style.backgroundColor='#9aa700'
}else{
    //BOA NOITE!
    img.src="./Imagens/noite.jpg"
    document.body.style.backgroundColor='#08091b'
}
}
