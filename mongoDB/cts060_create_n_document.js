var MongoClient = require('mongodb').MongoClient;
//create a database named anything_db
var url= "mongodb://localhost:27017/pritam_db";

//var url = "mongodb+srv://pritam03:tukai1996@cluster0-v2k4n.mongodb.net/pritam_db"

MongoClient.connect(url, {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
    if(err) throw err;
    var dbo = dbcon.db("pritam_db");
    var record=[
      {code : "emp03", name:"Ram", designation:"VB Developer"},
        {code : "emp04", name:"Sham", designation:"PHP Developer"},
        {code : "emp05", name:"Jadhu", designation:"Node Developer"},
        {code : "emp06", name:"Madhu", designation:"JavaDeveloper"},
        {code : "emp07", name:"Vijay", designation:"Mean Developer"},
        {code : "emp08", name:"Jay", designation:"Jr. Developer"}
       /* {album_id:"a01", album_name:"album one", artist_name:"artist one"},
        {album_id:"a02", album_name:"album two", artist_name:"artist two"}*/

    ] ;
    dbo.collection("employee_masters").insertMany(record,function(err,res){
        if(err) throw err;
    console.log('No of documents Inserted '+res.insertedCount);
    dbcon.close();
    });
});