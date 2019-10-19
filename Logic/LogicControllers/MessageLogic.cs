using Data.Interfaces;
using Data.Repositories;
using Models.DataModels;
using System.Collections.Generic;

namespace Logic.LogicControllers
{
    public class MessageLogic
    {
        private readonly MessageRepository MessageRepository;

        public MessageLogic(IMessageContext context)
        {
            MessageRepository = new MessageRepository(context);
        }

        public List<Message> GetAll()
        {
            return MessageRepository.GetAll();
        }

        public List<Message> Search(string searchquery)
        {
            return MessageRepository.Search(searchquery);
        }

        public Message GetById(int id)
        {
            return MessageRepository.GetById(id);
        }

        public bool Insert(Message message)
        {
            return MessageRepository.Insert(message);
        }

        public bool Delete(int id)
        {
            return MessageRepository.Delete(id);
        }

        public bool Update(Message message)
        {
            return MessageRepository.Update(message);
        }
    }
}