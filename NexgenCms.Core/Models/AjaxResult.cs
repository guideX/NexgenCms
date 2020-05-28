using System.Collections.Generic;
namespace NexgenCms.Core.Models {
    /// <summary>
    /// Ajax Result
    /// </summary>
    public abstract class AjaxResult {
        /// <summary>
        /// Tag
        /// </summary>
        public string Tag { get; set; }
        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; } = "";
        /// <summary>
        /// Stack Trace
        /// </summary>
        public string StackTrace { get; set; } = "";
        /// <summary>
        /// Inner Exception
        /// </summary>
        public string InnerException { get; set; } = "";
        /// <summary>
        /// Success
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// Validation Errors
        /// </summary>
        public List<string> ValidationErrors { get; set; } = new List<string>();
    }
}