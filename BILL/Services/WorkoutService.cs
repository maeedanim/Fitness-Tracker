using AutoMapper;
using BILL.DTOs;
using BILL.Utilities;
using DAL;
using DAL.Models;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL.Services
{
    public class WorkoutService
    {
        public static List<WorkoutDTO> Get()
        {
            var data = DataAccessFactory.WorkoutData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Workout, WorkoutDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<WorkoutDTO>>(data);
            return mapped;

        }

        public static WorkoutDTO Get(int id)
        {
            var data = DataAccessFactory.WorkoutData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Workout, WorkoutDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<WorkoutDTO>(data);
            return mapped;
        }


        public static WorkoutUserWorkoutDTO Getwithuserworkout(int id)
        {
            var data = DataAccessFactory.WorkoutData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Workout, WorkoutUserWorkoutDTO>();
                c.CreateMap<Userworkout, UserWorkoutDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<WorkoutUserWorkoutDTO>(data);
            return mapped;
        }


        public static bool Create(WorkoutDTO dto)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<WorkoutDTO, Workout>();
            });
            var mapper = new Mapper(cfg);
            var workout = mapper.Map<Workout>(dto);
            return DataAccessFactory.WorkoutData().Create(workout);
        }

        /*
        public static bool Update(WorkoutDTO dto)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<WorkoutDTO, Workout>();
            });
            var mapper = new Mapper(cfg);
            var workout = mapper.Map<Workout>(dto);
            return DataAccessFactory.WorkoutData().Update(workout);
        }
        */


        public static bool Delete(int id)
        {
            return DataAccessFactory.WorkoutData().Delete(id);
        }



    }
}
