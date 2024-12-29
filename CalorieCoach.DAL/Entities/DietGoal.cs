using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.Entities
{
    public class DietGoal
    {
        public int Goal { get; set; }
        public DietGoal user { get; set; }
    }
}
