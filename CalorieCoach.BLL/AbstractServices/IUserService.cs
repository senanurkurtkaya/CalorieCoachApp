using CalorieCoach.BLL.Dtos.UserDtos;
using CalorieCoach.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.BLL.AbstractServices
{
    public interface IUserService
    {
        void ValidateUser(CreateUserDto userDto); //kullanıcı girişleri ve e posta şifre kontrolü,

        User GetUserByTryLogin(string Email, string Password); //giriş yap

        UserDto GetUserByEmailAndPassword(string Email,string PassWord); //kull
       

        void CreateUser(CreateUserDto userDto); //kullanıc kaydı

        UserDto GetById(int id);

        
    }
}
