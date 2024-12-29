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
    public class MealRecordDto
    {
        public int Id { get; set; }

        public MealType MealType { get; set; }

        //public ICollection<FoodItem> FoodItems { get; set; }

        public List<FoodPortionDto> Portions { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
