using CalorieCoach.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.AbstractRepositories
{
    public interface IFoodRepository
    {
        IEnumerable<Food> GetAllWithCategories();
        Food GetByIdWithCategory(int Id);
        IEnumerable<Food> GetFoodsByIds(IEnumerable<int> foodIds);
        
    }
}
