using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace server.Controllers
{
    [EnableCors("*", "*", "*")]
    public class UserController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage Login([FromBody] User user)
        {
            User us = DB.UsersList.Find(u => u.userName == user.userName && u.userPassword == user.userPassword);
            if (us != null)
                return Request.CreateResponse(HttpStatusCode.OK, us);
            us = DB.UsersList.Find(u => u.userName == user.userName);
            if (us != null)
                return Request.CreateResponse(HttpStatusCode.Conflict, us);
            return Request.CreateResponse(HttpStatusCode.NotFound, us);
        }



        [HttpGet]
        public List<User> GetAllUsers()
        {
            return DB.UsersList;
        }

        [HttpPost]
        public IHttpActionResult Register([FromBody] User newUser)
        {
            User u = DB.UsersList.Find(user => user.userName == newUser.userName);
            if (u != null)
                return Conflict();
            DB.UsersList.Add(newUser);
            return Ok(newUser);

        }

    }
}
