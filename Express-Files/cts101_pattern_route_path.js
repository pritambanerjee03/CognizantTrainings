const express = require('express');
const app = express();

app.get('/ab?cd', (req,res) => {

    res.send("ab?cd,  note that b is optional if we provide abcdor acd it will work fine")
    //? is used for optional parameter
});


app.listen(3000, () => console.log('Server is runnig at 3000'));
