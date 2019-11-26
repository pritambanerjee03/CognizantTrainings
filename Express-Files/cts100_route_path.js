const express = require('express');
const app = express();

app.get('/', (req,res) => {

    res.send("root")
});

app.get('/about', (req,res) => {

    res.send("about")
});

app.get('/contact', (req,res) => {

    res.send("contact")
});
app.listen(3000, () => console.log('Server is runnig at 3000'));
