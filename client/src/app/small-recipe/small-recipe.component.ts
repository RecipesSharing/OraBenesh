import { Component, Input, OnInit } from '@angular/core';
import { Recipe } from 'src/models/Recipe';
import { isTemplateExpression } from 'typescript';
import { Router } from '@angular/router';

@Component({
  selector: 'app-small-recipe',
  templateUrl: './small-recipe.component.html',
  styleUrls: ['./small-recipe.component.css']
})
export class SmallRecipeComponent implements OnInit {
  @Input()
  item: Recipe;
  myImg: string;
  level: string;
  // preparations:any[]=[{p:1,oiuh:""},2,3];
  constructor(public router: Router) {
    console.log("details")
  }
  setLevel() {
    this.level = "👨🏻‍🍳".repeat(this.item.level);
    // this.level += "👨🏻‍🍳".repeat(5 - this.item.level);
  }
  recipeDetails() {
    // console.log("preee " + this.preparations)
    // for (let index = 0; index < this.item.recipePreparation.length; index++) {
      // this.preparations[index]=this.item.recipePreparation[index];
    // }
    // console.log("preee " + this.preparations)

    this.router.navigate(['recipeDetails', this.item])
  }

  ngOnInit(): void {
    console.log("imgg " + this.item.recipeImage);
    console.log("recipe from small " + this.item.recipePreparation);
    // this.myImg = this.item.recipeImage;
    this.myImg = "../../assets/images/" + this.item.recipeImage;
  }

}
