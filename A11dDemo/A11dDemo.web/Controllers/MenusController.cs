using A11dDemo.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace A11dDemo.web.Controllers
{
	public partial class MenusController : Controller
	{

		public virtual async Task<ActionResult> MenuBien()
		{
			var model = new MenusModel
			{
				Items = new List<MenusModel> {
					new MenusModel {
						Name = "Anne Rice", Items = new List<MenusModel> {
							new MenusModel {
								Name = "Entrevista con el vampiro" },
							new MenusModel { Name = "Lestat el vampiro" },
							new MenusModel { Name = "La reina de los condenados" },
							new MenusModel { Name = "El ladrón de cuerpos" },
							new MenusModel { Name = "Memnoch el diablo" },
							new MenusModel { Name = "Armand el vamipro" },
							new MenusModel { Name = "Merrick" },
							new MenusModel { Name = "Sangre y oro" },
							new MenusModel { Name = "El santuario" },
							new MenusModel { Name = "Príncipe Lestat" },
							new MenusModel { Name = "Príncipe Lestat y los Reinos de la Atlántida" }
						}
					},
					new MenusModel{
						Name = "Arthur C. Clarke",
						Items = new List<MenusModel> {
							new MenusModel { Name = "2010, Una odisea espacial" },
							new MenusModel { Name = "2010: Odisea dos" },
							new MenusModel { Name = "2061: Odisea tres" },
							new MenusModel { Name = "3001: Odisea final" },
							new MenusModel { Name = "Cita con Rama" },
							new MenusModel { Name = "Rama II" },
							new MenusModel { Name = "El jardín de Rama" },
							new MenusModel { Name = "Rama revelada" },
							new MenusModel { Name = "Las arenas de Marte" },
							new MenusModel { Name = "El fin de la infancia" }
						}
					}
				}
			};


			return await Task.FromResult(View(model));
		}

		public virtual async Task<ActionResult> MenuMal()
		{
			var model = new MenusModel
			{
				Items = new List<MenusModel> {
					new MenusModel {
						Name = "Anne Rice", Items = new List<MenusModel> {
							new MenusModel {
								Name = "Entrevista con el vampiro" },
							new MenusModel { Name = "Lestat el vampiro" },
							new MenusModel { Name = "La reina de los condenados" },
							new MenusModel { Name = "El ladrón de cuerpos" },
							new MenusModel { Name = "Memnoch el diablo" },
							new MenusModel { Name = "Armand el vamipro" },
							new MenusModel { Name = "Merrick" },
							new MenusModel { Name = "Sangre y oro" },
							new MenusModel { Name = "El santuario" },
							new MenusModel { Name = "Príncipe Lestat" },
							new MenusModel { Name = "Príncipe Lestat y los Reinos de la Atlántida" }
						}
					},
					new MenusModel{
						Name = "Arthur C. Clarke",
						Items = new List<MenusModel> {
							new MenusModel { Name = "2010, Una odisea espacial" },
							new MenusModel { Name = "2010: Odisea dos" },
							new MenusModel { Name = "2061: Odisea tres" },
							new MenusModel { Name = "3001: Odisea final" },
							new MenusModel { Name = "Cita con Rama" },
							new MenusModel { Name = "Rama II" },
							new MenusModel { Name = "El jardín de Rama" },
							new MenusModel { Name = "Rama revelada" },
							new MenusModel { Name = "Las arenas de Marte" },
							new MenusModel { Name = "El fin de la infancia" }
						}
					}
				}
			};


			return await Task.FromResult(View(model));
		}
	}
}