using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A11dDemo.web.Controllers
{
	public partial class MultimediaController : Controller
	{
		// GET: Multimedia
		public virtual ActionResult Index()
		{
			return View();
		}
	}
}