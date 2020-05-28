using System.Collections.Generic;
namespace NexgenCms.Core.Interfaces.Repository.Base {
    /// <summary>
    /// IRepository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> {
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Insert(T entity);
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Update(T entity);
        /// <summary>
        /// Get By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(T entity);
        /// <summary>
        /// Delete By ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteByID(int id);
        /// <summary>
        /// Read All
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> ReadAll();
        /// <summary>
        /// Dispose
        /// </summary>
        void Dispose();
    }
}