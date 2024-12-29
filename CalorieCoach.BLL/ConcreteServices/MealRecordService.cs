using CalorieCoach.BLL.AbstractServices;
using CalorieCoach.BLL.Dtos.FoodPortionDtos;
using CalorieCoach.BLL.Dtos.MealRecordDtos;
using CalorieCoach.DAL.AbstractRepositories;
using CalorieCoach.DAL.ConcreteRepositories;
using CalorieCoach.DAL.Data;
using CalorieCoach.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.BLL.ConcreteServices
{
    public class MealRecordService : IMealRecordService
    {
        private readonly IGenericRepository<User> _userRepository;
        private readonly IMealRecordRepository _mealRecordRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly IGenericRepository<MealRecord> _genericMealRecordRepository;

        public MealRecordService(CalorieCoachDbContext dbContext)
        {
            _userRepository = new GenericRepository<User>(dbContext);
            _foodRepository = new FoodRepository(dbContext);
            _genericMealRecordRepository = new GenericRepository<MealRecord>(dbContext);
            _mealRecordRepository = new MealRecordRepository(dbContext);
        }
        public void CreateMealRecord(CreateMealRecordDto createMealRecordDto)
        {
            var user = _userRepository.GetById(createMealRecordDto.UserId);

            var foodIds = createMealRecordDto.FoodPortions
                .Select(foodItem => foodItem.FoodId)
                .ToList();
            var foods = _foodRepository.GetFoodsByIds(foodIds);

            var foodPortions = createMealRecordDto.FoodPortions.Select(foodPortion => new FoodPortion
            {
                Food = foods.First(food => food.Id == foodPortion.FoodId),
                Portion = foodPortion.Portion
            }).ToList();

            //var foodItems = createMealRecordDto.FoodItems.Select(foodItem => new FoodItem
            //{
            //    Food = foods.First(food => food.Id == foodItem.FoodId),
            //    Portion = foodItem.Portion
            //}).ToList();

            var mealRecord = new MealRecord
            {
                MealType = createMealRecordDto.MealType,
                User = user,
                Portions = foodPortions, //dogrudan foodItems listesini ata
                Created = createMealRecordDto.Date
            };
            _genericMealRecordRepository.Add(mealRecord);
        }

        public IEnumerable<MealRecordDto> GetMealRecordsByDate(int userId, DateTime dateTime)
        {
           var meals = _mealRecordRepository.GetAllWithPortionsByDateAndUserId(userId, dateTime);
            List<MealRecordDto>mealRecordDtos = new List<MealRecordDto>();
            foreach (var meal in meals)
            {
                var mealRecordDto = new MealRecordDto
                {
                    Id = meal.Id,
                    MealType = meal.MealType,
                    Portions = new List<FoodPortionDto>(),
                    CreatedAt = meal.Created
                };
                foreach (var portion in meal.Portions)
                {
                    var foodPortionDto = new FoodPortionDto
                    {
                        FoodName = portion.Food.Name,
                        ImagePath = portion.Food.ImagePath,
                        CaloriesPerUnit = portion.Food.CaloriesPerUnit,
                        FoodUnit = portion.Food.Unit,
                        Portion = portion.Portion
                    };

                    mealRecordDto.Portions.Add(foodPortionDto);
                }
                mealRecordDtos.Add(mealRecordDto);

            }

            return mealRecordDtos;

        }

    }
}
