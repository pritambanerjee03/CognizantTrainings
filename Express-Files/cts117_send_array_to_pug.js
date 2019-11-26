const express = require('express');
const app = express();

app.set('view engine', 'pug')

app.get('/', (req,res) => {
    
    let array2 = ['one','two','three','four'];
    res.render('index117', {array1 : array2});
});


app.listen(3000, () => console.log('Server is runnig at 3000'));
