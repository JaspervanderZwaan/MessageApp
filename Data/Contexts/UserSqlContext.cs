using Data.Interfaces;
using Models.Datamodels;
using System;
using System.Collections.Generic;

namespace Data.Contexts
{
    public class UserSqlContext : IUserContext
    {
        private readonly DatabaseHandler DatabaseHandler = new DatabaseHandler();

        public bool Authenticate(User user)
        {
            return DatabaseHandler.GetAffectedRowCount($"EXEC [AuthenticateUser] '{user.Username}', '{user.Password}'") == 1;
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
            return DatabaseHandler.GetAffectedRowCount($"EXEC [InsertUser] '{user.Username}', '{user.Email}', '{user.Password}', 0") == 1;
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