import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Recipe } from 'src/models/Recipe';
import { JsonPipe } from '@angular/common';
import { Category } from 'src/models/Category';
import { CategoryService } from '../category.service';
import { RecipeService } from '../recipe.service';
import { User } from 'src/models/User';
import { UserService } from '../user.service';
import { Subscription } from 'rxjs';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-recipe-details',
  templateUrl: './recipe-details.component.html',
  styleUrls: ['./recipe-details.component.css'],
})
export class RecipeDetailsComponent implements OnInit {
  user = new User('', '', '', '', '');
  cat: Category = new Category('', '', '');
  recipe: Recipe = new Recipe('', '', '', 0, 0, null, [''], [''], '', '');
  myImg: string;
  level: string;
  arrIngredients: string[];
  arrPreparations: string[];
  constructor(
    public myActive: ActivatedRoute,
    public catSer: CategoryService,
    public recSer: RecipeService,
    public userSer: UserService,
    public router: Router
  ) {
    this.user = JSON.parse(localStorage.getItem('currentUser'));
    this.userSer.updateCurrentUser.subscribe((s) => (this.user = s as User));
    console.log('usersub: ' + JSON.stringify(this.user));
    console.log(this.recipe);
    this.myActive.params.subscribe((pa) => {
      this.recipe = pa as Recipe;
      console.log('imagee :', this.recipe.recipeImage);
      this.arrIngredients = this.recipe.recipeIngredientsList
        .toString()
        .split(',');
      this.arrPreparations = this.recipe.recipePreparation
        .toString()
        .split(',');

      console.log('this.recipe.recipeIngredientsList ' + this.arrPreparations);
    });
    this.catSer.GetCategoryByCode(this.recipe.categoryCode).subscribe(
      (s) => {
        this.cat = s;
        // alert("cat" + JSON.stringify(this.cat))
      },
      (e) => {
        console.log('error');
      }
    );
    // this.myImg = this.recipe.recipeImage;
    this.myImg = '../../assets/images/' + this.recipe.recipeImage;
    this.level = '👨🏻‍🍳'.repeat(this.recipe.level);
    // this.level += "👨🏻‍🍳".repeat(5 - this.recipe.level);
    console.log('user: ' + JSON.stringify(this.user));
  }
  delelteRecipe() {
    // this.recSer.DeleteRecipe(this.recipe.recipeCode).subscribe(s => {

    //   alert("deleted");
    //   this.router.navigate(['allRecipes']);
    // })

    Swal.fire({
      title: 'Are you sure want to delete it?',
      text: 'You will not be able to restore it !',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonText: 'Yes, delete recipe!',
      cancelButtonText: 'No, keep it',
    }).then((result) => {
      if (result.value) {
        this.recSer.DeleteRecipe(this.recipe.recipeCode).subscribe((s) => {
          Swal.fire('deleted', '', 'success');
          this.router.navigate(['allRecipes']);
        });
      } else if (result.dismiss === Swal.DismissReason.cancel) {
        Swal.fire('Cancelled', '', 'error');
      }
    });
  }
  sub: Subscription;
  ngOnInit(): void {}
}
