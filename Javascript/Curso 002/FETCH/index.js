
fetch("http://localhost:3000/Node").then(res => res.json()).then(res=>{
    console.log(res)
    document.write(`<p> <strong>${res.curso}</strong> : <em>${res.info}</em> </p>`)
})