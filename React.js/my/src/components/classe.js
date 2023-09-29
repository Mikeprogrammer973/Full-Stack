import React from 'react';

class Classe extends React.Component
{
    constructor(props)
    {
        super(props)
    }
    render()
    {
        return(
            <>
                <h3>Primeiro Componente de Classe</h3>
                <p>Canal: {this.props.canal}</p>
                <p>Curso: {this.props.curso}</p>
            </>
        )
    }
}

export default Classe 