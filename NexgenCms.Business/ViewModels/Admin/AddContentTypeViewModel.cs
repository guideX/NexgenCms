//using NexgenCms.Business.Business;
//using NexgenCms.Business.Interfaces.Business;
using NexgenCms.Core.Interfaces.Helper;
using NexgenCms.Core.Models;
//using NexgenCms.Model;
//using System.Linq;
namespace NexgenCms.Business.ViewModels.Admin {
    /// <summary>
    /// Add Content Type View Model
    /// </summary>
    public class AddContentTypeViewModel {
        #region "variables"
        /// <summary>
        /// Content Types
        /// </summary>
        //public ContentTypeModelResults ContentTypes { get; set; } = new ContentTypeModelResults();
        #endregion
        #region "methods"
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn"></param>
        public AddContentTypeViewModel(IConfigurationHelper configuration, DatabaseConnectionModel conn) {
            //using (IContentTypeBusiness cb = new ContentTypeBusiness(configuration, conn)) {
                //ContentTypes.Results = cb.ReadAll().ToList();
            //}
        }
        #endregion
    }
}