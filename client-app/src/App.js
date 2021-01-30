import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import HeaderComponent from './components/HeaderComponent/HeaderComponent';
import HabitsComponent from './components/HabitsComponent/HabitsComponent';
import HabitsDisplay from './components/HabitsComponent/HabitsDisplay/HabitsDisplay';
import EventSchedulerComponent from './components/EventSchedulerComponent/EventSchedulerComponent';
import FormSchedulerComponent from './components/EventSchedulerComponent/FormSchedulerComponent/FormSchedulerComponent';
import EventModel from './Models/EventModel';
import PlannerComponent from './components/PlannerComponent/PlannerComponent';
import PlannerAndRolesComponent from './components/PlannerComponent/PlannerAndRolesComponent/PlannerAndRolesComponent';
import axios from 'axios';
import { Header, Icon, Image } from 'semantic-ui-react'

class App extends Component {
  state={
   clients:[]
  }

  componentDidMount(){
    axios.get('http://localhost:5000/api/client')
    .then((response)=>{
      this.setState({
        clients:response.data
      })
    })
  }

  render(){
  return (
    <div>
      
      {this.state.clients.map((client)=>(
        <li key={client.id}>{client.name} {client.surname}</li>
      ))}

    </div>
  )};
  }

export default App;
