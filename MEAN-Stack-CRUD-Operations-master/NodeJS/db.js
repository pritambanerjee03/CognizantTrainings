const mongoose = require('mongoose');

//mongodb+srv://pritam03:<password>@cluster0-v2k4n.mongodb.net/test
mongoose.connect('mongodb+srv://pritam03:tukai1996@cluster0-v2k4n.mongodb.net/pritam_db', (err) => {
    if (!err)
        console.log('MongoDB connection succeeded.');
    else
        console.log('Error in DB connection : ' + JSON.stringify(err, undefined, 2));
});

module.exports = mongoose;