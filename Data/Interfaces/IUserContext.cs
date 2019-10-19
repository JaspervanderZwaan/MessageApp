using Models.Datamodels;
using System.Collections.Generic;

namespace Data.Interfaces
{
    public interface IUserContext
    {
        List<User> GetAll();
        List<User> Search(string searchquery);
        User GetById(int id);
        bool Insert(User user);
        bool Delete(int id);
        bool Update(User user);
        bool Authenticate(User user);
    }
}