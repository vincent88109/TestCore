import React, { Component } from 'react';

class TestState extends Component {

    //Tips:快捷键AN是箭头函数 




    //state繁写
    // constructor(props) {
    //     super(props);
    //     this.state = {
    //         ishot: true
    //     }
    // }


    //state简写
    state={ishot: true}



    ChangeHot = () => {
        // console.log(this)   
        const ishotVal = this.state.ishot
        this.setState({ ishot: !ishotVal })
    }
    MyOnBlur = () => {
       
    }

    render() {
        const { ishot } = this.state
        return (
            <div>
                <h1 onClick={this.ChangeHot}>
                    {this.state.ishot ? '炎热' : '寒冷'}
                </h1>
               
            </div>
        );
    }
}

export default TestState;