using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace server.Models
{
  
    public class Recipe
    {
        public string recipeCode { get; set; }
        public string recipeName { get; set; }
        public string categoryCode { get; set; }
        public int recipePreparationTime { get; set; }
        public int level { get; set; }
        public DateTime recipeAddDate { get; set; }
        public List<string> recipeIngredientsList { get; set; }
        public List<string> recipePreparation { get; set; }
        public string recipeUserCode { get; set; }
        public string recipeImage { get; set; }
        public Recipe()
        {

        }
        public Recipe(string recipeCode, string recipeName, string categoryCode, int recipePreparationTime, int level, DateTime recipeAddDate, List<string> recipeIngredientsList, List<string> recipePreparation, string recipeUserCode, string recipeImage)
        {
            this.recipeCode = recipeCode;
            this.recipeName = recipeName;
            this.categoryCode = categoryCode;
            this.recipePreparationTime = recipePreparationTime;
            this.level = level;
            this.recipeAddDate = recipeAddDate;
            this.recipeIngredientsList = recipeIngredientsList;
            this.recipePreparation = recipePreparation;
            this.recipeUserCode = recipeUserCode;
            this.recipeImage = recipeImage;
        }

    }
}