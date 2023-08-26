const http = require('http')
const events = require("events")
const EventoEmissor = new events.EventEmitter()

EventoEmissor.on('msg', ()=> console.log("Te amo principessa!"))
EventoEmissor.on('end', ()=> console.log("Fim do processamento...."))

const port = process.env.PORT || 3000
const server = http.createServer((req, res)=>{
    res.statusCode = 200
    res.setHeader("Content-Type", "text/plain")
    EventoEmissor.emit('msg')
    res.write("Bella ciao!")
    EventoEmissor.emit('end')
    res.end()
})

server.listen(port, ()=> console.log("\nServidor rodando...\n"))