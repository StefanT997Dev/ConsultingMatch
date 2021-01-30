import React from 'react';
import './HabitComponent.css';

const HabitComponent = (props) => {
  return(
  <div className="HabitComponent">
    <div>
      {props.habits.map((habit,index)=>
        <div className="habitAndCheck">
        <button 
        onClick={()=>props.setSelectedHabit(index)}
        className="habitButton">{habit}</button>
        <input type="checkbox"></input>
      </div>)}
    </div>
  </div>
)};

HabitComponent.propTypes = {};

HabitComponent.defaultProps = {};

export default HabitComponent;
