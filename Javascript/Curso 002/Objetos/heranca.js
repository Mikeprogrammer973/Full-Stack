class Carro{// classe pai
    tipo = "01"
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
    tipo = "02"
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

const tipos = document.getElementsByName("tipo")
let tipo

tipos.forEach((t, i)=>{
    t.addEventListener("change", ()=>{
        if(t.value == "on" && i == 0){
            [...document.querySelectorAll(".op-ml")].forEach((op)=>{
                op.children[0].value = 0
                op.style.display = "none"
            })
            tipo = false
        }else if(t.value == "on" && i == 1){
            [...document.querySelectorAll(".op-ml")].forEach((op)=>{
                op.children[0].value = ""
                op.style.display = "block"
            })
            tipo = true
        }
    })
})

let cars = []
const add_car = ()=>{
    let container_cars = document.getElementById("cars")
    container_cars.innerHTML = ""
    cars.forEach((car)=>{
        let dv = document.createElement("div")
        dv.setAttribute("class", "car")
        if(car.tipo == "01"){
            dv.innerHTML = `<p>${car.nome}</p><p>${car.doors} porta(s)</p>`
        }else{
            dv.innerHTML = `<p>${car.nome}</p><p>${car.doors} porta(s)</p><p>${car.municao} balas</p><p>${car.blindagem}%`
        }
        container_cars.append(dv)
    })
}

document.getElementById("f-carros").onsubmit = ()=>{
    let nome = document.getElementById("nome")
    let portas = document.getElementById("portas")
    let blindg = document.getElementById("blindg")
    let balas = document.getElementById("balas")
    if(!tipo){
        cars.push(new Carro(nome.value, portas.value))
        nome.value = portas.value = ""
        blindg.value = balas.value = 0
    }else{
        cars.push(new Militar(nome.value, portas.value, blindg.value, balas.value))
        nome.value = portas.value = blindg.value = balas.value = ""
    }
    add_car()
    return false
}