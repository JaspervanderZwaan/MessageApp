using Data.Interfaces;
using Models.DataModels;
using System.Collections.Generic;

namespace Data.Repositories
{
    public class MessageRepository
    {
        private readonly IMessageContext Context;

        public MessageRepository(IMessageContext context)
        {
            Context = context;
        }

        public List<Message> GetAll()
        {
            return Context.GetAll();
        }

        public List<Message> Search(string searchquery)
        {
            return Context.Search(searchquery);
        }

        public Message GetById(int id)
        {
            return Context.GetById(id);
        }

        public bool Insert(Message message)
        {
            return Context.Insert(message);
        }

        public bool Delete(int id)
        {
            return Context.Delete(id);
        }

        public bool Update(Message message)
        {
            return Context.Update(message);
        }
    }
}