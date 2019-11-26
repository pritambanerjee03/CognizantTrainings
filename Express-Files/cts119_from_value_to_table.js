const express = require('express');
const app = express();

var MongoClient = require('mongodb').MongoClient;
//create a database named anything_db
var url= "mongodb://localhost:27017/pritam_db";
const bodyParser= require('body-parser')
app.use(bodyParser.urlencoded({extended: true}))
app.use(bodyParser.json())

app.get('/', (req,res) => {
    res.send("Got 'GET' Request....")
});

app.post('/', (req,res) => {
    let record = {code: req.body.code, name: req.body.name, designation: req.body.designation}
    MongoClient.connect(url, {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
        if(err) throw err;
        var dbo = dbcon.db("pritam_db");
       
        dbo.collection("employee_masters").insertOne(record,function(err,result){  
            if(err) throw err;
            console.log("1 record inserted")
            res.send("1 record inserted")
        dbcon.close();
        });   
    });
});

app.listen(3000, () => console.log('Server is runnig at 3000'));