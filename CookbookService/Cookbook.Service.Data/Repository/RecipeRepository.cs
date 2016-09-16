using Cookbook.Service.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Service.Data.Repository
{
    public class RecipeRepository
    {
        public static IList<RecipeDetail> GetRecipes()
        {
            var recipes = new List<RecipeDetail>()
            {
                new RecipeDetail()
                {
                    Title = "Auflauf",
                    ImagePath = "http://localhost:54321/Content/Images/auflauf.jpg",
                    Instructions = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque eu elit sit amet enim porta scelerisque non vel eros. Nam sit amet lorem orci. Nunc malesuada turpis placerat diam aliquet, et tincidunt dui vestibulum. Morbi fermentum nibh lacus, et ultrices nunc scelerisque vel. Maecenas non elit eu nulla venenatis mollis. Maecenas porttitor lobortis dolor sit amet vehicula. Duis odio odio, porta at venenatis quis, dictum a mauris. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Morbi id enim velit. Praesent ante lectus, vestibulum a lectus ac, sagittis venenatis nibh. Donec eget dictum lectus, nec dictum tortor. Ut eu feugiat dolor. Etiam vel nibh ultricies, imperdiet libero ac, porta augue.",
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient("1 Lorem"),
                        new Ingredient("2 Ipsum"),
                        new Ingredient("30 ml dolor"),
                        new Ingredient("40 g sit"),
                        new Ingredient("5 Tl amet"),
                        new Ingredient("6-7 consectetur"),
                        new Ingredient("80 g adipiscing"),
                        new Ingredient("9 elit")
                    }
                },
                new RecipeDetail()
                {
                    Title = "Italienischer Brotsalat",
                    ImagePath = "http://localhost:54321/Content/Images/brotsalat.jpg",
                    Instructions = "Brot würfelig schneiden, in einer Pfanne etwas Olivenöl erhitzen und Brot knusprig rösten, Knoblauch, Senf, Essig, 3 El Wasser, Honig und Sardellen in einen Mixbecher geben, pürieren, dann nach und nach 100 ml Olivenöl zufügen, mit Salz und Pfeffer würzen, Zwiebel schälen und in dünne Ringe schneiden, 1 El Öl in einer Pfanne erhitzen, Tomaten und Zucker zugeben, rundherum ca. 4 Minuten braten, bis die Haut aufplatzt, herausnehmen und abkühlen lassen, restliches Öl erhitzen und Zwiebelringe anbraten, mit den Tomaten, Kapern, Oliven und Brot mischen, Schnittlauch nicht zu klein schneiden, Dressing zu der Brotmischung geben und vorsichtig verrühren, Salat und Schnittlauch untermischen und anrichten",
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient("250 g Roggenbrot                          "),   
                        new Ingredient("1 Knoblauchzehe                           "),   
                        new Ingredient("1 El Senf                                 "),   
                        new Ingredient("30 ml Rotweinessig                        "),   
                        new Ingredient("2 Tl Honig                                "),   
                        new Ingredient("5-10 Sardellen in Öl (je nach Geschmack)  "),   
                        new Ingredient("120 ml Olivenöl                           "),   
                        new Ingredient("Salz                                      "),   
                        new Ingredient("", "", "schwarzer Pfeffer aus der Mühle           "),   
                        new Ingredient("2", "", "rote Zwiebeln (ca. 200 g)               "),   
                        new Ingredient("200 g Kirschtomaten                       "),   
                        new Ingredient("1 Tl Zucker                               "),   
                        new Ingredient("2 El Kapern                               "),   
                        new Ingredient("50 g schwarze Oliven mit Kern             "),   
                        new Ingredient("1 Bund Schnittlauch                       "),   
                        new Ingredient("", "", "gemischter Salat                          ")
                    }
                },
                new RecipeDetail() 
                {
                    Title = "Crepe-Röllchen",
                    ImagePath = "http://localhost:54321/Content/Images/creperoellchen.jpg",
                    Instructions = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque eu elit sit amet enim porta scelerisque non vel eros. Nam sit amet lorem orci. Nunc malesuada turpis placerat diam aliquet, et tincidunt dui vestibulum. Morbi fermentum nibh lacus, et ultrices nunc scelerisque vel. Maecenas non elit eu nulla venenatis mollis. Maecenas porttitor lobortis dolor sit amet vehicula. Duis odio odio, porta at venenatis quis, dictum a mauris. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Morbi id enim velit. Praesent ante lectus, vestibulum a lectus ac, sagittis venenatis nibh. Donec eget dictum lectus, nec dictum tortor. Ut eu feugiat dolor. Etiam vel nibh ultricies, imperdiet libero ac, porta augue.",
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient("1 Lorem"),
                        new Ingredient("2 Ipsum"),
                        new Ingredient("30 ml dolor"),
                        new Ingredient("40 g sit"),
                        new Ingredient("5 Tl amet"),
                        new Ingredient("6-7 consectetur"),
                        new Ingredient("80 g adipiscing"),
                        new Ingredient("9 elit")
                    }
                },
                new RecipeDetail() 
                {
                    Title = "Entenbrust mit Polentaterrine",
                    ImagePath = "http://localhost:54321/Content/Images/entenbrust.jpg",
                    Instructions = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque eu elit sit amet enim porta scelerisque non vel eros. Nam sit amet lorem orci. Nunc malesuada turpis placerat diam aliquet, et tincidunt dui vestibulum. Morbi fermentum nibh lacus, et ultrices nunc scelerisque vel. Maecenas non elit eu nulla venenatis mollis. Maecenas porttitor lobortis dolor sit amet vehicula. Duis odio odio, porta at venenatis quis, dictum a mauris. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Morbi id enim velit. Praesent ante lectus, vestibulum a lectus ac, sagittis venenatis nibh. Donec eget dictum lectus, nec dictum tortor. Ut eu feugiat dolor. Etiam vel nibh ultricies, imperdiet libero ac, porta augue.",
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient("1 Lorem"),
                        new Ingredient("2 Ipsum"),
                        new Ingredient("30 ml dolor"),
                        new Ingredient("40 g sit"),
                        new Ingredient("5 Tl amet"),
                        new Ingredient("6-7 consectetur"),
                        new Ingredient("80 g adipiscing"),
                        new Ingredient("9 elit")
                    }
                },
                new RecipeDetail() 
                {
                    Title = "Gefüllte Tomaten",
                    ImagePath = "http://localhost:54321/Content/Images/gefuellte-tomaten.jpg",
                    Instructions = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque eu elit sit amet enim porta scelerisque non vel eros. Nam sit amet lorem orci. Nunc malesuada turpis placerat diam aliquet, et tincidunt dui vestibulum. Morbi fermentum nibh lacus, et ultrices nunc scelerisque vel. Maecenas non elit eu nulla venenatis mollis. Maecenas porttitor lobortis dolor sit amet vehicula. Duis odio odio, porta at venenatis quis, dictum a mauris. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Morbi id enim velit. Praesent ante lectus, vestibulum a lectus ac, sagittis venenatis nibh. Donec eget dictum lectus, nec dictum tortor. Ut eu feugiat dolor. Etiam vel nibh ultricies, imperdiet libero ac, porta augue.",
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient("1 Lorem"),
                        new Ingredient("2 Ipsum"),
                        new Ingredient("30 ml dolor"),
                        new Ingredient("40 g sit"),
                        new Ingredient("5 Tl amet"),
                        new Ingredient("6-7 consectetur"),
                        new Ingredient("80 g adipiscing"),
                        new Ingredient("9 elit")
                    }
                },
                new RecipeDetail() 
                {
                    Title = "Mango-Ruccola-Salat",
                    ImagePath = "http://localhost:54321/Content/Images/mango-ruccola-salat.jpg",
                    Instructions = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque eu elit sit amet enim porta scelerisque non vel eros. Nam sit amet lorem orci. Nunc malesuada turpis placerat diam aliquet, et tincidunt dui vestibulum. Morbi fermentum nibh lacus, et ultrices nunc scelerisque vel. Maecenas non elit eu nulla venenatis mollis. Maecenas porttitor lobortis dolor sit amet vehicula. Duis odio odio, porta at venenatis quis, dictum a mauris. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Morbi id enim velit. Praesent ante lectus, vestibulum a lectus ac, sagittis venenatis nibh. Donec eget dictum lectus, nec dictum tortor. Ut eu feugiat dolor. Etiam vel nibh ultricies, imperdiet libero ac, porta augue.",
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient("1 Lorem"),
                        new Ingredient("2 Ipsum"),
                        new Ingredient("30 ml dolor"),
                        new Ingredient("40 g sit"),
                        new Ingredient("5 Tl amet"),
                        new Ingredient("6-7 consectetur"),
                        new Ingredient("80 g adipiscing"),
                        new Ingredient("9 elit")
                    }
                },
                new RecipeDetail() 
                {
                    Title = "Nudeln",
                    ImagePath = "http://localhost:54321/Content/Images/nudeln.jpg",
                    Instructions = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque eu elit sit amet enim porta scelerisque non vel eros. Nam sit amet lorem orci. Nunc malesuada turpis placerat diam aliquet, et tincidunt dui vestibulum. Morbi fermentum nibh lacus, et ultrices nunc scelerisque vel. Maecenas non elit eu nulla venenatis mollis. Maecenas porttitor lobortis dolor sit amet vehicula. Duis odio odio, porta at venenatis quis, dictum a mauris. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Morbi id enim velit. Praesent ante lectus, vestibulum a lectus ac, sagittis venenatis nibh. Donec eget dictum lectus, nec dictum tortor. Ut eu feugiat dolor. Etiam vel nibh ultricies, imperdiet libero ac, porta augue.",
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient("1 Lorem"),
                        new Ingredient("2 Ipsum"),
                        new Ingredient("30 ml dolor"),
                        new Ingredient("40 g sit"),
                        new Ingredient("5 Tl amet"),
                        new Ingredient("6-7 consectetur"),
                        new Ingredient("80 g adipiscing"),
                        new Ingredient("9 elit")
                    }
                },
                new RecipeDetail() 
                {
                    Title = "Spargel",
                    ImagePath = "http://localhost:54321/Content/Images/spargel.jpg",
                    Instructions = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque eu elit sit amet enim porta scelerisque non vel eros. Nam sit amet lorem orci. Nunc malesuada turpis placerat diam aliquet, et tincidunt dui vestibulum. Morbi fermentum nibh lacus, et ultrices nunc scelerisque vel. Maecenas non elit eu nulla venenatis mollis. Maecenas porttitor lobortis dolor sit amet vehicula. Duis odio odio, porta at venenatis quis, dictum a mauris. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Morbi id enim velit. Praesent ante lectus, vestibulum a lectus ac, sagittis venenatis nibh. Donec eget dictum lectus, nec dictum tortor. Ut eu feugiat dolor. Etiam vel nibh ultricies, imperdiet libero ac, porta augue.",
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient("1 Lorem"),
                        new Ingredient("2 Ipsum"),
                        new Ingredient("30 ml dolor"),
                        new Ingredient("40 g sit"),
                        new Ingredient("5 Tl amet"),
                        new Ingredient("6-7 consectetur"),
                        new Ingredient("80 g adipiscing"),
                        new Ingredient("9 elit")
                    }
                },
                new RecipeDetail() 
                {
                    Title = "Spargel mit gebackenem Ei",
                    ImagePath = "http://localhost:54321/Content/Images/spargel-mit-gebackenem-ei.jpg",
                    Instructions = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque eu elit sit amet enim porta scelerisque non vel eros. Nam sit amet lorem orci. Nunc malesuada turpis placerat diam aliquet, et tincidunt dui vestibulum. Morbi fermentum nibh lacus, et ultrices nunc scelerisque vel. Maecenas non elit eu nulla venenatis mollis. Maecenas porttitor lobortis dolor sit amet vehicula. Duis odio odio, porta at venenatis quis, dictum a mauris. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Morbi id enim velit. Praesent ante lectus, vestibulum a lectus ac, sagittis venenatis nibh. Donec eget dictum lectus, nec dictum tortor. Ut eu feugiat dolor. Etiam vel nibh ultricies, imperdiet libero ac, porta augue.",
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient("1 Lorem"),
                        new Ingredient("2 Ipsum"),
                        new Ingredient("30 ml dolor"),
                        new Ingredient("40 g sit"),
                        new Ingredient("5 Tl amet"),
                        new Ingredient("6-7 consectetur"),
                        new Ingredient("80 g adipiscing"),
                        new Ingredient("9 elit")
                    }
                },
                new RecipeDetail() 
                {
                    Title = "Spinat-Roulade",
                    ImagePath = "http://localhost:54321/Content/Images/spinatroulade.jpg",
                    Instructions = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque eu elit sit amet enim porta scelerisque non vel eros. Nam sit amet lorem orci. Nunc malesuada turpis placerat diam aliquet, et tincidunt dui vestibulum. Morbi fermentum nibh lacus, et ultrices nunc scelerisque vel. Maecenas non elit eu nulla venenatis mollis. Maecenas porttitor lobortis dolor sit amet vehicula. Duis odio odio, porta at venenatis quis, dictum a mauris. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Morbi id enim velit. Praesent ante lectus, vestibulum a lectus ac, sagittis venenatis nibh. Donec eget dictum lectus, nec dictum tortor. Ut eu feugiat dolor. Etiam vel nibh ultricies, imperdiet libero ac, porta augue.",
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient("1 Lorem"),
                        new Ingredient("2 Ipsum"),
                        new Ingredient("30 ml dolor"),
                        new Ingredient("40 g sit"),
                        new Ingredient("5 Tl amet"),
                        new Ingredient("6-7 consectetur"),
                        new Ingredient("80 g adipiscing"),
                        new Ingredient("9 elit")
                    }
                }
            };

            Random random = new Random();
            var fullList = recipes;

            for (int i = 0; i < fullList.Count; i++)
            {
                fullList[i].Id = (i + 1);
                fullList[i].Rating = random.Next(1, 5);
            }

            return fullList;
        }
    }
}
