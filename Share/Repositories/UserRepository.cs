using Share.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebChat.Models;

namespace Share.Repositories
{
    class UserRepository : IUserRepository
    {
        private readonly WebChatContext _webChatContext;
        public UserRepository(WebChatContext context)
        {
            _webChatContext = context;
        }

        public User AddUser(User user)
        {
            _webChatContext.Users.Add(user);
            return user;
        }

        public IQueryable<User> GetUsers(Expression<Func<User, bool>> predicate)
        {
            return _webChatContext.Users.Where(predicate);
        }

        public User RemoveUser(User user)
        {
            _webChatContext.Users.Remove(user);
            return user;
        }

        public async Task SaveChangesAsync()
        {
            await _webChatContext.SaveChangesAsync();
        }
    }
}
