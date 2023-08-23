const http = require('http')
const fs = require('fs')

const port = process.env.PORT
const host = "127.0.0.1"

const server = http.createServer((req, res)=>{

    /*fs.readFile('site.html', (err, file)=>{
        res.writeHead(200, {"Content-Type": "text/html"})

        res.write(file)

       return res.end()
    })*/

    fs.appendFile("file.txt", "Curso de Node.js", (err)=>{
        if(err) throw err
        console.log("File created successfully!")

        res.end()
    })

})

server.listen(port || 3000, host, ()=> console.log("Servidor rodando..."))