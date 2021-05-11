using Microsoft.AspNetCore.Mvc;
using System;

namespace CollateralLoanMVC.Controllers
{
	[Route("[controller]")]
	public class HomeController : Controller
	{
		/// <summary>
		/// Used to get the template view for index page. This page does not provide the list of loans.
		/// </summary>
		/// <returns>template view for index page</returns>
		[HttpGet("[action]")]
		public ActionResult Index()
		{
			//TODO: Index action
			//throw new NotImplementedException();//remove this
			return View();
		}
	}
}
