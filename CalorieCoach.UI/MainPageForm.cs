
using AutoMapper;
using CalorieCoach.BLL.AbstractServices;
using CalorieCoach.BLL.ConcreteServices;
using CalorieCoach.BLL.Dtos.UserDtos;
using CalorieCoach.DAL.ConcreteRepositories;
using CalorieCoach.DAL.Data;
using CalorieCoach.DAL.Entities;
using CalorieCoach.UI.FoodWiews;
using CalorieCoach.UI.Views.FoodCategoryViews;
using CalorieCoach.UI.Views.FoodWiews;
using CalorieCoach.UI.Views.MainPageViews;
using CalorieCoach.UI.Views.MealRecordViews;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCoach.UI
{
    public partial class MainPageForm : Form
    {
        private readonly IUserService _userService;

        public UserDto CurrentUser { get; set; }

        public MainPageForm()
        {
            InitializeComponent();
            CurrentUser = null;

            var dbContext = new CalorieCoachDbContext();
            var mapper = new Mapper(new MapperConfiguration(config =>
            {

            }));

            _userService = new UserService(dbContext, mapper);
        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {
           
            //CurrentUser = _userService.GetById(1);

            if (CurrentUser == null)
            {
                var loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog(this);

            }

        }

        private void tsLogout_Click(object sender, EventArgs e)
        {

            CurrentUser = null;
            var loginForm = new LoginForm();
            loginForm.ShowDialog(this);
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsNewRecord_Click(object sender, EventArgs e)
        {

            var newMealRecords = new NewMealRecord(DateTime.Now);
            newMealRecords.ShowDialog(this);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            flpMain.Controls.Clear();

            var newFood = new NewFood();

            flpMain.Controls.Add(newFood);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            flpMain.Controls.Clear();

            var foods = new Foods();

            flpMain.Controls.Add(foods);
        }

        private void tsFoodCategories_Click(object sender, EventArgs e)
        {
            flpMain.Controls.Clear();

            var foodCategories = new FoodCategories();

            flpMain.Controls.Add(foodCategories);
        }

        private void tsMainPage_Click(object sender, EventArgs e)
        {
            flpMain.Controls.Clear();
            var mainPage = new MainPage(CurrentUser.Id);
            flpMain.Controls.Add(mainPage);

        }
        public static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var exception = (Exception)e.ExceptionObject;
            MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tsMealRecords_Click(object sender, EventArgs e)
        {
            flpMain.Controls.Clear();

            var mealRecords = new MealRecords();

            flpMain.Controls.Add(mealRecords);
        }
    }
}
