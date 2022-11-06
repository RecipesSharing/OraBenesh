using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace server.Controllers
{
    [EnableCors("*", "*", "*")]

    public class CategoryController : ApiController
    {
        [HttpGet]
        public List<Category> GetAllCategories()
        {
            return DB.CategoryList;
        }
        [HttpGet]
        public Category GetCategoryByCode(string code)
        {
            return DB.CategoryList.FirstOrDefault(c => c.categoryCode == code);
        }
    }
}
