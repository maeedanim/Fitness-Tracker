using BILL.DTOs;
using BILL.Services;
using Fitness_Tracker.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fitness_Tracker.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("api/user")]
        public HttpResponseMessage Users()
        {
            try
            {
                var data = UserService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/user/{id}")]
        public HttpResponseMessage Users(int id)
        {
            try
            {
                var data = UserService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Logged]
        [HttpGet]
        [Route("api/user/{id}/userworkout")]
        public HttpResponseMessage Userwithuserworkout(int id)
        {
            try
            {
                var data = UserService.GetUserwithuserworkout(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Logged]
        [HttpGet]
        [Route("api/user/{id}/userworkout/goal/workout")]
        public HttpResponseMessage Userwithuserworkoutgoals(int id)
        {
            try
            {
                var data = UserService.GetUserwithuserworkout(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }




        [HttpPost]
        [Route("api/user")]
        public HttpResponseMessage Create(UserDTO user)
        {
            try
            {
                if (!ModelState.IsValid)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);

                var data = UserService.Create(user);
                if (data == null)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "User creation failed." });

                return Request.CreateResponse(HttpStatusCode.Created, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }



        [HttpPut]
        [Route("api/user/{id}")]
        public HttpResponseMessage Update(int id, UpdateUserDTO user)
        {
            try
            {
                if (!ModelState.IsValid)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);

               
                var success = UserService.Update(id, user);

                if (!success)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "User update failed." });

                return Request.CreateResponse(HttpStatusCode.OK, new { Message = "User updated successfully." });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }




        [HttpDelete]
        [Route("api/user/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var success = UserService.Delete(id);
                if (!success)
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { Message = "User deletion failed." });

                return Request.CreateResponse(HttpStatusCode.OK, new { Message = "User deleted successfully." });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }










    }
}
