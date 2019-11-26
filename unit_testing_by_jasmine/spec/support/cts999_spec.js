var prog= require("../cts999");
describe("Test case 1.Testing get_reult(-10)",function(){ //false statements under " "
    it("should return 'Less than 0 is not possible!",function(){  //false statements under " "
    var result=prog.get_result(-60);
    expect(result).toBe("Less than 0 is not possible!");
    var result=prog.get_result(110);
    expect(result).toBe("Greater than 100 is not possible");
    var result=prog.get_result(40);
    expect(result).toBe("Pass");
    var result=prog.get_result(20);
    expect(result).toBe("Fail");
    var result=prog.get_result(10);
    expect(result).toBe("Fail");
    var result=prog.get_result(210);
    expect(result).toBe("Greater than 100 is not possible");
    var result=prog.get_result(80);
    expect(result).toBe("Pass");
    var result=prog.get_result(-30);
    expect(result).toBe("Less than 0 is not possible!");
});
});
