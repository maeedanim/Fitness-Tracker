using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TokenRepo : Repo, IRepo<Token, string, Token>
    {
        public Token Create(Token obj)
        {
            db.Tokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var token = Read(id);
            if (token == null) return false;
            db.Tokens.Remove(token);
            return db.SaveChanges() > 0;
        }

        public List<Token> Read()
        {
            return db.Tokens.ToList();
        }

        public Token Read(string id)
        {
            return db.Tokens.FirstOrDefault(t=>t.Tkey ==id );
        }

        public Token Update(Token obj)
        {
            var token = Read(obj.Tkey);
            if (token == null) return null;  // Handle case where token doesn't exist
            db.Entry(token).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return token;
            return null;

        }
    }
}
