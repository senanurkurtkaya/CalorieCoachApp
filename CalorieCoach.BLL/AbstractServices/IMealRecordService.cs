using CalorieCoach.BLL.Dtos.MealRecordDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.BLL.AbstractServices
{
    public interface IMealRecordService
    {
      
        void CreateMealRecord(CreateMealRecordDto createMealRecordDto);
        IEnumerable<MealRecordDto> GetMealRecordsByDate(int userId, DateTime dateTime);

    }
}
