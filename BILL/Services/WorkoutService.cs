using AutoMapper;
using BILL.DTOs;
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

    }
}
