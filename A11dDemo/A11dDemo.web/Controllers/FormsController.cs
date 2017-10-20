using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A11dDemo.web.Controllers
{
	public partial class FormsController : Controller
	{
		// GET: Forms
		public virtual ActionResult Mal()
		{
			return View();
		}

		public virtual ActionResult Bien()
		{
			return View();
		}
	}
}