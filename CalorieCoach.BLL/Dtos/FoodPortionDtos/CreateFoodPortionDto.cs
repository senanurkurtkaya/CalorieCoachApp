using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.BLL.Dtos.FoodPortionDtos
{
    public class CreateFoodPortionDto
    {
        public int FoodId { get; set; }

        public decimal Portion { get; set; }
    }
}
