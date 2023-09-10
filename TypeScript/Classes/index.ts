namespace Fabrica
{
    abstract class Standar 
    {
        readonly ligado: boolean = false
        static qtd_doors: number = 0
        ligar(){}
        desligar(){}
    }

    export class Car implements Standar
    {
        private nome: string
        readonly ano: number
        protected tipo: string
        static qtd_doors: number = 4
        ligado: boolean = false
        static confecionnaria_nome: string = "Techno-X-Cars"

        constructor(nome: string, ano: number)
        {
            this.nome = nome
            this.ano = ano
            this.tipo = "Standar"
        }

        public print_details()
        {
            return `${this.nome} ${this.tipo} ${this.ano}`
        }

        get nome_car()
        {
            return `${this.nome}`
        }

        set nome_car(new_name: string)
        {
            if(new_name != "") this.nome = new_name
        }

        ligar(): void {
            this.ligado = true
        }

        desligar(): void {
            this.ligado = false
        }

    }

    export class CarMilitar extends Car 
    {
        private municao: number 

        constructor(nome: string, ano: number)
        {
            super(nome, ano)
            this.tipo = "Militar"
            this.municao = 1584
        }

        get_municao()
        {
            return `Qtd. munição: ${this.municao}`
        }
    }
}

const car_std = new Fabrica.Car("Mercedez XWiz", 1895)
console.log(Fabrica.Car.confecionnaria_nome)
car_std.nome_car = "Astrix-WZ VI"
console.log(car_std.print_details() + "\n..........\n")

let car_mlt = new Fabrica.CarMilitar("KillerZ-007", 1892)
console.log(Fabrica.CarMilitar.confecionnaria_nome)
console.log(car_mlt.print_details())
console.log(car_mlt.get_municao())
console.log(car_mlt.ligado)
car_mlt.ligar()
console.log(car_mlt.ligado)