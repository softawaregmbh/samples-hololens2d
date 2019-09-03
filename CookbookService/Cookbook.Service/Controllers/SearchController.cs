using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Cookbook.Service.Data.Domain;
using Cookbook.Service.Data.Repository;

namespace Cookbook.Service.Controllers
{
    public class SearchController : ApiController
    {
        public IEnumerable<Recipe> Get(string query)
        {
            try
            {
                query = query.ToLower();

                return RecipeRepository.GetRecipes()
                            .Where(p => p.Title.ToLower().StartsWith(query))
                            .Select(r => new Recipe(r.Id, r.Title, r.ImagePath, r.Rating))
                            .ToList();
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }
	}
}