const express = require('express');
const app = express();

app.get('/', (req,res) => {

    res.download('./sample.pdf')
});


app.listen(3000, () => console.log('Server is runnig at 3000'));
