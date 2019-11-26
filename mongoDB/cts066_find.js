var MongoClient = require('mongodb').MongoClient;
//create a database named anything_db
var url= "mongodb://localhost:27017/pritam_db";

//var url = "mongodB server"

MongoClient.connect(url, {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
    if(err) throw err;
    var dbo = dbcon.db("pritam_db");
   
    //{} -> select * from employee_master  // without any conditions
    dbo.collection("employee_masters").find({}).toArray(function(err,result){  //{}-> shows condition
        if(err) throw err;
         console.log(result);
         res.send(result);
    dbcon.close();
    process.exit();
    });
});