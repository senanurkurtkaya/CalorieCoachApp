using CalorieCoach.BLL.Dtos.MealRecordDtos;
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
    public partial class MealRecordItem : UserControl
    {
        private readonly MealRecordDto _mealRecordDto;
        public MealRecordItem(MealRecordDto mealRecordDto)
        {
            InitializeComponent();
            _mealRecordDto = mealRecordDto;
        }

        private void MealReacordItem_Load(object sender, EventArgs e)
        {
            lblMealType.Text = _mealRecordDto.MealType.ToString();
            lblTime.Text =_mealRecordDto.CreatedAt.ToString("HH:mm");
            lblCalories.Text = _mealRecordDto.Portions
                .Sum(Portion => Portion.CaloriesPerUnit * Portion.Portion).ToString();

            foreach (var portionDto in _mealRecordDto.Portions)
            {
                Label label = new Label();
                label.Text = $"{portionDto.Portion} {portionDto.FoodUnit} {portionDto.FoodName} - {portionDto.CaloriesPerUnit * portionDto.Portion} cal";
                label.Size = new Size(flpFoodPortions.Width,label.Height);

                flpFoodPortions.Controls.Add(label);
            }
        }
    }
}
