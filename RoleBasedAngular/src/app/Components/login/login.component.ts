import { Component } from '@angular/core';
import { UserDTOModel } from '../register/Models/UserDTO.model';
import { loginuserModel } from '../register/Models/Loginuser.model';
import { SignupService } from 'src/app/Services/signup.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {


  userDTO:UserDTOModel
  loggedInUser:loginuserModel
  

  constructor(private signupService : SignupService, private router : Router){
    this.userDTO=new UserDTOModel();
    this.loggedInUser=new loginuserModel

  }

 

  Login(){

    this.signupService.userLogin(this.userDTO).subscribe(data=>{
      
      this.loggedInUser = data as loginuserModel;
      console.log(this.loggedInUser);
      
      localStorage.setItem("token",this.loggedInUser.token);
      localStorage.setItem("UserID",this.loggedInUser.id);
      localStorage.setItem("role",this.loggedInUser.role);
      localStorage.setItem("login", new Date().toDateString());
      alert("Login Successful")
      this.router.navigateByUrl('homepage');
    },
    err=>{
      console.log(err)
      alert("Invalid Username/password")
    });
  }

  move(){
    this.router.navigateByUrl('register');
  }
}
