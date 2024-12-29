using CalorieCoach.BLL.AbstractServices;
using CalorieCoach.BLL.ConcreteServices;
using CalorieCoach.DAL.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalorieCoach.UI.Views.MealRecordViews
{
    public partial class MealRecordsByDate : UserControl
    {
        private readonly DateTime _date;
        private readonly int _userId;
        private readonly IMealRecordService _mealRecordService;
        public MealRecordsByDate(int userId ,DateTime date)
        {
            InitializeComponent();
            _date = date;
            _userId = userId;

            var dbContext = new CalorieCoachDbContext();
            _mealRecordService = new MealRecordService(dbContext);
        }

        private void MealRecordsByDate_Load(object sender, EventArgs e)
        {
            var mealRecords = _mealRecordService.GetMealRecordsByDate(_userId, _date);

            foreach (var mealRecord in mealRecords)
            {
                var mealRecordItem = new MealRecordItem(mealRecord);

                flpMainContainer.Controls.Add(mealRecordItem);
            }
        }
    }
}
