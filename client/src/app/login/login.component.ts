import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { UserService } from '../user.service';
import { ActivatedRoute, Router } from '@angular/router';
import { User } from 'src/models/User';
import { HttpResponse, HttpStatusCode } from '@angular/common/http';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  name: string;
  Password: string;
  user: User = new User("", "", "", "", "");
  login() {
    this.user.userName = this.name;
    this.user.userPassword = this.Password;

    this.userSer.Login(this.user).subscribe(s => {
      // alert(JSON.stringify(s))
      // alert()
      this.userSer.setCurrentUser(s);
      alert(" you are in!!");
      this.router.navigate(['allRecipes']);
    },
      e => {
        // alert(e.status)
        if (e.status == 409) {
          alert("The password is incorrect. Please try again.")
          this.Password = "";
        }
        else {
          alert("User does not exist. Please register.")
          if (this.user.userName == undefined)
            this.router.navigate(['register'])
          else
            this.router.navigate(['register', this.user])
        }
      }
    )
  }

  constructor(
    public userSer: UserService, public router: Router, public myActive: ActivatedRoute) {
    this.myActive.params.subscribe((pa => {
      this.name = pa.userName;
    }))
  }

  ngOnInit(): void {
  }

}
