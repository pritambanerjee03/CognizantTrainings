const express = require('express');
const app = express();

app.use(express.static(__dirname + '/public')); //Serving static files

app.set('view engine', 'pug')

app.get('/', (req,res) => {
    
    res.render('index113');
});


app.listen(3000, () => console.log('Server is runnig at 3000'));
