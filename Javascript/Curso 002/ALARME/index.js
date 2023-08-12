let soneta_alarme
let alarme = false
let t_alarme
let timer 
let c_h_a

window.onload = ()=>{
    soneta_alarme = new Audio("videoplayback.m4a")

    soneta_alarme.loop = 1

    data()
    relogio()

    timer = document.getElementById("time")
    c_h_a = document.getElementById("t-end-a")
}

function data(){
    const data = new Date()

    document.getElementById("data").innerHTML = `${data.getDate()>9?data.getDate():"0"+data.getDate()}/${data.getMonth()>9?(data.getMonth()+1):"0"+(data.getMonth()+1)}/${data.getFullYear()}`
}

function relogio(){
    const data = new Date()

    document.getElementById("hora").innerHTML = `${data.getHours()>9?data.getHours():"0"+data.getHours()}:${data.getMinutes()>9?data.getMinutes():"0"+data.getMinutes()}:${data.getSeconds()>9?data.getSeconds():"0"+data.getSeconds()}`

    if(alarme && data.getTime() > t_alarme){
        document.getElementById("alarme").style.backgroundColor = "darkred"
        soneta_alarme.play()
    }

    setInterval(relogio, 1000)
}

function stop_alarme(){
    if(!alarme){
        alert("Nenhum alarme ativa!")
        return
    }
    alarme = false
    t_alarme = 0
    timer.removeAttribute("readonly")
    soneta_alarme.pause()
    document.getElementById("alarme").style.backgroundColor = "rgba(211, 211, 211, 0.548)"
    c_h_a.innerHTML = `Hora do alarme:`
}

function set_alarme(btn){

    if(alarme){
        alert("Espere o fim do alarme anterior!")
        return
    }

    if(timer.value <= 0 || timer.value == ""){
        alert("Tempo inválido!")
        timer.focus()
        return
    }

    let data = new Date()
    data.setTime(data.getTime()+(timer.value*1000))
    
    c_h_a.innerHTML = `Hora do alarme: ${data.getHours()>9?data.getHours():"0"+data.getHours()}:${data.getMinutes()>9?data.getMinutes():"0"+data.getMinutes()}:${data.getSeconds()>9?data.getSeconds():"0"+data.getSeconds()}`

    alarme = true
    timer.setAttribute("readonly", "readonly")
    timer.value = ""
    t_alarme = data.getTime()

}