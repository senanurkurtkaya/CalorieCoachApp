using CalorieCoach.BLL.Dtos.FoodPortionDtos;
using CalorieCoach.DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.BLL.AbstractServices
{
    public interface IReportService
    {
        decimal LastCaloriesByUser(int userId);


        decimal WeeklyAvgCaloriesByUser(int userId);

        FoodPortionDto? LastWeekHighestCaloriesByUser(int userId);

        MostPrefferedFoodDto MostPreferredFoodInLastWeekByUser(int userId);

        decimal WeeklyAvgCalories();

        decimal LastDayAvgCalories();

        MostPrefferedFoodDto MostPopularFoodInLastWeek();

        decimal LastDayCaloriesByUser(int userId);

    }
}
