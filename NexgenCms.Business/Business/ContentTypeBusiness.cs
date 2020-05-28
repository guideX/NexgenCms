using System;
using NexgenCms.Business.Extenders;
using NexgenCms.Business.Interfaces.Business;
using NexgenCms.Core.Interfaces.Helper;
using NexgenCms.Core.Models;
using NexgenCms.Data.Interfaces.ContentType;
using NexgenCms.Data.Repositories.ContentType;
using NexgenCms.Model;
namespace NexgenCms.Business.Business {
    /// <summary>
    /// Admin Business
    /// </summary>
    public class ContentTypeBusiness : BusinessExtender<ContentTypeModel>, IDisposable, IContentTypeBusiness {
        #region "repositories"
        /// <summary>
        /// Content Types
        /// </summary>
        private IContentTypeRepository _contentTypes;
        #endregion
        #region "methods"
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="conn"></param>
        /// <param name="paperwiseConn"></param>
        public ContentTypeBusiness(IConfigurationHelper configuration, DatabaseConnectionModel conn) : base(configuration, conn) {
            this.GetType().DoAllMethodResultsHaveBaseClass(typeof(AjaxResult));
            _contentTypes = new ContentTypeRepository(conn);
            this.SetDefaultRepository(_contentTypes);
        }
        #endregion
    }
}