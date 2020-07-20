using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebChat.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        [Required]
        public DateTime PostedTime { get; set; }
        [Required]
        public User Sender { get; set; }
    }
}
