using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Patholabs_Express.BuisnessLogic.DTOs;
using Patholabs_Express.BuisnessLogic.Services;
using Patholabs_Express.DataAccess.Entities;

namespace Patholabs_Express.API.Controllers
{
    public class Appointment_DetailsController : ApiController
    {
        private readonly Appointment_DetailsService appDetailsService;

        public Appointment_DetailsController()
        {
            appDetailsService = new Appointment_DetailsService();
        }
        [HttpPost]
        public IHttpActionResult Add([FromBody] Appointment_DetailsDto obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                appDetailsService.Add(obj);
                return Ok(new Responce() { Success = true, Message = "Appointment Booked Successfully" });
            }

        }
        //Cancel Appointment
        [HttpDelete]
        [Route("api/Appintment_Details/Delete/{AppointmentId}")]
        public IHttpActionResult Delete([FromUri] int AppointmentId)
        {
            var Removed = appDetailsService.Remove(AppointmentId);
            if (Removed == true)
                return Ok(new Responce() { Success = true, Message = "Appointment Cancelled Successfully" });
            return BadRequest();
        }

        //get by id Appointmentdetails
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var Items = appDetailsService.GetAppDetails(id);
            if (Items != null)
                return Ok(Items);
            return NotFound();
        }

    }
}
