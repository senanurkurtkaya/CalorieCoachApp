using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.Entities
{
    public class Report: BaseEntity
    {
       

        public int UserId { get; set; }

        public User User { get; set; }

        public DateTime ReportDate { get; set; }
        public double TotalCalories { get; set; }

        public double AverageCalories  { get; set; }

    }
}
