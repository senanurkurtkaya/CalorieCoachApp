using AutoMapper;
using CalorieCoach.BLL.AbstractServices;
using CalorieCoach.BLL.ConcreteServices;
using CalorieCoach.BLL.Dtos.UserDtos;
using CalorieCoach.DAL.ConcreteRepositories;
using CalorieCoach.DAL.Data;
using CalorieCoach.DAL.Entities;
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
    /// <summary>
    //BURALARIANLAMADIM
    /// </summary>
    public partial class RegisterForm : Form
    {
        private readonly IUserService _userService;

        public RegisterForm()
        {
            InitializeComponent();
            var dbContext = new CalorieCoachDbContext();    
            var mapper = new Mapper(new MapperConfiguration(config =>
            {
                config.CreateMap<CreateUserDto, User>(); 
            }));
            _userService = new UserService(dbContext, mapper);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            var loginForm = (LoginForm)Owner;
            //LoginForm loginForm = new LoginForm(_userService);
            this.Hide();
            loginForm.Show();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var CreateUserDto = new BLL.Dtos.UserDtos.CreateUserDto { ConfirmPassword = txtConfirmPassword.Text, Email = txtEmail.Text, Password = txtPassword.Text };
                _userService.ValidateUser(CreateUserDto);

                _userService.CreateUser(CreateUserDto);

               

                var loginForm = (LoginForm)Owner;
                //LoginForm loginForm = new LoginForm(_userService);
                this.Hide();
                loginForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }   
    }
}
