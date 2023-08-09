class Npc{
    static alert = false
    constructor(energy){
        this.energy = energy
    }
    print_info = function(){
        console.log(`Energy: ${this.energy}\nAlert: ${Npc.alert}\n\n`)
    }
}

const npc1 = new Npc(98)
const npc2 = new Npc(100)
const npc3 = new Npc(75)

Npc.alert = true

npc1.print_info()
npc2.print_info()
npc3.print_info()