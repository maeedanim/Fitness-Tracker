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
    public class AuthService
    {
        public static TokenDTO Authenticate(string uname, string password)
        {



            var res = DataAccessFactory.AuthData().Authenticate(uname, password);
            if (res)
            {
                var token = new Token();
                token.Uname = uname;
                token.CreatedAt = DateTime.Now;
                token.Tkey = Guid.NewGuid().ToString();
                var ret = DataAccessFactory.TokenData().Create(token);
                if (ret != null) 
                {
                    var cfg = new MapperConfiguration(c =>
                    {
                        c.CreateMap<Token, TokenDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenDTO>(ret);
                }
            }
                return null;

        }

        public static bool IsTokenValid(string tkey)
        {
            var existingtoken = DataAccessFactory.TokenData().Read(tkey);
            
            if (existingtoken != null && existingtoken.Expiry == null)
            {
                return true;
            }
            return false;
        }
        public static bool Logout(string tkey)
        {
            var existingtoken = DataAccessFactory.TokenData().Read(tkey);
            existingtoken.Expiry = DateTime.Now;
            if (DataAccessFactory.TokenData().Update(existingtoken) != null)
            {
                return true;
            }
            else
            {
                return false;

            }

        }
    }
}
