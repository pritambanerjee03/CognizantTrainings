const url=require('url')
const sample_url='http://localhost:3000/index.html?year=2017&month=Feb'

const parsed_obj=url.parse(sample_url,true)
console.log('Smaple URL: '+sample_url)
console.log('Host: '+parsed_obj.host)
console.log('Path name/File name: '+parsed_obj.pathname)
console.log('Search/Parameters: '+parsed_obj.search)