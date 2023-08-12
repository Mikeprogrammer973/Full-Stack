
function get_promise(){
    console.clear()
    console.log("Processando...")
    
    promise()
        // deu certo
        .then(
            (res)=>{
                console.clear()
                console.log(res)
            }
        )

        // deu errado - rejeitado
        .catch(
            (res)=>{
                console.clear()
                console.error(res)
            }
        )
}

const promise = ()=>{
    const pmise = new Promise(
        (resolve, reject)=>{
            let time = 3000
            let result = true
    
            setTimeout(()=>{
                if(result){
                    resolve("Deu tudo certo!")
                }else{
                    reject("Deu tudo errado!")
                }
            }, time)
        }
    )
    return pmise
}

console.log("Esperando...")
setTimeout(get_promise, 3000)