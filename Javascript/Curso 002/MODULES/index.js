import Contact from "./contacts.js"
import { contacts } from "./contacts.js"

Contact.conatiner_contact = document.getElementById("list-contacts")

document.getElementById("f-add-cts").onsubmit = ()=>{
    const els = document.getElementById("f-add-cts").elements

    const ct = new Contact(els[0].value, els[1].value, els[2].value)
    print_contacts()

    els[0].value = ""
    els[1].value = ""
    els[2].value = ""

    return false
}

const print_contacts = ()=>{
    Contact.conatiner_contact.innerHTML = ""
    contacts.map((ct)=>{
        ct.print_contact()
        ct.ref.onclick = ()=>{
            ct.remove_contact()
            print_contacts()
        }
    })
}