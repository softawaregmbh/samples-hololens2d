using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Models
{
  public class Recipe
  {
      public int Id { get; set; }
      public string Title { get; set; }
      public string ImagePath { get; set; }
      public int Rating { get; set; }
  }
}
