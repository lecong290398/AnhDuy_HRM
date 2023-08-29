using AnhDuyCompany.ManagerCompany.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AnhDuyCompany.ManagerCompany.Web.Public.Controllers
{
	public class HomeController : ManagerCompanyControllerBase
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult HomeIndex()
		{
			return View();
		}

		[Route("product")]
		public ActionResult Product()
		{
			return View();
		}

		[Route("Faq")]
		public ActionResult Faq()
		{
			return View();
		}

		[Route("About")]
		public ActionResult About()
		{
			return View();
		}
		[Route("Recipe")]
		public ActionResult Recipe()
		{
			return View();
		}

		[Route("Column")]
		public ActionResult Column()
		{
			return View();
		}

		[Route("Shop")]
		public ActionResult Shop()
		{
			return View();
		}

		[Route("Company")]
		public ActionResult Company()
		{
			return View();
		}

		[Route("Contact")]
		public ActionResult Contact()
		{
			return View();
		}
	}
}