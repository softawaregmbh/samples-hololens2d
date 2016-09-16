using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Service.Data.Domain
{
    [KnownType(typeof(RecipeDetail))]
    public class Recipe
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ImagePath { get; set; }
        
        public int Rating { get; set; }

        public Recipe()
        {
        }

        public Recipe(int id, string title, string imagePath, int rating)
        {
            this.Id = id;
            this.Title = title;
            this.ImagePath = imagePath;
            this.Rating = rating;
        }
    }
}
