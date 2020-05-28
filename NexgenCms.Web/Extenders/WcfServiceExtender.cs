using NexgenCms.Core.Helper;
using NexgenCms.Core.Interfaces.Helper;
using NexgenCms.Core.Models;
namespace NexgenCms.Extenders {
    /// <summary>
    /// Wcf Service Extender
    /// </summary>
    public abstract class WcfServiceExtender {
        /// <summary>
        /// Configuration
        /// </summary>
        public IConfigurationHelper Configuration { get; set; }
        /// <summary>
        /// Conn
        /// </summary>
        public DatabaseConnectionModel Conn { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public WcfServiceExtender() {
            Configuration = new ConfigurationHelper();
            Conn = new DatabaseConnectionModel(Configuration, Core.Enum.DatabaseTypeEnum.NexgenCmsConnection);
        }
    }
}