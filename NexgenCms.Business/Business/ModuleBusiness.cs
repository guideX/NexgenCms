using System;
using NexgenCms.Business.Extenders;
using NexgenCms.Business.Interfaces.Business;
using NexgenCms.Core.Interfaces.Helper;
using NexgenCms.Core.Models;
using NexgenCms.Data.Interfaces.Module;
using NexgenCms.Data.Repositories.Module;
using NexgenCms.Model;
namespace NexgenCms.Business.Business {
    /// <summary>
    /// Admin Business
    /// </summary>
  //public class ContentTypeBusiness : BusinessExtender<ContentTypeModel>, IDisposable, IContentTypeBusiness {
    public class ModuleBusiness : BusinessExtender<ModuleModel>, IDisposable, IModuleBusiness {
        #region "repositories"
        /// <summary>
        /// Module Repository
        /// </summary>
        private IModuleRepository _moduleRepository;
        #endregion
        #region "methods"
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="conn"></param>
        /// <param name="paperwiseConn"></param>
        public ModuleBusiness(IConfigurationHelper configuration, DatabaseConnectionModel conn) : base(configuration, conn) {
            this.GetType().DoAllMethodResultsHaveBaseClass(typeof(AjaxResult));
            _moduleRepository = new ModuleRepository(conn);
            this.SetDefaultRepository(_moduleRepository);
        }
        #endregion
    }
}