using Microsoft.AspNetCore.Mvc;

namespace NouvellesTechnosAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WebhooksController : ControllerBase
	{
		private static Message LastMessage = new Message() { Content = "" };

		[HttpGet]
		public string Get()
		{
			return LastMessage.Content;
		}

		[HttpPost]
		public void Post([FromBody] Message message)
		{
			LastMessage = message;
		}
	}
}
