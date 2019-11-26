const express = require('express');
const app = express();

app.get('/ab+cd', (req,res) => {

    res.send("ab+cd,  note that b+ means minimum 1 b, inbetween 'a' and ' ")
    //will sastisfy for abcd, abbcd, abbbcd
});


app.listen(3000, () => console.log('Server is runnig at 3000'));
