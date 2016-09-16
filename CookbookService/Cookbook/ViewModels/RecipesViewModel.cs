using Cookbook.Models;
using Cookbook.Services;
using Microsoft.Practices.Prism.StoreApps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.ViewModels
{
    public class RecipesViewModel : ViewModel
    {
        private ObservableCollection<RecipeDetail> recipes;

        public ObservableCollection<RecipeDetail> Recipes
        {
            get { return recipes; }
            set { this.SetProperty(ref this.recipes, value); }
        }

        private IEnumerable<RecipeDetail> topRecipes;

        public IEnumerable<RecipeDetail> TopRecipes
        {
            get { return topRecipes; }
            set { this.SetProperty(ref this.topRecipes, value); }
        }

        private RecipeDetail recipeOfTheDay;

        public RecipeDetail RecipeOfTheDay
        {
            get { return recipeOfTheDay; }
            set { this.SetProperty(ref this.recipeOfTheDay, value); }
        }

        public RecipesViewModel()
        {
            this.Recipes = new ObservableCollection<RecipeDetail>();
        }

        public async Task LoadRecipes()
        {
            var recipes = await RecipeService.GetRecipes();
            this.Recipes = new ObservableCollection<RecipeDetail>(recipes);

            // new: set top recipes and recipe of the day
            this.TopRecipes = recipes.GroupBy(p => p.Rating).OrderByDescending(p => p.Key).First();
            this.RecipeOfTheDay = this.TopRecipes.First();
        }
    }
}
