using Cookbook.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace Cookbook.Services
{
    public class RecipeService
    {
        private static string RECIPE_BASEURL = "http://localhost:54321/api/Recipes";

        public async static Task<IList<RecipeDetail>> GetRecipes()
        {
            var url = new Uri(RECIPE_BASEURL);
            var http = new HttpClient();
            var json = await http.GetStringAsync(url);
            var recipes = JsonConvert.DeserializeObject<List<RecipeDetail>>(json);
            return recipes;
        }

        public async static Task<RecipeDetail> GetRecipeDetail(int id)
        {
            var url = new Uri(string.Format("{0}/{1}", RECIPE_BASEURL, id));

            var http = new HttpClient();
            var json = await http.GetStringAsync(url);
            var recipe = JsonConvert.DeserializeObject<RecipeDetail>(json);
            return recipe;
        }
    }
}
