using CalorieCoach.BLL.Dtos.FoodDtos;
using CalorieCoach.BLL.Dtos.FoodPortionDtos;
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
    public partial class AddFoodToMeal : UserControl
    {
        private readonly List<FoodDto> _foods;

        public AddFoodToMeal(List<FoodDto> foods)
        {
            InitializeComponent();
            _foods = foods;
        }
        public CreateFoodPortionDto FoodPortion { get; set; } = new CreateFoodPortionDto();

        private void AddFoodToMeal_Load(object sender, EventArgs e)
        {
            foreach (var food in _foods)
            {
                cbFood.Items.Add(food);
            }
        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            var foodDto = (FoodDto)cbFood.SelectedItem;
            lblUnit.Text = foodDto.Unit;
            FoodPortion.FoodId = foodDto.Id;
        }

        private void numPortion_ValueChanged(object sender, EventArgs e)
        {
            FoodPortion.Portion = numPortion.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newMealRecord = ((NewMealRecord)this.Parent.Parent);
            newMealRecord.RemoveFood(this);
        }
    }
}
