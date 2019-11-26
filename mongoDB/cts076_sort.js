var MongoClient = require('mongodb').MongoClient;
//create a database named anything_db
var url= "mongodb://localhost:27017/pritam_db";

//var url = "mongodB server"

MongoClient.connect(url, {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
    if(err) throw err;
    var dbo = dbcon.db("pritam_db");
   
    //sort the result by designation
    var sort_by = {designation : 1}; 
    dbo.collection("employee_masters")
    .find({code : /emp03/ })
    .sort(sort_by)
    .toArray(function(err,result){  
        if(err) throw err;
         console.log(result);
    dbcon.close();
    process.exit();
    });
});