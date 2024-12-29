using CalorieCoach.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.AbstractRepositories
{
    public interface IMealRecordRepository
    {
        IEnumerable<MealRecord> GetAllWithPortionsByDateAndUserId(int userId, DateTime dateTime);

        IEnumerable<MealRecord> GetByUserInLastDay(int userId);

        IEnumerable<MealRecord> GetByUserInLastWeek(int userId);

        IEnumerable<MealRecord> GetAllInLastDay();

        IEnumerable<MealRecord> GetAllInLastWeek();
    }
}
