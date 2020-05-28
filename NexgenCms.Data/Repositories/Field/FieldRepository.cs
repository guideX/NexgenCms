using NexgenCms.Core.Models;
using NexgenCms.Core.Repository.Base;
using NexgenCms.Data.Interfaces.Field;
using NexgenCms.Model;
namespace NexgenCms.Data.Repositories.Field {
    /// <summary>
    /// Field Repository
    /// </summary>
    public class FieldRepository : Repository<FieldModel>, IFieldRepository {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn"></param>
        public FieldRepository(DatabaseConnectionModel conn) : base(conn) {
        }
    }
}