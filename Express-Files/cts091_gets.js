const express = require('express');
const app = express();

app.get('', (req,res) => {

    res.send("Hello World 1 blank ")
});

app.get('/', (req,res) => {

    res.send("Hello World 2 '/' ")
});
app.listen(3000, () => console.log('Server is runnig at 3000'));

//app.get('')  & app.get('/') are same
//if there are more same http verbs then first will be run
 