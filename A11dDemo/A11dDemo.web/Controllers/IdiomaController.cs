using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace A11dDemo.web.Controllers
{
	public partial class IdiomaController : Controller
	{

		public virtual async Task<ActionResult> IdiomaMal()
		{
			return await Task.FromResult(View());
		}

		public virtual async Task<ActionResult> IdiomaBien()
		{
			return await Task.FromResult(View());
		}
	}
}