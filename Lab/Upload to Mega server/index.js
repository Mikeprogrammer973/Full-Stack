const express = require('express')
const app = express()
const fs = require('fs')
const formidable = require('formidable')
const storage = require('./upload')

app.get("/", (req, res)=>{
    fs.readFile("index.html", (err, file)=>{
        if(err) throw err
        res.contentType(".html")
        res.status(200).send(file)
    })
})

app.post("/uploadFile", (req, res)=>{
    if(req.url == "/uploadFile"){
        const form = new formidable.IncomingForm()
        form.parse(req, (err, fields, files)=>{
            const f = files.file[0]
            const file_c = fs.readFile(f.filepath, async (err, data)=>{
                if(err) throw err
                console.log(data)
                const tipo = "." + f.mimetype.split("/")[1]
                await storage.upload({nome: f.newFilename+tipo, data: data})
                res.contentType(".html")
                res.status(200).send('<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"><hr><span style="margin:50px;" class="alert alert-success">File uploaded!</span><hr><button style="margin:50px;" class="btn btn-dark"><a href="http://127.0.0.1:3033/">Upload new file</a></button>')
            })
        })
    }else{
        res.status(404)
        res.end()
    }
})

app.listen(3033, ()=> console.log("Server running..."))