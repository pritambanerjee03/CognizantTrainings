const events= require("events");
let emitter1= new events.EventEmitter();
emitter1.on(`start`,()=>{
    console.log(`started`);
});
emitter1.emit(`start`);