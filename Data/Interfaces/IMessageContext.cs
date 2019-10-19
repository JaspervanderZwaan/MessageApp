using Models.DataModels;
using System.Collections.Generic;

namespace Data.Interfaces
{
    public interface IMessageContext
    {
        List<Message> GetAll();
        List<Message> Search(string searchquery);
        Message GetById(int id);
        bool Insert(Message message);
        bool Delete(int id);
        bool Update(Message message);
    }
}