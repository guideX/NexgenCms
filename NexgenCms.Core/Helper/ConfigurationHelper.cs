using NexgenCms.Core.Models;
namespace NexgenCms.Core.Helper {
    /// <summary>
    /// Configuration Helper
    /// </summary>
    public class ConfigurationHelper : AConfigurationHelper, Interfaces.Helper.IConfigurationHelper {

    }
    /// <summary>
    /// Configuration Helper
    /// </summary>
    public abstract class AConfigurationHelper {
        /// <summary>
        /// Configuration
        /// </summary>
        private ConfigurationModel _configuration { get; set; }
        /// <summary>
        /// Loaded
        /// </summary>
        private bool _loaded { get; set; }
        /// <summary>
        /// Configuration Helper
        /// </summary>
        /// <param name="useConfigFiles"></param>
        /// <param name="iniFile"></param>
        public AConfigurationHelper() {
            _configuration = new ConfigurationModel {
                NexgenCmsConnectionString = NexgenCmsConnectionString,
                NexgenCmsConnectionProvider = NexgenCmsConnectionProvider
            };
        }
        /// <summary>
        /// Nexgen Cms Connection String
        /// </summary>
        public string NexgenCmsConnectionString => _loaded ? _configuration.NexgenCmsConnectionString : "NexgenCmsConnectionString".ReadAppSettings();
        /// <summary>
        /// Nexgen Cms Connection Provider
        /// </summary>
        public string NexgenCmsConnectionProvider => _loaded ? _configuration.NexgenCmsConnectionString : "NexgenCmsConnectionProvider".ReadAppSettings();
    }
}