using CalorieCoach.BLL.AbstractServices;
using CalorieCoach.BLL.ConcreteServices;
using CalorieCoach.BLL.Dtos.FoodCategoryDtos;
using CalorieCoach.BLL.Dtos.FoodDtos;
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
using System.Xml.Linq;

namespace CalorieCoach.UI.Views.FoodWiews
{
    public partial class UpdateFoodForm : Form
    {
        private readonly IFoodService _foodService;
        private readonly IFoodCategoryService _foodCategoryService;
        private readonly UpdateFoodDto _updateFoodDto;

        public UpdateFoodForm(int foodId)
        {
            InitializeComponent();
            var dbContext = new CalorieCoachDbContext();
            _foodService = new FoodService(dbContext);
            _foodCategoryService = new FoodCategoryService(dbContext);

            var food = _foodService.GetById(foodId);

            _updateFoodDto = new UpdateFoodDto()
            {
                Id = food.Id,
                Name = food.Name,
                CaloriesPerUnit = food.CaloriesPerUnit,
                ImagePath = food.ImagePath,
                CategoryId = food.CategoryId,

            };
        }

        private void UpdateFoodForm_Load(object sender, EventArgs e)
        {
            var categories = _foodCategoryService.GetAll().ToList();

            foreach (var category in categories)
            {
                cbCategories.Items.Add(category);
            }
            txtName.Text = _updateFoodDto.Name;
            var selectedCategory = categories.FirstOrDefault(x => x.Id == _updateFoodDto.CategoryId);

            cbCategories.SelectedIndex = categories.IndexOf(selectedCategory);
            numCaloriesPerUnit.Value = _updateFoodDto.CaloriesPerUnit;
            pbImage.Image = Image.FromFile(_updateFoodDto.ImagePath);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var appDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var appData = Path.Combine(appDataDirectory, "CalorieCoach");
            if (!Directory.Exists(appData))
            {
                Directory.CreateDirectory(appData);
            }

            var dialogResult = openFileDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                using (var fileStream = openFileDialog.OpenFile())
                {
                    var fileExtension = openFileDialog.FileName.Split('.').LastOrDefault();
                    pbImage.Image = Image.FromFile(openFileDialog.FileName);

                    using (BinaryReader binaryReader = new BinaryReader(fileStream))
                    {
                        if (fileStream.Length > int.MinValue)
                        {
                            throw new Exception("Image file is too large");
                        }

                        var imageDate = binaryReader.ReadBytes((int)fileStream.Length);

                        var fileName = $"{Guid.NewGuid()}.{fileExtension}";
                        var filePath = Path.Combine(appData, fileName);

                        File.WriteAllBytes(filePath, imageDate);

                        _updateFoodDto.ImagePath = filePath;
                        ToggleSubmitButton();
                    }
                }
            }
        }

        private void ToggleSubmitButton()
        {
            if (string.IsNullOrEmpty(_updateFoodDto.Name) || _updateFoodDto.CategoryId == default || _updateFoodDto.CaloriesPerUnit == default || string.IsNullOrEmpty(_updateFoodDto.ImagePath))
            {
                btnSubmit.Enabled = false;
            }
            else
            {
                btnSubmit.Enabled = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _foodService.UpdateFood(_updateFoodDto);

            MessageBox.Show($"{_updateFoodDto.Name} yemeği başarılı bir şekilde güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void numCaloriesPerUnit_ValueChanged(object sender, EventArgs e)
        {
            _updateFoodDto.CaloriesPerUnit = numCaloriesPerUnit.Value;
            ToggleSubmitButton() ;
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var foodCategory = cbCategories.SelectedItem as FoodCategoryDto;
            if (foodCategory != null)
            {
                _updateFoodDto.CategoryId = foodCategory.Id;
                ToggleSubmitButton();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

            _updateFoodDto.Name = txtName.Text;

            ToggleSubmitButton();

        }

    }
}
