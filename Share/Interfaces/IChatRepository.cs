using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebChat.Models;

namespace Share.Interfaces
{
    interface IChatRepository
    {
        Message AddMessage(Message message);
        Message GetMessage(int id);
        IQueryable<Message> GetMessagesInLastMin();
        Task SaveChangesAsync();
    }
}
