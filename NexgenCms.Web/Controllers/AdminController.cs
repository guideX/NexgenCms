using NexgenCms.Business.ViewModels.Admin;
using NexgenCms.Core.Models;
using NexgenCms.Extenders.Base;
using System.Web.Mvc;
/// <summary>
/// Nexgen Cms Controllers
/// </summary>
namespace NexgenCms.Controllers {
    /// <summary>
    /// Admin Controller
    /// </summary>
    public class AdminController : MvcControllerExtender {
        /// <summary>
        /// Content Types
        /// </summary>
        /// <returns></returns>
        public ActionResult ContentTypes() {
            return View(new ContentTypesViewModel(Configuration, new DatabaseConnectionModel(Configuration, Core.Enum.DatabaseTypeEnum.NexgenCmsConnection)));
        }
        /// <summary>
        /// Add Content Type
        /// </summary>
        /// <returns></returns>
        public ActionResult AddContentType() {
            return View(new AddContentTypeViewModel(Configuration, new DatabaseConnectionModel(Configuration, Core.Enum.DatabaseTypeEnum.NexgenCmsConnection)));
        }
    }
}