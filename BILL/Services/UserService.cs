using AutoMapper;
using BILL.DTOs;
using BILL.Utilities;
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

        public static UserDTO Create(UserDTO user)
        {
          
            if (user.CreatedAt == DateTime.MinValue)
                user.CreatedAt = DateTime.Now;

         
            var cfg = new MapperConfiguration(c => c.CreateMap<UserDTO, User>());
            var mapper = new Mapper(cfg);
            var entity = mapper.Map<User>(user);

           
            var created = DataAccessFactory.UserData().Create(entity);
            if (created == null) return null;

            
            try
            {
                
                Task.Run(() => EmailHelper.SendEmail(
                    toEmail: created.Email,
                    subject: "Welcome to Fitness Tracker!",
                    body: $"Hi {created.Name},\n\nYour Fitness Tracker account has been created successfully!\n\nUsername: {created.Uname}\n\nStay fit and healthy!\n\n— The Fitness Tracker Team"
                ));
            }
            catch (Exception ex)
            {
              
                Console.WriteLine("Email send failed: " + ex.Message);
            }

           
            var cfg2 = new MapperConfiguration(c => c.CreateMap<User, UserDTO>());
            var mapper2 = new Mapper(cfg2);
            return mapper2.Map<UserDTO>(created);
        }

        public static bool Update(int id, UpdateUserDTO user)
        {
            
            var existing = DataAccessFactory.UserData().Read(id);
            if (existing == null) return false;

           
            existing.Uname = user.Uname;
            existing.Name = user.Name;
            existing.Email = user.Email;
            existing.Password = user.Password;
            

            var result = DataAccessFactory.UserData().Update(existing);
            return result != null;
        }


        public static bool Delete(int id)
        {
            return DataAccessFactory.UserData().Delete(id);
        }


    }
}
