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
    public class GoalController : ApiController
    {
        [HttpGet]
        [Route("api/goal")]
        public HttpResponseMessage Goal()
        {
            try
            {
                var data = GoalService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/Goal/{id}")]
        public HttpResponseMessage Goal(int id)
        {
            try
            {
                var data = GoalService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/Goal")]
        public HttpResponseMessage Create(GoalsDTO goal)
        {
            try
            {
                if (!ModelState.IsValid)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);

                var data = GoalService.Create(goal);
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
        [Route("api/Goal/{id}")]
        public HttpResponseMessage Update(int id, GoalsDTO goal)
        {
            try
            {
                if (!ModelState.IsValid)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);


                var success = GoalService.Update(id, goal);

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
        [Route("api/goal/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var success = GoalService.Delete(id);
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
