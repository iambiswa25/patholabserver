using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patholabs_Express.DataAccess.Entities;

namespace Patholabs_Express.DataAccess.Repository
{
    public class Test_DetailsRepository
    {
        private readonly Patholabs_ExpressModel context;
        public Test_DetailsRepository()
        {
            context = new Patholabs_ExpressModel();
        }
        public List<Test_Details> Get()
        {
            return context.TestDetail.ToList();
        }

        public int Add(Test_Details testdetail)
        {
            context.TestDetail.Add(testdetail);
            return context.SaveChanges();
        }

        public bool Exists(int testId)
        {
            return context.TestDetail.Any(item => item.TestId == testId);
        }


        public int Update(Test_Details test)
        {
            context.TestDetail.Attach(test);
            context.Entry(test).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public Test_Details TestItem(int TestId)
        {
            return context.TestDetail.Find(TestId);
        }




    }
}
