using hack_it_mvc.Models;
using System.Diagnostics;
using System.Text;
using System.Web.Mvc;

namespace hack_it_mvc.Controllers {
	public class VulnerableController : Controller {
		public ActionResult Index() {
			return View(new VulnerableModel());
		}

		// Javascript DOM injection
		public ActionResult Post(string Text) {
			return View(new VulnerableModel { Text = Text });
		}

		// Javascript DOM injection
		public ActionResult Get(string Text) {
			return View(new VulnerableModel { Text = Text });
		}

		// Execute code on server from client
		public ActionResult OS(string command) {
			// Careful with this one...
			Process process = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.WindowStyle = ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = command;
			startInfo.RedirectStandardOutput = true;
			startInfo.UseShellExecute = false;
			process.StartInfo = startInfo;
			process.Start();

			StringBuilder result = new StringBuilder();
			while (!process.StandardOutput.EndOfStream) {
				result.AppendLine(process.StandardOutput.ReadLine());
			}

			return View(new VulnerableModel { Text = result.ToString() });
		}

		// Link/DOM manipulation
		public ActionResult LinkManip(string link) {
			return View(new VulnerableModel { Text = link });
		}
	}
}
