import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { registerModel } from '../Components/register/register.component';
import { UserDTOModel } from '../Components/register/Models/UserDTO.model';

@Injectable({
  providedIn: 'root'
})
export class SignupService {

  constructor(private httpClient:HttpClient)
  {

  }

  signup(register:registerModel){
      console.log("register in servive")
      return this.httpClient.post("https://localhost:7192/api/User/Register",register);
  }

  userLogin(userDTO:UserDTOModel){
      return this.httpClient.post("https://localhost:7192/api/User/Login",userDTO);
  }
}
