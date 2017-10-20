using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using Resource = Resources.Js;


namespace FrontFest
{
	public partial class ResourcesController : Controller
	{

		public virtual JsonResult GetResources()
		{
			return Json(
				typeof(Resource)
					.GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
					.Where(p => !p.Name.Equals("ResourceManager") && !p.Name.Equals("Culture")) // Skip the properties you don't need on the client side.
					.ToDictionary(p => p.Name, p => p.GetValue(null) as string)
				, JsonRequestBehavior.AllowGet);
		}
	}
}