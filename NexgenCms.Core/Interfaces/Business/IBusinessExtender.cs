using NexgenCms.Core.Models;
using System;
using System.Collections.Generic;
namespace NexgenCms.Core.Interfaces.Business {
    /// <summary>
    /// Business Extender
    /// </summary>
    public interface IBusinessExtender<T> : IDisposable {
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        AjaxResultModel Insert(T obj);
        /// <summary>
        /// Read All
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> ReadAll();
        /// <summary>
        /// Delete By ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        AjaxResultModel DeleteByID(int id);
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        AjaxResultModel Update(T obj);
    }
}