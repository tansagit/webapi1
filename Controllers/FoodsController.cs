using System.Linq;
using Microsoft.AspNetCore.Mvc;
using webapi1.Models;
using webapi1.Services;

namespace webapi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        // private readonly FoodContext _context;
        private readonly IFoodService _foodService;


        public FoodsController(IFoodService foodService)
        {
            _foodService = foodService;

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var foods = _foodService.GetAll();

                if (foods == null)
                {
                    return NotFound();
                }
                return Ok(foods);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("FoodId")]
        public IActionResult Get(int foodId)
        {
            if (foodId == null){
                return BadRequest();
            }
            try
            {
                var food = _foodService.Get(foodId, true);
                if(food == null)
                {
                    return NotFound();
                }
                return Ok(food);
            }
            
            catch (System.Exception)
            {
                
                return BadRequest();
            }
        }
    }
}