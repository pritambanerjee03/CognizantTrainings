const http = require("http");
const hostname = "localhost";
const port = 3000;
const server = http.createServer((req,res)=>
{
    
    res.end(" hello world");

    for(let i=0;i<5;i++)
    {
        console.log(i);
        if(i==4)
        process.exit();
    }
});

server.listen(port,hostname,()=>{
    console.log(`Server is running at http://${hostname}:${port}`); 
});