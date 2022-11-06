import { Component, OnInit } from '@angular/core';
import { UserService } from '../user.service';
import { Recipe } from 'src/models/Recipe';
import { RecipeService } from '../recipe.service';
import { Router } from '@angular/router';
import { Category } from 'src/models/Category';
import { CategoryService } from '../category.service';

@Component({
  selector: 'app-all-recipe',
  templateUrl: './all-recipe.component.html',
  styleUrls: ['./all-recipe.component.css'],
})
export class AllRecipeComponent implements OnInit {
  arr;
  filterArr: Recipe[];
  constructor(public ser: RecipeService, public catSer: CategoryService) {}
  recName: string;
  recCategoryName: string = 'all categories';
  recCategory: Category;
  recTime: number;
  catArr: Category[];

  filter() {
    this.recCategory = this.catArr.find(
      (category) => category.categoryName == this.recCategoryName
    );
    if (this.recCategory == null) this.recCategory = new Category('', '', '');
    console.log(
      'filter ' +
        this.recName +
        ' ' +
        this.recTime +
        ' ' +
        this.recCategory.categoryCode
    );

    this.filterArr = this.arr.filter(
      (r) =>
        (r.recipeName.includes(this.recName) ||
          this.recName == '' ||
          this.recName == null) &&
        (r.recipePreparationTime <= this.recTime ||
          this.recTime == 0 ||
          this.recTime == undefined) &&
        (r.categoryCode == this.recCategory.categoryCode ||
          this.recCategoryName == 'all categories')
    );
  }

  ngOnInit(): void {
    this.ser.GetAllRecipes().subscribe(
      (s) => {
        this.arr = s;
        this.filterArr = this.arr;
        console.log('all recipes', this.arr);
      },
      (e) => {
        console.log('error');
      }
    );
    this.catSer.GetAllCategories().subscribe((s) => {
      this.catArr = s;
    });
  }
}
