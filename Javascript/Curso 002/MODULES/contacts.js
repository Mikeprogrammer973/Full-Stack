import { contacts } from "./db_cts.js"

export default class Contact{
    static conatiner_contact = document.body

    constructor(nome, tel, email){
        this.nome = nome
        this.tel = tel 
        this.email = email
        this.ref = ""

        contacts.push(this)
    }

    print_contact(){
        const ct = document.createElement("div")
        ct.setAttribute("class", "contact")
        ct.innerHTML = `<p>${this.nome}</p> <p>${this.tel}</p> <p>${this.email}</p>`
        ct.style.cursor = "pointer"

        this.ref = ct

        Contact.conatiner_contact.append(ct)
    }

    get_ct_index(){
        return contacts.indexOf(this)
    }

    remove_contact(){
        contacts.splice(this.get_ct_index(), 1)
        this.ref.remove()
    }
}

export {contacts}