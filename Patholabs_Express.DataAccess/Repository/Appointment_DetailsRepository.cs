using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patholabs_Express.DataAccess.Entities;

namespace Patholabs_Express.DataAccess.Repository
{
    public class Appointment_DetailsRepository
    {
        private readonly Patholabs_ExpressModel context;
        public Appointment_DetailsRepository()
        {
            context = new Patholabs_ExpressModel();
        }
        public int Add(Appointment_Details appointment_Details)
        {
            context.Appointment_details.Add(appointment_Details);
            return context.SaveChanges();
        }
        public int Remove(int AppointmentId)
        {
            var app1 = context.Appointment_details.Find(AppointmentId);
            context.Appointment_details.Remove(app1);
            return context.SaveChanges();
        }
        //appointmnets details to user by creator id
        public IEnumerable<Appointment_Details> GetDetails(int creatorid)
        {
            var Query = from appDetails in context.Appointment_details
                        where appDetails.CreatorUserId == creatorid
                        select appDetails;
            return Query.ToList();
        }
    }
}
