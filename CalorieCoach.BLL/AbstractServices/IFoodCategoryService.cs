using CalorieCoach.BLL.Dtos.FoodCategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.BLL.AbstractServices
{
    public interface IFoodCategoryService
    {
        void CreateFoodCategory(string categoryName);

        void UpdateFoodCategory(FoodCategoryDto foodCategoryDto);
        void DeleteFoodCategory(int id);
        IEnumerable<FoodCategoryDto> GetAll();

        
    }
}
