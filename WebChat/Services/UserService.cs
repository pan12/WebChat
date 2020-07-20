using Microsoft.EntityFrameworkCore;
using Share.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using WebChat.Interfaces;
using WebChat.Models;

namespace WebChat.Services
{
    public class UserService : IUserService
    {
        IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> AddUser(User user)
        {
            if (await _userRepository.GetUsers(u => u.Nickname == user.Nickname).AnyAsync())
                throw new Exception("User nickname already exist!");
            user =  _userRepository.AddUser(user);
            await _userRepository.SaveChangesAsync();
            return user;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await _userRepository.GetUsers(u => u != null).ToListAsync(); //lambda expression ???
            return users;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _userRepository.GetUsers(u => u.Id == id).FirstOrDefaultAsync();
            return user;
        }

        public async Task<User> GetUser(string nickName)
        {
            var user = await _userRepository.GetUsers(u => u.Nickname == nickName).FirstOrDefaultAsync();
            return user;
        }
    }
}
