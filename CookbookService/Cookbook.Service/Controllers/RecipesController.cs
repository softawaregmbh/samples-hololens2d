using Cookbook.Service.Data.Domain;
using Cookbook.Service.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cookbook.Service.Controllers
{
    public class RecipesController : ApiController
    {
        // GET api/recipes/5
        public IEnumerable<RecipeDetail> Get()
        {
            try
            {
                return RecipeRepository.GetRecipes().ToList();
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        // GET api/recipes/5
        public RecipeDetail Get(int id)
        {
            try
            { 
                return RecipeRepository.GetRecipes().First(p => p.Id == id);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        // POST api/recipes
        public void Post([FromBody]string value)
        {
        }

        // PUT api/recipes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/recipes/5
        public void Delete(int id)
        {
        }
    }
}
