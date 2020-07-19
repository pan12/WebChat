using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebChat.Models;

namespace WebChat.Services
{
    public class ChatService : IChatService
    {
        IChatService _chatRepository;
        
        public ChatService()
        {

        }

        public Task<Message> AddMessage(string text)
        {
            throw new NotImplementedException();
        }

        public Task<Message> GetMessage(int messageId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Message>> GetMessagesByUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Message>> GetMessagesInLastMin()
        {
            throw new NotImplementedException();
        }
    }
}
