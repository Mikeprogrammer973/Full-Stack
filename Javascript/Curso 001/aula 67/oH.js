
var painel, voltar, avant;

function iniciar(){
    painel = document.getElementById("info");
    voltar = document.getElementById("back");
    avant = document.getElementById("forward");

    avant.addEventListener("click", function(){
        hi(1);
    });
    voltar.addEventListener("click", function(){
        hi(-1);
    });
    document.getElementById("back_2").addEventListener("click", function(){
        hi(-2);
    });

    painel.innerHTML = "Tam. Histórico: "+history.length;
}

function avancer(){
    history.forward();
}

function reculer(){
    history.back();    
}

function aller(){
    history.go(-2);    
}

function hi(num){
    history.go(num);    
}

window.addEventListener("load", iniciar);