var MongoClient = require('mongodb').MongoClient;
//create a database named anything_db
var url= "mongodb://localhost:27017/pritam_db";

//var url = "mongodB server"

MongoClient.connect(url, {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
        if(err) throw err;
    console.log("Database created, but mongo DB will actually create the Database once we create a collection")
    dbcon.close();
});
