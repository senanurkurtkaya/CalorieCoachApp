using CalorieCoach.BLL.ConcreteServices;
using CalorieCoach.BLL.Dtos.FoodCategoryDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCoach.UI.Views.FoodCategoryViews
{
    public partial class FoodCategories : UserControl
    {
        private readonly FoodCategoryService _foodCategoryService;
        private List<FoodCategoryDto> _foodCategories;
        public FoodCategories()
        {
            InitializeComponent();
            _foodCategoryService = new FoodCategoryService(new DAL.Data.CalorieCoachDbContext());
        }

        private void FoodCategories_Load(object sender, EventArgs e)
        {
            LoadFoodCategories();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedCategory = lbFoodCategories.SelectedItem as FoodCategoryDto;

                if (selectedCategory != null)
                {
                    _foodCategoryService.DeleteFoodCategory(selectedCategory.Id);

                    txtUpdateFoodCategory.Text = string.Empty;

                    LoadFoodCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newCategoryName = txtNewCategory.Text;

                _foodCategoryService.CreateFoodCategory(newCategoryName);

                LoadFoodCategories();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedCategory = lbFoodCategories.SelectedItem as FoodCategoryDto;

                if (selectedCategory != null)
                {
                    selectedCategory.Name = txtUpdateFoodCategory.Text;

                    _foodCategoryService.UpdateFoodCategory(selectedCategory);

                    LoadFoodCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNewCategory_TextChanged(object sender, EventArgs e)
        {
            var newCategoryName = txtNewCategory.Text;

            if (string.IsNullOrEmpty(newCategoryName))
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void LoadFoodCategories()
        {
            lbFoodCategories.Items.Clear();

            _foodCategories = _foodCategoryService.GetAll().ToList();

            foreach (var foodCategory in _foodCategories)
            {
                lbFoodCategories.Items.Add(foodCategory);
            }
        }

        private void txtUpdateFoodCategory_TextChanged(object sender, EventArgs e)
        {
            var newName = txtUpdateFoodCategory.Text;

            if (string.IsNullOrEmpty(newName))
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;
            }

        }

        private void lbFoodCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newCategoryName = txtNewCategory.Text;

            if (string.IsNullOrEmpty(newCategoryName))
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
           
        }
    }
}
