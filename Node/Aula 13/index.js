
const { MongoClient, ServerApiVersion } = require("mongodb")

const uri = "mongodb+srv://mikepascaldelta:Nac15e71Nac15e71@cluster0.dprt8mv.mongodb.net/?retryWrites=true&w=majority";

// Create a MongoClient with a MongoClientOptions object to set the Stable API version
const client = new MongoClient(uri,  {
        serverApi: {
            version: ServerApiVersion.v1,
            strict: true,
            deprecationErrors: true,
        }
    }
)

async function run() {
  try {

    await client.connect()

    /*const obj = [
      {curso: "Curso de Asp.Net", canal: "Web Hacker"},
      {curso: "Curso de Asp.Net", canal: "Web Hacker"},
      {curso: "Curso de Asp.Net", canal: "Web Hacker"},
      {curso: "Curso de Asp.Net", canal: "Web Hacker"},
      {curso: "Curso de Asp.Net", canal: "Web Hacker"},
      {curso: "Curso de Asp.Net", canal: "Web Hacker"}
    ]
    const count = (await client.db("technocursos").collection("cursos").insertMany(obj)).insertedCount
    console.log(`\n${count} novo curso(s) adicionado(s)!\n`)*/

    //const curso = await client.db("technocursos").collection("cursos").findOne({canal: "CFB Cursos"})
    /*const options = {
      // sort returned documents in ascending order by title (A->Z) 1 or -1
      sort: { curso: 1 },
      projection: { _id: 1, curso: 1},
    }
    const query = {canal: "CFB Cursos"}
    const cursor = client.db("technocursos").collection("cursos").find(query, options)
    const cursos = []

    // print a message if no documents were found
    if ((await client.db("technocursos").collection("cursos").countDocuments(query)) === 0) {
      console.log("No courses found!");
    }

    for await (const curso of cursor) {
      cursos.push(curso)
    }

    cursos.map((curso)=>{
      console.log(curso._id.toJSON(), curso.curso)
    })*/

    //await client.db("technocursos").collection("cursos").deleteOne({curso: "Curso de Java"})
    //await client.db("technocursos").collection("cursos").deleteMany({curso: "Curso de Node"})
    //const count = (await client.db("technocursos").collection("cursos").deleteMany({curso: /.t/})).deletedCount
    //console.log(`\n${count} cursos deletados!\n`)

    //await client.db("technocursos").collection("cursos").replaceOne({curso: "Curso de CSS"}, {curso: "Curso de Bootstrap", canal: "Curso em Vídeo"})
    //await client.db("technocursos").collection("cursos").updateOne({curso: "Curso de C++"}, {$set:{curso: "Curso de Typescript"}})
    //console.log(`\n1 curso atualizado!\n`)

    const options = {
      sort: { curso: 1 },
      projection: { _id: 0, curso: 1, canal: 1},
    }
    const query = {}
    //{curso: /.o./i}
    const cursor = client.db("technocursos").collection("cursos").find(query, options).limit(3)

    for await (const curso of cursor) {
      console.log(curso)
    }

  } finally {
    await client.close()
  }
}
run().catch(console.dir)
