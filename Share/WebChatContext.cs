using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebChat.Models;

namespace Share
{
    public class WebChatContext : DbContext
    {
        public WebChatContext(DbContextOptions<WebChatContext> options) : base (options)
        {
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
