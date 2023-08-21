const q1 = document.getElementById("q1")
const q2 = document.getElementById("q2")

const DOMRect_q1 = q1.getBoundingClientRect()
const DOMRect_q2 = q2.getBoundingClientRect()

q1.accessKey = "a"
q2.accessKey = "b"

console.log(q1.accessKey)

q1.onclick = ()=>{
    console.clear()
    console.log(`pX: ${DOMRect_q1.x}, pY: ${DOMRect_q1.y}, width: ${DOMRect_q1.width}, height: ${DOMRect_q1.height}, left: ${DOMRect_q1.left}, top: ${DOMRect_q1.top}`)
}
q2.onclick = ()=>{
    console.clear()
    console.log(`pX: ${DOMRect_q2.x}, pY: ${DOMRect_q2.y}, width: ${DOMRect_q2.width}, height: ${DOMRect_q2.height}, left: ${DOMRect_q2.left}, top: ${DOMRect_q2.top}`)
}

