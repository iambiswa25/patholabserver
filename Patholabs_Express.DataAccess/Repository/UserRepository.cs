using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patholabs_Express.DataAccess.Entities;

namespace Patholabs_Express.DataAccess.Repository
{
    public class UserRepository
    {
        private readonly Patholabs_ExpressModel context;
        public UserRepository()
        {
            context = new Patholabs_ExpressModel();
        }

        public int Add(User user)
        {
            context.Users.Add(user);
            return context.SaveChanges();
        }

        public int GetUserId(string email)
        {
            return context.Users.Single(user => user.Email.Equals(email)).UserId;
        }

        public bool Exists(string email)
        {
            return context.Users.Any(item => item.Email == email);
        }

    }
}
