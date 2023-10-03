import React from 'react';

class Carro extends React.Component
{
    constructor(props)
    {
        super(props)
        this.modelo = "Mercedez"
        this.state = {
            ligado: false,
            velAtual: 0
        }

        this.ld = this.ligar_desligar.bind(this)
    }

    ligar_desligar()
    {
        //this.setState({ligado: !this.state.ligado})
        this.setState(
            (state)=>(
                {ligado: !state.ligado}
            )
        )
    }

    accelerar()
    {
        if(this.state.ligado)
            this.setState(
                (state)=>(
                    {velAtual: state.velAtual + this.props.fator}
                )
            )
    }

    ralentir()
    {
        if(this.state.ligado)
            this.setState(
                (state)=>(
                    {velAtual: state.velAtual >= this.props.fator ? state.velAtual - this.props.fator: state.velAtual}
                )
            )
    }

    componentDidMount()
    {
        console.log("O carro foi criado!")
    }

    componentDidUpdate()
    {
        console.log("O carro foi atualizado!")
    }

    render()
    {
        return(
            <>
                <h3>Meu Carro</h3>
                <p>Modelo: {this.modelo}</p>
                <p>Ligado {this.state.ligado?"Sim":"Não"}</p>
                <p>Velocidade atual: {this.state.velAtual} km/h</p>
                <p>
                    <button className={this.state.ligado?"btn btn-danger":"btn btn-success"} onClick={this.ld}>{this.state.ligado?"Desligar":"Ligar"} carro</button>
                </p>
                <p>
                    <button className={"btn btn-warning"} onClick={()=>this.accelerar()}>Accelerar</button>
                    <button className={"btn btn-primary"} onClick={()=>this.ralentir()}>Ralentir</button>
                </p>
            </>
        )
    }
}

export default Carro