const express = require('express');
const router = express.Router();
const bodyParser= require('body-parser')

var mongo_client = require('mongodb').MongoClient
var dbo;
var config = require('./../config/config')

router.use(bodyParser.urlencoded({extended: true}))
//router.use(bodyParser.json())

mongo_client.connect(config.mongodb_server, 
    {useNewUrlParser: true,useUnifiedTopology:true}, function(err,dbcon){
        console.log("DB cconnected");
    if(err) return console.log(err);
        dbo = dbcon.db(config.database_name);
});

router.get('/',(req,res)=>{
    console.log("Recived a HTTP GET request from a browser");
    var message1 = "Employee home page list of Employees"
 
    dbo.collection(config.table_name).find()
        .toArray((err,result)=>{
        if(err) return console.log(err)
        res.render('employee/employee_list' ,{message : message1, records :result})
    })  
})
router.get('/json',(req,res)=>{
    var record_set1 =[ { name : "Pritam", department: "Software"},
    { name : "Simran", department: "Hardware"},
    { name : "Subhra", department: "Electronics"} ]
    res.json(record_set1)
})

router.get('/employee_add_form',(req,res)=>{
   res.render('employee/employee_add')
})
     
 router.get('/edit_employee/:employee_id',(req,res)=>{

    let { employee_id } = req.params;
    var where = {_id: employee_id};
    dbo.collection(config.table_name).findOne(where,(err,result)=>{
        if(err) throw err;
        res.render('employee/employee_edit',{record: result})
    })
})

router.post('/insert_employees',(req,res)=>{
    console.log("Recived a HTTP POST request from a browser");
    var record = {_id: req.body.employee_id,
        code: req.body.employee_code,
        name: req.body.employee_name,
        designation: req.body.employee_designation};
    
    if((req.body.employee_id !="") && (req.body.employee_code != "") && (req.body.employee_name !=""))
    {
        dbo.collection(config.table_name).insertOne(record,function(err,dbcon){
            if(err) throw err;
        console.log("1 Document Created");
        res.redirect('/');
        });
    }
    else{
        res.redirect('/');
    }
 })

 router.post('/update_employee/:employee_id',(req,res)=>{

    let { employee_id } = req.params;
    var where = { _id: req.params.employee_id};
    var set_values = 
    { $set: { name: req.body.employee_name,
        code: req.body.employee_code,
        designation:req.body.employee_designation}};

    if(req.body.employee_name !="")
    {
        dbo.collection(config.table_name).updateOne(where,set_values,function(err,result){
            if(err) throw err;
        console.log("1 Document Updated");
        res.redirect('/');
        });
    }
    else{
        res.redirect('/');
    }
})

router.get('/delete_employee/:employee_id',(req,res)=>{

    let { employee_id } = req.params;
    var where = {_id: req.params.employee_id};

    dbo.collection(config.table_name).deleteOne(where,(err,result)=>{
        if(err) throw err;
        console.log("1 Document Deleted");
    })
    res.redirect('/')
})

router.get('/sort_employee_by_id',(req,res)=>{
    var message1 = "Employee home page list of Employees Sort by ID"
    var mysort = {_id: 1};
    dbo.collection(config.table_name).find().sort(mysort)
        .toArray((err,result)=>{
        if(err) return console.log(err)
        res.render('employee/employee_list' ,{message:message1, records :result})
    })  
})
router.get('/sort_employee_by_code',(req,res)=>{
    var message1 = "Employee home page list of Employees Sort by Code"
    var mysort = {code: 1};
    dbo.collection(config.table_name).find().sort(mysort)
        .toArray((err,result)=>{
        if(err) return console.log(err)
        res.render('employee/employee_list' ,{message:message1, records :result})
    })  
})
router.get('/sort_employee_by_name',(req,res)=>{
    var message1 = "Employee home page list of Employees Sort by Name"
    var mysort = {name: 1};
    dbo.collection(config.table_name).find().sort(mysort)
        .toArray((err,result)=>{
        if(err) return console.log(err)
        res.render('employee/employee_list' ,{message:message1, records :result})
    })  
})
router.get('/sort_employee_by_designation',(req,res)=>{
    var message1 = "Employee home page list of Employees Sort by Desigtnation"
    var mysort = {designation: 1};
    dbo.collection(config.table_name).find().sort(mysort)
        .toArray((err,result)=>{
        if(err) return console.log(err)
        res.render('employee/employee_list' ,{message:message1, records :result})
    })  
})
module.exports = router
