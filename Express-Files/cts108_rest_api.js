const express = require('express');
const app = express();

app.get('/', (req,res) => {
   
    res.send('GOt GET Request....')
});

app.post('/', (req,res) => {
   
    res.send('GOt POST Request....')
});

app.put('/', (req,res) => {
   
    res.send('GOt PUT Request....')
});

app.delete('/', (req,res) => {
   
    res.send('GOt DELETE Request.....')
});


app.listen(3000, () => console.log('Server is runnig at 3000'));
