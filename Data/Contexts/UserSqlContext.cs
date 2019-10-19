using Data.Interfaces;
using Models.Datamodels;
using System;
using System.Collections.Generic;

namespace Data.Contexts
{
    public class UserSqlContext : IUserContext
    {
        public bool Authenticate(User user)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> Search(string searchquery)
        {
            throw new NotImplementedException();
        }

        public bool Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}