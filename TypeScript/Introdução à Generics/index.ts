
function return_random_element<T>(items: T[]): T
{
    return items[Math.floor(Math.random() * items.length)]
}

let nums = [15, 78, 5, 586, 58, 6, 96, 21, 30]

console.log(return_random_element<number>(nums))

let countries = ["EUA", "CA", "FR", "MX", "BR", "HTI", "ES", "CHINA"]

console.log(return_random_element<string>(countries))