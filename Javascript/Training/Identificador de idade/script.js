function verify(){
    var data = new Date()
    var ano = data.getFullYear()
    var fano = document.querySelector('#txtano')
    var res = document.querySelector('div#res')
    if(fano.value.length === 0 || fano.value > ano){
        alert("[ERRO!] Digite os dados corretamente e, tente novamente!")
    }else{
        var fsex = document.getElementsByName('radsex')
        var idade = ano - Number(fano.value)
        var gênero = ''
        var img = document.createElement('img')
        img.setAttribute('id', 'foto')
        if(fsex[0].checked){
            gênero = 'Homem'
            if(idade >= 0 && idade <= 10){
               //CRIANÇA 
               img.setAttribute('src', './Imagens/menino.jpg')
            }else if(idade > 10 && idade < 22){
                //JOVEM
                img.setAttribute('src', './Imagens/jovem masc..jpg')
            }else if(idade > 22 && idade <= 50){
                //ADULTO
                img.setAttribute('src', './Imagens/homem.jpg')
            }else if(idade > 50){
                //IDOSO
                img.setAttribute('src', './Imagens/idoso.jpg')
            }
        }else if(fsex[1].checked){
            gênero = 'Mulher'
             if(idade >= 0 && idade <= 10){
               //CRIANÇA 
               img.setAttribute('src', './Imagens/menina.jpg')
            }else if(idade > 10 && idade < 22){
                //JOVEM
                img.setAttribute('src', './Imagens/jovem f.jpg')
            }else if(idade > 22 && idade <= 50){
                //ADULTO
                img.setAttribute('src', './Imagens/mulher.jpg')
            }else if(idade > 50){
                //IDOSO
                img.setAttribute('src', './Imagens/idosa.jpg')
            }
        }
        res.style.textAlign = 'center'
        res.innerHTML = `Detectamos ${gênero} com ${idade} anos.`
        res.appendChild(img)
    }
}