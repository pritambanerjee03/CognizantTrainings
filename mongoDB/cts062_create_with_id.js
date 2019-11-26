var MongoClient = require('mongodb').MongoClient;
//create a database named anything_db
var url= "mongodb://localhost:27017/pritam_db";

//var url = "mongodB server"

MongoClient.connect(url, {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
    if(err) throw err;
    var dbo = dbcon.db("pritam_db");
    var record=[
        {_id:"101", code : "emp15", name:"Ram", designation:"VB Developer"},
        {_id:"102", code : "emp16", name:"Sham", designation:"PHP Developer"},
        {_id:"103", code : "emp17", name:"Jadhu", designation:"Node Developer"},
        {_id:"104", code : "emp15", name:"Ram", designation:"VB Developer"},
        {_id:"105", code : "emp16", name:"Sham", designation:"PHP Developer"},
        {_id:"106", code : "emp17", name:"Jadhu", designation:"Node Developer"}
    ] ;
    dbo.collection("employee_masters").insertMany(record,function(err,result_obj){
        if(err) throw err;
    console.log(result_obj);
    dbcon.close();
    process.exit();
    });
});