using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebChat.Models;
using Share.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace WebChat.Services
{
    public class ChatService : IChatService
    {
        IChatRepository _chatRepository;
        
        public ChatService(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }

        public async Task<Message> AddMessage(Message message)
        {
            message.PostedTimeUTC = DateTime.UtcNow;
            message = _chatRepository.AddMessage(message);
            await _chatRepository.SaveChangesAsync();
            return message;
        }

        public async Task<Message> GetMessage(int messageId)
        {
            var message = await _chatRepository.GetMessages(m => m.Id == messageId).FirstOrDefaultAsync();
            return message;
        }

        public async Task<List<Message>> GetMessagesByUser(int userId)
        {
            var messages = await _chatRepository.GetMessages(m => m.Sender.Id == userId).ToListAsync();
            return messages;
        }

        public async Task<List<Message>> GetMessagesInLastMin()
        {
            var time = DateTime.UtcNow.AddMinutes(-1);
            var messages = await _chatRepository.GetMessages(m => m.PostedTimeUTC >= time).ToListAsync();
            return messages;
        }
    }
}
