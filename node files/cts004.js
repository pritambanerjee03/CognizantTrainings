const array1=[];
 //variable hostile program where if we change var to let
 // it will cange the output also, it's called variable hostile
 for(let i=0;i<5;i++)
{
    array1.push(()=>{
        console.log(i);
    })
} 
for(const var1 of array1)
{
    var1();
}