using Share;
using Share.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebChat.Models;

namespace WebChat.Repositories
{
    public class ChatRepository : IChatRepository
    {
        private readonly WebChatContext _webChatContext;
        public ChatRepository(WebChatContext context)
        {
            _webChatContext = context;
        }

        public Message AddMessage(Message message)
        {
            message.PostedTime = DateTime.UtcNow;
            _webChatContext.Messages.Add(message);
            return message;
            
        }

        public Message GetMessage(int id)
        {
            return _webChatContext.Messages.Find(id);
        }

        public IQueryable<Message> GetMessagesInLastMin()
        {
            var time = DateTime.UtcNow.AddMinutes(-1);
            return _webChatContext.Messages.Where(m => m.PostedTime > time);
        }

        public async Task SaveChangesAsync()
        {
            await _webChatContext.SaveChangesAsync();
        }
    }
}
