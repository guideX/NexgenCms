using NexgenCms.Core.Models;
using NexgenCms.Core.Repository.Base;
using NexgenCms.Data.Interfaces.Module;
using NexgenCms.Model;
namespace NexgenCms.Data.Repositories.Module {
    /// <summary>
    /// Content Type Repository
    /// </summary>
    public class ModuleRepository : Repository<ModuleModel>, IModuleRepository {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn"></param>
        public ModuleRepository(DatabaseConnectionModel conn) : base(conn) {
        }
    }
}