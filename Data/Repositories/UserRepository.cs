using Data.Interfaces;
using Models.Datamodels;
using System.Collections.Generic;

namespace Data.Repositories
{
    public class UserRepository
    {
        private readonly IUserContext Context;

        public UserRepository(IUserContext context)
        {
            Context = context;
        }

        public List<User> GetAll()
        {
            return Context.GetAll();
        }

        public List<User> Search(string searchquery)
        {
            return Context.Search(searchquery);
        }

        public User GetById(int id)
        {
            return Context.GetById(id);
        }

        public bool Insert(User user)
        {
            return Context.Insert(user);
        }

        public bool Delete(int id)
        {
            return Context.Delete(id);
        }

        public bool Update(User user)
        {
            return Context.Update(user);
        }

        public bool Authenticate(User user)
        {
            return Context.Authenticate(user);
        }
    }
}