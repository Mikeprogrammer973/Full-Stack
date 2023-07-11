let mapa = new Map()
mapa.set("name", "Mike")
mapa.set("age", 18)

console.log(mapa.get("name"))

console.log(mapa.has("name"))

console.log(mapa.size)

mapa.forEach((value)=>{
    console.log(value)
})

console.log(mapa.size)