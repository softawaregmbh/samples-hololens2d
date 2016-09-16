using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Service.Data.Domain
{
    public class RecipeDetail : Recipe
    {
        public string Instructions { get; set; }

        [DataMember]
        public IList<Ingredient> Ingredients { get; set; }
    }
}
