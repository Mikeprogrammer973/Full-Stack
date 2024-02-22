const express = require('express')
const app = express()
const fs = require('fs')
const formidable = require('formidable')
const storage = require('./storage')
const url = require('url')

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
    var files = []
    var names = []
    const all = await storage.get_all_files()
    if(typeof(all) != "undefined"){
        //console.log(all)
        async function converter()
        {
            await all.map( async (file, i) => {
                const btmap = await storage.download(file.name)
                names.push(file.name)
                files.push(btmap.toString('base64'))
                if(i == all.length-1){
                    let filtro = []
                    files.map( async f => {
                        if(filtro.indexOf(f) > -1){
                            files = filtro = names = []
                            await converter()
                            return
                        }else{
                            filtro.push(f)
                        }
                    })
                    if(files.length < all.length || files.length > all.length){
                        files = filtro = names = []
                        await converter()
                    }else{
                        console.log(names)
                        res.status(200).json({0: files, 1: names})
                    }
                }
            })
        }
        await converter()
        return
    }
    res.status(200).json(files)
})

app.get("/deleteFile", async (req, res)=>{
    const prms = url.parse(req.url, true).query
    console.log(prms.file_name)
    await storage.delete_file(prms.file_name)
    res.end(prms.file_name)
})



// // Imports the Google Cloud client library
// const {Translate} = require('@google-cloud/translate').v2;

// // Creates a client
// const translate = new Translate();
// translate.key = "AIzaSyDGpdMFzdyJkSOP9YUSgpTH7apoJVQ2ZQA"
// /**
//  * TODO(developer): Uncomment the following lines before running the sample.
//  */
// // const text = 'The text to translate, e.g. Hello, world!';
// // const target = 'The target language, e.g. ru';

// async function translateText(text, target) {
//   // Translates the text into the target language. "text" can be a string for
//   // translating a single piece of text, or an array of strings for translating
//   // multiple texts.
//   let [translations] = await translate.translate(text, target);
//   translations = Array.isArray(translations) ? translations : [translations];
//   console.log('Translations:');
//   translations.forEach((translation, i) => {
//     console.log(`${text[i]} => (${target}) ${translation}`);
//   });
// }

// translateText("I Love You!", 'tr');







app.listen(3033, ()=> console.log("Server running..."))