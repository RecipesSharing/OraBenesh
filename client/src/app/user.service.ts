import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { User } from 'src/models/User';



@Injectable({
  providedIn: 'root'
})
export class UserService {
  updateCurrentUser = new Subject();

  baseUrl = "https://localhost:44350/api/User";
  // user: User;

  Login(user: User) {
    return this.http.post<User>(`${this.baseUrl}/Login`, user);
    // if (this.u)s
    //   this.setCurrentUser(this.u);
    // return this.u;
  }

  GetAllUsers() {
    return this.http.get<User[]>(`${this.baseUrl}/GetAllUsers`);
  }
  Register(newUser: User) {
    return this.http.post<User>(`${this.baseUrl}/Register`, newUser);
    // if (this.u)
    //   this.setCurrentUser(this.u);
    // return this.u;
  }
  setCurrentUser(user: User) {
    localStorage.setItem("currentUser", JSON.stringify(user));
    this.updateCurrentUser.next(user);
    // this.user=user;
  }
  // getCurrentUser() {
  //   localStorage.getItem("currentUser");
  // }


  constructor(public http: HttpClient) { }
}
