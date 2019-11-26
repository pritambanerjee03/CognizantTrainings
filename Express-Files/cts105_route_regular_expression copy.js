const express = require('express');
const app = express();

app.get('/*fly$/', (req,res) => {

    res.send("/*fly$/ anything end with 'fly'")
   //this router path will match butterfly and dragonfly
   //but not butterflyman and dragonflyman and so on
});


app.listen(3000, () => console.log('Server is runnig at 3000'));
