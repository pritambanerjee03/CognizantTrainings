const fs=require('fs')
const old_file_name='cts030.txt'
const new_file_name='cts030new.txt'

fs.rename(old_file_name,new_file_name,(err)=>{
    if(err) throw err
    console.log(`File Renamed`)
})