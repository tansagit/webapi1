using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi1.Models;
using webapi1.Repositories;

namespace webapi1.Services
{
    public class FoodService : Repository<Food>, IFoodService 
    {
        private readonly IRepository<Food> _foodRepository; //thay the cho context trong Repository

        public FoodService(FoodContext context): base(context) { }

        public List<Food> GetAllFoodsList()
        {
            return _foodRepository.GetAll().ToList();
        } 

       
    }
}
