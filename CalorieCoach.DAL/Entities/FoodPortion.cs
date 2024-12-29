using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.Entities
{
    public class FoodPortion :BaseEntity
    {
        public MealRecord MealRecord { get; set; }
        
        public Food Food { get; set; }

        public int FoodId { get; set; }
        public decimal Portion { get; set; }
    }
}
