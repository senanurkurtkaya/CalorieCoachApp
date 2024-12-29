using CalorieCoach.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.AbstractRepositories
{
    public interface IUserRepository
    {
        User   GetByEmailAndPassword(string Email, string Password);
        void ValidateUser(string Email ,string Password);


    }
}
