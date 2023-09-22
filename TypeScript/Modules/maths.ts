
function Somar(...nums: number[]): number
{
    let res = 0
    nums.map(n => res += n)
    return res
}

function Multiplicar(...nums: number[]):number
{
    let res = 1
    nums.map(n => res *= n)
    return res
}

function Dividir(...nums: number[]):number
{
    let res = nums[0]
    nums.map((n, i) => { if(i > 0) res /= n })
    return res
}

/*export default {
    "Somar": Somar,
    "Multiplicar": Multiplicar,
    "Dividir": Dividir
}*/

export {Somar, Multiplicar, Dividir}
