const header =  
{
    method: "POST", 
    headers: {"Content-Type": "application/json"},
    body: JSON.stringify({nome: "Mike", idade: 18})
}

const gravar_dados = async ()=>{
    const res = await fetch("http://localhost:3536/insert-user", header)

    console.log(await res.json())
}

gravar_dados()