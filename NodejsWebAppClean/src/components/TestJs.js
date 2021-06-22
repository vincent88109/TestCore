import React, { Component } from 'react';

class TestJs extends Component {


    render() {
        let arr = [1, 3, 4, 7, 9]

        return (
            <div>
                {SumYY(...arr)}
            </div>
        );
    }
}


function SumYY(...numbers) {
    return numbers.reduce((a,b)=>{
        return a+b
    })
}

export default TestJs;