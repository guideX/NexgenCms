using NexgenCms.Core.Interfaces.Business;
using NexgenCms.Core.Interfaces.Helper;
using NexgenCms.Core.Interfaces.Repository.Base;
using NexgenCms.Core.Models;
using System;
using System.Collections.Generic;
namespace NexgenCms.Business.Extenders {
    /// <summary>
    /// Business Extender
    /// </summary>
    public abstract class BusinessExtender<T> : IBusinessExtender<T> {
        /// <summary>
        /// Disposed
        /// </summary>
        public bool Disposed { get; set; }
        /// <summary>
        /// Configuration
        /// </summary>
        public IConfigurationHelper Configuration { get; set; }
        /// <summary>
        /// Conn
        /// </summary>
        public DatabaseConnectionModel Conn { get; set; }
        /// <summary>
        /// Default Repository
        /// </summary>
        private IRepository<T> _defaultRepository = null;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="conn"></param>
        public BusinessExtender(IConfigurationHelper configuration, Core.Models.DatabaseConnectionModel conn) {
            Configuration = configuration;
            Conn = conn;
        }
        /// <summary>
        /// Set Default Repository
        /// </summary>
        public virtual void SetDefaultRepository(IRepository<T> obj) {
            _defaultRepository = obj;
        }
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public virtual AjaxResultModel Insert(T obj) {
            if (_defaultRepository != null) {
                return new AjaxResultModel() { Success = _defaultRepository.Insert(obj) };
            } else {
                return new AjaxResultModel() { Message = "Default Repository Not Set" };
            }
        }
        /// <summary>
        /// Read By ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T ReadByID(int id) {
            if (_defaultRepository != null) {
                return _defaultRepository.GetById(id);
            } else {
                return default(T);
            }
        }
        /// <summary>
        /// Read All
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<T> ReadAll() {
            if (_defaultRepository != null) {
                return _defaultRepository.ReadAll();
            } else {
                return null;
            }
        }
        /// <summary>
        /// Delete By ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual AjaxResultModel DeleteByID(int id) {
            var result = new AjaxResultModel();
            if (_defaultRepository != null) {
                result.Success = _defaultRepository.DeleteByID(id);
            } else {
                result.Message = "Default Repository Not Set";
            }
            return result;
        }
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public virtual AjaxResultModel Update(T obj) {
            var result = new AjaxResultModel();
            if (_defaultRepository != null) {
                result.Success = _defaultRepository.Update(obj);
            } else {
                result.Message = "Default Repository Not Set";
            }
            return result;
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
                _defaultRepository.Dispose();
            }
            Disposed = true;
        }
    }
}