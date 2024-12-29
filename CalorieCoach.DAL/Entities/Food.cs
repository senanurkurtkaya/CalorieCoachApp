using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.Entities
{
    public class Food :BaseEntity
    {
        public int Id { get; set; } //Base entityden miras alıyor ama repoda metodun içinde kullanamadın !!
        public string Name { get; set; }
        public  string ImagePath { get; set; }

        public FoodCategory Category { get; set; }
        public decimal CaloriesPerUnit { get; set; }
        public string Unit { get; set; }
    }
}
