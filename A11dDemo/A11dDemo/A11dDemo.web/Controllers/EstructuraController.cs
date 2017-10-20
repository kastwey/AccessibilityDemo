using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A11dDemo.web.Controllers
{
	public partial class EstructuraController : Controller
	{
		// GET: Estructura
		public virtual ActionResult SinEstructura()
		{
			return View();
		}

		public virtual ActionResult ConEstructura()
		{
			return View();
		}

	}
}