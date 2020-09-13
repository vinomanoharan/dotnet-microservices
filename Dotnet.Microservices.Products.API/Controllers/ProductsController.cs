using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Dotnet.Microservices.Products.API.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class ProductsController : ControllerBase
    {
        private string[] Products = new[]
        {
            "Apples", "Rice", "Wheat", "Candies", "Sugar", "Eggs"
        };


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Products;
        }
    }
}
