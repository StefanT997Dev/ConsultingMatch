import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import NavbarComponent from './components/NavbarComponent/NavbarComponent';
import HabitsDisplay from './components/HabitsComponent/HabitsDisplay/HabitsDisplay';
import EventSchedulerComponent from './components/EventSchedulerComponent/EventSchedulerComponent';
import FormSchedulerComponent from './components/EventSchedulerComponent/FormSchedulerComponent/FormSchedulerComponent';
import EventModel from './Models/EventModel';
import PlannerComponent from './components/PlannerComponent/PlannerComponent';
import PlannerAndRolesComponent from './components/PlannerComponent/PlannerAndRolesComponent/PlannerAndRolesComponent';
import axios from 'axios';
import { Button, Header, Icon, Image } from 'semantic-ui-react'

class App extends Component {
  state={
   clients:[],
   clientName:""
  }

  componentDidMount(){
    axios.get('http://localhost:5000/api/client')
    .then((response)=>{
      this.setState({
        clients:response.data
      })
    });
  }

  createAClient=(e)=>{
    e.preventDefault();
    axios.post('http://localhost:5000/api/client/',this.state.clientName);
  }

  changeHandler=(e)=>{
    this.setState({
      clientName:e.target.value
    })
  }

  getClientsFromUsa=()=>{
    axios.get('http://localhost:5000/api/client/country/2')
    .then((response)=>{
      this.setState({
        clients:response.data
      })
    });
  }

  render(){
  const {clientName}=this.state
  return (
    <div>

        <NavbarComponent/>
        <label>Enter your name</label>
        <input 
          type="text" 
          name="clientName"
          onChange={this.changeHandler}
        />
        <br/>
        <button className="btn btn-primary" onClick={this.createAClient}>Create client</button>
        <br/>

        <button className="btn btn-primary" onClick={this.getClientsFromUsa}>Get clients from USA</button>
      

      
      {this.state.clients.map((client)=>(
        <li key={client.id}>{client.name} {client.surname}</li>
      ))}

    </div>
  )};
  }

export default App;
