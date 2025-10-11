using BILL.DTOs;
using BILL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fitness_Tracker.Controllers
{
    public class UserWorkoutController : ApiController
    {
        [HttpGet]
        [Route("api/userworkout")]
        public HttpResponseMessage Userworkout()
        {
            try
            {
                var data = UserWorkoutService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/userworkout/{id}")]
        public HttpResponseMessage Userworkout(int id)
        {
            try
            {
                var data = UserWorkoutService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/userworkout")]
        public HttpResponseMessage Create(UserWorkoutDTO Userworkout)
        {
            try
            {
                if (!ModelState.IsValid)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);

                var data = UserWorkoutService.Create(Userworkout);
                if (!data)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "User creation failed." });

                return Request.CreateResponse(HttpStatusCode.Created, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        /*

        [HttpPut]
        [Route("api/userworkout/{id}")]
        public HttpResponseMessage Update(int id, UserWorkoutDTO Userworkout)
        {
            try
            {
                if (!ModelState.IsValid)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);


                var success = UserWorkoutService.Update(id, Userworkout);

                if (!success)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "User update failed." });

                return Request.CreateResponse(HttpStatusCode.OK, new { Message = "User updated successfully." });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        */


        [HttpDelete]
        [Route("api/userworkout/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var success = UserWorkoutService.Delete(id);
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
