// Declarar variáveis
let inpt_tot_objs
let inpt_add_objs
let btn_add_objs
let btn_remove_all
let tela

let width_tela
let height_tela
let bolas = []
let qtd_bolas = 0

// Classe Bola
class Bola
{
    constructor()
    {
        this.size = Math.round((Math.random()*15) + 10)
        this.color = `rgb(${Math.round(Math.random()*255)}, ${Math.round(Math.random()*255)}, ${Math.round(Math.random()*255)})`
        this.pX = Math.round(Math.random()*(width_tela - this.size))
        this.pY = Math.round(Math.random()*(height_tela - this.size))
        this.velX = this.velY = Math.round(Math.random()*3) + 0.5
        this.dirX = this.dirY = (Math.random()*10) > 5 ? 1 : -1
        this.tela = tela
        this.id = Date.now() + "_" + Math.round(Math.random()*1000000000000)
        this.draw()
        this.ctrl = setInterval(this.control, 10)
        this.bola = document.getElementById(this.id)
    }

    draw(){
        const dv = document.createElement("div")
        dv.style.width = `${this.size}px`
        dv.style.height = `${this.size}px`
        dv.style.backgroundColor = this.color
        dv.style.top = `${this.pY}px`
        dv.style.left = `${this.pX}px`
        dv.setAttribute("class", "bola")

        this.tela.append(dv)
    }

    static remover_all(){
        bolas.splice(0, bolas.length)
        document.querySelectorAll(".bola").forEach((b)=>{
            b.remove()
        })
    }

    control(){

    }
}

window.onload = ()=>{
    // Inicializar as variáveis
    inpt_tot_objs = document.getElementById("total-objs")
    inpt_add_objs = document.getElementById("qtd-add-objs")
    btn_add_objs = document.getElementById("btn-add")
    btn_remove_all = document.getElementById("btn-remove")
    tela = document.getElementById("tela")
    width_tela = tela.offsetWidth
    height_tela = tela.offsetHeight

    window.addEventListener("resize", ()=>{
        width_tela = tela.offsetWidth
        height_tela = tela.offsetHeight
    })

    btn_add_objs.addEventListener("click", ()=>{
        if(inpt_add_objs.value <= 0) return

        for(let i = 0; i < inpt_add_objs.value; i++){
            // Instanciar novas bolinhas
            const bola = new Bola()
            bolas.push(bola)
        }
        inpt_add_objs.value = ""
        inpt_tot_objs.value = bolas.length
        console.log(bolas)
    })

    btn_remove_all.addEventListener("click", ()=>{
        Bola.remover_all()
        inpt_tot_objs.value = bolas.length
        console.log(bolas)
    })
}