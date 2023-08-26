(
    async ()=>{
        
        const db = require('./db')
        const app = require('express')()

        const bodyParser = require('body-parser')
        app.use(bodyParser.json())
        app.use(bodyParser.urlencoded({ extended: false }))

        const cors = require('cors');
        app.use(cors({
            origin: '*'
        }))
        
        app.post("/insert-user", (req, res)=>{
            console.log(req.body)
            res.status(200).json(req.body)
        })

        app.listen(3536)

        //console.log("Inserindo novo cliente....")
        //await db.new_client({nome: "Fernanda Eloi", idade: 20})

        //console.log("Deletando cliente ID 1....")
        //await db.delete_client(1)

        //console.log("Atualizando cliente ID 4....")
        //await db.update_client(4, {nome: "Carolina Peterson", idade: 19})

        const clients = await db.all_clients()
        console.log("\nObtendo todos os clientes...\n")
        console.log(clients)
    }
)()