using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubbitSimulation
{
    public class ConfigurationService
    {
        public readonly IConfiguration _config;
        public ConfigurationService()
        {
            var builder = new ConfigurationBuilder()
             .AddJsonFile($"appsettings.json", optional: true, true);

            _config = builder.Build();
        }

        public int GetMontlyCycle()
        {
            int montlyCycle;

            try
            {
                var config = _config.GetSection("MonthlyCycleCount");
                if (config.Value == null)
                {
                    throw new Exception("Could not get data from config file!");
                }

                montlyCycle = int.Parse(config.Value);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return montlyCycle;
        }
    }
}
