const express = require('express');
const app = express();

const routers_employee =require('./routers/employee')

var config = require('./config/config')




app.set('view engine', config.view_engine)

app.use('/', routers_employee)

app.use('/images', express.static(__dirname + '/assets/images'))

app.set('port_no',config.port_no)
app.listen(app.get('port_no'), () => {

    console.log(`Server is runnig at port ${app.get('port_no')}`)
});
