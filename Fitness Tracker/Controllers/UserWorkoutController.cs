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





    }
}
