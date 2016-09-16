using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Models
{
  public class RecipeDetail : Recipe
  {
      public string Instructions { get; set; }

      public Ingredient[] Ingredients { get; set; }
  }
}
