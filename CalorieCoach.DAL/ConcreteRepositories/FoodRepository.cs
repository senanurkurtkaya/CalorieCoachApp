using CalorieCoach.DAL.AbstractRepositories;
using CalorieCoach.DAL.Data;
using CalorieCoach.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.ConcreteRepositories
{
    public class FoodRepository : IFoodRepository
    {
        private readonly CalorieCoachDbContext _dbContext;
        private readonly DbSet<Food> _foods;

        public FoodRepository(CalorieCoachDbContext dbContext)
        {
            _dbContext = dbContext;
            _foods = _dbContext.Foods;
        }

        public IEnumerable<Food> GetAllWithCategories()
        {
            return _foods.Include(x => x.Category).ToList();
        }



        //public IEnumerable<Food> GetAllWithCategories()
        //{
        //    return _foods.Include(x => x.Category).ToList();
        //}

        public Food GetByIdWithCategory(int id)
        {
            return _foods.Include(x => x.Category).FirstOrDefault(x => x.Id==id);
        }

        public IEnumerable<Food> GetFoodsByIds(IEnumerable<int> foodIds)
        {
            return _foods.Include(x => x.Category).ToList();
        }
    }
}
