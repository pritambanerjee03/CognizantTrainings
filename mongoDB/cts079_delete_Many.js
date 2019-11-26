var MongoClient = require('mongodb').MongoClient;
//create a database named anything_db

var url= "mongodb://localhost:27017/pritam_db";

//var url = "mongodB server"

MongoClient.connect(url, {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
    if(err) throw err;
    var dbo = dbcon.db("pritam_db");
   
    var where = {name : "Sham", designation: /Developer$/};

    //dbo.collection("employee_masters").deleteMany(where,function(err,result){ 

    dbo.collection("employee_masters").find(where).toArray(function(err,result){  
        if(err) throw err;
    //console.log("1 document deleted");
    console.log(result);
    dbcon.close();
    process.exit();
    });
});

//delete Many with given condition 
//if multiple data is present it will delete all the records