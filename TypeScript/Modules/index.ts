//import operations from "./maths"
import { Somar, Multiplicar, Dividir } from "./maths"
import { EmailValidator as Validator } from "./email-validator"

console.log(Somar(15, 7))
console.log(Multiplicar(8, 5, 2))
console.log(Dividir(15, 5, 3, 2, 4))

console.log(new Validator().isValid("dhtshsrt@gmail.com"))
