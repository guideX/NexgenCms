using System.Web.Mvc;
namespace NexgenCms.Controllers {
    /// <summary>
    /// Home Controller
    /// </summary>
    public class HomeController : Controller {
        /// <summary>
        /// Home 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index() {
            return View();
        }
    }
}