using CalorieCoach.DAL.Dtos;
using CalorieCoach.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.AbstractRepositories
{
    public interface IFoodPortionRepository
    {
        FoodPortion GetByHighestCaloriesInLastWeek(int userId);

        MostPrefferedFoodDto GetMostPrefferedFoodByUser(int userId);

        MostPrefferedFoodDto GetMostPopularFood();
    }
}
