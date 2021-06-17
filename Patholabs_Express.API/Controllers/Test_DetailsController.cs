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
    public class Test_DetailsController : ApiController
    {
        private readonly Test_DetailsService testService;

        public Test_DetailsController()
        {
            testService = new Test_DetailsService();

        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Test_DetailsDto obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                testService.Add(obj);
                return Ok(new Responce() { Success = true, Message = "User Registered Successfully" });
            }

        }

        [HttpGet]
        public IHttpActionResult Get()
        {

            return Ok(new Responce() { Success = true, Message = "User Registered Successfully",Result= testService.getall() });

        }
        [HttpPut]
        public IHttpActionResult UpdateTestPrice([FromBody] Test_DetailsDto obj)

        {
            var item = testService.UpdateTest(obj);
            if (item == true)
            {
                return Ok(new Responce() { Success = true, Message = "Price updated successfully" });
            }
            else
                return BadRequest();
        }

    }
}
