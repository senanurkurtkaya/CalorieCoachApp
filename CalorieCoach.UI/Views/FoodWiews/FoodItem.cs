using CalorieCoach.BLL.Dtos.FoodDtos;
using CalorieCoach.UI.Views.FoodWiews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCoach.UI.FoodWiews
{
    public partial class FoodItem : UserControl
    {
        private readonly FoodDto _foodDto;

        public FoodItem(FoodDto foodDto)
        {
            InitializeComponent();
            _foodDto = foodDto;
        }

        private void FoodItem_Load(object sender, EventArgs e)
        {
            pbFoodImage.Image = Image.FromFile(_foodDto.ImagePath);
            lblFoodName.Text = _foodDto.Name;
            lblCategory.Text = _foodDto.Category;
            lblCaloriesPerUnit.Text = _foodDto.CaloriesPerUnit.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateFoodForm = new UpdateFoodForm(_foodDto.Id);
            var dialogResult = updateFoodForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var foodsView = this.Parent.Parent as Foods;

                foodsView.LoadFoods();
            }
        }
    }
}
