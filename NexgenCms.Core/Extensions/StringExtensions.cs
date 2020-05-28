using System;
using System.Configuration;
/// <summary>
/// String Extensions
/// </summary>
public static class StringExtensions {
    /// <summary>
    /// Read App Settings
    /// </summary>
    /// <param name="setting"></param>
    /// <returns></returns>
    public static string ReadAppSettings(this string setting) {
        var obj = ConfigurationManager.AppSettings[setting];
        if (obj != null) return obj;
        throw new Exception("'" + setting + "' key is not available");
    }
    /// <summary>
    /// Read Connection String
    /// </summary>
    /// <param name="connectionStringName"></param>
    /// <returns></returns>
    public static string ReadConnectionString(this string connectionStringName) {
        var obj = ConfigurationManager.ConnectionStrings[connectionStringName];
        if (obj != null) {
            if (!string.IsNullOrEmpty(obj.ConnectionString)) return obj.ConnectionString;
            throw new Exception("'" + connectionStringName + "' key is not available");
        } else {
            throw new Exception("'" + connectionStringName + "' key is not available");
        }
    }
    /// <summary>
    /// Read Connection
    /// </summary>
    /// <param name="connectionStringName"></param>
    /// <returns></returns>
    public static string ReadConnectionStringProvider(this string connectionStringName) {
        var obj = ConfigurationManager.ConnectionStrings[connectionStringName];
        if (obj == null || string.IsNullOrEmpty(obj.ConnectionString)) throw new Exception("'" + connectionStringName + "' key is not available");
        return obj.ProviderName;
    }
}