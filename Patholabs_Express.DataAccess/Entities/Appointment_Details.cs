using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patholabs_Express.DataAccess.Entities
{
    public class Appointment_Details

    {
        [Key]
        public int AppointmentId { get; set; }

        public int TestId { get; set; }
        public Test_Details Test_Details { get; set; }
        public string CustomerName { get; set; }
        public DateTime App_Book_Time { get; set; }

        public string Email { get; set; }
        public DateTime App_Date_Time { get; set; }
        public bool Status { get; set; }
        public int CreatorUserId { get; set; }

    }
}
