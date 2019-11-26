const asks_property_owner=(msg)=>{
    console.log("agent2 asks property owner:"+msg);
    return new Promise(resolve=>{
        setTimeout(()=>resolve('property owner was thinking for 3 second/days and replied, i am ready to sell my plot'),3000);
    });
}

const asks_agent2=async(msg)=>{
    console.log('agent1 asks agent2:'+msg);
    const reply_from_property_owner=await asks_property_owner(msg);
    console.log(reply_from_property_owner);
    return 'agent2 replied agent1: owner is ready to sell so i can arrange it';
}

const asks_agent1=async (msg)=>{
    console.log('a buyer asks agent1:' +msg);
    const reply_from_agent2= await  asks_agent2(msg);
    console.log(reply_from_agent2);
    return 'agent1 replied buyer:owner is ready to sell so when you will purchase it';
}

asks_agent1('is the the plot is availble for sale?').then((res)=>{
    console.log(res);
})