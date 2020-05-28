namespace NexgenCms.Core.Interfaces.Helper {
    /// <summary>
    /// Configuration Helper
    /// </summary>
    public interface IConfigurationHelper {
        /// <summary>
        /// Nexgen Cms Connection String
        /// </summary>
        string NexgenCmsConnectionString { get; }
        /// <summary>
        /// Nexgen Cms Connection Provider
        /// </summary>
        string NexgenCmsConnectionProvider { get; }
    }
}