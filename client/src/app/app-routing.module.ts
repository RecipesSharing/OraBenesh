import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddRecipeComponent } from './add-recipe/add-recipe.component';
import { AllRecipeComponent } from './all-recipe/all-recipe.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { RecipeDetailsComponent } from './recipe-details/recipe-details.component';



const routes: Routes = [
  {path:'',redirectTo:'login',pathMatch: 'full' },
  { path: 'register', component: RegisterComponent },
  { path: 'login', component: LoginComponent },
  { path: 'allRecipes', component: AllRecipeComponent },
  { path: 'addRecipe', component: AddRecipeComponent },
  { path: 'recipeDetails', component: RecipeDetailsComponent },
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [RouterModule]
})
export class AppRoutingModule { }