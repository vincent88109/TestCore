import React, { Component } from 'react';

class TestProps extends Component {
    constructor(props) {
        super(props);
        
    }
    render() {
        const {name,sex,age}=this.props
        return (
           <ul>
               <li>姓名：{name}</li>
               <li>性别：{sex}</li>
               <li>年龄：{age}</li>
           </ul>
        );
    }
}

export default TestProps;