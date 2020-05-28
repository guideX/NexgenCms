namespace NexgenCms.Core.Models {
    /// <summary>
    /// Configuration Model
    /// </summary>
    public class ConfigurationModel {
        /// <summary>
        /// Nexgen Cms Connection String
        /// </summary>
        public string NexgenCmsConnectionString { get; set; }
        /// <summary>
        /// Nexgen Cms Connection Provider
        /// </summary>
        public string NexgenCmsConnectionProvider { get; set; }
        /// <summary>
        /// Verbose Debugging
        /// </summary>
        public bool VerboseDebugging { get; set; }
        /// <summary>
        /// Email To Name
        /// </summary>
        public string EmailToName { get; set; }
        /// <summary>
        /// Enable Logging
        /// </summary>
        public bool EnableLogging { get; set; }
        /// <summary>
        /// Local Folder Path
        /// </summary>
        public string LocalFolderPath { get; set; }
        /// <summary>
        /// Is Test
        /// </summary>
        public bool IsTest { get; set; }
        /// <summary>
        /// Debug Version
        /// </summary>
        public string DebugVersion { get; set; }
        /// <summary>
        /// Email From Name
        /// </summary>
        public string EmailFromName { get; set; }
        /// <summary>
        /// Email From
        /// </summary>
        public string EmailFrom { get; set; }
        /// <summary>
        /// Email From
        /// </summary>
        public string EmailTo { get; set; }
        /// <summary>
        /// Email Bcc Address
        /// </summary>
        public string EmailBccAddress { get; set; }
        /// <summary>
        /// Root Url
        /// </summary>
        public string RootUrl { get; set; }
        /// <summary>
        /// Email Server
        /// </summary>
        public string EmailServer { get; set; }
        /// <summary>
        /// Email Port
        /// </summary>
        public int EmailPort { get; set; }
    }
}