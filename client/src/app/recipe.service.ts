import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Recipe } from 'src/models/Recipe';

@Injectable({
  providedIn: 'root'
})
export class RecipeService {
  baseUrl = "https://localhost:44350/api/Recipe";
  GetAllRecipes() {
    return this.http.get<Recipe[]>(`${this.baseUrl}/GetAllRecipes`)
  }
  GetRecipeByCode(code: string) {
    return this.http.get<Recipe>(`${this.baseUrl}/GetRecipeByCode?code=${code}`);
  }
  GetRecipesByTime(d: Date) {
    return this.http.get<Recipe>(`${this.baseUrl}/GetRecipesByTime?miniutes=${d}`);
  }
  AddRecipe(r: Recipe) {
    console.log("rec from ser" + JSON.stringify(r))
    return this.http.post(`${this.baseUrl}/AddRecipe/`, r);
  }
  DeleteRecipe(code: string) {
    return this.http.delete<Recipe>(`${this.baseUrl}/DeleteRecipe?code=${code}`);
  }
  SetRecipe(code: string, r: Recipe) {
    return this.http.put<Recipe>(`${this.baseUrl}/SetRecipe?code=${code}`, r);
  }

  constructor(public http: HttpClient) { }
}
