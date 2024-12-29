using CalorieCoach.BLL.Dtos.FoodPortionDtos;
using CalorieCoach.DAL.Entities;
using CalorieCoach.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.BLL.Dtos.MealRecordDtos
{
    public class CreateMealRecordDto
    {
        public MealType MealType { get; set; }

        public int UserId { get; set; }

        //public ICollection<FoodItem> FoodPortions { get; set; }
        public List<CreateFoodPortionDto> FoodPortions { get; set; }

        public DateTime Date { get; set; }
    }
}
