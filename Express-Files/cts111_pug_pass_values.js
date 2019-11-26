const express = require('express');
const app = express();

app.set('view engine', 'pug')

app.get('/', (req,res) => {
    res.render('index112',
    {title_msg : 'Title Message', h1_msg : 'Heading1 Message', para_msg: 'hi hello'})  
});


app.listen(3000, () => console.log('Server is runnig at 3000'));
