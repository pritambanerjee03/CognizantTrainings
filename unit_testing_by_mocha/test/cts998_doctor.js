var expect = require('chai').expect
var dr= require('../app/cts998_doctor') //testable code

describe("To check the BP",function(){ //false statements under " "
    it("To check the BP is Normal",function(){  //false statements under " "
    let _result=dr.getBP(100,70);
    expect(_result).to.equal("normal");
    })
    
    it("To check the BP is Abnormal",function(){  //false statements under " "
    let _result=dr.getBP(130,90);
    expect(_result).to.equal("abnormal");
    })
})

