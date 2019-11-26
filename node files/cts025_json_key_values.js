let json_obj=[{
    "name":"Pritam",
    "place":"KOLAKATA"
},
{
    "name":"Simran",
    "place":"Aurangabad"
},
{
    "name":"Anirban",
    "place":"Dhanbad"
}]
json_obj.forEach((value1,key1)=>{
    let keys=Object.keys(value1)
    console.log(`Object ${key1}`)
    keys.forEach((value2,key2)=>{
        console.log(`${value2}:${value1[value2]}`)
    })
    console.log()
})