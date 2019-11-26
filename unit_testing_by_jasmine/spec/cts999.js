module.exports.get_result =function(mark){
    if(mark <0){
        return "Less than 0 is not possible!"
    } else if(mark >100){
        return "Greater than 100 is not possible"
    }else if(mark >34){
        return "Pass"
    }else if(mark <35){
        return "Fail"
    }else{
        return "it is not a number"
    }
};