using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patholabs_Express.DataAccess.Entities
{
    public class Test_Details
    {
        [Key]
        public int TestId { get; set; }
        public string TestName { get; set; }
        public int TestPrice { get; set; }
    }
}
