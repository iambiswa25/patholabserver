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
    public class Appointment_DetailsService
    {
        private readonly Appointment_DetailsRepository appDetailsRepository;



        private readonly Patholabs_ExpressModel context;
        public Appointment_DetailsService()
        {
            context = new Patholabs_ExpressModel();
            appDetailsRepository = new Appointment_DetailsRepository();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool Add(Appointment_DetailsDto dto)
        {
            var user = new Appointment_Details { TestId = dto.TestId, CustomerName = dto.CustomerName, Email = dto.Email, App_Book_Time = Convert.ToDateTime(dto.App_Book_Time), App_Date_Time = Convert.ToDateTime(dto.App_Date_Time), Status = dto.Status, CreatorUserId = dto.CreatorUserId };
            return appDetailsRepository.Add(user) == 1;
        }
        public bool Remove(int appointmentId)
        {
            return appDetailsRepository.Remove(appointmentId) == 1;
        }
        public IEnumerable<Appointment_DetailsDto> GetAppDetails(int creatorid)
        {
            var details = appDetailsRepository.GetDetails(creatorid);
            var Dtos = new List<Appointment_DetailsDto>();
            foreach (var item in details)
                Dtos.Add(new Appointment_DetailsDto
                {
                    AppointmentId = item.AppointmentId,
                    TestId = item.TestId,
                    CustomerName = item.CustomerName,
                    App_Book_Time = item.App_Book_Time,
                    Email = item.Email,
                    App_Date_Time = item.App_Date_Time,
                    Status = item.Status,
                    CreatorUserId = item.CreatorUserId
                });
            return Dtos;
        }

    }
}
