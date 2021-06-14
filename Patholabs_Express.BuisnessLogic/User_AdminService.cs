using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patholabs_Express.API.Models;
using Patholabs_Express.DataAccess;
using Patholabs_Express.DataAccess.Entities;
using Patholabs_Express.DataAccess.Repository;

namespace Patholabs_Express.BuisnessLogic
{
    public class User_AdminService: IDisposable
        
    {
        private readonly User_AdminRepository userRepository;



        private readonly Patholabs_ExpressModel context;
        public User_AdminService()
        {
            context = new Patholabs_ExpressModel();
            userRepository = new User_AdminRepository();
        }

      
        public void Dispose()
        {
            context.Dispose();
        }
        public List<User_Admin> GetAll()
        {
            try
            {
                var user = from i in context.User_Admins
                           select i;
                return user.ToList();
            }

            catch(System.Data.Common.DbException ex)
            {
                throw new Patholabs_ExpressException("Error reading data", ex);
            }

            catch (Exception ex)
            {
                throw new Patholabs_ExpressException("Unknown error while reading User Admin data", ex);
            }

        }

        public List<User_Admin> GetAllActive()
        {
            try
            {
                var user = from i in context.User_Admins
                           where i.IsAdmin == true
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

        public bool Add(User_AdminDto dto)
        {
            if (!userRepository.Exists(dto.Email))
            {

                var user = new User_Admin { Id = dto.Id, Name = dto.Name, Address = dto.Address, Age = dto.Age, Gender=dto.Gender, Email=dto.Email, Contact_No=dto.Contact_No,IsAdmin=dto.IsAdmin, Password=dto.Password };
                return userRepository.Add(user) == 1;
            }
            else
            {
                return false;
            }
        }
        public List<User_Admin>  getall()
        {
           return userRepository.getUserlist();
        }


        public bool Authenticate(string email, string password)
        {
           
            bool Succeded = userRepository.ValidateCredentials(email, password);
            if (Succeded)
            {
                return Succeded;
            }
                
            return false;
        }

       
    }
}
