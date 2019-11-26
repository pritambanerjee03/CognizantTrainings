//create promise
var promise1 = new Promise(function(resolve,reject){
    //reject(`Failed`)
    setTimeout(()=>{
        resolve("Success")
    },2000)
})

//make use of promise 
promise1.then(function(result){ //resolve/fulfilling callback
    console.log(result)
}).catch(function(error1){      //reject/error callback
    console.log(error1)
})