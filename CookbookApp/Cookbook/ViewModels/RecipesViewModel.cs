using Cookbook.Models;
using Cookbook.Service;
using Microsoft.Practices.Prism.Mvvm;
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
        private ObservableCollection<Recipe> recipes;

        public ObservableCollection<Recipe> Recipes
        {
            get { return recipes; }
            set { this.SetProperty(ref this.recipes, value); }
        }

        private IEnumerable<Recipe> topRecipes;

        public IEnumerable<Recipe> TopRecipes
        {
            get { return topRecipes; }
            set { this.SetProperty(ref this.topRecipes, value); }
        }

        private Recipe recipeOfTheDay;

        public Recipe RecipeOfTheDay
        {
            get { return recipeOfTheDay; }
            set { this.SetProperty(ref this.recipeOfTheDay, value); }
        }

        private Recipe selectedRecipe;

        public Recipe SelectedRecipe
        {
            get { return selectedRecipe; }
            set
            {
                this.SetProperty(ref this.selectedRecipe, value);
                LoadRecipeDetail(this.selectedRecipe.Id);
            }
        }


        private RecipeDetail selectedRecipeDetail;

        public RecipeDetail SelectedRecipeDetail
        {
            get { return selectedRecipeDetail; }
            set { this.SetProperty(ref this.selectedRecipeDetail, value); }
        }


        public RecipesViewModel()
        {
            this.Recipes = new ObservableCollection<Recipe>();
        }

        public async Task LoadRecipes()
        {
            var recipes = await RecipeService.GetRecipes();
            this.Recipes = new ObservableCollection<Recipe>(recipes);

            // new: set top recipes and recipe of the day
            this.TopRecipes = recipes.GroupBy(p => p.Rating).OrderByDescending(p => p.Key).First();
            this.RecipeOfTheDay = this.TopRecipes.First();
        }

        private async void LoadRecipeDetail(int id)
        {
            this.SelectedRecipeDetail = await RecipeService.GetRecipeDetail(id);
        }

        public void NavigateRecipe(int offset)
        {
            int newIndex = 0;

            if (this.SelectedRecipe != null)
            {
                var currentIndex = this.Recipes.IndexOf(this.SelectedRecipe);
                newIndex = (currentIndex + offset) % this.Recipes.Count;

                if (newIndex < 0)
                {
                    newIndex += this.Recipes.Count;
                }
            }

            this.SelectedRecipe = this.Recipes[newIndex];
        }
    }
}
