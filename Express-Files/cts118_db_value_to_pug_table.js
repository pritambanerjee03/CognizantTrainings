const express = require('express');
const app = express();
app.set('view engine', 'pug')

var MongoClient = require('mongodb').MongoClient;
//create a database named anything_db
var url= "mongodb://localhost:27017/pritam_db";

app.get('/', (req,res) => {
    MongoClient.connect(url, {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
        if(err) throw err;
        var dbo = dbcon.db("pritam_db");
       
        dbo.collection("employee_masters").find({}).toArray(function(err,result){  //{}-> shows condition
            if(err) throw err;
            res.render('index118',{records : result})
        dbcon.close();
        });   
    });
});
app.listen(3000, () => console.log('Server is runnig at 3000'));