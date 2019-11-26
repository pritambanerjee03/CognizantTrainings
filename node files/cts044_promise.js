const one = function()
{
    console.log(`One`);
}
const two = ()=>
{
    console.log(`Two`);
}
const three = ()=> console.log(`Three`);

const zero=() =>{
    console.log(`Zero`);
    one();
    setTimeout(two,2000);
    new Promise((resolve,reject)=>
        resolve(`should be right after three and before two`)
    ).then(resolve => console.log(resolve))
    three(); 
}
zero();