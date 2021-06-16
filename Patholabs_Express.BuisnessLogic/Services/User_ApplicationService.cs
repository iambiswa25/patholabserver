using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patholabs_Express.BuisnessLogic.DTOs;
using Patholabs_Express.DataAccess;
using Patholabs_Express.DataAccess.Entities;
using Patholabs_Express.DataAccess.Repository;

namespace Patholabs_Express.BuisnessLogic.Services
{
    public class User_ApplicationService
    {
        private readonly Application_UserRepository userRepository;
        private readonly UserRepository userRepositoryforuser;



        private readonly Patholabs_ExpressModel context;
        public User_ApplicationService()
        {
            context = new Patholabs_ExpressModel();
            userRepository = new Application_UserRepository();
            userRepositoryforuser = new UserRepository();
        }


        public void Dispose()
        {
            context.Dispose();
        }
        public List<Application_User> GetAll()
        {
            try
            {
                var user = from i in context.application_Users
                           select i;
                return user.ToList();
            }

            catch (System.Data.Common.DbException ex)
            {
                throw new Patholabs_ExpressException("Error reading data", ex);
            }

            catch (Exception ex)
            {
                throw new Patholabs_ExpressException("Unknown error while reading User Admin data", ex);
            }

        }


        public bool Add(UserDto dto)
        {
            try
            {
                if (!userRepository.Exists(dto.Email))
                {
                    dto.UserId = userRepositoryforuser.GetUserId(dto.Email);
                    var user = new Application_User { UserId = dto.UserId, Email = dto.Email, UserType = dto.UserType, Password = dto.Password };
                    return userRepository.Add(user) == 1;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Data.Common.DbException ex)
            {
                throw new Patholabs_ExpressException("Error reading data", ex);
            }

            catch (Exception ex)
            {
                throw new Patholabs_ExpressException("Unknown error while reading User Admin data", ex);
            }

        }




        public bool Authenticate(string email, string password)
        {
            try
            {
                bool Succeded = userRepository.ValidateCredentials(email, password);
                if (Succeded)
                {
                    return Succeded;
                }

                return false;
            }
            catch (System.Data.Common.DbException ex)
            {
                throw new Patholabs_ExpressException("Error reading data", ex);
            }

            catch (Exception ex)
            {
                throw new Patholabs_ExpressException("Unknown error while reading User Admin data", ex);
            }
        }
    }
}
