using NexgenCms.Core.Helper;
using NexgenCms.Core.Interfaces.Helper;
using System.Web.Mvc;
namespace NexgenCms.Extenders.Base {
    /// <summary>
    /// Mvc Controller Extender
    /// </summary>
    public abstract class MvcControllerExtender : Controller {
        /// <summary>
        /// Configuration
        /// </summary>
        public IConfigurationHelper Configuration { get; set; } = new ConfigurationHelper();
    }
}