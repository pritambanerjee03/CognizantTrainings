function sleep(milli_seconds){
    return new Promise(resolve=> setTimeout(resolve,milli_seconds))
}

async function run1()
{
    console.log("One")
    await sleep(2000)         //wait two seconds
    console.log("Two")
}
run1() //print one and wait for 2 seconds to print two