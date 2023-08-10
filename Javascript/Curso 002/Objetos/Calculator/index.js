let op_exp = ""

window.onload = ()=>{
    const teclas = ["7", "8", "9", "+", "4", "5", "6", "-", "1", "2", "3", "*", "0", ".", "=", "/", "(", ")", "CE", "X"]

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

    const t_ops = [".", "=", "-", "/", "*", "+"]

    // limpar
    if(e.innerHTML == "CE"){
        document.getElementById("result").innerHTML = ""
        document.getElementById("current-op").innerHTML = ""
        op_exp = ""
        return
    }
    if(e.innerHTML == "X"){
        const ops = document.getElementById("current-op").children
        if(ops.length <= 0){
            return
        }
        ops[ops.length-1].remove()
        op_exp = op_exp.substring(0, op_exp.length-1)
        return
    }

    // zeros
    if(op_exp.length == 1 && op_exp[0] == "0" && e.innerHTML != "."){
        op_exp = ""
        document.getElementById("current-op").innerHTML = ""
    }

    // pontos
    if(e.innerHTML == "."){
        if(op_exp == ""){
            op_exp = "0."
            document.getElementById("current-op").innerHTML = "<span style='padding:0px 3px;'>0 .</span>"
            return
        }
        if(op_exp[op_exp.length-1] == ")"){
            return
        }
        let op_found = false
        for(let i = 0; i < op_exp.length; i++){
            if(t_ops.indexOf(op_exp[i]) >= 2){
                op_found = true
                break
            }
        }
        if(!op_found && !isNaN(op_exp[0])){
            if(op_exp.indexOf(".") > -1){
                return
            }
        }
        if(op_found){
            let ref = []
            for(let i = 0; i < op_exp.length; i++){
                if(t_ops.indexOf(op_exp[i]) >= 2){
                    ref.push([op_exp[i], i])
                 }
            }
            let last_p_op = op_exp.substring(ref[ref.length-1][1], op_exp.length)
            if(last_p_op.indexOf(".") > -1){
                return
            }
        }
    }

    // sinais
    if((t_ops.indexOf(op_exp[op_exp.length-1]) > -1 && t_ops.indexOf(e.innerHTML) > -1) || (op_exp == "" && t_ops.indexOf(e.innerHTML) > -1)){
        return
    }

    // parentheses
    if(!isNaN(op_exp[op_exp.length-1]) && e.innerHTML == "(" ){
        document.getElementById("current-op").innerHTML += `<span style='padding:0px 3px;'>* (</span>`
        op_exp += "*("
        return
    }
    if(op_exp[op_exp.length-1] == "(" && (e.innerHTML) == ")" ){
        document.getElementById("current-op").innerHTML += `<span style='padding:0px 3px;'>0 )</span>`
        op_exp += `0)`
        return
    }
    if(op_exp[op_exp.length-1] == "(" && t_ops.indexOf(e.innerHTML) > -1 ){
        return
    }
    if(op_exp[op_exp.length-1] == ")" && !isNaN(e.innerHTML) ){
        document.getElementById("current-op").innerHTML += `<span style='padding:0px 3px;'>* ${e.innerHTML}</span>`
        op_exp += `*${e.innerHTML}`
        return
    }

    // igualdade
    if(e.innerHTML == "=" && op_exp == ""){
        return
    }
    if(e.innerHTML == "="){
        document.getElementById("result").innerHTML = eval(op_exp)
        document.getElementById("current-op").innerHTML = ""
        op_exp = ""
        return
    }
    
    // add op
    document.getElementById("current-op").innerHTML += `<span style='padding:0px 3px;'>${e.innerHTML}</span>`
    op_exp += e.innerHTML
}