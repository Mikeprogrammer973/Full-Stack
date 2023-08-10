let op_exp = ""
let ligado = false

window.onload = ()=>{
    const teclas = ["7", "8", "9", "+", "4", "5", "6", "-", "1", "2", "3", "*", "0", ".", "=", "/", "(", ")", "CE", "ON"]

    teclas.forEach((t)=>{
        let tecla = ""
        if(isNaN(t)){
            tecla = `<button onclick='set_op(this)' class='tecla ctrl-op'>${t}</button>`
        }else{
            tecla = `<button onclick='set_op(this)' class='tecla'>${t}</button>`
        }
        document.getElementById("teclas").innerHTML += tecla
    })

}

function set_op(e){
    if(e.innerHTML == "ON"){
        e.innerHTML = "OFF"
        ligado = true
        return
    }
    if(e.innerHTML == "OFF"){
        e.innerHTML = "ON"
        ligado = false
        document.getElementById("result").innerHTML = ""
        document.getElementById("current-op").innerHTML = ""
        op_exp = ""
        return
    }
    if(!ligado){
        return
    }
    if(e.innerHTML == "CE"){
        document.getElementById("result").innerHTML = ""
        document.getElementById("current-op").innerHTML = ""
        op_exp = ""
        return
    }
    if(e.innerHTML == "="){
        document.getElementById("result").innerHTML = eval(op_exp)
        document.getElementById("current-op").innerHTML = ""
        op_exp = ""
        return
    }
    document.getElementById("current-op").innerHTML += `<span style='padding:0px 3px;'>${e.innerHTML}</span>`
    op_exp += e.innerHTML
}