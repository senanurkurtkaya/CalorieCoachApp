using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.BLL.Dtos.FoodPortionDtos
{
    public class FoodPortionDto
    {
        public string FoodName { get; set; }

        public string ImagePath { get; set; }

        public decimal CaloriesPerUnit { get; set; }

        public string FoodUnit { get; set; }

        public decimal Portion { get; set; }
    }
}
