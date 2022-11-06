import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Category } from 'src/models/Category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  baseUrl = "https://localhost:44350/api/Category";

  GetAllCategories() {
    return this.http.get<Category[]>(`${this.baseUrl}/GetAllCategories`)
  }
  GetCategoryByCode(code: string) {
    console.log("category code")
    // return this.http.get<Category>(`${this.baseUrl}/GetCategoryByCode(${code})`)
    return this.http.get<Category>(`${this.baseUrl}/GetCategoryByCode?code=${code}`)
  }
  constructor(public http: HttpClient) { }
}
