using CalorieCoach.DAL.AbstractRepositories;
using CalorieCoach.DAL.Data;
using CalorieCoach.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.ConcreteRepositories
{
    public class MealRecordRepository : IMealRecordRepository
    {
        private CalorieCoachDbContext _dbContext;

        public MealRecordRepository(CalorieCoachDbContext dbContext)
        {
           _dbContext = dbContext;
        }

        public IEnumerable<MealRecord> GetAllInLastDay()
        {
            var lastDay = DateTime.Now.AddDays(-1).Date;

            return _dbContext.MealRecords
                .Include(x => x.Portions)
                .ThenInclude(x => x.Food)
                .Where(x => x.Created.Date == lastDay)
                .ToList();
        }

        public IEnumerable<MealRecord> GetAllInLastWeek()
        {
            var now = DateTime.Now.Date;
            var lastWeek = now.AddDays(-7).Date;

            return _dbContext.MealRecords
                .Include(x => x.Portions)
                .ThenInclude(x => x.Food)
                .Where(x => lastWeek < x.Created.Date && x.Created.Date < now)
                .ToList();
        }

        public IEnumerable<MealRecord> GetAllWithPortionsByDateAndUserId(int userId, DateTime dateTime)
        {
            return _dbContext.MealRecords
                 .Include(x => x.Portions)
                 .ThenInclude(x => x.Food)
                 .Where(mealRecord => mealRecord.UserId == userId
                     && mealRecord.Created.Date == dateTime.Date)
                 .ToList();
        }

        public IEnumerable<MealRecord> GetByUserInLastDay(int userId)
        {
            var lastDay = DateTime.Now.AddDays(-1).Date;

            return _dbContext.MealRecords
                .Include(x => x.Portions)
                .ThenInclude(x => x.Food)
                .Where(x => x.Created.Date == lastDay && x.UserId == userId)
                .ToList();
        }

        public IEnumerable<MealRecord> GetByUserInLastWeek(int userId)
        {
            var now = DateTime.Now.Date;
            var lastWeek = now.AddDays(-7).Date;

            return _dbContext.MealRecords
                .Include(x => x.Portions)
                .ThenInclude(x => x.Food)
                .Where(x => lastWeek < x.Created.Date && x.Created.Date < now && x.UserId == userId)
                .ToList();
        }
    }
}
