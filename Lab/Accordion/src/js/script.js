// Add your javascript here

const places = document.querySelectorAll('.accordion')
const descs = document.querySelectorAll('.description')

let multiple = false
let active = []

places.forEach( (place, i) =>{
    place.children[1].style.display = 'none'
    place.children[0].children[2].style.display = 'none'
    place.children[0].children[1].style.display = 'block'
    place.children[0].children[1].addEventListener('click', (e)=>{
        if(!multiple)
        {
            if(active.length > 0) hideItem(active[0])
            active = [i]
        }
        else
        {
            active.push(i)
        }
        showItem()
    })
    place.children[0].children[2].addEventListener('click', (e)=>{
        hideItem(i)
        active.splice(active.indexOf(i), 1)
    })
})

function showItem()
{
    active.forEach( item =>{
        places[item].children[0].children[1].style.display = 'none'
        places[item].children[0].children[1].nextElementSibling.style.display = 'block'
        descs[item].style.display = 'block'
    })
}

function hideItem(item)
{
    places[item].children[0].children[2].style.display = 'none'
    places[item].children[0].children[2].previousElementSibling.style.display = 'block'
    descs[item].style.display = 'none'
    
}

multiselect.addEventListener('change', (e)=>{
    multiple = e.target.checked
    if(!multiple)
    {
        active.forEach( (item, i) =>{
            if(active.length == (i+1)){
                active = [item]
                showItem()
                return
            }
            hideItem(item)
        })
    }
})

active = [0]
showItem()
