const express = require('express')
const app = express()
const mongoose = require('mongoose')

const routes_album = require('./routes/album_r')
app.use('/album', routes_album)

mongoose.connect('mongodb://localhost:27017/pritam_db?retryWrites = true',{useNewUrlParser: true}, function(err,res){
    if(!err){
        console.log('Connected to DB')
    }
})

app.get('/', (req,res) => {
    res.send('<h1>Home Page</h1>')
})


app.listen(3000, ()=>{
    console.log('Server is Running at port 3000')
})