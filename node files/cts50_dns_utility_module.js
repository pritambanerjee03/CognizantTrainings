let dns=require('dns');
dns.lookup('www.google.co.in',function onLookup(err,address,family){
    console.log('address:',address);
    dns.reverse(address,function(err,hostname){
        if(err){
            console.log(err.stack);
        }
        console.log('reverse for'+address+':'+JSON.stringify(hostname));
    });
});