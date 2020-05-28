using System;
using PetaPoco;
using NexgenCms.Core.Interfaces.Repository.Base;
using NexgenCms.Core.Models;
using System.Collections.Generic;
using System.Linq;
namespace NexgenCms.Core.Repository.Base {
    /// <summary>
    /// Repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Repository<T> : IRepository<T>, IDisposable {
        #region "variables"
        /// <summary>
        /// Disposed
        /// </summary>
        public bool Disposed { get; set; }
        #endregion
        /// <summary>
        /// Conn
        /// </summary>
        private DatabaseConnectionModel _conn;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn"></param>
        protected Repository(DatabaseConnectionModel conn) {
            _conn = conn;
        }
        /// <summary>
        /// Db
        /// </summary>
        public Database Db {
            get {
                if (_conn != null) return _conn.Db;
                return null;
            }
        }
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public T InsertReturn(T entity) {
            var obj = _conn.Db.Insert(entity);
            return entity;
        }
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Insert(T entity) {
            _conn.Db.Insert(entity);
            return true;
        }
        /// <summary>
        /// Save (Insert or Update)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Save(T entity) {
            _conn.Db.Save(entity);
            return true;
        }
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(T entity) {
            _conn.Db.Update(entity);
            return true;
        }
        /// <summary>
        /// Read All
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> ReadAll() {
            return _conn.Db.QueryAll<T>();
        }
        /// <summary>
        /// Get By ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id) {
            return _conn.Db.QueryByID<T>(id).FirstOrDefault();
        }
        /// <summary>
        /// Delete By ID
        /// </summary>
        /// <param name="id"></param>
        public bool DeleteByID(int id) {
            _conn.Db.Delete<T>(id);
            return true;
        }
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(T entity) {
            return _conn.Db.Delete(entity) > 0;
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
            }
            Disposed = true;
        }
    }
}