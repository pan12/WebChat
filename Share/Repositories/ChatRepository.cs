using Share;
using Share.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            _webChatContext.Messages.Add(message);
            return message;
            
        }

        public IEnumerable<Message> GetMessages(Expression<Func<Message, bool>> predicate)
        {
            return _webChatContext.Messages.Where(predicate);
        }

        public async Task SaveChangesAsync()
        {
            await _webChatContext.SaveChangesAsync();
        }
    }
}
