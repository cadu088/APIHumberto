using Microsoft.AspNetCore.Mvc;

namespace Aula01.Controllers
{
	public class FreteController : Controller
	{
		public IActionResult CalcularFrete()
		{
			return View();
		}
	}
}
