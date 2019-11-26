const express = require('express');
const app = express();

app.get('/', (req,res) => {
    //res.redirect('http://example.com')
    res.redirect('http://google.co.in')
});


app.listen(3000, () => console.log('Server is runnig at 3000'));
