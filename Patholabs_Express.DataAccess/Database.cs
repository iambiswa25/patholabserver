using System;
using System.Data.Entity;
using System.Linq;

namespace Patholabs_Express.DataAccess
{
    public class Database : DbContext
    {
        
        public Database()
            : base("name=Database")
        {
        }

       
    }

   
}