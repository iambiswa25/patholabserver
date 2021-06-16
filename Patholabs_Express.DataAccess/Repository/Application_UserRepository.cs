﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patholabs_Express.DataAccess.Entities;

namespace Patholabs_Express.DataAccess.Repository
{
    public class Application_UserRepository
    {
        private readonly Patholabs_ExpressModel context;
        public Application_UserRepository()
        {
            context = new Patholabs_ExpressModel();
        }

        public int Add(Application_User user_app)
        {
            context.application_Users.Add(user_app);
            return context.SaveChanges();
        }




        public bool Exists(string email)
        {
            return context.application_Users.Any(item => item.Email == email);
        }

        public bool ValidateCredentials(string email, string password)
        {
            return context.application_Users.Any(user => user.Email.Equals(email) && user.Password.Equals(password));
        }


        public int GetUserId(string email)
        {
            return context.application_Users.Single(user => user.Email.Equals(email)).UserId;
        }
    }
}