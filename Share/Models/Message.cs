using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebChat.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime PostedTime { get; set; }
        public User Sender { get; set; }
    }
}
