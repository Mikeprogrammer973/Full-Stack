export = {}

class Box<T>
{
    private item: T

    constructor(item: T)
    {
        this.item = item
    }

    get item_val()
    {
        return this.item
    }

    set item_val(item: T)
    {
        this.item = item
    }
}

const box_str = new Box<string>("Vanessa")
const box_num = new Box<number>(18)

console.log(box_str.item_val, box_num.item_val)