using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    static public class AppConfiguration
    {
        static private IConfiguration configuration;

        public static string GetValue(string key)
        {
            if(configuration == null)
            {
                initConfig();
            }
            return configuration.GetValue<string>(key);
        }

        static private void initConfig()
        {
            configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").AddUserSecrets("ee5c7082-d769-4420-8874-76da54e20e5c").Build();
        }
    }
}
