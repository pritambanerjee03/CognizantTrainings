const fs=require('fs')
const file_name='cts030.txt'


fs.open(file_name,'w',(err,fp)=>{
    if(err) throw err
    console.log(`saved`)
})