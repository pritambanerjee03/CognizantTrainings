var array1=[];
array1.push(function(){
    console.log(`Hello World 1`);
})
array1.push(function(){
    console.log(`Hello World 2`);
})
array1.push(function(){
    console.log(`Hello World 3`);
})
array1.forEach(function(item){
    item()
})