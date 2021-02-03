import axios,{AxiosResponse} from 'axios';
import { IClient } from '../../Models/Client';

axios.defaults.baseURL="http://localhost:5000/api";

const responseBody=(response:AxiosResponse)=>response.data;

const requests={
    get:(url:string)=>axios.get(url).then(responseBody),
    post:(url:string,body:{} | null)=>axios.post(url,body).then(responseBody),
    put:(url:string,body:{})=>axios.put(url,body).then(responseBody),
    del:(url:string)=>axios.delete(url).then(responseBody)
}

const Clients={
    list:():Promise<IClient[]>=>requests.get('/client'),
    details:(id:string)=>requests.get(`/client/${id}`),
    create:(client:IClient | null)=>requests.post('/client',client)
}

export default{
    Clients
}