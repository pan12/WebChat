using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebChat.Models;

namespace WebChat.Interfaces
{
    interface IUserService
    {
        Task<User> AddUser(User user);
        Task<User> GetUser(int id);
        Task<User> GetUser(string nickName);
        Task<List<User>> GetAllUsers();
    }
}
