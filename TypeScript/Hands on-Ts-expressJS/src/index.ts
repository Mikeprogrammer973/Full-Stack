
import express, { Request, Response, Express } from "express"
import dotenv from "dotenv"
import helmet from "helmet"

dotenv.config()

const app: Express = express()

const port = process.env.PORT || 3000

app.use(helmet())
app.use(express.json())
app.use(express.urlencoded({extended: true}))

app.get("/", (req: Request, res: Response)=>{
    res.status(200).send("<h1>Welcome to TS with ExpressJS!</h1><h2>Are you ready to start?</h2>")
})

app.listen(port, ()=> console.log(`Server running on port ${port}...`))