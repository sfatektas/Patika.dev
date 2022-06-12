import axios from 'axios';

 const getData = async(number) =>
{
    const {data} = await axios(`https://jsonplaceholder.typicode.com/users/${number}`)
    const {data:data2} = await axios ("https://jsonplaceholder.typicode.com/posts?userId="+number);
    
    var userInformation ={data , posts:data2}
    console.log(userInformation);

}


export default getData ; 