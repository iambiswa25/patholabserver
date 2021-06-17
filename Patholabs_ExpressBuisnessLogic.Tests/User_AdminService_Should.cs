using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Patholabs_Express.BuisnessLogic;

namespace Patholabs_ExpressBuisnessLogic.Tests
{
    [TestFixture]
    public class User_AdminService_Should
    {
        private User_AdminService service;
        [OneTimeSetUp]
        public void Init()
        {
            service = new User_AdminService();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            service.Dispose();
        }
        [Test]
        public void Return_All_User_Admins()
        {
            var user = service.GetAll();
            CollectionAssert.IsNotEmpty(user);
            
        }
        [Test]
        public void Return_All_Admins()
        {
            var admin = service.GetAllActive();
            CollectionAssert.IsNotEmpty(admin);

        }

        [Test]
        public void Return_Credentials()
        {
            bool log = service.Authenticate("gunnu@gmail.com", "sej@12",Patholabs_Express.DataAccess.Entities.enUserType.Admin);
            bool x = true;
            Assert.AreEqual(x, log);
        }

      
    }
}
