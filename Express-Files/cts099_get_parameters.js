const express = require('express');
const app = express();

app.get('/:emp_code/:emp_name', (req,res) => {

    let { emp_code } = req.params;
    console.log(req.params['emp_code'])
    console.log(req.params['emp_name'])
    res.send(req.params['emp_code']+" : "+req.params['emp_name'])
});
app.listen(3000, () => console.log('Server is runnig at 3000'));

