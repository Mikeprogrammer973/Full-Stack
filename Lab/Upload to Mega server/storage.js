const { Storage } = require('megajs')
const fs = require('fs')
var current_folder = null

// Node doesn't support top-level await when using CJS
;(async function () {
  const storage = new Storage({
    email: 'mikepascal.delta@gmail.com',
    password: '#Inazuma15'
  })

  // Will resolve once the user is logged in
  // or reject if some error happens
  await storage.ready

  /*storage.upload('hello-world.txt', 'Hello world!', (error, file) => {
    if (error) return console.error('There was an error:', error)
    console.log('The file was uploaded!', file)
  })*/

  /*const file = Object.values(storage.files).find(file => file.name === 'hello-world.txt')

  file.delete((err, res)=>{
    if(err) throw err
    console.log("File deleted!")
  })*/

  const folder_cd = Object.values(storage.files).find(folder => folder.name === 'Cloud Drive')

  if(folder_cd != "undefined"){
    console.log("No ./Cloud Drive/")
    //const folder_teste = await folder_cd.mkdir("Teste")
    //console.log("Folder Teste created!")
    //const folder_teste = folder_cd.children[1]
    current_folder  = folder_cd.children[1]
    //;(await current_folder.downloadBuffer()).readBigInt64BE()
    console.log("No ./Cloud Drive/Teste/")
    //await folder_teste.upload('hello-world.txt', 'index.js').complete
    //console.log("File uploaded!")
    //await upload({nome: "hello-world.txt", data: "Hello world!", folder: folder_teste})
    //current_folder = folder_teste
  }

  //storage.close(()=> console.log("Storage closed!"))

}()).catch(error => {
  console.error(error)
  process.exit(1)
})

const upload = async prms=>{
    //await prms.folder.upload(prms.nome, prms.data).complete
    //console.log("File uploaded!")
    
    await current_folder.upload(prms.nome, prms.data).complete
    console.log("File uploaded!")
    return prms.nome
}

const get_all_files = async ()=>{
  return current_folder.children
}

const download = async file_name =>{
  const file = current_folder.children.find(file=> file.name === file_name)
  if(file != "undefined"){
    const readable = await file.downloadBuffer()
    return readable
  }
}

module.exports = {upload, download, get_all_files}