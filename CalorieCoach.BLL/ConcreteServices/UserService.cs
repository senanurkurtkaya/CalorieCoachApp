using AutoMapper;
using CalorieCoach.BLL.AbstractServices;
using CalorieCoach.BLL.Dtos.UserDtos;
using CalorieCoach.DAL.AbstractRepositories;
using CalorieCoach.DAL.ConcreteRepositories;
using CalorieCoach.DAL.Data;
using CalorieCoach.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalorieCoach.BLL.ConcreteServices
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<User> _genericRepository; //BaŞKA TÜRLÜ NASIL YAPABİLİRDİK ?
        private DAL.Data.CalorieCoachDbContext calorieCoachDbContext;

        public UserService(DAL.Data.CalorieCoachDbContext calorieCoachDbContext , IMapper mapper)
        {
            this.calorieCoachDbContext = calorieCoachDbContext;
            _userRepository = new UserRepository(calorieCoachDbContext);
            _mapper = mapper;
            _genericRepository = new GenericRepository<User>(calorieCoachDbContext);    
        }

        public void CreateUser(CreateUserDto userDto ) //yeni kullanıcı kullanıcı kaydı oluşturuluyor
        {
            var user = _mapper.Map<User>(userDto);
            _genericRepository.Add(user);

            
        }

        public UserDto GetById(int id)
        {
            var user = _genericRepository.GetById(id);

            return new UserDto
            {
                Id = user.Id,
                Email = user.Email
            };
        }

        public UserDto GetUserByEmailAndPassword(string Email, string Password)  //kullanıcın dogrulama e posta ve şifre ile 
        {
            var user =_userRepository.GetByEmailAndPassword(Email, Password);
            if(user == null)
            {
                return null;

            }
            return _mapper.Map<UserDto>(user);
        }

        

        public User GetUserByTryLogin(string Email, string Password) //şifre ve e posta ile giriş
        {
            var userExist = _userRepository.GetByEmailAndPassword(Email ,Password);      
            return userExist;
        }

       

        public void ValidateUser(CreateUserDto userDto) //kullanıcı giriş verilerini dogrular 
        {
            if (string.IsNullOrEmpty(userDto.Email))
            {
                throw new Exception("Email address is required!");
            }
            if (string.IsNullOrEmpty(userDto.Password))
            {

                throw new Exception("password is required");
            }
            // password boşsa

            // confirm password boşsa
            if (string.IsNullOrEmpty(userDto.ConfirmPassword))
            {
                throw new Exception("confirm password is required");
            }
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(userDto.Email, emailPattern, RegexOptions.IgnoreCase))
            {
                throw new Exception("An invalid email address!");
            }

            string PasswordPattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[\W_]).{8,}$";

            if (!Regex.IsMatch(userDto.Password, PasswordPattern))
            {
                throw new Exception("Password does not meet strong password guidelines.");
            }

            if(userDto.Password != userDto.ConfirmPassword)
            {
                throw new Exception("confirm password does not match");
            }

            // password ve confirm password eşleşmiyorsa
        }

      
        
    }   
}
