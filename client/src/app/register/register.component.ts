import { Component, OnInit } from '@angular/core';
import { UserService } from '../user.service';
import { Router, ActivatedRoute } from '@angular/router';
import { User } from 'src/models/User';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  user: User = new User("", "", "", "", "");
  register() {
    this.userSer.Register(this.user).subscribe(s => {
      this.userSer.setCurrentUser(s);
      alert(" you are in!");
      this.router.navigate(['/allRecipes']);

    },
      e => {
        alert("existing user");
        console.log("error!");
        if (this.user.userName == undefined)
        this.router.navigate(['login'])
      else
        this.router.navigate(['login', this.user])

      }
    )
  }

  constructor(public userSer: UserService, public router: Router, public myActive: ActivatedRoute) {
    this.myActive.params.subscribe((pa => {
      this.user.userName = pa.userName;
    }));
    this.userSer.GetAllUsers().subscribe(s => {
      this.user.userCode = (String)(s.length + 1);
    })

  }

  ngOnInit(): void {
  }
}
