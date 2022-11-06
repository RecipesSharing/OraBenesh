export class Recipe{
    constructor(public recipeCode: string, public recipeName:string,
         public categoryCode:string, public recipePreparationTime:number,
          public level:number, public recipeAddDate:Date,public recipeIngredientsList:string[],
          public recipePreparation:string[], public recipeUserCode:string, public recipeImage:string)
    {
        
    }
}


