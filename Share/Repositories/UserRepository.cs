using Share.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public User GetUser(int id)
        {
            return _webChatContext.Users.Find(id);
        }

        public IQueryable<User> GetUsers()
        {
            return _webChatContext.Users.AsQueryable();
        }

        public User RemoveUser(int id)
        {
            var user = _webChatContext.Users.Find(id);
            if (user != null)
                _webChatContext.Users.Remove(user);
            return user;
        }

        public async Task SaveChangesAsync()
        {
            await _webChatContext.SaveChangesAsync();
        }
    }
}
