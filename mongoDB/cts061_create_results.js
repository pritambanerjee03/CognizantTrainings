var MongoClient = require('mongodb').MongoClient;
//create a database named anything_db
var url= "mongodb://localhost:27017/pritam_db";

//var url = "mongodB server"

MongoClient.connect(url, {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
    if(err) throw err;
    var dbo = dbcon.db("pritam_db");
    var record=[
        {code : "emp15", name:"Ram", designation:"VB Developer"},
        {code : "emp16", name:"Sham", designation:"PHP Developer"},
        {code : "emp17", name:"Jadhu", designation:"Node Developer"},
    ] ;
    dbo.collection("employee_masters").insertMany(record,function(err,result_obj){
        if(err) throw err;
    console.log(result_obj);
    dbcon.close();
    });
});