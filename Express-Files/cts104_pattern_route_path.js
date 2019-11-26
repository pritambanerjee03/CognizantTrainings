const express = require('express');
const app = express();

app.get('/ab(cd)?ef', (req,res) => {

    res.send("ab(cd)?ef,  0 or 1 'cd' characters in between 'ab' and 'ef' ")
    //will sastisfy for abcd, abbcd, abbbcd
});


app.listen(3000, () => console.log('Server is runnig at 3000'));
