using System.Linq;
using Microsoft.AspNetCore.Mvc;
using webapi1.Models;

namespace webapi1.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly FoodContext _context;

        public FoodsController(FoodContext context)
        {
            _context = context;

            if (_context.Foods.Count() == 0){
                
            }
        }
    }
}