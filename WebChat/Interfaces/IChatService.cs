using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebChat.Models;

namespace WebChat
{
    interface IChatService
    {
        Task<Message> AddMessage(Message message);
        Task<Message> GetMessage(int messageId);
        Task<List<Message>> GetMessagesByUser(int userId);
        Task<List<Message>> GetMessagesInLastMin();
    }
}
