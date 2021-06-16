using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patholabs_Express.BuisnessLogic.DTOs
{
    public class Test_DetailsDto
    {
        [Key]
        public int TestId { get; set; }
        public string TestName { get; set; }
        public int TestPrice { get; set; }
    }
}
