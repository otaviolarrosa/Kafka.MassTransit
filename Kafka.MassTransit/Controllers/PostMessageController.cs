using System;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace Kafka.MassTransit.Controllers
{
    [ApiController]
    [Route("message")]
    public class PostMessageController : ControllerBase
    {
        private readonly IPublishEndpoint _bus;

        public PostMessageController(IPublishEndpoint bus)
        {
            _bus = bus;
        }

        [HttpPost]
        public async Task<IActionResult> PostMessage([FromBody] string text)
        {
            try
            {
                await _bus.Publish<Application.Mensageria.MessageContracts.Startup.IKafkaMessage>(new {Text = text});
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}