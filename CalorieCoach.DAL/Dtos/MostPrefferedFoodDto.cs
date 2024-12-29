using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.Dtos
{
    public class MostPrefferedFoodDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal CaloriesPerUnit { get; set; }

        public string ImagePath { get; set; }

        public int Count { get; set; }
    }
}
