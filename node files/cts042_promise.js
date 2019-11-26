function sleep(milli_seconds){
    return new Promise(resolve=> setTimeout(resolve,milli_seconds))
}

function run1()
{
    console.log("One")
    sleep(2000)         //wait two seconds
    console.log("Two")
}
run1() 