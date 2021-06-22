import React, { Component } from 'react';

class TestForm extends Component {





    state={
        username:'',
        password:''
    }


    
    saveUserName = (event) => {
        //event.target.preventDefault()//阻止表单提交
        let val=event.target.value
        this.setState({username:val})
    }
    savePassword=(event) => {
        let val=event.target.value
        this.setState({password:val})
    }

    render() {
        return (
            <form style={{ display: 'flex', justifyContent: 'center', alignItems: 'center', flexDirection: 'column', height: '500px' }}>
                <label>Username</label><input onChange={this.saveUserName} type="text" name="username"></input><br />
                <label>Password</label><input onChange={this.savePassword} type="password" name="age"></input><br />
                <button >确认</button>
            </form>
        );
    }
}

export default TestForm;