const http = require('http')
const url = require('url')

const port = 3000
const host = "127.0.0.1"

const server = http.createServer((req, res)=>{
    res.statusCode = 200

    res.setHeader("Content-Type", "text/html")

    const prms = url.parse(req.url, true).query

    console.log(prms)

    res.write(`<h1>${prms.nome}</h1>`)
    res.write(`<h2>${prms.curso}</h2>`)

    res.end()
})

server.listen(port, host, ()=>{
    console.log(`Servidor rodando...`)
})