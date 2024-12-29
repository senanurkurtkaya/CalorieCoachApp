using AutoMapper;
using CalorieCoach.BLL.AbstractServices;
using CalorieCoach.BLL.ConcreteServices;
using CalorieCoach.BLL.Dtos.UserDtos;
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
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;

        public LoginForm()
        {
            InitializeComponent();
            var mapper = new Mapper(new MapperConfiguration(config =>
            {
                config.CreateMap<CreateUserDto, User>();
            }));
            _userService = new UserService(new DAL.Data.CalorieCoachDbContext(), mapper);
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();// Burada formu gizliyoruz, ancak Close() ile değil
            registerForm.ShowDialog(this);// Kayıt formu açılırken LoginForm gizli kalır.
            this.Show();// Kayıt formu kapandıktan sonra LoginForm tekrar görünür.

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            var user = _userService.GetUserByTryLogin(txtEmail.Text, txtPassword.Text);

            if (user != null)
            {
                var mainPageForm = (MainPageForm)this.Owner;
                mainPageForm.CurrentUser = new BLL.Dtos.UserDtos.UserDto
                {
                    Id = user.Id,
                    Email = user.Email
                };

                mainPageForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı ya da parola girdiniz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var owner = this.Owner as MainPageForm;
            if (owner == null || owner.CurrentUser == null)
            {
                Application.Exit();
            }
        }

    }
}
