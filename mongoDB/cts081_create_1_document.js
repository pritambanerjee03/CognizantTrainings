var MongoClient = require('mongodb').MongoClient;
//create a database named anything_db
var url= "mongodb://localhost:27017/pritam_db";

//var url = "mongodb+srv://pritam03:tukai1996@cluster0-v2k4n.mongodb.net/pritam_db"

MongoClient.connect(url, {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
    if(err) throw err;
    var dbo = dbcon.db("pritam_db");

    var record={ _id: "emp119", name:"Roja", 
                dogs:["Blacky", "Puppy"] };

    dbo.collection("employee_masters").insertOne(record,function(err,result){
        if(err) throw err;
    console.log("1 Record Created");
    console.log(record);
    dbcon.close();
    });
});