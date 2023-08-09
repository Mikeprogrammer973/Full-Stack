const Nave = function(e){
    this.energy = e
    this.disparos = 100
}

const nv1 = new Nave(97)

Nave.prototype.vidas = 7
Nave.prototype.disparar = function(){
    if(this.disparos > 0) this.disparos -= 7
}

nv1.disparar()
nv1.disparar()
nv1.disparar()

console.log(nv1)
console.log(nv1.vidas)
