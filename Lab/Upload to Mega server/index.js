const express = require('express')
const app = express()
const fs = require('fs')
const formidable = require('formidable')
const storage = require('./storage')

const cors = require('cors');
app.use(cors({
    origin: '*'
}))

app.get("/", (req, res)=>{
    fs.readFile("form.html", (err, file)=>{
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
                const uploaded_file = await storage.upload({nome: f.newFilename+tipo, data: data})
                res.contentType(".html")
                let content = '<link rel="stylesheet" href="style.css"><hr><span style="margin:50px;" class="alert-success">File uploaded!</span><hr><button style="margin:50px;"><a href="http://127.0.0.1:5500/Lab/Upload%20to%20Mega%20server/index.html">Voltar</a></button>'
                //const dwn_file = f.filepath.substring(0, f.filepath.indexOf(f.newFilename)) + uploaded_file
                //fs.writeFileSync(dwn_file, await storage.download(uploaded_file))
                res.status(200).send(content)
            })
        })
    }else{
        res.status(404)
        res.end()
    }
})

app.get("/getFiles", async (req, res)=>{
    let files = []
    const all = await storage.get_all_files()
    await all.map( async file => {
        if(!fs.existsSync("C:/Teste")) fs.mkdirSync("C:/Teste")
        const dir_file = `C:/Teste/${file.name}`
        files.push(dir_file)
        fs.writeFileSync(dir_file, await storage.download(file.name))
        console.log(files)
    })
    res.status(200).json(files)
})

app.listen(3033, ()=> console.log("Server running..."))