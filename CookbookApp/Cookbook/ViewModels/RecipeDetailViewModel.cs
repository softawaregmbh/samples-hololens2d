using Cookbook.Models;
using Cookbook.Service;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.StoreApps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.ViewModels
{
    public class RecipeDetailViewModel : ViewModel
    {
        private RecipeDetail recipe;

        public RecipeDetail Recipe
        {
            get { return recipe; }
            set { base.SetProperty(ref this.recipe, value); }
        }

        public RecipeDetailViewModel()
        {
        }

        public async Task LoadRecipeDetail(int id)
        {
            this.Recipe = await RecipeService.GetRecipeDetail(id);
        }
    }
}
