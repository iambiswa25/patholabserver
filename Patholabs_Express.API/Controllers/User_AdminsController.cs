using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Patholabs_Express.API.Models;
using Patholabs_Express.BuisnessLogic;
using Patholabs_Express.DataAccess;
using Patholabs_Express.DataAccess.Entities;
using Patholabs_Express.DataAccess.Repository;

namespace Patholabs_Express.API.Controllers
{
    public class User_AdminsController : ApiController
    {
        private readonly User_AdminService userService;

        public User_AdminsController()
        {
            userService = new User_AdminService();

        }

        [HttpPost]
        public IHttpActionResult Add([FromBody]User_AdminDto obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                userService.Add(obj);
                return Ok(new Responce() {Success=true,Message="User Registered Successfully" });
            }

        }
        [HttpGet]
        public IHttpActionResult Get()
        {

                return Ok(userService.getall());
            

        }


    }
}
