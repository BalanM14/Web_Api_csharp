import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent {
  flag:boolean = false;
  constructor()
  {
    if (localStorage.getItem("role")=="Admin")
    {
      this.flag=true;
    }
  }
}
