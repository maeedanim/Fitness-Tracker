using BILL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fitness_Tracker.Controllers
{
    public class WorkoutController : ApiController
    {
        [HttpGet]
        [Route("api/workout")]
        public HttpResponseMessage Workout()
        {
            try
            {
                var data = WorkoutService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
