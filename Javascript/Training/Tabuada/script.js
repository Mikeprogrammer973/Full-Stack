function mostrar(){
    var table = document.querySelector('#tabnumber')
    var tab = document.querySelector('#table')  
    if(table.value.length == 0){
        alert("Por favor, escolhe uma tabuada!")
    }else{
        var n = Number(table.value)
        var c = 1
        tab.innerHTML = ""
        while(c <=10){
            var res = n*c
            var item = document.createElement('option')
            item.text = `${n} x ${c} = ${res}`
            item.value = `tab ${c}`
            tab.appendChild(item)
            c++
        }
    }
 } 
  