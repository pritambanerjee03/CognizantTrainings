const http= require('http')
const fs=require('fs')
const file_name='cts022.txt'
const new_text= '\nAdding Lines from Program\n Pritam Banerjee'

fs.appendFile(file_name,new_text,(err)=>{
    if(err) throw err
    //this program will append file if exist, Otherwise create  a new one
})