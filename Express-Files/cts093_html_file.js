const express = require('express');
const app = express();

app.get('/', (req,res) => {

    res.sendFile(__dirname+ '/cts093.html')
});
app.listen(3000, () => console.log('Server is runnig at 3000'));

