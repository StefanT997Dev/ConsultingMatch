import React from 'react'
import { IClient } from '../../../Models/Client'

interface IProps{
    clients:IClient[];
}

export const ClientDashboard:React.FC<IProps> = ({clients}) => {
    return (
        <div>
            {clients.map(client=>(
                <li>{client.name}</li>
            ))}
            <div className="row">
                

                <div className="col-6 col-sm-4">.col-6 .col-sm-4</div>
                <div className="col-6 col-sm-4">.col-6 .col-sm-4</div>
                <div className="w-100 d-none d-md-block"></div>

                <div className="col-6 col-sm-4">.col-6 .col-sm-4</div>
                <div className="col-6 col-sm-4">.col-6 .col-sm-4</div>
            </div>
        </div>
    )
}
