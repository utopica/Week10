
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10.Infrastructure.Services
{
    public class ConfigurationService
    {
        private static ConfigurationService instance;

        public static ConfigurationService GetInstance()
        {
            if (instance is null)
            {
                instance = new ConfigurationService();
            }
            return instance;
        }
        public static string GetValue(string key)
        {
            ConfigurationManager configurationManager = new();

            string path = Directory.GetCurrentDirectory();


            configurationManager.SetBasePath(path);

            configurationManager.AddJsonFile("appsettings.json");



            return configurationManager.GetSection(key).Value;

        }

        private ConfigurationService()
        {

        }
    }
}
