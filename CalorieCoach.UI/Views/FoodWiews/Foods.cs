using CalorieCoach.BLL.AbstractServices;
using CalorieCoach.BLL.ConcreteServices;
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
    public partial class Foods : UserControl
    {
        private readonly IFoodService _foodService;
        public Foods()
        {
            InitializeComponent();
            _foodService = new FoodService(new DAL.Data.CalorieCoachDbContext()); //??
        }

        private void Foods_Load(object sender, EventArgs e)
        {

            LoadFoods();
        }

        public void LoadFoods()
        {
            flpFoodItems.Controls.Clear();
            
            var foods = _foodService.GetAllFoods();

            foreach (var food in foods)
            {
                var foodItem = new FoodItem(food);          
                flpFoodItems.Controls.Add(foodItem);
            }

        }
    }
}
