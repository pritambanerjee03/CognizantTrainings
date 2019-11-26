const fs=require('fs')
const file_name='cts030.txt'


fs.unlink(file_name,(err)=>{
    if(err) throw err
    console.log(`File Deleted`)
})