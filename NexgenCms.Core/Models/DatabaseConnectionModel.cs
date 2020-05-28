using System;
using NexgenCms.Core.Enum;
using NexgenCms.Core.Interfaces.Helper;
using PetaPoco;
namespace NexgenCms.Core.Models {
    /// <summary>
    /// Database Connection Model
    /// </summary>
    public class DatabaseConnectionModel : IDisposable {
        #region "variables"
        /// <summary>
        /// Disposed
        /// </summary>
        public bool Disposed { get; set; }
        #endregion
        /// <summary>
        /// Type
        /// </summary>
        public DatabaseTypeEnum Type { get; set; }
        /// <summary>
        /// Sql Database
        /// </summary>
        public Database Db { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type"></param>
        public DatabaseConnectionModel(IConfigurationHelper configuration, DatabaseTypeEnum type) {
            Type = type;
            if (type != DatabaseTypeEnum.Nothing) {
                switch (type) {
                    case DatabaseTypeEnum.NexgenCmsConnection:
                        Db = new Database(configuration.NexgenCmsConnectionString, configuration.NexgenCmsConnectionProvider);
                        break;
                }
            }
        }
        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing) {
            if (Disposed) return;
            if (disposing) {
                switch (Type) {
                    case DatabaseTypeEnum.NexgenCmsConnection:
                        Db.Dispose();
                        break;
                }
            }
            Disposed = true;
        }
    }
}
