using NexgenCms.Core.Models;
using System.Collections.Generic;
namespace NexgenCms.Model {
    /// <summary>
    /// Content Type Model Results
    /// </summary>
    public class ContentTypeModelResults : AjaxResult {
        /// <summary>
        /// Results
        /// </summary>
        public List<ContentTypeModel> Results = new List<ContentTypeModel>();
    }
}