using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebChat.Models;

namespace Share.Interfaces
{
    public interface IUserRepository
    {
        User AddUser(User user);
        IQueryable<User> GetUsers(Expression<Func<User, bool>> predicate);
        User RemoveUser(User user);
        Task SaveChangesAsync();
    }
}
