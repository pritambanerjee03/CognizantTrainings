var MongoClient = require('mongodb').MongoClient;
//create a database named anything_db
var url= "mongodb://localhost:27017/pritam_db";

//var url = "mongodB server"

MongoClient.connect(url, {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
    if(err) throw err;
    var dbo = dbcon.db("pritam_db");
   
    //{} -> select * from employee_master limit 1 // without any conditions
    dbo.collection("employee_masters").findOne({_id: "102"},function(err,result){  //{}-> shows condition
        if(err) throw err;
        if(result == null)
        {
            console.log("Record Not Found"); 
        }else{
            console.log(result);
            console.log("..........................\n" + result.name);
        }
    
    dbcon.close();
    process.exit();
    });
});