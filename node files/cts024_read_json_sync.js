const fs=require('fs')
function function1(){
    var data = fs.readFileSync('cts022.txt')
       
        console.log(data.toString())
   
}
console.log(`one..\n`)
function1()
console.log(`\n..Two`)                                                                      