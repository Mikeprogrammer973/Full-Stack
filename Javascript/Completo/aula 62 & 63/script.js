var janela_1;
var janela_2;
var w, h, px, py;
var painel;

function New_Window(){
    janela_1 = window.open("tmp.html", "_blank", "width:300, height:300, top=100, left=300");
    janela_2 = window.open("tmp.html", "frame", "width:300, height:300, top=100, left=300");
}

function Close_Window(){
    janela_1.close();
    janela_2.close();
}

function OW_p2(){
painel = document.getElementById("painel");

w = window.innerWidth;// outerWidth -> largura externa
h = window.innerHeight;// outerHeight -> altura externa
px = window.screenX;
py = window.screenY;
}

function info(){
    OW_p2();
    painel.innerHTML = `Largura interna: ${w}</br>Altura interna: ${h}<br><br>Posição X = ${px}<br>Posição Y = ${py}`;
}