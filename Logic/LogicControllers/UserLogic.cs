using Data.Interfaces;
using Data.Repositories;
using Models.Datamodels;
using System.Collections.Generic;

namespace Logic
{
    public class UserLogic
    {
        private readonly UserRepository UserRepository;

        public UserLogic(IUserContext context)
        {
            UserRepository = new UserRepository(context);
        }

        public List<User> GetAll()
        {
            return UserRepository.GetAll();
        }

        public List<User> Search(string searchquery)
        {
            return UserRepository.Search(searchquery);
        }

        public User GetById(int id)
        {
            return UserRepository.GetById(id);
        }

        public bool InsertUser(User user)
        {
            return UserRepository.Insert(user);
        }

        public bool DeleteUser(int id)
        {
            return UserRepository.Delete(id);
        }

        public bool Update(User user)
        {
            return UserRepository.Update(user);
        }

        public bool Authenticate(User user)
        {
            return UserRepository.Authenticate(user);
        }
    }
}