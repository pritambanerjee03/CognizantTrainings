var MongoClient = require('mongodb').MongoClient;
//create a database named anything_db
var url= "mongodb://localhost:27017/pritam_db";

//var url = "mongodb+srv://pritam03:tukai1996@cluster0-v2k4n.mongodb.net/pritam_db"

MongoClient.connect(url, {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
    if(err) throw err;
    var dbo = dbcon.db("pritam_db");
   
    //Table structure (_id, code, name, designation)
    dbo.collection("employee_masters").find(
        {name:"Sham", designation:"PHP Developer"},
        {projection: {_id:0, code:1, name:1, designation:1 }}) //select All columns 1 means show 0 means not show
        .toArray(function(err,result){  //{}-> shows condition
        if(err) throw err;
         console.log(result);
    dbcon.close();
    process.exit();
    });
});