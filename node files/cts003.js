const one = function()
{
    console.log(`One`);
}
const two = ()=>
{
    console.log(`Two`);
}
const three = ()=> console.log(`Three
`);

const zero=() =>{
    console.log(`Zero`);
    one();
    setTimeout(two,2000);
    three(); 
}
zero();