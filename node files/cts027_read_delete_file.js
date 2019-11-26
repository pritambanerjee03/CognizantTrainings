const fs=require('fs')
fs.readFile('cts022.txt',(err,data)=>{
    if(err)
    {
        console.log(err)
        return
    }
    console.log(data.toString())
    fs.unlink('cts022.txt',(err)=>{     //delete a file
        if(err)
        {
            console.log(`err`)  
        }
    }) 

})
