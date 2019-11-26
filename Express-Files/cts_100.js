var MongoClient = require('mongodb').MongoClient;

var express = require('express');
var url = 'mongodb://localhost:27017/pritam_db';
var app=express();
var str="";
app.route('/name').get(function(req,res) 
{

    MongoClient.connect(url,function(err,dbo){
        var db=dbo.db('pritam_db')
        var cursor=db.collection('employee_masters').find();
        cursor.each(function(err,item){
            if(item!=null){
                
                str =str+"  "+item.code+"  "+item.name+"  "+item.designation+"</br>"
            }})
        res.send(str)
    })
})
app.listen(3000, () => console.log('Server is runnig at 3000'));