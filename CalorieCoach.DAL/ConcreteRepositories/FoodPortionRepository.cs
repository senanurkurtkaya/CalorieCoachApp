using CalorieCoach.DAL.AbstractRepositories;
using CalorieCoach.DAL.Data;
using CalorieCoach.DAL.Dtos;
using CalorieCoach.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.ConcreteRepositories
{
    public class FoodPortionRepository : IFoodPortionRepository
    {
        private readonly CalorieCoachDbContext _dbContext;
        public FoodPortionRepository(CalorieCoachDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public FoodPortion GetByHighestCaloriesInLastWeek(int userId)
        {
            var now =DateTime.Now.Date;
            var lastWeek = now.AddDays(-7).Date;

            return _dbContext.FoodPortions
                .Include(x=>x.Food)
                .Where(x=>x.MealRecord.UserId == userId 
                && lastWeek < x.Created.Date  && x.Created.Date< now)
                .OrderByDescending(x=>x.Food.CaloriesPerUnit * x.Portion)
                .FirstOrDefault();
             
        }

        public MostPrefferedFoodDto GetMostPopularFood()
        {
            var now = DateTime.Now.Date;
            var lastWeek = now.AddDays(-7).Date;

            return _dbContext.FoodPortions
               .Where(x => lastWeek < x.Created.Date && x.Created.Date < now)
                .GroupBy(x => new MostPrefferedFoodDto
                {
                    Id = x.FoodId,
                    Name = x.Food.Name,
                    CaloriesPerUnit = x.Food.CaloriesPerUnit,
                    ImagePath = x.Food.ImagePath,
                })
                .Select(x => new MostPrefferedFoodDto
                {
                    Id = x.Key.Id,
                    Name = x.Key.Name,
                    CaloriesPerUnit = x.Key.CaloriesPerUnit,
                    ImagePath = x.Key.ImagePath,
                    Count = x.Count()
                })
                .OrderByDescending(x => x.Count)
                .FirstOrDefault();

        }

        public MostPrefferedFoodDto GetMostPrefferedFoodByUser(int userId)
        {
            var now = DateTime.Now.Date;
            var lastWeek = now.AddDays(-7).Date;

            return _dbContext.FoodPortions
                .Where(x => x.MealRecord.UserId == userId
                    && lastWeek < x.Created.Date && x.Created.Date < now)
                .GroupBy(x => new MostPrefferedFoodDto
                {
                    Id = x.FoodId,
                    Name = x.Food.Name,
                    CaloriesPerUnit = x.Food.CaloriesPerUnit,
                    ImagePath = x.Food.ImagePath,
                })
                .Select(x => new MostPrefferedFoodDto
                {
                    Id = x.Key.Id,
                    Name = x.Key.Name,
                    CaloriesPerUnit = x.Key.CaloriesPerUnit,
                    ImagePath = x.Key.ImagePath,
                    Count = x.Count()
                })
                .OrderByDescending(x => x.Count)
                .FirstOrDefault();

        }
    }  
}
