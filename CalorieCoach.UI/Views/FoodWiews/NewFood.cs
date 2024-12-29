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

namespace CalorieCoach.UI.Views.FoodWiews
{
    public partial class NewFood : UserControl
    {
        //private readonly CreateFoodDto _createFoodDto;
        private readonly IFoodService _foodService;
        private readonly IFoodCategoryService _foodCategoryService;
        private CreateFoodDto _createFoodDto;
        public NewFood()
        {
            InitializeComponent();
            var dbContext = new CalorieCoachDbContext();
            _createFoodDto = new CreateFoodDto();
            _foodService = new FoodService(dbContext);
            _foodCategoryService = new FoodCategoryService(dbContext);

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var appDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var appData = Path.Combine(appDataDirectory, "KaloriTakip");

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
                        if (fileStream.Length > int.MaxValue)
                        {
                            throw new Exception("Image file is too large");
                        }

                        var imageData = binaryReader.ReadBytes((int)fileStream.Length);

                        var fileName = $"{Guid.NewGuid()}.{fileExtension}";
                        var filePath = Path.Combine(appData, fileName);

                        File.WriteAllBytes(filePath, imageData);

                        _createFoodDto.ImagePath = filePath;
                        ToggleSubmitButton();
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _foodService.CreateFood(_createFoodDto);

            MessageBox.Show($"{_createFoodDto.Name} dish added successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            _createFoodDto = new CreateFoodDto();
            txtName.Text = string.Empty;
            cbCategories.SelectedIndex = 0;
            numCaloriesPerUnit.Value = 0;
            pbImage.Image = null;
        }

        private void NewFood_Load(object sender, EventArgs e)
        {
            var categories = _foodCategoryService.GetAll();

            foreach (var category in categories)
            {
                cbCategories.Items.Add(category);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            _createFoodDto.Name = txtName.Text;

            ToggleSubmitButton();
        }

        private void numCaloriesPerUnit_ValueChanged(object sender, EventArgs e)
        {

            _createFoodDto.CaloriesPerUnit = numCaloriesPerUnit.Value;
            ToggleSubmitButton();
        }
        private void ToggleSubmitButton()
        {
            if (string.IsNullOrEmpty(_createFoodDto.Name) || _createFoodDto.CategoryId == default || _createFoodDto.CaloriesPerUnit == default || string.IsNullOrEmpty(_createFoodDto.ImagePath) || string.IsNullOrEmpty(_createFoodDto.Unit))
            {
                btnSubmit.Enabled = false;
            }
            else
            {
                btnSubmit.Enabled = true;
            }
        }
        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var foodCategory = cbCategories.SelectedItem as FoodCategoryDto;

            if (foodCategory != null)
            {
                _createFoodDto.CategoryId = foodCategory.Id;
                ToggleSubmitButton();
            }
        }
        private void txtUnit_TextChanged(object sender, EventArgs e)
        {          
            _createFoodDto.Unit=txtUnit.Text;
        }
    }
}
