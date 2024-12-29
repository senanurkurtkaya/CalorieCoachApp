using CalorieCoach.DAL.AbstractRepositories;
using CalorieCoach.DAL.Data;
using CalorieCoach.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.ConcreteRepositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CalorieCoachDbContext _context;
        DbSet<User> _users;

        public UserRepository(CalorieCoachDbContext context)
        {
            _context = context;
            _users = _context.Set<User>();
        }
       // public User GetByEmailAndPassword(string Email, string Password)
       // {
            
        public User GetByEmailAndPassword(string Email, string Password)
        {
            return _users.FirstOrDefault(u => u.Email == Email && u.Password == Password);
        }

        public void ValidateUser(string Email, string Password)
        {
            var user = _users.FirstOrDefault(u => u.Email == Email && u.Password == Password);
            if (user == null)
            {
                throw new Exception("Geçersiz e-posta veya şifre.");
            }

        }
    }
    //public User GetUserByTryLogin(string Email, string Password)
    //{
    //    var user =_users.FirstOrDefault(u => u.Email == Email && u.Password == Password);
    //    if (user == null)
    //    {
    //        throw new Exception("Geçersiz e-posta veya şifre.");
    //    }
    //    return user;
    //}


}

