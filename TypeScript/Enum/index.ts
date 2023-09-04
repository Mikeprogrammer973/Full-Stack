// enum numérico
enum Language {
    Portuguese,
    Italian,
    Spanish,
    English,
    Arabic,
    French
}
console.log(Language)

// enum de string
enum Day{
    Monday = 'MON',
    Tuesday = 'TUE',
    Wednesday = 'WED',
    Thursday = 'THU',
    Friday = 'FRI',
    Saturday = 'SAT',
    Sunday = 'SUN'
}
console.log(Day.Thursday)

// acessando valor com chave: (usando o const)
const enum Food {
    Hamburger,
    Cheeseburger,
    Barbecue,
    Hotdog,
    Pizza
}

function food(f: Food){
    return "Delicious foods!"
}

console.log(food(Food.Cheeseburger))