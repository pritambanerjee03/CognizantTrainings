const fs=require('fs')
fs.readFile('cts023.json',(err,data)=>{
    if(err)
    {
        console.log(err)
        return
    }
    //console.log(data.toString())
    let json1=JSON.parse(data)
    console.log(json1[0].name+" "+json1[2].place)
   
})                                                                      