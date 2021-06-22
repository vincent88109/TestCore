import React, { Component } from 'react';

class TestRef extends Component {
    showInfo=(params) => {
        const input1=this
        console.log(input1)
        alert(input1)
    }
    render() {
        return (
            <div>
                <input type="text" ref={(currentNode)=>{this.input1=currentNode}}></input>
                <button onClick={this.showInfo}>点击</button>
            </div>
        );
    }
}

export default TestRef;