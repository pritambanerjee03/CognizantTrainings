const express = require('express');
const app = express();

var MongoClient = require('mongodb').MongoClient;
//create a database named anything_db
var url= "mongodb://localhost:27017/pritam_db";
//var url = "mongodB server"
var text=" "
app.get('/', (req,res) => {
    MongoClient.connect(url, {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
        if(err) throw err;
        var dbo = dbcon.db("pritam_db");
       
        //{} -> select * from employee_master  // without any conditions
        dbo.collection("employee_masters").find({name: "Sham"}).toArray(function(err,result){  //{}-> shows condition
            if(err) throw err;
            text += `<table border="1"><tr><td>Code</td><td>Name</td><td>Designation</td></tr>`
            result.forEach((item)=> {
                text += `<tr><td>${item.code}</td><td>${item.name}</td><td>${item.designation}</td></tr>`
            })
            text += '</table>'
             res.send(text);
        dbcon.close();
        
        });   hg
    });
});
app.listen(3000, () => console.log('Server is runnig at 3000'));