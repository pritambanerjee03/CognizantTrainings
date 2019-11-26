const express = require('express');
const app = express();

app.set('view engine', 'pug')

app.get('/', (req,res) => {
    
    res.render('index115');
});


app.listen(3000, () => console.log('Server is runnig at 3000'));
