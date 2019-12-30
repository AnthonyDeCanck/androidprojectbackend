using AndroidAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndroidAPI.Data
{
    public class MessageRepository
    {
        private readonly DataContext _context;
        private readonly DbSet<Message> _messages;

        public MessageRepository(DataContext context)
        {
            _context = context;
            _messages = context.Fietsen;
        }

        public IEnumerable<Message> GetAll()
        {
            return _messages;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
