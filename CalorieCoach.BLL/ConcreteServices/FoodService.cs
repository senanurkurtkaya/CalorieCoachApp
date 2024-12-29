using CalorieCoach.BLL.AbstractServices;
using CalorieCoach.BLL.Dtos.FoodDtos;
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
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IGenericRepository<FoodCategory> _foodCategoryRepository;
        private readonly IGenericRepository<Food> _foodGenericRepository;

     
        public FoodService(CalorieCoachDbContext dbContext)
        {
            _foodRepository = new FoodRepository(dbContext);
            _foodCategoryRepository = new GenericRepository<FoodCategory>(dbContext);
            _foodGenericRepository = new GenericRepository<Food>(dbContext);
        }
        IEnumerable<FoodDto> IFoodService.GetAllFoods()
        {      
            var foods = _foodRepository.GetAllWithCategories();
     
            return foods.Select(x => new FoodDto // 2. Yiyecekleri FoodDTO'ya dönüştür ve döndür
            {
                Id = x.Id,  // Yiyeceğin ID'sini al
                Name = x.Name,  // Yiyeceğin adını al
                ImagePath = x.ImagePath,  // Yiyeceğin görsel yolunu al
                CategoryId = x.Category.Id,  // Yiyeceğin kategori ID'sini al
                CaloriesPerUnit = x.CaloriesPerUnit,  // Yiyeceğin başına kalori miktarını al
                Category = x.Category.CategoryName // Yiyeceğin kategorisinin adını al
            });
        }
        FoodDto IFoodService.GetById(int id)
        {
            var food = _foodRepository.GetByIdWithCategory(id);
            return new FoodDto ///food nesnesi dto ya dönüştürülşdü 
            {
                //foodDto özellikleri food nesnesindeki verilere göre set etttik
                Id = food.Id,// ID'yi al
                Name = food.Name, // Yemek adını al
                CaloriesPerUnit = food.CaloriesPerUnit,// Yiyecek başına kalori miktarını al
                Category =food.Category.CategoryName, // Kategorinin adını al (Category nesnesinden)
                ImagePath = food.ImagePath,// Yemek görselinin yolunu al
                CategoryId =food.Category.Id,// Kategorinin ID'sini al
            };
        }
        public void CreateFood(CreateFoodDto createFoodDto)
        {
           var foodCategory =_foodCategoryRepository.GetById(createFoodDto.CategoryId);
            if(foodCategory == null)
            {
                throw new Exception("Category not found");
            }
            var food = new Food()
            {
                Name = createFoodDto.Name,
                Category = foodCategory,
                CaloriesPerUnit = createFoodDto.CaloriesPerUnit,
                ImagePath = createFoodDto.ImagePath,
                Unit=createFoodDto.Unit,    
            };
            _foodGenericRepository.Add(food);
        }
        public void UpdateFood(UpdateFoodDto updateFoodDto)
        {
            var food = _foodGenericRepository.GetById(updateFoodDto.Id); //Güncellemek sitedigin veriyi getir

            if (food == null)
            {
                throw new Exception("Food Not Found");
            }
            var foodCategory = _foodCategoryRepository.GetById(updateFoodDto.CategoryId);

            food.Name = updateFoodDto.Name;
            food.Category = foodCategory;
            food.ImagePath = updateFoodDto.ImagePath;
            food.CaloriesPerUnit =updateFoodDto.CaloriesPerUnit;

            _foodGenericRepository.Update(food); //veritabanını güncelle
        }

        public IEnumerable<FoodDto> GetAllFoods()
        {
            var foods = _foodRepository.GetAllWithCategories();

            return foods.Select(food => new FoodDto
            {
                Id = food.Id,
                Name = food.Name,
                ImagePath = food.ImagePath,
                CategoryId = food.Category.Id,
                CaloriesPerUnit = food.CaloriesPerUnit,
                Category = food.Category.CategoryName,
                Unit = food.Unit
            });
        }
    }
}
