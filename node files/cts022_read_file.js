const fs=require('fs')
fs.readFile('cts022.txt',(err,data)=>{
    if(err)
    {
        console.log(err)
        return
    }
    console.log(data.toString())
   
})