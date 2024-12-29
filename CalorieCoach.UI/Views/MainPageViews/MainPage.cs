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

namespace CalorieCoach.UI.Views.MainPageViews
{
    public partial class MainPage : UserControl
    {

        private readonly IReportService _reportService;
        private readonly int _currentUserId;
        public MainPage(int userId)
        {

            InitializeComponent();
            var dbContext = new CalorieCoachDbContext();
            _reportService = new ReportService(dbContext);

            _currentUserId = userId;
        }

        private void MainPager_Load(object sender, EventArgs e)
        {
            var mostPreferredFoodInLastWeekByUser = _reportService.MostPreferredFoodInLastWeekByUser(_currentUserId);
            var lastWeekHighestCaloriesByUser = _reportService.LastWeekHighestCaloriesByUser(_currentUserId);
            var lastDayCaloriesByUser = _reportService.LastDayCaloriesByUser(_currentUserId);
            var weeklyAvgCaloriesByUser = _reportService.WeeklyAvgCaloriesByUser(_currentUserId);

            var lastWeekHighestCaloriesByUserLabel = new Label();
            lastWeekHighestCaloriesByUserLabel.Size = new Size(flpUserReports.Width, lastWeekHighestCaloriesByUserLabel.Height);
            lastWeekHighestCaloriesByUserLabel.Text = $"Last week's highest calories: {lastWeekHighestCaloriesByUser.Portion * lastWeekHighestCaloriesByUser.CaloriesPerUnit} cal";

            flpUserReports.Controls.Add(lastWeekHighestCaloriesByUserLabel);

            var lastDayCaloriesByUserLabel = new Label();
            lastDayCaloriesByUserLabel.Size = new Size(flpUserReports.Width, lastDayCaloriesByUserLabel.Height);
            lastDayCaloriesByUserLabel.Text = $"Last day's calories {lastDayCaloriesByUser} cal";

            flpUserReports.Controls.Add(lastDayCaloriesByUserLabel);

            var weeklyAvgCaloriesByUserLabel = new Label();
            weeklyAvgCaloriesByUserLabel.Size = new Size(flpUserReports.Width, weeklyAvgCaloriesByUserLabel.Height);
            weeklyAvgCaloriesByUserLabel.Text = $"Average calories last week: {weeklyAvgCaloriesByUser} cal";

            flpUserReports.Controls.Add(weeklyAvgCaloriesByUserLabel);

            var mostPreferredFoodInLastWeekByUserLabel = new Label();
            mostPreferredFoodInLastWeekByUserLabel.Size = new Size(flpUserReports.Width, mostPreferredFoodInLastWeekByUserLabel.Height);
            mostPreferredFoodInLastWeekByUserLabel.Text = $"What was your favorite meal last week?: {mostPreferredFoodInLastWeekByUser?.Name} / {mostPreferredFoodInLastWeekByUser?.CaloriesPerUnit ?? 0} cal";

            flpUserReports.Controls.Add(mostPreferredFoodInLastWeekByUserLabel);

            var mostPopularFoodInLastWeek = _reportService.MostPopularFoodInLastWeek();
            var lastDayAvgCalories = _reportService.LastDayAvgCalories();
            var weeklyAvgCalories = _reportService.WeeklyAvgCalories();

            var lastDayAvgCaloriesLabel = new Label();
            lastDayAvgCaloriesLabel.Size = new Size(groupBox2.Width, lastDayAvgCaloriesLabel.Height);
            lastDayAvgCaloriesLabel.Text = $"Average calories of the last day: {lastDayAvgCalories} cal";

            groupBox2.Controls.Add(lastDayAvgCaloriesLabel);

            var weeklyAvgCaloriesLabel = new Label();
            weeklyAvgCaloriesLabel.Size = new Size(groupBox2.Width, weeklyAvgCaloriesLabel.Height);
            weeklyAvgCaloriesLabel.Text = $"Average calories last week: {weeklyAvgCalories} cal";
            groupBox2.Controls.Add(weeklyAvgCaloriesLabel);

            var mostPopularFoodInLastWeekLabel = new Label();
            mostPopularFoodInLastWeekLabel.Size = new Size(groupBox2.Width, mostPopularFoodInLastWeekLabel.Height);
            mostPopularFoodInLastWeekLabel.Text = $"most popular dish: {mostPopularFoodInLastWeek?.Name} / {mostPopularFoodInLastWeek?.CaloriesPerUnit ?? 0} cal";

            groupBox2.Controls.Add(mostPopularFoodInLastWeekLabel);
        }

       
    }
}
