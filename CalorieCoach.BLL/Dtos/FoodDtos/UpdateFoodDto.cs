using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.BLL.Dtos.FoodDtos
{
    public class UpdateFoodDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ImagePath { get; set; }

        public int CategoryId { get; set; }

        public decimal CaloriesPerUnit { get; set; }
    }
}
