const args=process.argv.slice(2)
args.forEach((value,index)=>{
    console.log(`${index}.${value}`)
}) 
console.log(args[0],args[1],args[2],args[3])
// IN command line type 1 2 3 omr thats all 