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
    public class GoalService
    {
        public static List<GoalsDTO> Get()
        {
            var data = DataAccessFactory.GoalData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Goal, GoalsDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<GoalsDTO>>(data);
            return mapped;

        }

        public static GoalsDTO Get(int id)
        {
            var data = DataAccessFactory.GoalData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Goal, GoalsDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<GoalsDTO>(data);
            return mapped;
        }
    }
}
