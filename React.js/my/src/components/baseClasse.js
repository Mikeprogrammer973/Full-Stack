import React from "react";

export default class BaseClasse extends React.Component
{
    constructor(props)
    {
        // Permitir props
        super(props)

        // Setando state
        this.state = {
            canal: "CFB Cursos",
            curso: "ReactJS",
            ativo: true,
            nome: this.props.aluno
        }
        this.status = this.props.status

        // Bindagem
        const ad = this.ativar_desativar.bind(this)
        
        // Instruções do construtor
    }

    // Manipulando state
    ativar_desativar()
    {
        this.setState((state)=>({ativo : !state.ativo}))
    }

    // Ciclo de vida
    componentDidMount()
    {
        console.log("O componente foi criado!")
    }

    componentDidUpdate()
    {
        console.log("O componente foi atualizado!")
    }

    componentWillUnmount()
    {
        console.log("O ccomponente foi removido!")
    }

    render()
    {
        return (
            <>
                <h1>
                    Componente de Classe
                </h1>
            </>
        )
    }

}