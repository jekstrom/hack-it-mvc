using hack_it_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace hack_it_mvc.Controllers {
	public class VulnerableController : Controller {
		public ActionResult Index() {
			return View(new VulnerableModel());
		}

		public ActionResult Post(string Text) {
			return View(new VulnerableModel { Text = Text });
		}
	}
}
