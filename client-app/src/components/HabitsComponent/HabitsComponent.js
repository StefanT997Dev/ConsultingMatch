import React from 'react';
import './HabitsComponent.css';

const HabitsComponent = (props) => (
  <div className="HabitsComponent">
    <div className="flex-container">
      <div
        onClick={props.displayHabitsHandler}
        className="habits"><p>Habits</p>
      </div>
    </div>
  </div>
);

HabitsComponent.propTypes = {};

HabitsComponent.defaultProps = {};

export default HabitsComponent;
