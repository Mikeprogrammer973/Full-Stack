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
        this.velX = Math.round(Math.random()*3) + 1.5
        this.velY = Math.round(Math.random()*3) + 0.9
        this.dirX = this.dirY = (Math.random()*10) > 5 ? 1 : -1
        this.tela = tela
        this.id = Date.now() + "_" + Math.round(Math.random()*1000000000000)
        this.draw()
        this.bola = document.getElementById(this.id)
        this.ctrl = setInterval(()=>{
            this.control(this.bola)
        }, 10)
    }

    draw(){
        const dv = document.createElement("div")
        dv.id = this.id
        dv.style.width = `${this.size}px`
        dv.style.height = `${this.size}px`
        dv.style.backgroundColor = this.color
        dv.style.top = `${this.pY}px`
        dv.style.left = `${this.pX}px`
        dv.setAttribute("class", "bola")

        this.tela.append(dv)
    }

    static remover_all(){
        bolas.forEach((b, i)=>{
            clearInterval(b.ctrl)
            b.bola.remove()
        })
        bolas.splice(0, bolas.length)
    }

    remover(pos){
        bolas.splice(pos, 1)
        this.bola.remove()
        clearInterval(this.ctrl)
    }

    verify_limit_event(pos){
        if(this.pX + this. size > width_tela){
            this.remover(pos)
        }
    }

    control(){
        // Horizontal
        if(this.pX + this. size >= width_tela){
            this.dirX = -1
        }else if(this.pX + this.size <= 0){
            this.dirX = 1
        }
        // Vertical
        if(this.pY + this. size >= height_tela){
            this.dirY = -1
        }else if(this.pY + this.size <= 0){
            this.dirY = 1
        }

        this.pX += this.velX * this.dirX
        this.pY += this.velY * this.dirY
        this.bola.style.left = `${this.pX}px`
        this.bola.style.top = `${this.pY}px`
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
        // Atualizar altura e largura da tela
        width_tela = tela.offsetWidth
        height_tela = tela.offsetHeight

        bolas.map((b, i)=>{
            b.verify_limit_event(i)
            inpt_tot_objs.value = bolas.length
            //console.log(bolas)
        })
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
        //console.log(bolas)

        bolas.map((b, i)=>{
            b.bola.addEventListener('click', ()=>{
                b.remover(i)
                inpt_tot_objs.value = bolas.length
                //console.log(bolas)
            })
        })
    })

    btn_remove_all.addEventListener("click", ()=>{
        Bola.remover_all()
        inpt_tot_objs.value = bolas.length
        //console.log(bolas)
    })
}