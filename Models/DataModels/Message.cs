using Models.Datamodels;
using System;

namespace Models.DataModels
{
    public class Message
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
        public object Image { get; set; }
        public DateTime Date { get; set; }
    }
}