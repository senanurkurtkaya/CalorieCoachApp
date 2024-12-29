using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.Entities
{
    public class FoodCategory :BaseEntity
    {
      

        public string CategoryName { get; set; }

        //Bir kategoriye birden fazla yemek ait olabilir
        public  ICollection<FoodPortion>FoodItems { get; set; }
    }
}
