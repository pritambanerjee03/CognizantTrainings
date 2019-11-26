const express = require('express');
const app = express();

app.set('view engine', 'pug')

app.get('/', (req,res) => {
    res.render('index')  //render is look pug files from views folder
});


app.listen(3000, () => console.log('Server is runnig at 3000'));
