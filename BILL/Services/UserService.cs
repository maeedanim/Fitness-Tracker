using AutoMapper;
using BILL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL.Services
{
    public class UserService
    {
        public static List<UserDTO> Get()
        {
            var data = DataAccessFactory.UserData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<UserDTO>>(data);
            return mapped;

        }

        public static UserDTO Get(int id)
        {
            var data = DataAccessFactory.UserData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<UserDTO>(data);
            return mapped;
        }

        public static UserwithUserWorkout GetUserwithuserworkout(int id)
        {
            var data = DataAccessFactory.UserData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserwithUserWorkout>();
                c.CreateMap<Goal, GoalsDTO>();
                c.CreateMap<Userworkout, UserWorkoutDTO>();
                c.CreateMap<Workout, WorkoutDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<UserwithUserWorkout>(data);
            return mapped;
        }
    }
}
