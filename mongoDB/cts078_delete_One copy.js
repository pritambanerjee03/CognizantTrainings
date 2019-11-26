var MongoClient = require('mongodb').MongoClient;
//create a database named anything_db

var url= "mongodb://localhost:27017/pritam_db";

//var url = "mongodB server"

MongoClient.connect(url, {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
    if(err) throw err;
    var dbo = dbcon.db("pritam_db");
   
    var where = {code : "emp07"};

    //dbo.collection("employee_masters").deleteOne(where,function(err,result){ 

    dbo.collection("employee_masters").find(where).toArray(function(err,result){  
        if(err) throw err;
    //console.log("1 document deleted");
    console.log(result);
    dbcon.close();
    process.exit();
    });
});

//delete only one with given condition 
//if multiple data is present it will delete the first inserted record