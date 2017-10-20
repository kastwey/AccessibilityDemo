using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A11dDemo.web.Controllers
{
	public partial class InterfacesController : Controller
	{
		// GET: Interfaces
		public virtual ActionResult VisualYDOM()
		{
			return View();
		}

		public virtual ActionResult VisualYDom2()
		{
			return View();
		}

		public virtual ActionResult Mienteme()
		{
			return View();
		}
	}
}