using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A11dDemo.web.Models
{
	public class MenusModel
	{
		public string Name { get; set; }

		public List<MenusModel> Items { get; set; }
		
	}
}