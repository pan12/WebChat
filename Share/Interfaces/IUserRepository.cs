using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebChat.Models;

namespace Share.Interfaces
{
    interface IUserRepository
    {
        User AddUser(User user);
        User GetUser(int id);
        IQueryable<User> GetUsers();
        User RemoveUser(int id);
        Task SaveChangesAsync();
    }
}
