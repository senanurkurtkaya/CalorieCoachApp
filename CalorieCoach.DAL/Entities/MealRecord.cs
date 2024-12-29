using CalorieCoach.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.Entities
{
    public class MealRecord :BaseEntity
    {
       
        public int UserId { get; set; }

        public User User { get; set; }

        //public ICollection<FoodItem> FoodItems { get; set; }

        public MealType MealType { get; set; }

        public List<FoodPortion> Portions { get; set; }

       


    }
}
