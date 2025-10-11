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
    public class UserWorkoutService
    {
        public static List<UserWorkoutDTO> Get()
        {
            var data = DataAccessFactory.UserworkoutData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Userworkout, UserWorkoutDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<UserWorkoutDTO>>(data);
            return mapped;

        }

        public static UserWorkoutDTO Get(int id)
        {
            var data = DataAccessFactory.UserworkoutData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Userworkout, UserWorkoutDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<UserWorkoutDTO>(data);
            return mapped;
        }


        
        public static bool Create(UserWorkoutDTO dto)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserWorkoutDTO, Userworkout>();
            });
            var mapper = new Mapper(cfg);
            var entity = mapper.Map<Userworkout>(dto);

            return DataAccessFactory.UserworkoutData().Create(entity);
        }

        /*
        public static bool Update(UserWorkoutDTO dto)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserWorkoutDTO, Userworkout>();
            });
            var mapper = new Mapper(cfg);
            var entity = mapper.Map<Userworkout>(dto);

            return DataAccessFactory.UserworkoutData().Update(entity);
        }
        */
       
        public static bool Delete(int id)
        {
            return DataAccessFactory.UserworkoutData().Delete(id);
        }



    }
}
