using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndroidAPI.Data;
using AndroidAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AndroidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly MessageRepository _messageRepository;

        public MessageController(MessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        [HttpGet]
        public IEnumerable<Message> GetFiets()
        {
            return _messageRepository.GetAll();
        }
    }
}