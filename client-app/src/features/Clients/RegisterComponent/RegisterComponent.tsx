import React from 'react'
import { useState } from 'react';
import { IClient } from '../../../Models/Client';
import './RegisterComponent.css'

interface IProps{
    createAClient:(client:IClient | null)=>void;
    client:IClient | null;
}

export const RegisterComponent:React.FC<IProps> = ({client,createAClient}) => {
    const initializeForm=()=>{
        if(client){
            return client
        }else{
            return{
                id:'',
                name:'',
                surname:'',
                email:'',
                password:''
            }
        }
    };
    
    const [client,setClient]=useState<IClient>(initializeForm);

    const changeClientName=(event:any)=>{
        setClient({...client,name:event.target.value});
    }
    
    return (
        <div>
            <br/>
            <div className="container">

            <div className="card bg-light">
                <article className="card-body mx-auto">
	            <h4 className="card-title mt-3 text-center">Create Account</h4>
                <p className="text-center">Get started with your free account</p>
                <p>
                    <a href="" className="btn btn-block btn-twitter"> <i className="fab fa-twitter"></i>   Login via Twitter</a>
                    <a href="" className="btn btn-block btn-facebook"> <i className="fab fa-facebook-f"></i>   Login via facebook</a>
                </p>
                <p className="divider-text">
                    <span className="bg-light">OR</span>
                </p>
	        
                <div className="form-group input-group">
                    <div className="input-group-prepend">
                        <span className="input-group-text"> <i className="fa fa-user"></i> </span>
                    </div>
                    <input 
                           onChange={changeClientName}
                           value={client?.name} 
                           className="form-control"
                           placeholder="Full name"
                           type="text"/>
                </div> 

                <div className="form-group input-group">
                    <div className="input-group-prepend">
                        <span className="input-group-text"> <i className="fa fa-envelope"></i> </span>
                    </div>
                    <input value={client?.email} className="form-control" placeholder="Email address" type="email"/>
                </div>
                {/* <div className="form-group input-group">
                    <div className="input-group-prepend">
                        <span className="input-group-text"> <i className="fa fa-building"></i> </span>
                    </div>
                    <select className="form-control">
                        <option>Consulting category</option>
                    </select>
                </div> */}
                <div className="form-group input-group">
                    <div className="input-group-prepend">
                        <span className="input-group-text"> <i className="fa fa-lock"></i> </span>
                    </div>
                    <input value={client?.password} className="form-control" placeholder="Create password" type="password"/>
                </div> 

                <div className="form-group input-group">
                    <div className="input-group-prepend">
                        <span className="input-group-text"> <i className="fa fa-lock"></i> </span>
                    </div>
                    <input className="form-control" placeholder="Repeat password" type="password"/>
                </div>       
                
                <div className="form-group">
                    <button 
                        type="submit"
                        className="btn btn-primary btn-block"
                        onClick={()=>createAClient(client)}
                    > Create Account</button>
                </div>

                <p className="text-center">Have an account? <a href="">Log In</a> </p>                                                                  
                </article>
            </div>
        </div> 
    </div>
    )
}
