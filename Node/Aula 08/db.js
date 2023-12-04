
const connect = async ()=>{
    if(global.connection && global.connection.state != 'disconnected') 
        return global.connection

    const mysql = require('mysql2/promise')
    const connection = mysql.createConnection("mysql://root:@localhost/curso_node")
    //console.log('Conectado ao banco...')
    global.connection = connection
    return connection
}

const all_clients = async ()=>{
    const connection = await connect()
    const [lines] = await connection.query("SELECT * FROM clients")
    return await lines
}

const new_client = async (client)=>{
    const connection = await connect()
    const sql = "INSERT INTO clients (nome, idade) VALUES (?, ?)"
    const prms = [client.nome, client.idade]
    await connection.query(sql, prms)
}

const update_client = async (id, client)=>{
    const connection = await connect()
    const sql = "UPDATE clients SET nome = ?, idade = ? WHERE id = ?"
    const prms = [client.nome, client.idade, id]
    await connection.query(sql, prms)
}

const delete_client = async (id)=>{
    const connection = await connect()
    const sql = "DELETE FROM clients WHERE id = ?"
    const prms = [id]
    await connection.query(sql, prms)
}

module.exports = {all_clients, new_client, update_client, delete_client}