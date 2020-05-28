using NexgenCms.Core.Models;
using NexgenCms.Core.Repository.Base;
using NexgenCms.Data.Interfaces.DataType;
using NexgenCms.Model;
namespace NexgenCms.Data.Repositories.DataType {
    /// <summary>
    /// Content Type Repository
    /// </summary>
    public class DataTypeRepository : Repository<DataTypeModel>, IDataTypeRepository {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn"></param>
        public DataTypeRepository(DatabaseConnectionModel conn) : base(conn) {
        }
    }
}