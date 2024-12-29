using CalorieCoach.BLL.ConcreteServices;
using CalorieCoach.BLL.Dtos.FoodDtos;
using CalorieCoach.BLL.Dtos.FoodPortionDtos;
using CalorieCoach.BLL.Dtos.MealRecordDtos;
using CalorieCoach.DAL.Data;
using CalorieCoach.DAL.Entities;
using CalorieCoach.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCoach.UI.Views.MealRecordViews
{

    public partial class NewMealRecord : Form
    {
        private readonly List<MealType> _mealTypes = new List<MealType>
        {
            MealType.Breakfast,
            MealType.Launch,
            MealType.Dinner,
            MealType.Snack
        };

        private readonly DateTime _date;

        private readonly FoodService _foodService;
        private readonly MealRecordService _mealRecordService;

        private List<FoodDto> _foods;
        public NewMealRecord(DateTime date)
        {
            InitializeComponent();
            var dbContext = new CalorieCoachDbContext();
            _foodService = new FoodService(dbContext);
            _mealRecordService = new MealRecordService(dbContext);
            _date = date;

        }

        public void RemoveFood(AddFoodToMeal addFoodToMeal)
        {
            var indexOfFood = flpFoods.Controls.IndexOf(addFoodToMeal);
            flpFoods.Controls.RemoveAt(indexOfFood);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                var mainPageForm = (MainPageForm)this.Owner;
                var mealType = (MealType)cbMealTypes.SelectedIndex;

                List<CreateFoodPortionDto> foodPortionDTOs = new List<CreateFoodPortionDto>();
                foreach (var control in flpFoods.Controls)
                {
                    if (control is AddFoodToMeal addFoodToMeal)
                    {
                        foodPortionDTOs.Add(addFoodToMeal.FoodPortion);
                    }
                }

                var createMealRecordDto = new CreateMealRecordDto
                {
                    UserId = mainPageForm.CurrentUser.Id,
                    MealType = mealType,
                    FoodPortions = foodPortionDTOs,
                    Date = _date
                };

                _mealRecordService.CreateMealRecord(createMealRecordDto);

                MessageBox.Show("Meal record has been created successfully..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var addFoodToMeal = new AddFoodToMeal(_foods);

            addFoodToMeal.Width = flpFoods.Width;

            flpFoods.Controls.Add(addFoodToMeal);
        }

        private void NewMealRecord_Load(object sender, EventArgs e)
        {
            foreach (var mealType in _mealTypes)
            {
                cbMealTypes.Items.Add(mealType);
            }

            var foods = _foodService.GetAllFoods();

            _foods = foods.ToList();
        }
    }
}
