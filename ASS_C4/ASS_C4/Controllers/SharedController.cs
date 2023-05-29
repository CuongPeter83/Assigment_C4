using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
	public class SharedController : Controller
	{
		public IActionResult _Layout()
		{
			return View();
		}
	}
}
