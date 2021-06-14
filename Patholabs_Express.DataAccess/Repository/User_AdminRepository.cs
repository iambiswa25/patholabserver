using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patholabs_Express.DataAccess.Entities;

namespace Patholabs_Express.DataAccess.Repository
{
    public class User_AdminRepository
    {
        private readonly Patholabs_ExpressModel context;
        public User_AdminRepository()
        {
            context = new Patholabs_ExpressModel();
        }

        public int Add(User_Admin user_Admins)
        {
            context.User_Admins.Add(user_Admins);
            return context.SaveChanges();
        }
        public List<User_Admin> getUserlist()
        {
            return context.User_Admins.Where(a => a.IsAdmin == true).ToList();
            
        }



        public bool Exists(string email)
        {
            return context.User_Admins.Any(item => item.Email == email);
        }

        public bool ValidateCredentials(string email, string password)
        {
            return context.User_Admins.Any(user => user.Email.Equals(email) && user.Password.Equals(password));
        }


        public int GetUserId(string email)
        {
            return context.User_Admins.Single(user => user.Email.Equals(email)).Id;
        }
    }
}
