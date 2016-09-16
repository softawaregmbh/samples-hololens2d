using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Cookbook.Service.Data.Domain
{
    [DataContract]
    public class Ingredient
    {
        [DataMember]
        public string Amount { get; set; }

        [DataMember]
        public string Unity { get; set; }

        [DataMember]
        public string Title { get; set; }

        public Ingredient(string amount, string unity, string title)
        {
            this.Amount = amount;
            this.Unity = unity;
            this.Title = title;
        }

        public Ingredient(string ingredient)
        {
            var parts = ingredient.Trim().Split(' ');
            if (parts.Length >= 3)
            {
                this.Amount = parts[0];
                this.Unity = parts[1];

                this.Title = parts[2];
                for (int i = 3; i < parts.Length; i++)
                {
                    this.Title += " " + parts[i];    
                }                
            }
            else if (parts.Length == 2)
            {
                this.Amount = parts[0];
                this.Title = parts[1];
            }
            else
            {
                this.Title = ingredient;
            }
        }
    }
}
