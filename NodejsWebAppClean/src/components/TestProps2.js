import React, { Component } from 'react';

class TestProps2 extends Component {
    constructor(props) {
        super(props);
        
    }
    render() {
        const {name,sex,age}=this.props
        return (
           <ul>
               <li>姓名：{name}</li>
           </ul>
        );
    }
}

export default TestProps2;