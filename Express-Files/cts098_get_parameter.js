const express = require('express');
const app = express();

app.get('/:emp_code', (req,res) => {

    let { emp_code } = req.params;
    console.log(req.params)
    res.send(emp_code)
});
app.listen(3000, () => console.log('Server is runnig at 3000'));

