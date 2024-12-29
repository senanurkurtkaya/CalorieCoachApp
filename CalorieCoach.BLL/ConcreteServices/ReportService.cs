using CalorieCoach.BLL.AbstractServices;
using CalorieCoach.BLL.Dtos.FoodPortionDtos;
using CalorieCoach.DAL.AbstractRepositories;
using CalorieCoach.DAL.ConcreteRepositories;
using CalorieCoach.DAL.Data;
using CalorieCoach.DAL.Dtos;
using CalorieCoach.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.BLL.ConcreteServices
{
    public class ReportService : IReportService
    {
        private readonly IMealRecordRepository _mealRecordRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly IFoodPortionRepository _foodPortionRepository;

        public ReportService(CalorieCoachDbContext dbContext)

        {
            _mealRecordRepository = new MealRecordRepository(dbContext);
            _foodRepository = new FoodRepository(dbContext);
            _foodPortionRepository = new FoodPortionRepository(dbContext);

        }
        public decimal LastCaloriesByUser(int userId)
        {
            throw new NotImplementedException();
        }

        public decimal LastDayAvgCalories()
        {
            var mealRecords = _mealRecordRepository.GetAllInLastDay();

            if (!mealRecords.Any())
            {
                return 0;

            }
            return mealRecords.SelectMany(mr => mr.Portions).Sum(p => p.Portion * p.Food.CaloriesPerUnit) / mealRecords.Count();

        }

        public decimal LastDayCaloriesByUser(int userId)
        {
            var mealRecords = _mealRecordRepository.GetByUserInLastDay(userId);

            return mealRecords.SelectMany(mr => mr.Portions).Sum(p => p.Portion * p.Food.CaloriesPerUnit);
        }

        public FoodPortionDto? LastWeekHighestCaloriesByUser(int userId)
        {
            var foodPortion = _foodPortionRepository.GetByHighestCaloriesInLastWeek(userId);

            if (foodPortion == null)
            {
                return new FoodPortionDto();
            }

            return new FoodPortionDto
            {
                Portion = foodPortion.Portion,
                CaloriesPerUnit = foodPortion.Food.CaloriesPerUnit,
                FoodName = foodPortion.Food.Name,
                FoodUnit = foodPortion.Food.Unit,
                ImagePath = foodPortion.Food.ImagePath
            };
        }

        public MostPrefferedFoodDto MostPopularFoodInLastWeek()
        {
            return _foodPortionRepository.GetMostPopularFood();
        }

        public MostPrefferedFoodDto MostPreferredFoodInLastWeekByUser(int userId)
        {
            return _foodPortionRepository.GetMostPrefferedFoodByUser(userId);
        }

        public decimal WeeklyAvgCalories()
        {
            var mealRecords = _mealRecordRepository.GetAllInLastWeek();

            return AvgCals(mealRecords);
        }

        public decimal WeeklyAvgCaloriesByUser(int userId)
        {
            var mealRecords = _mealRecordRepository.GetByUserInLastWeek(userId);

            return AvgCals(mealRecords);
        }
        private decimal AvgCals(IEnumerable<MealRecord> mealRecords)
        {
            if (mealRecords.Count() == 0)
            {
                return 0;
            }

            var totalCalories = mealRecords
                .SelectMany(x => x.Portions)
                .Sum(x => x.Portion * x.Food.CaloriesPerUnit);

            var avgCalories = totalCalories / mealRecords.Count();

            return avgCalories;
        }
    }
}
