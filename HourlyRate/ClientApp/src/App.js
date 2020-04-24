import React, { Component } from 'react';
import uuid from 'react-uuid';

export default class App extends Component {
  static displayName = App.name;

    constructor(props) {
        super(props);
        this.state = {
            userId: uuid(),
            hourlyRate: 40
        };
        
        this.updateHourlyRate = this.updateHourlyRate.bind(this);        
        this.updateUserId = this.updateUserId.bind(this);

        this.handleSubmit = this.handleSubmit.bind(this);
    }


    handleSubmit(event) {
        event.preventDefault();
        console.log(JSON.stringify(this.state));

        fetch('api/rate/setHourlyRate', {
            method: 'POST',
            headers: {
                Accept: 'application/json',
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(this.state),
        });
    }
    
    setDefault() {
        this.setState({userId:uuid(), hourlyRate:40 });
    }
    
    updateUserId(event) {
        this.setState({userId: event.target.value});
    }

    updateHourlyRate(event) {
        this.setState({hourlyRate: event.target.value});
    }
    
  render () {
    return (
        <div>
             <h1>HourlyRate</h1>
            <form  onSubmit={this.handleSubmit}>
                <label  > UserId:</label>
                <input type="text" name="UserId"  value={this.state.userId}  onChange={this.updateUserId}/>
                <br/>
              <label >  HourlyRate: </label>
                <input type="number" name="HourlyRate"  value={this.state.HourlyRate}  onChange={this.updateHourlyRate}/>
             
                <input className="btn btn-primary" type="submit" value="Wyślij" />
                </form>
          </div>
    );
  }
}
