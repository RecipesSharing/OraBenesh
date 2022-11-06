import { Component, OnDestroy, OnInit } from '@angular/core';
import { UserService } from './user.service';
import { Subscription } from 'rxjs';
import { Router } from '@angular/router';
import { User } from 'src/models/User';
import Swal from 'sweetalert2/dist/sweetalert2.js';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit, OnDestroy {
  sub: Subscription;
  user;
  title = 'project';
  login() {
    this.router.navigate(['/login']);
  }
  register() {
    this.router.navigate(['/register']);
  }
  allRecipes() {
    this.router.navigate(['/allRecipes']);
  }
  addRecipe() {
    if (this.user) this.router.navigate(['/addRecipe']);
    else {
      alert('To add a recipe, log in');
      this.router.navigate(['/login']);
    }
  }
  logout() {
    Swal.fire({
      title: 'Are you sure you want to log out?',
      text: 'You will not be able to add new recipe!',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonText: 'Yes, log out!',
      cancelButtonText: 'No, keep me in',
    }).then((result) => {
      if (result.value) {
        localStorage.removeItem('currentUser');
        this.usser.setCurrentUser(null);
        // this.sub.unsubscribe();

        Swal.fire('you are out!', '', 'success');
      } else if (result.dismiss === Swal.DismissReason.cancel) {
        Swal.fire('Cancelled', '', 'error');
      }
    });

    // this.usser.currentUser.unsubscribe();
  }

  constructor(private usser: UserService, public router: Router) {}
  ngOnInit(): void {
    // this.sub = this.usser.currentUser.subscribe(s => {this.user=s});
    this.usser.updateCurrentUser.subscribe((s) => {
      this.user = s as User;
      console.log('updatecurrentuser: ' + JSON.stringify(this.user));
    });
  }
  ngOnDestroy(): void {
    localStorage.removeItem('currentUser');
    this.usser.setCurrentUser(null);
    // this.sub.unsubscribe();
  }
}
