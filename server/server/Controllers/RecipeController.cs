using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace server.Controllers
{
    [EnableCors("*", "*", "*")]

    public class RecipeController : ApiController
    {
        [HttpGet]
        public List<Recipe> GetAllRecipes()
        {
            return DB.RecipeList;
        }
        [HttpGet]
        public Recipe GetRecipe(string code)
        {
            return DB.RecipeList.FirstOrDefault(recipe => recipe.recipeCode == code);
        }

        [HttpGet]
        public List<Recipe> GetRecipesByTime(int miniutes)
        {
            return DB.RecipeList.Where(recipe => recipe.recipePreparationTime <= miniutes).ToList();
        }

        [HttpPost]
        public void AddRecipe([FromBody] Recipe newRecipe)
        {
            DB.RecipeList.Add(newRecipe);
        }

        [HttpDelete]
        public Recipe DeleteRecipe(string code)
        {
            Recipe recipe = DB.RecipeList.FirstOrDefault(r => r.recipeCode == code);
            DB.RecipeList.Remove(recipe);
            return recipe;
        }

        [HttpPut]
        public Recipe SetRecipe(string code,[FromBody] Recipe recipe)
        {

           Recipe re= DB.RecipeList.FirstOrDefault(r => r.recipeCode == code);
            re.level = recipe.level;

            return re;
        }
    }
}
