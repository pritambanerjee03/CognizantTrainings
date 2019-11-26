const http= require('http')
const fs=require('fs')

http.createServer((req,res)=>{
    fs.readFile('cts005.html',(err,data)=>{
        if(err)
        {
            console.log(err)
            return
        }
       
        res.writeHead(200,{'Content-Type':'text/html'})  
        res.write(data) 
        res.end()
    })
}).listen(3000,()=>{
    console.log(`server is running`)
})