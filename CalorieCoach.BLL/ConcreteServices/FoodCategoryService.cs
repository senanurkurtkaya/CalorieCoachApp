using CalorieCoach.BLL.AbstractServices;
using CalorieCoach.BLL.Dtos.FoodCategoryDtos;
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
    public class FoodCategoryService : IFoodCategoryService
    {
        private readonly CalorieCoachDbContext _dbContext;
        private readonly GenericRepository<FoodCategory> _genericRepository;

        public FoodCategoryService(CalorieCoachDbContext dbContext)
        {
            _dbContext = dbContext;
            _genericRepository = new GenericRepository<FoodCategory>(dbContext);
        }                       
    
        public void CreateFoodCategory(string categoryName)
        {
            _genericRepository.Add(new FoodCategory
            {
                CategoryName = categoryName
            });
        }

     

        public void DeleteFoodCategory(int id)
        {
            var foodCategory = _genericRepository.GetById(id);

            _genericRepository.Delete(foodCategory);
        }

        public IEnumerable<FoodCategoryDto> GetAll()
        {
            var foodCategories = _genericRepository.GetAll();
            return foodCategories.Select(x => new FoodCategoryDto
            {
                Id = x.Id,
                Name= x.CategoryName
            });
        }

       

        public void UpdateFoodCategory(FoodCategoryDto foodCategoryDto)
        {
            var foodCategory = _genericRepository.GetById(foodCategoryDto.Id);
            foodCategory.CategoryName = foodCategoryDto.Name;
            _genericRepository.Update(foodCategory);
        }
    }
}
