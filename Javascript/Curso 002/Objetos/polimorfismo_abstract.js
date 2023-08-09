class Standar{
    constructor(){
        if(this.constructor === Standar){
            throw new TypeError("You cannot get an instgance of this class! It's an abstract class!")
        }
        if(this.ligar === undefined){
            throw new TypeError("It's mandatory to implements the 'ligar' method!")
        }
        if(this.desligar === undefined){
            throw new TypeError("It's mandatory to implements the 'desligar' method!")
        }
        this.portas = 4
        this.rodas = 4
        this.ligado =  false
    }
}

class Carro extends Standar{
    constructor(tipo, e_turbo){
        super()

        this.turbo = new Turbo(e_turbo)

        if(tipo == 1){
            this.velMax = 120
            this.nome = "Normal"
        } 
        if(tipo == 2) {
            this.velMax = 160
            this.nome = "Esportivo"
        }
        if(tipo == 3) {
            this.velMax = 200
            this.nome = "XportivoZ"
        }

        this.velMax += this.turbo.pot
    }
    ligar(){
        this.ligado = true
    }
    desligar(){
        this.ligado = false
    }
    print_info(){
        console.log(`Nome: ${this.nome}\nVelMax: ${this.velMax}\nTurbo: ${this.turbo.pot}\nPortas: ${this.portas}\nRodas: ${this.rodas}\nLigado: ${this.ligado?"Sim":"Não"}\n\n`)
    }
}

class Turbo{
    constructor(e){
        if(e == 0) this.pot = 0
        if(e == 1) this.pot = 50
        if(e == 2) this.pot = 75
        if(e == 3) this.pot = 100
    }
}

class XcarZ extends Carro{
    constructor(e_turbo){
        super(4, e_turbo)
        this.velMax = 300 + this.turbo.pot
        this.nome = "Special XCarZ"
    }
    print_info(){
        console.log("....................")
        super.print_info()
    }
}

const car1 = new Carro(1, 0)
const car2 = new Carro(1, 3)
const car3 = new XcarZ(3)

car3.ligar()

car1.print_info()
car2.print_info()
car3.print_info()