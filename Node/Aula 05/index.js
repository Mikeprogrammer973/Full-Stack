const express = require('express')
const app = express()

const port = process.env.port
const host = '127.0.0.1'

app.get("/", (req, res)=>{
    res.send("Maria Daniela!")
})

app.get("/mind", (req, res)=>{
    res.json({feel: 'Ni ideia', bkHeart: 'quizás'})
})

app.listen(port || 3000, host, ()=> console.log("Server running...."))

