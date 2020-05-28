using NexgenCms.Business.Business;
using NexgenCms.Business.Interfaces.Business;
using NexgenCms.Core.Interfaces.Helper;
using NexgenCms.Core.Models;
using NexgenCms.Model;
using System.Linq;
namespace NexgenCms.Business.ViewModels.Admin {
    /// <summary>
    /// Content Types View Model
    /// </summary>
    public class ContentTypesViewModel {
        #region "variables"
        /// <summary>
        /// Content Types
        /// </summary>
        public ContentTypeModelResults ContentTypes { get; set; } = new ContentTypeModelResults();
        #endregion
        #region "methods"
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn"></param>
        public ContentTypesViewModel(IConfigurationHelper configuration, DatabaseConnectionModel conn) {
            using (IContentTypeBusiness cb = new ContentTypeBusiness(configuration, conn)) {
                ContentTypes.Results = cb.ReadAll().ToList();
            }
        }
        #endregion
    }
}