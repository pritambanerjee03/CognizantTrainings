const fetch=require('node-fetch');
async function getGithubData() {
    let data= await fetch('https://api.github.com/users/KrunalLathiya');
    let json_obj= await data.json();
    console.log("Id : " +json_obj.id+ "\n");
    console.log(json_obj);
}
getGithubData();