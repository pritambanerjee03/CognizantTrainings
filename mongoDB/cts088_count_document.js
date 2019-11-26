var MongoClient = require('mongodb').MongoClient;
// Create a database names "sample_db"
var url = "mongodb://localhost:27017/pritam_db";


MongoClient.connect(url,{useNewUrlParser:true,useUnifiedTopology:true},function(err,dbcon){
    if(err) throw err;
    var dbo=dbcon.db("pritam_db");
    
    dbo.collection("employee_masters").countDocuments({},function(err,noOfDocs){
        if(err) throw err;
        console.log("no of records:"+noOfDocs);
    });
    dbo.collection("employee_masters").estimatedDocumentCount({},function(err,noOfDocs){
        if(err) throw err;
        console.log("no of records:"+noOfDocs);
        dbcon.close();
        process.exit();
    });
});