using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi1.Models;
using webapi1.Repositories;

namespace webapi1.Services
{
    public interface IFoodService : IRepository<Food>
    {
        List<Food> GetAllFoodsList();
    }
}
