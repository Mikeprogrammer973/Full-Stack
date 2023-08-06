class Carro{// classe pai
    constructor(nome, doors){
        this.nome = nome
        this.doors = doors
        this.started = false
        this.vel = 0
        this.color = undefined
    }
    ligar(){
        this.started = true
    }
    desligar(){
        this.started = false
    }
    set_color(color){
        this.color = color
    }
}

class Militar extends Carro{
    constructor(nome, doors, blindagem, municao){
        super(nome, doors)
        this.blindagem = blindagem
        this.municao = municao
        this.set_color("Verde")
    }
    atirar(){
        if(this.municao > 0) this.municao--
    }
    get_info(){
        return `Nome: ${this.nome}\nPortas: ${this.doors}\nLigado: ${this.started}\nCor: ${this.color}\nBlindagem: ${this.blindagem}\nMunição: ${this.municao}`
    }
}

//const car_n = new Carro("Mustang X", 6)
//console.log(car_n)

const car_m = new Militar("Mustang XKiller", 6, 100, 7)

car_m.atirar()

console.log(car_m)
console.log(car_m.get_info())