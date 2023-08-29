
const head = document.head
const body = document.body

const link_css = document.createElement("link")
link_css.rel = "stylesheet"
link_css.href = "header.css"

head.appendChild(link_css)

const header = document.createElement("header")
header.setAttribute("id", "header")
header.setAttribute("class", "header")

const c_logo = document.createElement("div")
c_logo.id = "c_logo"
const logo_img = document.createElement("img")
logo_img.src = "logo.png"
logo_img.alt = "Logo Image"
logo_img.id = "logo_img"
c_logo.appendChild(logo_img)

const title_ = document.createElement("h1")
title_.id = "title_"
title_.innerHTML = "TechnoPro"

header.appendChild(c_logo)
header.appendChild(title_)


body.prepend(header)