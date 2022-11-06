import { Component, OnInit } from '@angular/core';
import { Category } from 'src/models/Category';
import { Recipe } from 'src/models/Recipe';
import { CategoryService } from '../category.service';
import { RecipeService } from '../recipe.service';
import { UserService } from '../user.service';
import { User } from 'src/models/User';
import { Router } from '@angular/router';
import Swal from 'sweetalert2/dist/sweetalert2.js';


@Component({
  selector: 'app-add-recipe',
  templateUrl: './add-recipe.component.html',
  styleUrls: ['./add-recipe.component.css']
})
export class AddRecipeComponent implements OnInit {
  user: User = new User("", "", "", "", "");
  constructor(public recser: RecipeService, public catser: CategoryService, public userSer: UserService, public router: Router) {
    this.user = JSON.parse(localStorage.getItem("currentUser"))
    this.newRecipe.recipeUserCode = this.user.userCode;
    console.log("categoryArr " + this.categoryArr + " " + this.recipePreparation)
  }
  levels: number[] = [1, 2, 3, 4, 5];

  newRecipe: Recipe = new Recipe("0", "", "1111", 0, 1, new Date(), [""], [""], "0", "../../assets/images/1.JPG");
  categoryArr: Category[];
  recipeIngredientsList: string[] = [""];
  recipePreparation: object[] = [{ pre: "" }];
  recipeIngredient: object[] = [{ ing: "" }];
  imagesArr: object[] = [
    { src:"e.jpg",name:"cake"},
    { src:"1.JPG",name:"dessert;"},
    { src:"i.jpg",name:"salad"},
    { src:"m.jpg",name:"soup"},
    { src:"n.jpg",name:"special course"},
    { src:"ice.jpg",name:"sweets"},
    { src:"g.jpg",name:"pasrties"}
   ];

  addIngredient() {
    this.recipeIngredient = this.recipeIngredient.filter(i => i['ing'] != "");
    this.recipeIngredient.push({ ing: "" });

  }
  addprepartion() {
    this.recipePreparation = this.recipePreparation.filter(i => i['pre'] != "");
    this.recipePreparation.push({ pre: "" });
  }

  addRecipe() {
    this.newRecipe.recipeIngredientsList = this.recipeIngredient.map(i => i = i['ing']).filter(i => i != "");
    this.newRecipe.recipePreparation = this.recipePreparation.map(p => p = p['pre']).filter(i => i != "");
    console.log("recipePreparation from new " + this.newRecipe.recipePreparation)

    this.recser.AddRecipe(this.newRecipe).subscribe(
      s => {
        console.log("new recipe::" + JSON.stringify(this.newRecipe));
        Swal.fire('Added successfully...', 'Thank you for sharing your recipe with us!', 'success')
        this.router.navigate(['allRecipes'])
      }
    )
  }

  // chooseImage(event) {    console.log("add recipe bef : "+JSON.stringify(this.newRecipe))

  //   let file = event.target.files[0];

  //   let reader = new FileReader();
  //   reader.readAsDataURL(file);
  //   reader.onload = () => {
  //     this.newRecipe.recipeImage = reader.result as string;
  //     console.log("choose image success: ",this.newRecipe.recipeImage)
  //   };
  //   reader.onerror = (error) => {
  //     console.log("Error ", error);
  //   };
  //   console.log("add recipe "+JSON.stringify(this.newRecipe))

  // }

  ngOnInit(): void {
    this.recser.GetAllRecipes().subscribe(s => {
      this.newRecipe.recipeCode = (String)(s.length + 1);
    })

    this.catser.GetAllCategories().subscribe(s => {
      this.categoryArr = s;
      // s.forEach(element => {
      //   this.categoryArr[this.i++]=element.categoryCode;
      // this.categoryArr = s;
    }
    )
    this.userSer.updateCurrentUser.subscribe(s => {
      this.user = s as User;
    })
  }
}
