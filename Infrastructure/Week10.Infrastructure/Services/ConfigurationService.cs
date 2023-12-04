using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week10.Domain.Interfaces;

namespace Week10.Infrastructure.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private static ConfigurationService instance;

        public ConfigurationService()
        {
            Console.WriteLine("Instance is created.");
        }
        public static ConfigurationService GetInstance()
        {
            if (instance is null)
            {
                instance = new ConfigurationService();
            }
            return instance;
        }
        public string GetValue(string key)
        {
            ConfigurationManager configurationManager = new();

            //string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string path = Directory.GetCurrentDirectory();

            configurationManager.SetBasePath(path);

            configurationManager.AddJsonFile("appsettings.json");

            //configurationManager.AddJsonFile("Configuration.json");



            return configurationManager.GetSection(key).Value;

        }


    }
}
