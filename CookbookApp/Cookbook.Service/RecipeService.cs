using Cookbook.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace Cookbook.Service
{
    public class RecipeService
    {
        //private static string RECIPE_BASEURL = "http://localhost:54321/api";
        private static string RECIPE_BASEURL = "http://mycookbookservice.azurewebsites.net/api";

        public async static Task<IList<Recipe>> GetRecipes()
        {
            var url = new Uri(RECIPE_BASEURL + "/Recipes");
            var http = new HttpClient();
            var json = await http.GetStringAsync(url);
            var recipes = JsonConvert.DeserializeObject<List<Recipe>>(json);
            return recipes;
        }

        public async static Task<RecipeDetail> GetRecipeDetail(int id)
        {
            var url = new Uri(string.Format("{0}/Recipes/{1}", RECIPE_BASEURL, id));

            var http = new HttpClient();
            var json = await http.GetStringAsync(url);
            var recipe = JsonConvert.DeserializeObject<RecipeDetail>(json);
            return recipe;
        }

        public async static Task<IList<RecipeDetail>> GetRecipeDetails()
        {
            var url = new Uri(string.Format("{0}/recipedetails", RECIPE_BASEURL));

            var http = new HttpClient();
            var json = await http.GetStringAsync(url);
            var recipes = JsonConvert.DeserializeObject<List<RecipeDetail>>(json);
            return recipes;
        }
    }
}
