const express = require('express');
const app = express();

app.get('/ab*cd', (req,res) => {

    res.send("ab*cd,  0 or more  characters in between 'ab' and 'cd' ")
    //will sastisfy for abcd, abbcd, abbbcd
});


app.listen(3000, () => console.log('Server is runnig at 3000'));
