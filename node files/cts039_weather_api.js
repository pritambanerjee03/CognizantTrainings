const http= require('http')
const request = require('request')
http.createSrever(function(req,res){
    var loc = 'Chennai.in'
    request(``), 
    {json:true}, //application/json content type header
    (err,resp,body)=>{
        if(!err)
        res.end(template(body))
    } 
})

 