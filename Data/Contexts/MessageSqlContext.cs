using Data.Interfaces;
using Models.DataModels;
using System;
using System.Collections.Generic;

namespace Data.Contexts
{
    public class MessageSqlContext : IMessageContext
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetAll()
        {
            throw new NotImplementedException();
        }

        public Message GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Message message)
        {
            throw new NotImplementedException();
        }

        public List<Message> Search(string searchquery)
        {
            throw new NotImplementedException();
        }

        public bool Update(Message message)
        {
            throw new NotImplementedException();
        }
    }
}