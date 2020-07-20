using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebChat.Models;

namespace Share.Interfaces
{
    interface IChatRepository
    {
        Message AddMessage(Message message);
        IEnumerable<Message> GetMessages(Expression<Func<Message, bool>> predicate);
        Task SaveChangesAsync();
    }
}
