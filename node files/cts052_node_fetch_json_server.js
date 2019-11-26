const fetch=require('node-fetch');
async function getGithubData() {
    let data= await fetch('http://localhost:3000/employees');
    let json_obj= await data.json();
   // console.log(json_obj);

    json_obj.forEach(obj => {
        console.log(`Id : `+obj.id);
        console.log(`Name : `+obj.name);
        console.log(`Company : `+obj.company);
        console.log(`Place : `+obj.place);
        console.log(`-----------------------------------------`);
    })
}
getGithubData();
    