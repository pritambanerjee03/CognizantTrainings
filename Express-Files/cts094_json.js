const express = require('express');
const app = express();

app.get('/', (req,res) => {

    var record_set1 = [
        {name: "Pritam" , department:"CSE"},
        {name: "Kimran" , department:"IT"},
        {name: "Pompi" , department:"ECE"}
    ];

    res.json(record_set1)
});
app.listen(3000, () => console.log('Server is runnig at 3000'));

