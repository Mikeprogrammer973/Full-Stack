const express = require('express')
const app = express()
const routers = require('./routers/router')

const cors = require('cors');
app.use(cors({
    origin: '*'
}))

const port = process.env.PORT

app.use("/", routers)

app.get("*", (req, res)=>{
    res.status(200).send("OK!")
})

app.listen(port || 3000)