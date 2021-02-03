import React, { useState,useEffect } from 'react';
import NavbarComponent from '../../features/NavbarComponent/NavbarComponent';
import axios from 'axios';
import {Container} from 'semantic-ui-react'
import {LoginComponent} from '../../features/LoginComponent/LoginComponent';
import { IClient } from '../../Models/Client';
import { ClientDashboard } from '../../features/Clients/dashboard/ClientDashboard';
import { IConsultingCategory } from '../../Models/ConsultingCategory';
import { RegisterComponent } from '../../features/Clients/RegisterComponent/RegisterComponent';
import agent from '../api/agent';

const App =()=> {
  const [clients,setClients]=useState<IClient[]>([]);
  const [categories,setCategories]=useState<IConsultingCategory[]>([]);
  const [client,setClient]=useState<IClient | null>(null);

  useEffect(()=>{
    agent.Clients.list()
    .then(response=>{
      setClients(response)
    })
  },[]);
  
  const createAClient=(client:IClient | null)=>{
    console.log(client?.name);
    agent.Clients.create(client);
  }

  // const changeClientName=(e)=>{
  //   client?.name=e.target.value;
  // }

  // getClientsFromUsa=()=>{
  //   axios.get<IClient[]>('http://localhost:5000/api/client/country/2')
  //   .then((response)=>{
  //     this.setState({
  //       clients:response.data
  //     })
  //   });
  // }
  
  const getAllCategories=()=>{
    axios.get('http://localhost:5000/api/category')
    .then((response)=>{
      setCategories(response.data)
    });
    setTimeout(() => {
      console.log(categories)
    }, 1000);
  }

  
  return (
    <div>
        {/* <button onClick={this.getClients}>Get all clients</button> */}

        <NavbarComponent
          getAllCategories={getAllCategories}
          // renderCategories={renderCategories}
          categories={categories}
        />
        <RegisterComponent
          client={client}
          createAClient={createAClient}
        />

        <LoginComponent/>

        <Container>

        <ClientDashboard
          clients={clients}
        />

        </Container>

        {/* <NavbarComponent
          //renderCategories={this.state.renderCategories}
          //categories={this.state.categories}
          //getAllCategories={this.getAllCategories}
        />
        <LoginComponent
          //createAClient={this.createAClient}
          //getClientsFromUsa={this.getClientsFromUsa}
          //clients={this.state.clients}
          //changeHandler={this.changeHandler}
        /> */}

    </div>
  );
  }

export default App;
