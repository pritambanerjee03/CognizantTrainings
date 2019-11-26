const express = require('express');
const app = express();

app.get('/', (req,res) => {

    res.send("Got 'GET' request.....")
});

app.post('/', (req,res) => {

    res.send("Got 'POST' request.....")
});
app.listen(3000, () => console.log('Server is runnig at 3000'));

