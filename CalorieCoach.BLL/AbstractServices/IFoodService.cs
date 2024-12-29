using CalorieCoach.BLL.Dtos.FoodDtos;
using CalorieCoach.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.BLL.AbstractServices
{
    public interface IFoodService
    {
        FoodDto GetById(int id);
        void CreateFood(CreateFoodDto createFoodDto);
        void UpdateFood(UpdateFoodDto updateFoodDto);
        IEnumerable<FoodDto> GetAllFoods();




    }
}
