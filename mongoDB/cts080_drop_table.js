var MongoClient = require('mongodb').MongoClient;
//create a database named anything_db
var url= "mongodb://localhost:27017/pritam_db";

//var url = "mongodB server"

MongoClient.connect(url, {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
    if(err) throw err;
    var dbo = dbcon.db("pritam_db");
   
    var table_name= "employee_masters2";
    
    dbo.collection(table_name).drop(function(err,dropped){  //delete the colletion of employee_master2
        if(err) throw err;
        if(dropped)
        {
            console.log(table_name+" Collection Deleted"); 
        }else{
            console.log(table_name+" Collection Not Deleted"); 
        }
    
    dbcon.close();
    process.exit();
    });
});