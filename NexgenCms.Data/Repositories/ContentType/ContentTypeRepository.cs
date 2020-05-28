using NexgenCms.Core.Models;
using NexgenCms.Core.Repository.Base;
using NexgenCms.Data.Interfaces.ContentType;
using NexgenCms.Model;
namespace NexgenCms.Data.Repositories.ContentType {
    /// <summary>
    /// Content Type Repository
    /// </summary>
    public class ContentTypeRepository : Repository<ContentTypeModel>, IContentTypeRepository {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn"></param>
        public ContentTypeRepository(DatabaseConnectionModel conn) : base(conn) {
        }
    }
}