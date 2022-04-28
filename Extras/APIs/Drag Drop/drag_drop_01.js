function iniciar(){
 origem_1 = document.getElementById('imagem');
 origem_1.addEventListener('dragstart', arrastado, false);
 destino = document.getElementById('soltar');
 destino.addEventListener('dragenter', function(e){
 e.preventDefault(); }, false);
 destino.addEventListener('dragover', function(e){
 e.preventDefault(); }, false);
 destino.addEventListener('drop', soltado, false);
}
function arrastado(e){
 var codigo = '<img src="' + origem_1.getAttribute('src')+'">';
 e.dataTransfer.setData('Text', codigo);
}
function soltado(e){
 e.preventDefault();
 destino.innerHTML = e.dataTransfer.getData('Text');
}
window.addEventListener('load', iniciar, false);