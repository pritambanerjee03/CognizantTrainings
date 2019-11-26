var MongoClient = require('mongodb').MongoClient;
var ObjectId = require('mongodb').ObjectID;
//create a database named anything_db
var url= "mongodb://localhost:27017/pritam_db";

//var url = "mongodB server"

MongoClient.connect(url, {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
    if(err) throw err;
    var dbo = dbcon.db("pritam_db");
   
    var ids = [ "5d5b9a81bfeeae13607965ba" ,"5d5ccd3e221eeb12005b0243"];

    var obj_ids= ids.map(function(id) { return ObjectId(id); } );

    let where = { _id : {$in :obj_ids} }; 

    dbo.collection("employee_masters").find(where).toArray(function(err,result){  
        if(err) throw err;
         console.log(result);
    dbcon.close();
    process.exit();
    });
});