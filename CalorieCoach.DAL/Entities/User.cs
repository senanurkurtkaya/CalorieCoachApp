using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.Entities
{
    public class User :BaseEntity

    {
        public string? Email { get; set; }   

        public string? Password { get; set; }


        public List<MealRecord> MealRecords { get; set; }
        //Bir Kullanıcının birden fazla öğünü olabilirr 
        //public ICollection<MealRecord> Meals { get; set; }
    }
}
