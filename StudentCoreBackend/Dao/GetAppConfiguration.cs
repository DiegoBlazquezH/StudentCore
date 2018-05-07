using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Dao
{
    public static class GetAppConfiguration
    {
        private static Configuration GetConfig(Type type)
        {
            var dllLoc = new StringBuilder(
                new Uri(type.Assembly.CodeBase).LocalPath)
                .Append(".config")
                .ToString();

            var fileMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = dllLoc
            };

            return ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
        }

        public static string GetConnectionString(Type type)
        {
            return GetConfig(type)
                .ConnectionStrings
                .ConnectionStrings["StudentCoreConnection"]
                .ConnectionString;
        }
    }
}
