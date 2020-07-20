using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebChat.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(20)]
        public string Nickname { get; set; }
        public ICollection<Message> Messages { get; set; }

        public User()
        {
            Messages = new List<Message>();
        }
    }
}
