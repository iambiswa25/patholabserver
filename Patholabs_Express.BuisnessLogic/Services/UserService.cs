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
    public class UserService
    {
        private readonly UserRepository userRepository;



        private readonly Patholabs_ExpressModel context;
        public UserService()
        {
            context = new Patholabs_ExpressModel();
            userRepository = new UserRepository();
        }


        public void Dispose()
        {
            context.Dispose();
        }
        public List<User> GetAll()
        {
            try
            {
                var user = from i in context.Users
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

                    var user = new User { UserId = dto.UserId, Name = dto.Name, Address = dto.Address, Age = dto.Age, Gender = dto.Gender, Email = dto.Email, Contact_No = dto.Contact_No };
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

    }
}
