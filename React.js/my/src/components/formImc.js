import { useState } from "react"

export default function IMCForm()
{
    const [imc, setImc] = useState(0.00)
    const [peso, setPeso] = useState(0.00)
    const [alt, setAlt] = useState(0.00)
    return(
        <div>
            <strong>Peso(kg):</strong><input className="form-control" onChange={(e)=>{
                setPeso(e.target.value)
            }} value={peso} type="number" placeholder="Peso em kg" /> 
            <strong>Altura(m):</strong><input onChange={(e)=>{
                setAlt(e.target.value)
            }} className="form-control" value={alt} type="number" placeholder="Altura em metro" /> 
            <button onClick={()=>{
                setImc(Number(peso)/(Math.pow(Number(alt), 2)))
            }} className="Btn btn btn-success">Calcular</button>
            <p><strong>IMC: {imc.toFixed(2)}</strong></p>
        </div>
    )
}
