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


        [HttpGet]
        [Route("api/workout/{id}")]
        public HttpResponseMessage Workout(int id)
        {
            try
            {
                var data = WorkoutService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/workout/{id}/userworkout")]
        public HttpResponseMessage Workoutwithuserworkout(int id)
        {
            try
            {
                var data = WorkoutService.Getwithuserworkout(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/workout")]
        public HttpResponseMessage Create(WorkoutDTO workout)
        {
            try
            {
                if (!ModelState.IsValid)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);

                var data = WorkoutService.Create(workout);
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
        [Route("api/workout/{id}")]
        public HttpResponseMessage Update(int id, UserWorkoutDTO workout)
        {
            try
            {
                if (!ModelState.IsValid)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);


                var success = WorkoutService.Update(id, workout);

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
        [Route("api/workout/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var success = WorkoutService.Delete(id);
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
