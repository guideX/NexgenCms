using NexgenCms.Core.Models;
using NexgenCms.Core.Repository.Base;
using NexgenCms.Data.Interfaces.FieldType;
using NexgenCms.Model;
namespace NexgenCms.Data.Repositories.FieldType {
    /// <summary>
    /// Content Type Repository
    /// </summary>
    public class FieldTypeRepository : Repository<FieldTypeModel>, IFieldTypeRepository {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn"></param>
        public FieldTypeRepository(DatabaseConnectionModel conn) : base(conn) {
        }
    }
}