const http = require('http')
const fs = require('fs')
const formidable = require('formidable')

const server = http.createServer((req, res)=>{
    if(req.url == "/sendFile"){
        const form = new formidable.IncomingForm()
        form.parse(req, (errors, fields, files)=>{
            const old_dir = files.fileupload[0].filepath
            const new_dir = "./" + files.fileupload[0].originalFilename
            fs.rename(old_dir, new_dir, (error)=>{
                if(error) throw new Error(error)
                console.log(files)
                res.end("Arquivo movido com sucesso!")
            })
        })
        return
    }
    res.writeHead(200, {"Content-Type": "text/html"})
    res.write('<form action="sendFile" method="post" enctype="multipart/form-data"><input type="file" name="fileupload" required><br><input type="submit" value="Enviar"></form>')
    return res.end()
})

server.listen(3000, ()=> console.log("Running..."))